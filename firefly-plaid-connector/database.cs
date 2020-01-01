using System;
using Microsoft.EntityFrameworkCore;

namespace firefly_plaid_connector
{
    // We need a tiny database to keep track of imported transaction IDs
    public class ImportDbContext : DbContext
    {
        public DbSet<ImportedTransaction> Transactions { get; set; }
        public DbSet<LastPoll> Poll { get; set; }

        public static string database_file = "import-db.sqlite3";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={database_file}");
        }
    }

    public class LastPoll
    {
        public int LastPollId { get; set; }
        public string PlaidId { get; set; }
        public DateTime Time { get; set; }
    }

    public class ImportedTransaction
    {
        public int ImportedTransactionId { get; set; }
        public string PlaidId { get; set; }
        public int? FireflyId { get; set; }
    }
}