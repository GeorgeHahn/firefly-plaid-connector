# FireflyIII.Net.Api.SummaryApi

All URIs are relative to *https://demo.firefly-iii.org*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBasicSummary**](SummaryApi.md#getbasicsummary) | **GET** /api/v1/summary/basic | Returns basic sums of the users data.


<a name="getbasicsummary"></a>
# **GetBasicSummary**
> List&lt;BasicSummaryEntry&gt; GetBasicSummary (DateTime start, DateTime end, string currencyCode = null)

Returns basic sums of the users data.

Returns basic sums of the users data, like the net worth, spent and earned amounts. It is multi-currency, and is in Firefly III to populate the dashboard. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class GetBasicSummaryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SummaryApi(Configuration.Default);
            var start = 2013-10-20;  // DateTime | A date formatted YYYY-MM-DD. 
            var end = 2013-10-20;  // DateTime | A date formatted YYYY-MM-DD. 
            var currencyCode = currencyCode_example;  // string | A currency code like EUR or USD, to filter the result.  (optional) 

            try
            {
                // Returns basic sums of the users data.
                List<BasicSummaryEntry> result = apiInstance.GetBasicSummary(start, end, currencyCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SummaryApi.GetBasicSummary: " + e.Message );
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
 **start** | **DateTime**| A date formatted YYYY-MM-DD.  | 
 **end** | **DateTime**| A date formatted YYYY-MM-DD.  | 
 **currencyCode** | **string**| A currency code like EUR or USD, to filter the result.  | [optional] 

### Return type

[**List&lt;BasicSummaryEntry&gt;**](BasicSummaryEntry.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An array of sums. It depends on the user what you can expect to get back, so please check out the documentation and try this out on the demo site. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

