# FireflyIII.Net.Api.ImportApi

All URIs are relative to *https://demo.firefly-iii.org*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetImport**](ImportApi.md#getimport) | **GET** /api/v1/import/{key} | Show info on a single import
[**ListImport**](ImportApi.md#listimport) | **GET** /api/v1/import/list | List al imports
[**ListTransactionByImport**](ImportApi.md#listtransactionbyimport) | **GET** /api/v1/import/{key}/transactions | List all transactions related to the import job. The correlation is made through the tag.


<a name="getimport"></a>
# **GetImport**
> ImportJobSingle GetImport (string key)

Show info on a single import

Show info on single import.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class GetImportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ImportApi(Configuration.Default);
            var key = x2Akaijm2;  // string | The job key of an import job.

            try
            {
                // Show info on a single import
                ImportJobSingle result = apiInstance.GetImport(key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ImportApi.GetImport: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The job key of an import job. | 

### Return type

[**ImportJobSingle**](ImportJobSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested import job |  -  |
| **404** | Import job not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listimport"></a>
# **ListImport**
> ImportJobArray ListImport (int? page = null)

List al imports

List all imports

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class ListImportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ImportApi(Configuration.Default);
            var page = 1;  // int? | Page number. The default pagination is per 50 items. (optional) 

            try
            {
                // List al imports
                ImportJobArray result = apiInstance.ListImport(page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ImportApi.ListImport: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Page number. The default pagination is per 50 items. | [optional] 

### Return type

[**ImportJobArray**](ImportJobArray.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of import jobs. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtransactionbyimport"></a>
# **ListTransactionByImport**
> TransactionArray ListTransactionByImport (string key, int? page = null, DateTime? start = null, DateTime? end = null, TransactionTypeFilter type = null)

List all transactions related to the import job. The correlation is made through the tag.

See summary 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class ListTransactionByImportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ImportApi(Configuration.Default);
            var key = abcde;  // string | The key of the import job
            var page = 1;  // int? | Page number. The default pagination is 50. (optional) 
            var start = Sun Sep 16 19:00:00 CDT 2018;  // DateTime? | A date formatted YYYY-MM-DD. This is the start date of the selected range (inclusive).  (optional) 
            var end = Sun Sep 16 19:00:00 CDT 2018;  // DateTime? | A date formatted YYYY-MM-DD. This is the end date of the selected range (inclusive).  (optional) 
            var type = new TransactionTypeFilter(); // TransactionTypeFilter | Optional filter on the transaction type(s) returned. (optional) 

            try
            {
                // List all transactions related to the import job. The correlation is made through the tag.
                TransactionArray result = apiInstance.ListTransactionByImport(key, page, start, end, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ImportApi.ListTransactionByImport: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the import job | 
 **page** | **int?**| Page number. The default pagination is 50. | [optional] 
 **start** | **DateTime?**| A date formatted YYYY-MM-DD. This is the start date of the selected range (inclusive).  | [optional] 
 **end** | **DateTime?**| A date formatted YYYY-MM-DD. This is the end date of the selected range (inclusive).  | [optional] 
 **type** | [**TransactionTypeFilter**](TransactionTypeFilter.md)| Optional filter on the transaction type(s) returned. | [optional] 

### Return type

[**TransactionArray**](TransactionArray.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of transactions. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

