using System;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Acklann.Plaid.Entity;
using Acklann.Plaid;
using FireflyIII.Net.Client;
using FireflyIII.Net.Api;
using FireflyIII.Net.Model;

namespace firefly_plaid_connector
{
    public class Connector
    {
        private readonly ConnectorConfig config;
        private readonly PlaidClient plaid;
        private readonly FireflyIII.Net.Api.TransactionsApi firefly;
        private List<Acklann.Plaid.Entity.Account> plaid_accounts = new List<Acklann.Plaid.Entity.Account>();

        public Connector(ConnectorConfig config)
        {
            this.config = config;
            this.plaid = new PlaidClient(
                config.plaid.client_id,
                config.plaid.secret,
                config.plaid.pubkey,
                Acklann.Plaid.Environment.Sandbox); // TODO: Swap to development environment
            this.firefly = new TransactionsApi(new FireflyIII.Net.Client.Configuration()
            {
                BasePath = config.firefly.Url,
                AccessToken = config.firefly.Token,
            });
        }

        private void transfer_between_two_plaid_accounts(Acklann.Plaid.Entity.Transaction txn, Acklann.Plaid.Entity.Transaction other)
        {
            using (var db = new ImportDbContext())
            {
                var source = txn.Amount > 0 ? txn : other;
                var dest = txn.Amount < 0 ? txn : other;
                var source_config = config.sync.FirstOrDefault(a => a.plaid_account_id == source.AccountId);
                var dest_config = config.sync.FirstOrDefault(a => a.plaid_account_id == dest.AccountId);

                if (source_config == null || dest_config == null)
                {
                    throw new Exception($"Account not found in config: {source.AccountId} or {dest.AccountId}");
                }

                var transfer = new FireflyIII.Net.Model.TransactionSplit
                {
                    Date = source.Date,
                    Description = source.Name + " -> " + dest.Name,
                    Amount = source.Amount,
                    CurrencyCode = source.CurrencyCode,
                    ExternalId = source.TransactionId + " -> " + dest.TransactionId,
                    Type = TransactionSplit.TypeEnum.Transfer,
                    SourceId = source_config.firefly_account,
                    DestinationId = dest_config.firefly_account,
                };
                var storedtransfer = firefly.StoreTransaction(new FireflyIII.Net.Model.Transaction(new[] { transfer }.ToList()));

                // Record both transactions as imported
                db.Transactions.AddRange(new[] {
                    new ImportedTransaction
                    {
                        PlaidId = txn.TransactionId,
                        FireflyId = storedtransfer.Data.Id,
                    },
                    new ImportedTransaction
                    {
                        PlaidId = other.TransactionId,
                        FireflyId = storedtransfer.Data.Id,
                    }
                });
                db.SaveChanges();
            }
        }

        private void transfer_between_plaid_and_ff3_account(Acklann.Plaid.Entity.Transaction txn, firefly_plaid_connector.Account other)
        {
            using (var db = new ImportDbContext())
            {
                var is_source = txn.Amount > 0;
                var txn_config = config.sync.FirstOrDefault(a => a.plaid_account_id == txn.AccountId);
                if (txn_config == null)
                {
                    throw new Exception($"Account not found in config: {txn.AccountId}");
                }

                var transfer = new FireflyIII.Net.Model.TransactionSplit
                {
                    Date = txn.Date,
                    Description = txn.Name,
                    Amount = Math.Abs(txn.Amount),
                    CurrencyCode = txn.CurrencyCode,
                    ExternalId = txn.TransactionId,
                    Type = TransactionSplit.TypeEnum.Transfer,
                    SourceId = is_source ? txn_config.firefly_account : other.firefly_account,
                    DestinationId = !is_source ? txn_config.firefly_account : other.firefly_account,
                };
                var storedtransfer = firefly.StoreTransaction(new FireflyIII.Net.Model.Transaction(new[] { transfer }.ToList()));

                // Record transaction as imported
                db.Transactions.Add(new ImportedTransaction
                {
                    PlaidId = txn.TransactionId,
                    FireflyId = storedtransfer.Data.Id,
                });
                db.SaveChanges();
            }
        }

