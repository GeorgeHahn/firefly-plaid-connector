using System;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using Acklann.Plaid;
using FireflyIII.Api;
using FireflyIII.Model;
using CommandLine;
using Nett;

namespace firefly_plaid_connector
{
    public class Connector
    {
        private Program.Args args;
        private readonly ConnectorConfig config;
        private readonly PlaidClient plaid;
        private readonly FireflyIII.Api.TransactionsApi firefly;
        private List<Acklann.Plaid.Entity.Account> plaid_accounts = new List<Acklann.Plaid.Entity.Account>();

        public Connector(Program.Args args, ConnectorConfig config)
        {
            this.args = args;
            this.config = config;
            this.plaid = new PlaidClient(
                config.plaid.client_id,
                config.plaid.secret,
                config.plaid.pubkey,
                Acklann.Plaid.Environment.Development);
            this.firefly = new TransactionsApi(new FireflyIII.Client.Configuration()
            {
                BasePath = config.firefly.url,
                AccessToken = config.firefly.token,
            });
        }

        public async Task InitializeAccountData()
        {
            foreach (var token in config.plaid.access_tokens)
            {
                // Try to get full (bank) account numbers for better records
                Acklann.Plaid.Entity.Account[] accounts = null;
                string itemid = null;
                var fullinfo = await this.plaid.FetchAccountInfoAsync(new Acklann.Plaid.Auth.GetAccountInfoRequest()
                {
                    AccessToken = token,
                });

                if (fullinfo.IsSuccessStatusCode)
                {
                    accounts = fullinfo.Accounts;
                    itemid = fullinfo.Item.Id;
                }
                else
                {
                    var accts = await this.plaid.FetchAccountAsync(new Acklann.Plaid.Balance.GetAccountRequest()
                    {
                        AccessToken = token,
                    });

                    if (!accts.IsSuccessStatusCode)
                    {
                        Console.WriteLine($"Failed to get account info for token '{token}'");
                        System.Environment.Exit(1);
                    }
                    accounts = accts.Accounts;
                    itemid = accts.Item.Id;
                }

                foreach (var acct in accounts)
                {
                    var cfg = config.account.FirstOrDefault(a =>
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
                        cfg.plaid_item_id = itemid;
                        cfg.plaid_account_id = acct.Id;
                        cfg.account_lastfour = acct.Mask;

                        if (fullinfo.IsSuccessStatusCode)
                        {
                            cfg.account_number = fullinfo.Numbers.ACH
                                                    .Where(a => a.AccountId == acct.Id)
                                                    .Select(a => a.AccountNumber)
                                                    .FirstOrDefault();
                        }
                    }
                }

                plaid_accounts.AddRange(accounts);
            }
        }

        private void transfer_between_two_plaid_accounts(ImportDbContext db, Acklann.Plaid.Entity.Transaction txn, Acklann.Plaid.Entity.Transaction other)
        {
            var source = txn.Amount > 0 ? txn : other;
            var dest = txn.Amount < 0 ? txn : other;
            var source_config = config.account.FirstOrDefault(a => a.plaid_account_id == source.AccountId);
            var dest_config = config.account.FirstOrDefault(a => a.plaid_account_id == dest.AccountId);

            if (source_config == null || dest_config == null)
            {
                throw new Exception($"Account not found in config: {source.AccountId} or {dest.AccountId}");
            }

            // TODO: shrink txn names? (too verbose: "Requested transfer from... account XXXXXX0123 -> Incoming transfer from ...")
            var transfer = new FireflyIII.Model.TransactionSplit(
                date: source.Date,
                processDate: dest.Date,
                description: source.Name + " -> " + dest.Name,
                amount: source.Amount,
                currencyCode: source.CurrencyCode,
                externalId: source.TransactionId + " -> " + dest.TransactionId,
                type: TransactionSplit.TypeEnum.Transfer,
                sourceId: source_config.firefly_account_id,
                destinationId: dest_config.firefly_account_id
            );
            var storedtransfer = firefly.StoreTransaction(new FireflyIII.Model.Transaction(new[] { transfer }.ToList()));

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

        private void sindle_sided_transaction(ImportDbContext db, Acklann.Plaid.Entity.Transaction txn)
        {
            Console.WriteLine("Creating single sided transaction");

            var txn_config = config.account.FirstOrDefault(a => a.plaid_account_id == txn.AccountId);
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
                return;
            }

            var is_source = txn.Amount > 0;

            var name = txn.Name;
            // TODO: fill name with PaymentInfo if non-null

            var transfer = new FireflyIII.Model.TransactionSplit(
                date: txn.Date,
                description: txn.Name,
                amount: Math.Abs(txn.Amount),
                currencyCode: txn.CurrencyCode,
                externalId: txn.TransactionId,
                tags: txn.Categories?.ToList()
            );

            if (is_source)
            {
                transfer.Type = TransactionSplit.TypeEnum.Withdrawal;
                transfer.SourceId = txn_config.firefly_account_id;
                transfer.DestinationName = name;
            }
            else
            {
                transfer.Type = TransactionSplit.TypeEnum.Deposit;
                transfer.SourceName = name;
                transfer.DestinationId = txn_config.firefly_account_id;
            }

            var storedtransfer = firefly.StoreTransaction(new FireflyIII.Model.Transaction(new[] { transfer }.ToList()));

            // Record transaction as imported
            db.Transactions.Add(new ImportedTransaction
            {
                PlaidId = txn.TransactionId,
                FireflyId = storedtransfer.Data.Id,
            });
            db.SaveChanges();
        }

