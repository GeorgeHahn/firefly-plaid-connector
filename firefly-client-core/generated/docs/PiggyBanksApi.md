# FireflyIII.Net.Api.PiggyBanksApi

All URIs are relative to *https://demo.firefly-iii.org*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletePiggyBank**](PiggyBanksApi.md#deletepiggybank) | **DELETE** /api/v1/piggy_banks/{id} | Delete a piggy bank.
[**GetPiggyBank**](PiggyBanksApi.md#getpiggybank) | **GET** /api/v1/piggy_banks/{id} | Get a single piggy bank.
[**ListEventByPiggyBank**](PiggyBanksApi.md#listeventbypiggybank) | **GET** /api/v1/piggy_banks/{id}/events | List all events linked to a piggy bank.
[**ListPiggyBank**](PiggyBanksApi.md#listpiggybank) | **GET** /api/v1/piggy_banks | List all piggy banks.
[**StorePiggyBank**](PiggyBanksApi.md#storepiggybank) | **POST** /api/v1/piggy_banks | Store a new piggy bank
[**UpdatePiggyBank**](PiggyBanksApi.md#updatepiggybank) | **PUT** /api/v1/piggy_banks/{id} | Update existing piggy bank.


<a name="deletepiggybank"></a>
# **DeletePiggyBank**
> void DeletePiggyBank (int id)

Delete a piggy bank.

Delete a piggy bank.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class DeletePiggyBankExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PiggyBanksApi(Configuration.Default);
            var id = 1;  // int | The ID of the piggy bank.

            try
            {
                // Delete a piggy bank.
                apiInstance.DeletePiggyBank(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PiggyBanksApi.DeletePiggyBank: " + e.Message );
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
 **id** | **int**| The ID of the piggy bank. | 

### Return type

void (empty response body)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Piggy bank deleted. |  -  |
| **404** | No such piggy bank |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpiggybank"></a>
# **GetPiggyBank**
> PiggyBankSingle GetPiggyBank (int id)

Get a single piggy bank.

Get a single piggy bank.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class GetPiggyBankExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PiggyBanksApi(Configuration.Default);
            var id = 1;  // int | The ID of the piggy bank.

            try
            {
                // Get a single piggy bank.
                PiggyBankSingle result = apiInstance.GetPiggyBank(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PiggyBanksApi.GetPiggyBank: " + e.Message );
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
 **id** | **int**| The ID of the piggy bank. | 

### Return type

[**PiggyBankSingle**](PiggyBankSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested piggy bank |  -  |
| **404** | Piggy bank not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listeventbypiggybank"></a>
# **ListEventByPiggyBank**
> PiggyBankEventArray ListEventByPiggyBank (int id, int? page = null)

List all events linked to a piggy bank.

List all events linked to a piggy bank (adding and removing money).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class ListEventByPiggyBankExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PiggyBanksApi(Configuration.Default);
            var id = 1;  // int | The ID of the piggy bank
            var page = 1;  // int? | Page number. The default pagination is 50. (optional) 

            try
            {
                // List all events linked to a piggy bank.
                PiggyBankEventArray result = apiInstance.ListEventByPiggyBank(id, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PiggyBanksApi.ListEventByPiggyBank: " + e.Message );
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
 **id** | **int**| The ID of the piggy bank | 
 **page** | **int?**| Page number. The default pagination is 50. | [optional] 

### Return type

[**PiggyBankEventArray**](PiggyBankEventArray.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of piggy bank related events |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpiggybank"></a>
# **ListPiggyBank**
> PiggyBankArray ListPiggyBank (int? page = null)

List all piggy banks.

List all piggy banks.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class ListPiggyBankExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PiggyBanksApi(Configuration.Default);
            var page = 1;  // int? | Page number. The default pagination is 50. (optional) 

            try
            {
                // List all piggy banks.
                PiggyBankArray result = apiInstance.ListPiggyBank(page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PiggyBanksApi.ListPiggyBank: " + e.Message );
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
 **page** | **int?**| Page number. The default pagination is 50. | [optional] 

### Return type

[**PiggyBankArray**](PiggyBankArray.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of piggy banks |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="storepiggybank"></a>
# **StorePiggyBank**
> PiggyBankSingle StorePiggyBank (PiggyBank piggyBank)

Store a new piggy bank

Creates a new piggy bank. The data required can be submitted as a JSON body or as a list of parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class StorePiggyBankExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PiggyBanksApi(Configuration.Default);
            var piggyBank = new PiggyBank(); // PiggyBank | JSON array or key=value pairs with the necessary piggy bank information. See the model for the exact specifications.

            try
            {
                // Store a new piggy bank
                PiggyBankSingle result = apiInstance.StorePiggyBank(piggyBank);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PiggyBanksApi.StorePiggyBank: " + e.Message );
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
 **piggyBank** | [**PiggyBank**](PiggyBank.md)| JSON array or key&#x3D;value pairs with the necessary piggy bank information. See the model for the exact specifications. | 

### Return type

[**PiggyBankSingle**](PiggyBankSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | New piggy bank stored, result in response. |  -  |
| **422** | Validation errors (see body) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepiggybank"></a>
# **UpdatePiggyBank**
> PiggyBankSingle UpdatePiggyBank (int id, PiggyBank piggyBank)

Update existing piggy bank.

Update existing piggy bank.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class UpdatePiggyBankExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PiggyBanksApi(Configuration.Default);
            var id = 1;  // int | The ID of the piggy bank
            var piggyBank = new PiggyBank(); // PiggyBank | JSON array with updated piggy bank information. See the model for the exact specifications.

            try
            {
                // Update existing piggy bank.
                PiggyBankSingle result = apiInstance.UpdatePiggyBank(id, piggyBank);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PiggyBanksApi.UpdatePiggyBank: " + e.Message );
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
 **id** | **int**| The ID of the piggy bank | 
 **piggyBank** | [**PiggyBank**](PiggyBank.md)| JSON array with updated piggy bank information. See the model for the exact specifications. | 

### Return type

[**PiggyBankSingle**](PiggyBankSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated piggy bank stored, result in response |  -  |
| **422** | Validation errors (see body) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

