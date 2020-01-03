# Plaid to Firefly Transaction Importer

This utility imports transactions from [Plaid](https://plaid.com/) into [Firefly III](https://firefly-iii.org/).
The primary goal of this tool is to give good data with low ongoing effort.

You will need a Plaid developer account to use this tool. Sign up [here](https://dashboard.plaid.com/signup?email=) and apply for development access. (This can take a few days.)

## Modes of operation

- Batch: run once and exit
- Polled: run forever and sync periodically

## Setup & Installation

Copy `config.example.json` to `config.json` and fill in your account info.

Plaid account access tokens are required for each account/institution that will
be synchronized. This tool does not provide a UI for linking accounts to Plaid.
Accounds can be linked using the [Plaid Quickstart tool](https://github.com/plaid/quickstart");
copy the access token for each institution into `config.json`.

Please note: the information stored in `config.json` (and the `import-db.sqlite3`
database that is created at runtime) is sufficient for anyone to query
your account information and transaction history. These should be kept very
secure.

### Docker

Move `config.json` into the `./config` volume

Example docker-compose:

```
version: "3.2"
services:
  plaid_connector:
    image: registry.gitlab.com/georgehahn/firefly-plaid-connector:latest
    restart: unless-stopped
    depends_on:
      - firefly_iii_app
    volumes:
      - ./config:/config
```

### From source

Build `firefly-plaid-connector` with the .Net Core 3.1 SDK. Repo organization is
currentlty subpar due to dependencies on two libraries that are not yet
avalable on Nuget.