        public async Task SyncOnce()
        {
            // TODO: Update FF3 account balances?

            using (var datedb = new ImportDbContext())
            {
                var plaidtxns = new List<Acklann.Plaid.Entity.Transaction>();
                if (args.ForceSync)
                {
                    Console.WriteLine($"Info: force sync enabled - requesting data from the last {config.sync.max_sync_days} days");
                }

                // Get list of unique plaid access tokens to query
                var plats_to_use = config.account
                                    .Select(t => t.plaid_access_token)
                                    .Where(t => !String.IsNullOrWhiteSpace(t))
                                    .Distinct();

                // Get all txns for every access token in use
                foreach (var token in plats_to_use)
                {
                    // TODO: It's not very desirable to have access tokens in the db. It would be
                    // better to figure out the next-poll time for each account ID and store that,
                    // then figure out the correct poll time for each access token.
                    var lastpoll = datedb.Poll.Where(p => p.PlaidId == token).FirstOrDefault();
                    var max_days = DateTime.Now - TimeSpan.FromDays(config.sync.max_sync_days);

                    // If we haven't polled this account before, request `config.sync.max_sync_days` of data
                    if (lastpoll == null)
                    {
                        lastpoll = new LastPoll();
                        lastpoll.PlaidId = token;
                        lastpoll.Time = DateTime.Now - TimeSpan.FromDays(config.sync.max_sync_days);
                    }

                    // Override lastpoll if the force-sync flag was passed
                    if (args.ForceSync)
                    {
                        lastpoll.Time = max_days;
                    }

                    // Throw an error and exit if the last poll was more than `sync.max_sync_days` ago
                    if (lastpoll.Time < max_days)
                    {
                        Console.WriteLine($"Error: last program run was more than {config.sync.max_sync_days} days ago");
                        Console.WriteLine("Increase 'sync.max_sync_days' configuration value or use the '--force-sync' argument to ignore this error (and potentially miss some transactions)");
                        System.Environment.Exit(1);
                    }

                    // Handle response pagination
                    uint request_size = 100;
                    uint page_offset = 0;
                    var now = DateTime.Now;
                    var page_count = 0;
                    var page_txn_list = new List<Acklann.Plaid.Entity.Transaction>();
                    do
                    {
                        // TODO: Fill in account info from this response and eliminate most of the `InitializeAccountData` step
                        var plaid_txn_rsp = await this.plaid.FetchTransactionsAsync(new Acklann.Plaid.Transactions.GetTransactionsRequest
                        {
                            StartDate = lastpoll.Time,
                            EndDate = now,
                            AccessToken = token,
                            Options = new Acklann.Plaid.Transactions.GetTransactionsRequest.PaginationOptions
                            {
                                Offset = page_offset,
                                Total = request_size,
                            },
                        });
                        page_count = plaid_txn_rsp.TransactionsReturned;
                        page_offset += (uint)plaid_txn_rsp.Transactions.Count();
                        page_txn_list.AddRange(plaid_txn_rsp.Transactions);

                        Console.WriteLine($"Fetched {page_offset}/{page_count}");
                    } while (page_offset < page_count);

                    // Only record transactions that are not pending
                    plaidtxns.AddRange(page_txn_list.Where(t => t.Pending == false));

                    // Next run, fetch all transactions from the last pending txn forward
                    if (page_txn_list.Count(c => c.Pending == true) > 0)
                    {
                        lastpoll.Time = page_txn_list
                            .Where(t => t.Pending == true)
                            .Select(t => t.Date)
                            .OrderBy(t => t)
                            .First();
                    }
                    else
                    {
                        lastpoll.Time = DateTime.Now;
                    }

                    // These updates will be saved at the end of the sync process
                    datedb.Poll.Update(lastpoll);
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
                        if (txn.CategoryId == "21005000" || // transfer - credit
                            txn.CategoryId == "21006000" || // transfer - debit
                            txn.CategoryId == "16001000" || // payment - credit card
                            txn.CategoryId == "21009000")   // some amex are miscategorized as transfer - payroll
                        {
                            // Attempt to collect Transfer/Debit & Transfer/Credit pair into a single FF3 transfer transaction
                            var others = plaidtxns.Where(t =>
                                t.Amount == -1 * txn.Amount &&
                                ((t.Date - txn.Date).Duration() < TimeSpan.FromDays(7)) && // less than a week apart
                                t.CurrencyCode == txn.CurrencyCode &&
                                ((t.CategoryId == "21005000" && txn.CategoryId == "21006000") ||
                                (t.CategoryId == "21006000" && txn.CategoryId == "21005000") ||
                                (t.CategoryId == "16001000" && txn.CategoryId == "21009000") ||
                                (t.CategoryId == "21009000" && txn.CategoryId == "16001000"))
                            );

                            if (others != null && others.Count() > 0)
                            {
                                if (others.Count() == 1)
                                {
                                    // Found exactly one matching txn
                                    Console.WriteLine("Found matching txn pair");
                                    transfer_between_two_plaid_accounts(db, txn, others.First());
                                    continue;
                                }
                                else
                                {
                                    // Found multiple possible transactions
                                    Console.WriteLine("Found multiple possible transfer pairings; creating single sided txns instead");
                                    // Create the single sided txns here; otherwise, we'll may end up creating a pair from remaining transactions as we continue processing.
                                    sindle_sided_transaction(db, txn);
                                    foreach (var other in others)
                                    {
                                        sindle_sided_transaction(db, other);
                                    }
                                    continue;
                                }
                            }
                        }

                        // Did not find a matching txn: create single sided FF3 transaction
                        sindle_sided_transaction(db, txn);
                    }
                }

                // save last-polled at the very end
                datedb.SaveChanges();
            }
        }

