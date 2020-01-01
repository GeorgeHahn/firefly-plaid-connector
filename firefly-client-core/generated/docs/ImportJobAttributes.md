# FireflyIII.Net.Model.ImportJobAttributes
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt** | **DateTime** |  | [optional] 
**UpdatedAt** | **DateTime** |  | [optional] 
**TagId** | **int** | ID of the tag related to the import job, if present. | [optional] 
**TagTag** | **string** | Tag related to the import job, if present. | [optional] 
**Key** | **string** | Import job unique identifier. | [optional] 
**FileType** | **string** | File type, if relevant. | [optional] 
**Provider** | **string** | Import provider that did the import. | [optional] 
**Status** | **string** | Status of import job. | [optional] 
**Stage** | **string** | Current stage. | [optional] 
**Configuration** | **string** | JSON string with job-specific configuration. | [optional] 
**ExtendedStatus** | **string** | JSON string with job-specific status. | [optional] 
**Transactions** | **string** | JSON string with a count of transactions in the job. | [optional] 
**Errors** | **string** | JSON string with a list of errors. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

