# FireflyIII.Net.Api.BudgetsApi

All URIs are relative to *https://demo.firefly-iii.org*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteBudget**](BudgetsApi.md#deletebudget) | **DELETE** /api/v1/budgets/{id} | Delete a budget.
[**DeleteBudgetLimit**](BudgetsApi.md#deletebudgetlimit) | **DELETE** /api/v1/budgets/limits/{id} | Delete a budget limit.
[**GetBudget**](BudgetsApi.md#getbudget) | **GET** /api/v1/budgets/{id} | Get a single budget.
[**GetBudgetLimit**](BudgetsApi.md#getbudgetlimit) | **GET** /api/v1/budgets/limits/{id} | Get single budget limit.
[**ListBudget**](BudgetsApi.md#listbudget) | **GET** /api/v1/budgets | List all budgets.
[**ListBudgetLimitByBudget**](BudgetsApi.md#listbudgetlimitbybudget) | **GET** /api/v1/budgets/{id}/limits | Get all limits
[**ListTransactionByBudget**](BudgetsApi.md#listtransactionbybudget) | **GET** /api/v1/budgets/{id}/transactions | All transactions to a budget.
[**ListTransactionByBudgetLimit**](BudgetsApi.md#listtransactionbybudgetlimit) | **GET** /api/v1/budgets/limits/{id}/transactions | List all transactions by a budget limit ID.
[**StoreBudget**](BudgetsApi.md#storebudget) | **POST** /api/v1/budgets | Store a new budget
[**StoreBudgetLimit**](BudgetsApi.md#storebudgetlimit) | **POST** /api/v1/budgets/{id}/limits | Store new budget limit.
[**UpdateBudget**](BudgetsApi.md#updatebudget) | **PUT** /api/v1/budgets/{id} | Update existing budget.
[**UpdateBudgetLimit**](BudgetsApi.md#updatebudgetlimit) | **PUT** /api/v1/budgets/limits/{id} | Update existing budget limit.


<a name="deletebudget"></a>
# **DeleteBudget**
> void DeleteBudget (int id)

Delete a budget.

Delete a budget. Transactions will not be deleted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class DeleteBudgetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BudgetsApi(Configuration.Default);
            var id = 1;  // int | The ID of the budget.

            try
            {
                // Delete a budget.
                apiInstance.DeleteBudget(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetsApi.DeleteBudget: " + e.Message );
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
 **id** | **int**| The ID of the budget. | 

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
| **204** | Budget deleted. |  -  |
| **404** | No such budget |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebudgetlimit"></a>
# **DeleteBudgetLimit**
> void DeleteBudgetLimit (int id)

Delete a budget limit.

Delete a budget limit.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class DeleteBudgetLimitExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BudgetsApi(Configuration.Default);
            var id = 1;  // int | The ID of the requested budget limit.

            try
            {
                // Delete a budget limit.
                apiInstance.DeleteBudgetLimit(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetsApi.DeleteBudgetLimit: " + e.Message );
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
 **id** | **int**| The ID of the requested budget limit. | 

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
| **204** | Budget limit deleted. |  -  |
| **404** | No such budget limit |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbudget"></a>
# **GetBudget**
> BudgetSingle GetBudget (int id, DateTime? startDate = null, DateTime? endDate = null)

Get a single budget.

Get a single budget. If the start date and end date are submitted as well, the \"spent\" array will be updated accordingly.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class GetBudgetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BudgetsApi(Configuration.Default);
            var id = 1;  // int | The ID of the requested budget.
            var startDate = Sun Sep 16 19:00:00 CDT 2018;  // DateTime? | A date formatted YYYY-MM-DD, to get info on how much the user has spent.  (optional) 
            var endDate = Sun Dec 30 18:00:00 CST 2018;  // DateTime? | A date formatted YYYY-MM-DD, to get info on how much the user has spent.  (optional) 

            try
            {
                // Get a single budget.
                BudgetSingle result = apiInstance.GetBudget(id, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetsApi.GetBudget: " + e.Message );
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
 **id** | **int**| The ID of the requested budget. | 
 **startDate** | **DateTime?**| A date formatted YYYY-MM-DD, to get info on how much the user has spent.  | [optional] 
 **endDate** | **DateTime?**| A date formatted YYYY-MM-DD, to get info on how much the user has spent.  | [optional] 

### Return type

[**BudgetSingle**](BudgetSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested budget |  -  |
| **404** | Budget not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbudgetlimit"></a>
# **GetBudgetLimit**
> BudgetLimitSingle GetBudgetLimit (int id)

Get single budget limit.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class GetBudgetLimitExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BudgetsApi(Configuration.Default);
            var id = 1;  // int | The ID of the requested budget limit.

            try
            {
                // Get single budget limit.
                BudgetLimitSingle result = apiInstance.GetBudgetLimit(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetsApi.GetBudgetLimit: " + e.Message );
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
 **id** | **int**| The ID of the requested budget limit. | 

### Return type

[**BudgetLimitSingle**](BudgetLimitSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested budget limit |  -  |
| **404** | Budget limit not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listbudget"></a>
# **ListBudget**
> BudgetArray ListBudget (int? page = null, DateTime? start = null, DateTime? end = null)

List all budgets.

List all the budgets the user has made. If the start date and end date are submitted as well, the \"spent\" array will be updated accordingly.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class ListBudgetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BudgetsApi(Configuration.Default);
            var page = 1;  // int? | Page number. The default pagination is 50. (optional) 
            var start = Sun Sep 16 19:00:00 CDT 2018;  // DateTime? | A date formatted YYYY-MM-DD, to get info on how much the user has spent. You must submit both start and end.  (optional) 
            var end = Sun Dec 30 18:00:00 CST 2018;  // DateTime? | A date formatted YYYY-MM-DD, to get info on how much the user has spent. You must submit both start and end.  (optional) 

            try
            {
                // List all budgets.
                BudgetArray result = apiInstance.ListBudget(page, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetsApi.ListBudget: " + e.Message );
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
 **start** | **DateTime?**| A date formatted YYYY-MM-DD, to get info on how much the user has spent. You must submit both start and end.  | [optional] 
 **end** | **DateTime?**| A date formatted YYYY-MM-DD, to get info on how much the user has spent. You must submit both start and end.  | [optional] 

### Return type

[**BudgetArray**](BudgetArray.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of budgets. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listbudgetlimitbybudget"></a>
# **ListBudgetLimitByBudget**
> BudgetLimitArray ListBudgetLimitByBudget (int id, DateTime? start = null, DateTime? end = null)

Get all limits

Get all budget limits for this budget and the money spent, and money left. You can limit the list by submitting a date range as well. The \"spent\" array for each budget limit is NOT influenced by the start and end date of your query, but by the start and end date of the budget limit itself. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class ListBudgetLimitByBudgetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BudgetsApi(Configuration.Default);
            var id = 1;  // int | The ID of the requested budget.
            var start = Sun Sep 16 19:00:00 CDT 2018;  // DateTime? | A date formatted YYYY-MM-DD.  (optional) 
            var end = Sun Dec 30 18:00:00 CST 2018;  // DateTime? | A date formatted YYYY-MM-DD.  (optional) 

            try
            {
                // Get all limits
                BudgetLimitArray result = apiInstance.ListBudgetLimitByBudget(id, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetsApi.ListBudgetLimitByBudget: " + e.Message );
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
 **id** | **int**| The ID of the requested budget. | 
 **start** | **DateTime?**| A date formatted YYYY-MM-DD.  | [optional] 
 **end** | **DateTime?**| A date formatted YYYY-MM-DD.  | [optional] 

### Return type

[**BudgetLimitArray**](BudgetLimitArray.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of budget limits applicable to this budget. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtransactionbybudget"></a>
# **ListTransactionByBudget**
> TransactionArray ListTransactionByBudget (int id, int? limit = null, int? page = null, DateTime? start = null, DateTime? end = null, TransactionTypeFilter type = null)

All transactions to a budget.

Get all transactions linked to a budget, possibly limited by start and end

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class ListTransactionByBudgetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BudgetsApi(Configuration.Default);
            var id = 1;  // int | The ID of the budget.
            var limit = 5;  // int? | Limits the number of results on one page. (optional) 
            var page = 1;  // int? | Page number. The default pagination is 50. (optional) 
            var start = Sun Sep 16 19:00:00 CDT 2018;  // DateTime? | A date formatted YYYY-MM-DD.  (optional) 
            var end = Sun Dec 30 18:00:00 CST 2018;  // DateTime? | A date formatted YYYY-MM-DD.  (optional) 
            var type = new TransactionTypeFilter(); // TransactionTypeFilter | Optional filter on the transaction type(s) returned (optional) 

            try
            {
                // All transactions to a budget.
                TransactionArray result = apiInstance.ListTransactionByBudget(id, limit, page, start, end, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetsApi.ListTransactionByBudget: " + e.Message );
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
 **id** | **int**| The ID of the budget. | 
 **limit** | **int?**| Limits the number of results on one page. | [optional] 
 **page** | **int?**| Page number. The default pagination is 50. | [optional] 
 **start** | **DateTime?**| A date formatted YYYY-MM-DD.  | [optional] 
 **end** | **DateTime?**| A date formatted YYYY-MM-DD.  | [optional] 
 **type** | [**TransactionTypeFilter**](TransactionTypeFilter.md)| Optional filter on the transaction type(s) returned | [optional] 

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

<a name="listtransactionbybudgetlimit"></a>
# **ListTransactionByBudgetLimit**
> TransactionArray ListTransactionByBudgetLimit (int id, int? page = null, TransactionTypeFilter type = null)

List all transactions by a budget limit ID.

List all the transactions within one budget limit. The start and end date are dictated by the budget limit.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class ListTransactionByBudgetLimitExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BudgetsApi(Configuration.Default);
            var id = 1;  // int | The ID of the requested budget limit.
            var page = 1;  // int? | Page number. The default pagination is 50. (optional) 
            var type = new TransactionTypeFilter(); // TransactionTypeFilter | Optional filter on the transaction type(s) returned (optional) 

            try
            {
                // List all transactions by a budget limit ID.
                TransactionArray result = apiInstance.ListTransactionByBudgetLimit(id, page, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetsApi.ListTransactionByBudgetLimit: " + e.Message );
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
 **id** | **int**| The ID of the requested budget limit. | 
 **page** | **int?**| Page number. The default pagination is 50. | [optional] 
 **type** | [**TransactionTypeFilter**](TransactionTypeFilter.md)| Optional filter on the transaction type(s) returned | [optional] 

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

<a name="storebudget"></a>
# **StoreBudget**
> BudgetSingle StoreBudget (Budget budget)

Store a new budget

Creates a new budget. The data required can be submitted as a JSON body or as a list of parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class StoreBudgetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BudgetsApi(Configuration.Default);
            var budget = new Budget(); // Budget | JSON array or key=value pairs with the necessary budget information. See the model for the exact specifications.

            try
            {
                // Store a new budget
                BudgetSingle result = apiInstance.StoreBudget(budget);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetsApi.StoreBudget: " + e.Message );
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
 **budget** | [**Budget**](Budget.md)| JSON array or key&#x3D;value pairs with the necessary budget information. See the model for the exact specifications. | 

### Return type

[**BudgetSingle**](BudgetSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | New budget stored, result in response. |  -  |
| **422** | Validation errors (see body) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="storebudgetlimit"></a>
# **StoreBudgetLimit**
> BudgetLimitSingle StoreBudgetLimit (int id, BudgetLimit budgetLimit)

Store new budget limit.

Store a new budget limit.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class StoreBudgetLimitExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BudgetsApi(Configuration.Default);
            var id = 1;  // int | The ID of the budget.
            var budgetLimit = new BudgetLimit(); // BudgetLimit | JSON array or key=value pairs with the necessary budget information. See the model for the exact specifications.

            try
            {
                // Store new budget limit.
                BudgetLimitSingle result = apiInstance.StoreBudgetLimit(id, budgetLimit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetsApi.StoreBudgetLimit: " + e.Message );
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
 **id** | **int**| The ID of the budget. | 
 **budgetLimit** | [**BudgetLimit**](BudgetLimit.md)| JSON array or key&#x3D;value pairs with the necessary budget information. See the model for the exact specifications. | 

### Return type

[**BudgetLimitSingle**](BudgetLimitSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | New budget limit stored, result in response. |  -  |
| **422** | Validation errors (see body) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebudget"></a>
# **UpdateBudget**
> BudgetSingle UpdateBudget (int id, Budget budget)

Update existing budget.

Update existing budget. This endpoint cannot be used to set budget amount limits.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class UpdateBudgetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BudgetsApi(Configuration.Default);
            var id = 1;  // int | The ID of the budget.
            var budget = new Budget(); // Budget | JSON array with updated budget information. See the model for the exact specifications.

            try
            {
                // Update existing budget.
                BudgetSingle result = apiInstance.UpdateBudget(id, budget);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetsApi.UpdateBudget: " + e.Message );
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
 **id** | **int**| The ID of the budget. | 
 **budget** | [**Budget**](Budget.md)| JSON array with updated budget information. See the model for the exact specifications. | 

### Return type

[**BudgetSingle**](BudgetSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated budget stored, result in response |  -  |
| **422** | Validation errors (see body) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebudgetlimit"></a>
# **UpdateBudgetLimit**
> BudgetLimitSingle UpdateBudgetLimit (int id, BudgetLimit budgetLimit)

Update existing budget limit.

Update existing budget limit.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class UpdateBudgetLimitExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BudgetsApi(Configuration.Default);
            var id = 1;  // int | The ID of the requested budget limit. The budget limit MUST be associated to the budget ID.
            var budgetLimit = new BudgetLimit(); // BudgetLimit | JSON array with updated budget limit information. See the model for the exact specifications.

            try
            {
                // Update existing budget limit.
                BudgetLimitSingle result = apiInstance.UpdateBudgetLimit(id, budgetLimit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BudgetsApi.UpdateBudgetLimit: " + e.Message );
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
 **id** | **int**| The ID of the requested budget limit. The budget limit MUST be associated to the budget ID. | 
 **budgetLimit** | [**BudgetLimit**](BudgetLimit.md)| JSON array with updated budget limit information. See the model for the exact specifications. | 

### Return type

[**BudgetLimitSingle**](BudgetLimitSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated budget limit stored, result in response |  -  |
| **422** | Validation errors (see body) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

