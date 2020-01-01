# FireflyIII.Net.Api.CurrencyExchangeRatesApi

All URIs are relative to *https://demo.firefly-iii.org*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetExchangeRate**](CurrencyExchangeRatesApi.md#getexchangerate) | **GET** /api/v1/cer | Get an exchange rate.


<a name="getexchangerate"></a>
# **GetExchangeRate**
> ExchangeRate GetExchangeRate (string from = null, string to = null, DateTime? date = null, double? amount = null)

Get an exchange rate.

Get an exchange rate. If Firefly III doesn't know the rate it will set the rate to 1.0.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class GetExchangeRateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CurrencyExchangeRatesApi(Configuration.Default);
            var from = EUR;  // string | The source currency code. If omitted, defaults to EUR. (optional) 
            var to = USD;  // string | The destination currency code. If omitted, defaults to USD. (optional) 
            var date = Sun Sep 16 19:00:00 CDT 2018;  // DateTime? | The date you want to know the exchange rate on. (optional) 
            var amount = 120.12;  // double? | The amount in the source currency. If added, Firefly III will calculate the amount in the destination currency. (optional) 

            try
            {
                // Get an exchange rate.
                ExchangeRate result = apiInstance.GetExchangeRate(from, to, date, amount);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CurrencyExchangeRatesApi.GetExchangeRate: " + e.Message );
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
 **from** | **string**| The source currency code. If omitted, defaults to EUR. | [optional] 
 **to** | **string**| The destination currency code. If omitted, defaults to USD. | [optional] 
 **date** | **DateTime?**| The date you want to know the exchange rate on. | [optional] 
 **amount** | **double?**| The amount in the source currency. If added, Firefly III will calculate the amount in the destination currency. | [optional] 

### Return type

[**ExchangeRate**](ExchangeRate.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The exchange rate as requested |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