        public async Task SyncPolled()
        {
            while (true)
            {
                await SyncOnce();
                await Task.Delay(TimeSpan.FromMinutes(config.sync.sync_frequency_minutes));
            }
        }

        public void Run()
        {
            InitializeAccountData().Wait();
            switch (config.sync.sync_mode)
            {
                case SyncMode.batch:
                    SyncOnce().Wait();
                    return;
                case SyncMode.polled:
                    SyncPolled().Wait();
                    return;
            }
        }
    }

    public class Program
    {
        public class Args
        {
            [Option("force-sync", Required = false, HelpText = "Force synchronization of `sync.max_sync_days` of data")]
            public bool ForceSync { get; set; }
        }

        private static bool VerifyConfig(ConnectorConfig config)
        {
            return !string.IsNullOrWhiteSpace(config.plaid.client_id) &&
                !string.IsNullOrWhiteSpace(config.plaid.pubkey) &&
                !string.IsNullOrWhiteSpace(config.plaid.secret) &&
                config.plaid.access_tokens.Length > 0 &&
                !string.IsNullOrWhiteSpace(config.firefly.url) &&
                !string.IsNullOrWhiteSpace(config.firefly.token);
        }

        static int Main(string[] unparsed_args)
        {
            Args args = Parser.Default.ParseArguments<Args>(unparsed_args)
                .MapResult(
                    args => args,
                    errors =>
                    {
                        var first = errors.First();
                        if (first.Tag == ErrorType.HelpRequestedError || first.Tag == ErrorType.VersionRequestedError)
                        {
                            System.Environment.Exit(0);
                        }

                        // Apparently there isn't a way to get the tag name??
                        Console.WriteLine($"Unknown argument: {first.Tag}");
                        System.Environment.Exit(-1);
                        return null;
                    });

            var path = System.Environment.GetEnvironmentVariable("CONFIG_PATH") ?? System.Environment.CurrentDirectory;
            var config_path = Path.Combine(path, "config.toml");

            if (!File.Exists(config_path))
            {
                Console.WriteLine($"Error: config file not found. Tried '{config_path}'; do you need to set `CONFIG_PATH`?");
                return -1;
            }

            var config = Toml.ReadFile<ConnectorConfig>(config_path);
            if (config == null)
            {
                Console.WriteLine($"Error: invalid config file");
                return -1;
            }

            if (!VerifyConfig(config))
            {
                Console.WriteLine($"Error: invalid config file");
                return -1;
            }

            var db_path = System.Environment.GetEnvironmentVariable("DB_PATH") ?? path;

            // Create DB if it doesn't exist & run migrations
            ImportDbContext.database_file = Path.Combine(db_path, "import-db.sqlite3");
            using (var db = new ImportDbContext())
            {
                db.Database.Migrate();
            }

            var connector = new Connector(args, config);
            connector.Run();
            return 0;
        }
    }
}
