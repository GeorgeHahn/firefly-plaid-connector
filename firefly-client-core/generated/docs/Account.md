# FireflyIII.Net.Model.Account
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt** | **DateTime** |  | [optional] [readonly] 
**UpdatedAt** | **DateTime** |  | [optional] [readonly] 
**Name** | **string** |  | 
**Type** | **string** | Can only be one one these account types. import, initial-balance and reconciliation cannot be set manually. | 
**Iban** | **string** |  | [optional] 
**Bic** | **string** |  | [optional] 
**AccountNumber** | **string** |  | [optional] 
**OpeningBalance** | **double** |  | [optional] 
**OpeningBalanceDate** | **DateTime** |  | [optional] 
**VirtualBalance** | **double** |  | [optional] 
**CurrentBalance** | **decimal** |  | [optional] [readonly] 
**CurrentBalanceDate** | **DateTime** |  | [optional] [readonly] 
**CurrencyId** | **int** | Use either currency_id or currency_code. Defaults to the user&#39;s default currency. | [optional] 
**CurrencyCode** | **string** | Use either currency_id or currency_code. Defaults to the user&#39;s default currency. | [optional] 
**CurrencySymbol** | **string** |  | [optional] [readonly] 
**CurrencyDecimalPlaces** | **int** |  | [optional] [readonly] 
**Active** | **bool** | If omitted, defaults to true. | [optional] 
**IncludeNetWorth** | **bool** | If omitted, defaults to true. | [optional] 
**AccountRole** | **string** | Is only mandatory when the type is asset. | 
**CreditCardType** | **string** | Mandatory when the account_role is ccAsset. Can only be monthlyFull. | [optional] 
**MonthlyPaymentDate** | **DateTime?** | Mandatory when the account_role is ccAsset. Moment at which CC payment installments are asked for by the bank. | [optional] 
**LiabilityType** | **string** | Mandatory when type is liability. Specifies the exact type. | [optional] 
**LiabilityAmount** | **double** | Mandatory when type is liability. Amount of money in the liability. Must be positive. | [optional] 
**LiabilityStartDate** | **DateTime** | Mandatory when type is liability. Start date for the liability. | [optional] 
**Interest** | **float** | Mandatory when type is liability. Interest percentage. | [optional] 
**InterestPeriod** | **string** | Mandatory when type is liability. Period over which the interest is calculated. | [optional] 
**Notes** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

