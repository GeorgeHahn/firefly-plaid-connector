# FireflyIII.Net.Model.BudgetLimit
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt** | **DateTime** |  | [optional] [readonly] 
**UpdatedAt** | **DateTime** |  | [optional] [readonly] 
**CurrencyId** | **int** | Use either currency_id or currency_code. Defaults to the user&#39;s default currency. | [optional] 
**CurrencyCode** | **string** | Use either currency_id or currency_code. Defaults to the user&#39;s default currency. | [optional] 
**CurrencySymbol** | **string** |  | [optional] [readonly] 
**CurrencyDecimalPlaces** | **int** |  | [optional] [readonly] 
**BudgetId** | **int** | The budget ID of the associated budget. | 
**Start** | **DateTime** | Start date of the budget limit. | 
**End** | **DateTime** | End date of the budget limit. | 
**Amount** | **double** |  | 
**Spent** | [**List&lt;BudgetSpent&gt;**](BudgetSpent.md) |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

