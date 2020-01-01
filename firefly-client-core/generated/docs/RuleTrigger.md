# FireflyIII.Net.Model.RuleTrigger
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [optional] [readonly] 
**CreatedAt** | **DateTime** |  | [optional] [readonly] 
**UpdatedAt** | **DateTime** |  | [optional] [readonly] 
**Type** | **string** | The type of thing this trigger responds to. A limited set is possible | 
**Value** | **string** | The accompanying value the trigger responds to. This value is often mandatory, but this depends on the trigger. | 
**Order** | **int** | Order of the trigger | [optional] [readonly] 
**Active** | **bool** | If the trigger is active. | [optional] 
**StopProcessing** | **bool** | When true, other triggers will not be checked if this trigger was triggered. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

