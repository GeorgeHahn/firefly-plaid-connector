# FireflyIII.Net.Api.AvailableBudgetsApi

All URIs are relative to *https://demo.firefly-iii.org*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAvailableBudget**](AvailableBudgetsApi.md#deleteavailablebudget) | **DELETE** /api/v1/available_budgets/{id} | Delete an available budget.
[**GetAvailableBudget**](AvailableBudgetsApi.md#getavailablebudget) | **GET** /api/v1/available_budgets/{id} | Get a single available budget.
[**ListAvailableBudget**](AvailableBudgetsApi.md#listavailablebudget) | **GET** /api/v1/available_budgets | List all available budget amounts.
[**StoreAvailableBudget**](AvailableBudgetsApi.md#storeavailablebudget) | **POST** /api/v1/available_budgets | Store a new available budget
[**UpdateAvailableBudget**](AvailableBudgetsApi.md#updateavailablebudget) | **PUT** /api/v1/available_budgets/{id} | Update existing available budget, to change for example the date range of the amount or the amount itself.


<a name="deleteavailablebudget"></a>
# **DeleteAvailableBudget**
> void DeleteAvailableBudget (int id)

Delete an available budget.

Delete an available budget. Not much more to say.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class DeleteAvailableBudgetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AvailableBudgetsApi(Configuration.Default);
            var id = 1;  // int | The ID of the available budget.

            try
            {
                // Delete an available budget.
                apiInstance.DeleteAvailableBudget(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvailableBudgetsApi.DeleteAvailableBudget: " + e.Message );
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
 **id** | **int**| The ID of the available budget. | 

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
| **204** | Available budget deleted. |  -  |
| **404** | No such available budget. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getavailablebudget"></a>
# **GetAvailableBudget**
> AvailableBudgetSingle GetAvailableBudget (int id)

Get a single available budget.

Get a single available budget, by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class GetAvailableBudgetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AvailableBudgetsApi(Configuration.Default);
            var id = 1;  // int | The ID of the available budget.

            try
            {
                // Get a single available budget.
                AvailableBudgetSingle result = apiInstance.GetAvailableBudget(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvailableBudgetsApi.GetAvailableBudget: " + e.Message );
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
 **id** | **int**| The ID of the available budget. | 

### Return type

[**AvailableBudgetSingle**](AvailableBudgetSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested available budget |  -  |
| **404** | AvailableBudget not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listavailablebudget"></a>
# **ListAvailableBudget**
> AvailableBudgetArray ListAvailableBudget (int? page = null, DateTime? start = null, DateTime? end = null)

List all available budget amounts.

Firefly III allows users to set the amount that is available to be budgeted in so-called \"available budgets\". For example, the user could have 1200,- available to be divided during the coming month. This amount is used on the /budgets page. This endpoint returns all of these amounts and the periods for which they are set. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class ListAvailableBudgetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AvailableBudgetsApi(Configuration.Default);
            var page = 1;  // int? | Page number. The default pagination is 50. (optional) 
            var start = Sun Sep 16 19:00:00 CDT 2018;  // DateTime? | A date formatted YYYY-MM-DD.  (optional) 
            var end = Sun Dec 30 18:00:00 CST 2018;  // DateTime? | A date formatted YYYY-MM-DD.  (optional) 

            try
            {
                // List all available budget amounts.
                AvailableBudgetArray result = apiInstance.ListAvailableBudget(page, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvailableBudgetsApi.ListAvailableBudget: " + e.Message );
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
 **start** | **DateTime?**| A date formatted YYYY-MM-DD.  | [optional] 
 **end** | **DateTime?**| A date formatted YYYY-MM-DD.  | [optional] 

### Return type

[**AvailableBudgetArray**](AvailableBudgetArray.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of available budget amounts. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="storeavailablebudget"></a>
# **StoreAvailableBudget**
> AvailableBudgetSingle StoreAvailableBudget (AvailableBudget availableBudget)

Store a new available budget

Creates a new available budget for a specified period. The data required can be submitted as a JSON body or as a list of parameters. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class StoreAvailableBudgetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AvailableBudgetsApi(Configuration.Default);
            var availableBudget = new AvailableBudget(); // AvailableBudget | JSON array or key=value pairs with the necessary available budget information. See the model for the exact specifications.

            try
            {
                // Store a new available budget
                AvailableBudgetSingle result = apiInstance.StoreAvailableBudget(availableBudget);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvailableBudgetsApi.StoreAvailableBudget: " + e.Message );
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
 **availableBudget** | [**AvailableBudget**](AvailableBudget.md)| JSON array or key&#x3D;value pairs with the necessary available budget information. See the model for the exact specifications. | 

### Return type

[**AvailableBudgetSingle**](AvailableBudgetSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | New available budget stored, result in response. |  -  |
| **422** | Validation errors (see body) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateavailablebudget"></a>
# **UpdateAvailableBudget**
> AvailableBudgetSingle UpdateAvailableBudget (int id, AvailableBudget availableBudget)

Update existing available budget, to change for example the date range of the amount or the amount itself.

Update existing available budget.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class UpdateAvailableBudgetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AvailableBudgetsApi(Configuration.Default);
            var id = 1;  // int | The ID of the object.X
            var availableBudget = new AvailableBudget(); // AvailableBudget | JSON array or form value with updated available budget information. See the model for the exact specifications.

            try
            {
                // Update existing available budget, to change for example the date range of the amount or the amount itself.
                AvailableBudgetSingle result = apiInstance.UpdateAvailableBudget(id, availableBudget);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvailableBudgetsApi.UpdateAvailableBudget: " + e.Message );
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
 **id** | **int**| The ID of the object.X | 
 **availableBudget** | [**AvailableBudget**](AvailableBudget.md)| JSON array or form value with updated available budget information. See the model for the exact specifications. | 

### Return type

[**AvailableBudgetSingle**](AvailableBudgetSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated available budget stored, result in response |  -  |
| **422** | Validation errors (see body) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

