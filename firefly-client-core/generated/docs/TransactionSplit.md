# FireflyIII.Net.Model.TransactionSplit
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**User** | **int** | User ID | [optional] [readonly] 
**TransactionJournalId** | **int** | ID of the underlying transaction journal. Each transaction consists of a transaction group (see the top ID) and one or more journals making up the splits of the transaction.  | [optional] [readonly] 
**Type** | **string** | Type of transaction. expense cannot be written. | [optional] 
**Date** | **DateTime** | Date of the transaction | 
**Amount** | **double** | Amount of the transaction. | 
**Description** | **string** | Description of the transaction. Will only be used if more than one split is submitted. | 
**Order** | **int** | Order of this entry in the list of transactions. | [optional] 
**CurrencyId** | **int** | Currency ID. Default is the source account&#39;s currency, or the user&#39;s default currency. Can be used instead of currency_code. | [optional] 
**CurrencyCode** | **string** | Currency code. Default is the source account&#39;s currency, or the user&#39;s default currency. Can be used instead of currency_id. | [optional] 
**CurrencySymbol** | **string** |  | [optional] [readonly] 
**CurrencyName** | **string** |  | [optional] [readonly] 
**CurrencyDecimalPlaces** | **int** | Number of decimals used in this currency. | [optional] [readonly] 
**ForeignAmount** | **double** | The amount in a foreign currency. | [optional] 
**ForeignCurrencyId** | **int?** | Currency ID. Default is null. Is required when you submit a foreign amount. | [optional] 
**ForeignCurrencyCode** | **string** | Currency code. Default is NULL. Can be used instead of the foreign_currency_id, but either is required when submitting a foreign amount. | [optional] 
**ForeignCurrencySymbol** | **string** |  | [optional] [readonly] 
**ForeignCurrencyDecimalPlaces** | **int?** | Number of decimals in the currency | [optional] [readonly] 
**BudgetId** | **int** | The budget ID for this transaction. | [optional] 
**BudgetName** | **string** | The name of the budget to be used. If the budget name is unknown, the ID will be used or the value will be ignored. | [optional] [readonly] 
**CategoryId** | **int?** | The category ID for this transaction. | [optional] 
**CategoryName** | **string** | The name of the category to be used. If the category is unknown, it will be created. If the ID and the name point to different categories, the ID overrules the name. | [optional] 
**SourceId** | **int** | ID of the source account. For a withdrawal or a transfer, this must always be an asset account. For deposits, this must be a revenue account. | 
**SourceName** | **string** | Name of the source account. For a withdrawal or a transfer, this must always be an asset account. For deposits, this must be a revenue account. Can be used instead of the source_id. If the transaction is a deposit, the source_name can be filled in freely: the account will be created based on the name. | [optional] 
**SourceIban** | **string** |  | [optional] [readonly] 
**SourceType** | **AccountTypeProperty** |  | [optional] 
**DestinationId** | **int** | ID of the destination account. For a deposit or a transfer, this must always be an asset account. For withdrawals this must be an expense account. | 
**DestinationName** | **string** | Name of the destination account. You can submit the name instead of the ID. For everything except transfers, the account will be auto-generated if unknown, so submitting a name is enough. | [optional] 
**DestinationIban** | **string** |  | [optional] [readonly] 
**DestinationType** | **AccountTypeProperty** |  | [optional] 
**Reconciled** | **bool** | If the transaction has been reconciled already. When you set this, the amount can no longer be edited by the user. | [optional] 
**PiggyBankId** | **int** | Optional. Use either this or the piggy_bank_name | [optional] 
**PiggyBankName** | **string** | Optional. Use either this or the piggy_bank_id | [optional] 
**BillId** | **int?** | Optional. Use either this or the bill_name | [optional] 
**BillName** | **string** | Optional. Use either this or the bill_id | [optional] 
**Tags** | **List&lt;string&gt;** | Array of tags. | [optional] 
**Notes** | **string** |  | [optional] 
**InternalReference** | **string** | Reference to internal reference of other systems. | [optional] 
**ExternalId** | **string** | Reference to external ID in other systems. | [optional] 
**OriginalSource** | **string** | System generated identifier for original creator of transaction. | [optional] [readonly] 
**RecurrenceId** | **int?** | Reference to recurrence that made the transaction. | [optional] [readonly] 
**BunqPaymentId** | **string** | Internal ID of bunq transaction. | [optional] 
**ImportHashV2** | **string** | Hash value of original import transaction (for duplicate detection). | [optional] [readonly] 
**SepaCc** | **string** | SEPA Clearing Code | [optional] 
**SepaCtOp** | **string** | SEPA Opposing Account Identifier | [optional] 
**SepaCtId** | **string** | SEPA end-to-end Identifier | [optional] 
**SepaDb** | **string** | SEPA mandate identifier | [optional] 
**SepaCountry** | **string** | SEPA Country | [optional] 
**SepaEp** | **string** | SEPA External Purpose indicator | [optional] 
**SepaCi** | **string** | SEPA Creditor Identifier | [optional] 
**SepaBatchId** | **string** | SEPA Batch ID | [optional] 
**InterestDate** | **DateTime?** |  | [optional] 
**BookDate** | **DateTime?** |  | [optional] 
**ProcessDate** | **DateTime?** |  | [optional] 
**DueDate** | **DateTime?** |  | [optional] 
**PaymentDate** | **DateTime?** |  | [optional] 
**InvoiceDate** | **DateTime?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

