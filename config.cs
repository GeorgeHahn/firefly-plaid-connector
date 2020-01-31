namespace firefly_plaid_connector
{
    public class SyncConfig
    {
        /// Sync mode
        public SyncMode sync_mode { get; set; } = SyncMode.batch;

        /// sync frenquency in minutes
        public int sync_frequency_minutes { get; set; } = 60 * 24;

        /// max days to sync
        public int max_sync_days { get; set; } = 30;
    }

    public class FireflyConfig
    {
        public string url { get; set; }
        public string token { get; set; }
    }

    public class PlaidConfig
    {
        public string client_id { get; set; }
        public string pubkey { get; set; }
        public string secret { get; set; }
        public string[] access_tokens { get; set; }
    }

    // Rename these values to Caps after this issue is solved: https://github.com/paiden/Nett/issues/80
    public enum SyncMode
    {
        // Sync once and exit
        batch,
        // Sync every `SyncFrequency` seconds
        polled,
        // TODO future: webhook triggered sync
    }

    public class Account
    {
        // Fill in one or more of these
        public string plaid_account_id { get; set; }
        /// matches name or officialname
        public string account_name { get; set; }
        /// only matches officialname
        public string account_officialname { get; set; }
        public string account_lastfour { get; set; }
        public string account_institution_id { get; set; }
        public string account_number { get; set; }

        // One of these is required
        public int firefly_account_id { get; set; }
        // TODO: Support specifying firefly accounts by name
        // public string firefly_account { get; set; }

        // (todo: move these to a non-user-specified/deserialized class)
        /// Automatically populated on startup
        public string plaid_item_id { get; set; }
        /// Automatically populated on startup
        public string plaid_access_token { get; set; }

        public override string ToString()
        {
            if (this.account_name != null)
            {
                return this.account_name;
            }
            else if (this.account_officialname != null)
            {
                return this.account_officialname;
            }
            else if (this.plaid_account_id != null)
            {
                return this.plaid_account_id;
            }
            else if (this.account_lastfour != null)
            {
                return this.account_lastfour;
            }
            else if (this.account_institution_id != null)
            {
                return this.account_institution_id;
            }
            return "no data";
        }
    }

    public class ConnectorConfig
    {
        /// General sync config
        public SyncConfig sync { get; set; }

        /// Plaid account configuration
        public PlaidConfig plaid { get; set; }

        /// Firefly server configuration
        public FireflyConfig firefly { get; set; }

        /// A list of items to sync
        public Account[] account { get; set; }
    }
}