        public async Task InitializeAccountData()
        {
            foreach (var token in config.plaid.access_tokens)
            {
                var accts = await this.plaid.FetchAccountInfoAsync(new Acklann.Plaid.Auth.GetAccountInfoRequest()
                {
                    AccessToken = token,
                });

                foreach (var acct in accts.Accounts)
                {
                    var cfg = config.sync.FirstOrDefault(a =>
                        // Match to as much account info as is given

                        (a.plaid_account_id != null || a.account_name != null || a.account_officialname != null ||
                            a.account_lastfour != null || a.account_institution_id != null) &&
                        (a.plaid_account_id == null || a.plaid_account_id == acct.Id) &&
                        (a.account_name == null || (a.account_name == acct.Name || a.account_name == acct.OfficialName)) &&
                        (a.account_officialname == null || a.account_name == acct.OfficialName) &&
                        (a.account_lastfour == null || a.account_lastfour == acct.Mask) &&
                        (a.account_institution_id == null || a.account_institution_id == acct.InstitutionId)
                    );

                    if (cfg == null)
                    {
                        Console.WriteLine($"Warning: plaid reported an unknown account: {acct.Name} {acct.OfficialName}");
                    }
                    else
                    {
                        cfg.account_officialname = acct.OfficialName;
                        cfg.account_name = acct.Name;
                        cfg.plaid_access_token = token;
                        cfg.plaid_item_id = accts.Item.Id;
                        cfg.plaid_account_id = acct.Id;
                        cfg.account_lastfour = acct.Mask;
                    }
                }

                plaid_accounts.AddRange(accts.Accounts);
            }
        }

