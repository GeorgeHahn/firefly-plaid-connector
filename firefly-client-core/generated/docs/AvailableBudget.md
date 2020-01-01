# FireflyIII.Net.Model.AvailableBudget
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt** | **DateTime** |  | [optional] [readonly] 
**UpdatedAt** | **DateTime** |  | [optional] [readonly] 
**CurrencyId** | **int** | Use either currency_id or currency_code. | [optional] 
**CurrencyCode** | **string** | Use either currency_id or currency_code. | [optional] 
**CurrencySymbol** | **string** |  | [optional] [readonly] 
**CurrencyDecimalPlaces** | **int** |  | [optional] [readonly] 
**Amount** | **double** |  | 
**Start** | **DateTime** | Start date of the available budget. | 
**End** | **DateTime** | End date of the available budget. | 
**SpentInBudgets** | [**List&lt;BudgetSpent&gt;**](BudgetSpent.md) |  | [optional] [readonly] 
**SpentOutsideBudget** | [**List&lt;BudgetSpent&gt;**](BudgetSpent.md) |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

