# FireflyIII.Net.Model.RuleAction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [optional] [readonly] 
**CreatedAt** | **DateTime** |  | [optional] [readonly] 
**UpdatedAt** | **DateTime** |  | [optional] [readonly] 
**Type** | **string** | The type of thing this action will do. A limited set is possible. | 
**Value** | **string** | The accompanying value the action will set, change or update. Can be empty, but for some types this value is mandatory. | 
**Order** | **int** | Order of the action | [optional] 
**Active** | **bool** | If the action is active. | [optional] 
**StopProcessing** | **bool** | When true, other actions will not be fired after this action has fired. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