        public async Task SyncOnce()
        {
            // TODO: Update FF3 account balances?

            // Get all txns for every account
            var plaidtxns = new List<Acklann.Plaid.Entity.Transaction>();
            foreach (var item in config.sync)
            {
                if (item.plaid_access_token == null)
                {
                    // Don't try to sync accounts that don't have an access token
                    continue;
                }

                // TODO: Only ask for transactions since the last poll on this account (save this info in the db)
                // TODO future: this step can be done in parallel
                var plaid_txn_rsp = await this.plaid.FetchTransactionsAsync(new Acklann.Plaid.Transactions.GetTransactionsRequest
                {
                    AccessToken = item.plaid_access_token,
                });
                plaidtxns.AddRange(plaid_txn_rsp.Transactions);
            }

            // Process all txns
            using (var db = new ImportDbContext())
            {
                foreach (var txn in plaidtxns)
                {
                    // See if we have already processed this transaction
                    if (db.Transactions.Any(b => b.PlaidId == txn.TransactionId))
                    {
                        // Already processed; skip
                        continue;
                    }

                    // Handle transfers between accounts
                    if (txn.CategoryId == "21005000" || txn.CategoryId == "21006000")
                    {
                        // Attempt to collect Transfer/Debit & Transfer/Credit pair into a single FF3 transfer transaction
                        var other = plaidtxns.FirstOrDefault(t =>
                            t.Amount == -1 * txn.Amount &&
                            t.Date == txn.Date &&
                            t.CurrencyCode == txn.CurrencyCode &&
                            ((t.CategoryId == "21005000" && txn.CategoryId == "21006000") ||
                            (t.CategoryId == "21006000" && txn.CategoryId == "21005000"))
                        );

                        if (other != null)
                        {
                            // Found a matching txn
                            Console.WriteLine("Found matching txn pair");
                            transfer_between_two_plaid_accounts(txn, other);
                            continue;
                        }
                    }

                    // TODO: Consider allowing fuzzy matches
                    var match = config.sync.FirstOrDefault(a => a.match_transaction?.transaction_name == txn.Name &&
                        a.match_transaction?.category_id == txn.CategoryId);
                    if (match != null)
                    {
                        Console.WriteLine("Creating transfer to account with matched transaction name");
                        transfer_between_plaid_and_ff3_account(txn, match);
                        continue;
                    }

                    Console.WriteLine("Did not find a transfer match, creating withdrawal");

                    // TODO: try to fuzzy match against txn name ("Requested transfer from... account XXXXXX0123")
                    // TODO: Handle other transfers
                    //      21005000 expensify
                    //      16001000 credit card payment
                    // TODO: Handle other deposits
                    //      21007001 check deposit
                    //      21010001 venmo
                    //      21010004 paypal
                    //      15001000 interest earned
                    //      21009000 payroll
                    // TODO: Handle payments: 16000000 Zelle payment

                    // Did not find a matching txn: create transfer to/from FF3 cash wallet
                    var txn_config = config.sync.FirstOrDefault(a => a.plaid_account_id == txn.AccountId);
                    var cash_dest = config.firefly.cash_wallet_account_dest;
                    var cash_src = config.firefly.cash_wallet_account_src;
                    if (txn_config == null)
                    {
                        Console.WriteLine($"Dropping transaction; account not configured for sync: {txn.AccountId}");

                        // Record transaction as imported
                        db.Transactions.Add(new ImportedTransaction
                        {
                            PlaidId = txn.TransactionId,
                            FireflyId = null,
                        });
                        db.SaveChanges();
                        continue;
                    }

                    var is_source = txn.Amount > 0;
                    var ff_source = is_source ? txn_config.firefly_account : cash_dest;
                    var ff_dest = !is_source ? txn_config.firefly_account : cash_dest;
                    var txn_type = is_source ? TransactionSplit.TypeEnum.Withdrawal : TransactionSplit.TypeEnum.Deposit;

                    var transfer = new FireflyIII.Net.Model.TransactionSplit
                    {
                        Date = txn.Date,
                        Description = txn.Name,
                        Amount = Math.Abs(txn.Amount),
                        CurrencyCode = txn.CurrencyCode,
                        ExternalId = txn.TransactionId,
                        Type = txn_type,
                        SourceId = ff_source,
                        DestinationId = ff_dest,
                    };

                    var storedtransfer = firefly.StoreTransaction(new FireflyIII.Net.Model.Transaction(new[] { transfer }.ToList()));

                    // Record transaction as imported
                    db.Transactions.Add(new ImportedTransaction
                    {
                        PlaidId = txn.TransactionId,
                        FireflyId = storedtransfer.Data.Id,
                    });
                    db.SaveChanges();
                }
            }
        }


        public async Task SyncPolled()
        {
            while (true)
            {
                await SyncOnce();
                await Task.Delay(TimeSpan.FromMinutes(config.sync_frequency));
            }
        }

        public void Run()
        {
            InitializeAccountData().Wait();
            switch (config.sync_mode)
            {
                case SyncMode.Batch:
                    SyncOnce().Wait();
                    return;
                case SyncMode.Polled:
                    SyncPolled().Wait();
                    return;
            }
        }
    }

    class Program
    {
        static int Main(string[] args)
        {
            var path = System.Environment.GetEnvironmentVariable("CONFIG_PATH") ?? System.Environment.CurrentDirectory;
            var config_path = Path.Combine(path, "config.json");

            if (!File.Exists(config_path))
            {
                Console.WriteLine($"Error: config file not found. Tried '{config_path}'; do you need to set `CONFIG_PATH`?");
                return -1;
            }

            var config = JsonConvert.DeserializeObject<ConnectorConfig>(File.ReadAllText(config_path));
            if (config == null)
            {
                Console.WriteLine($"Error: invalid config file");
                return -1;
            }

            // Create DB if it doesn't exist & run migrations
            ImportDbContext.database_file = Path.Combine(path, "import-db.sqlite3");
            using (var db = new ImportDbContext())
            {
                db.Database.Migrate();
            }

            var connector = new Connector(config);
            connector.Run();
            return 0;
        }
    }
}
