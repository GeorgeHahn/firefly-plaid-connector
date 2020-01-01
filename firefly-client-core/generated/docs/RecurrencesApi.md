# FireflyIII.Net.Api.RecurrencesApi

All URIs are relative to *https://demo.firefly-iii.org*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteRecurrence**](RecurrencesApi.md#deleterecurrence) | **DELETE** /api/v1/recurrences/{id} | Delete a recurring transaction.
[**GetRecurrence**](RecurrencesApi.md#getrecurrence) | **GET** /api/v1/recurrences/{id} | Get a single recurring transaction.
[**ListRecurrence**](RecurrencesApi.md#listrecurrence) | **GET** /api/v1/recurrences | List all recurring transactions.
[**ListTransactionByRecurrence**](RecurrencesApi.md#listtransactionbyrecurrence) | **GET** /api/v1/recurrences/{id}/transactions | List all transactions created by a recurring transaction.
[**StoreRecurrence**](RecurrencesApi.md#storerecurrence) | **POST** /api/v1/recurrences | Store a new recurring transaction
[**TriggerRecurrence**](RecurrencesApi.md#triggerrecurrence) | **POST** /api/v1/recurrences/trigger | Trigger the creation of recurring transactions (like a cron job).
[**UpdateRecurrence**](RecurrencesApi.md#updaterecurrence) | **PUT** /api/v1/recurrences/{id} | Update existing recurring transaction.


<a name="deleterecurrence"></a>
# **DeleteRecurrence**
> void DeleteRecurrence (int id)

Delete a recurring transaction.

Delete a recurring transaction. Transactions created will not be deleted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class DeleteRecurrenceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RecurrencesApi(Configuration.Default);
            var id = 1;  // int | The ID of the recurring transaction.

            try
            {
                // Delete a recurring transaction.
                apiInstance.DeleteRecurrence(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecurrencesApi.DeleteRecurrence: " + e.Message );
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
 **id** | **int**| The ID of the recurring transaction. | 

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
| **204** | Recurring transaction deleted. |  -  |
| **404** | No such recurring transaction |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrecurrence"></a>
# **GetRecurrence**
> RecurrenceSingle GetRecurrence (int id)

Get a single recurring transaction.

Get a single recurring transaction.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class GetRecurrenceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RecurrencesApi(Configuration.Default);
            var id = 1;  // int | The ID of the recurring transaction.

            try
            {
                // Get a single recurring transaction.
                RecurrenceSingle result = apiInstance.GetRecurrence(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecurrencesApi.GetRecurrence: " + e.Message );
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
 **id** | **int**| The ID of the recurring transaction. | 

### Return type

[**RecurrenceSingle**](RecurrenceSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested recurring transaction |  -  |
| **404** | Recurring transaction not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listrecurrence"></a>
# **ListRecurrence**
> RecurrenceArray ListRecurrence (int? page = null)

List all recurring transactions.

List all recurring transactions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class ListRecurrenceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RecurrencesApi(Configuration.Default);
            var page = 1;  // int? | Page number. The default pagination is 50. (optional) 

            try
            {
                // List all recurring transactions.
                RecurrenceArray result = apiInstance.ListRecurrence(page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecurrencesApi.ListRecurrence: " + e.Message );
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

[**RecurrenceArray**](RecurrenceArray.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of recurring transactions. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtransactionbyrecurrence"></a>
# **ListTransactionByRecurrence**
> TransactionArray ListTransactionByRecurrence (int id, int? page = null, DateTime? start = null, DateTime? end = null, TransactionTypeFilter type = null)

List all transactions created by a recurring transaction.

List all transactions created by a recurring transaction, optionally limited to the date ranges specified.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class ListTransactionByRecurrenceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RecurrencesApi(Configuration.Default);
            var id = 1;  // int | The ID of the recurring transaction.
            var page = 1;  // int? | Page number. The default pagination is 50. (optional) 
            var start = Sun Sep 16 19:00:00 CDT 2018;  // DateTime? | A date formatted YYYY-MM-DD. Both the start and end date must be present.  (optional) 
            var end = Sun Sep 16 19:00:00 CDT 2018;  // DateTime? | A date formatted YYYY-MM-DD. Both the start and end date must be present.  (optional) 
            var type = new TransactionTypeFilter(); // TransactionTypeFilter | Optional filter on the transaction type(s) returned (optional) 

            try
            {
                // List all transactions created by a recurring transaction.
                TransactionArray result = apiInstance.ListTransactionByRecurrence(id, page, start, end, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecurrencesApi.ListTransactionByRecurrence: " + e.Message );
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
 **id** | **int**| The ID of the recurring transaction. | 
 **page** | **int?**| Page number. The default pagination is 50. | [optional] 
 **start** | **DateTime?**| A date formatted YYYY-MM-DD. Both the start and end date must be present.  | [optional] 
 **end** | **DateTime?**| A date formatted YYYY-MM-DD. Both the start and end date must be present.  | [optional] 
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
| **200** | A list of transactions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="storerecurrence"></a>
# **StoreRecurrence**
> RecurrenceSingle StoreRecurrence (Recurrence recurrence)

Store a new recurring transaction

Creates a new recurring transaction. The data required can be submitted as a JSON body or as a list of parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class StoreRecurrenceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RecurrencesApi(Configuration.Default);
            var recurrence = new Recurrence(); // Recurrence | JSON array or key=value pairs with the necessary recurring transaction information. See the model for the exact specifications.

            try
            {
                // Store a new recurring transaction
                RecurrenceSingle result = apiInstance.StoreRecurrence(recurrence);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecurrencesApi.StoreRecurrence: " + e.Message );
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
 **recurrence** | [**Recurrence**](Recurrence.md)| JSON array or key&#x3D;value pairs with the necessary recurring transaction information. See the model for the exact specifications. | 

### Return type

[**RecurrenceSingle**](RecurrenceSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | New recurring transaction stored, result in response. |  -  |
| **422** | Validation errors (see body) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="triggerrecurrence"></a>
# **TriggerRecurrence**
> void TriggerRecurrence ()

Trigger the creation of recurring transactions (like a cron job).

Triggers the recurring transactions, like a cron job would. If the schedule does not call for a new transaction to be created, nothing will happen. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class TriggerRecurrenceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RecurrencesApi(Configuration.Default);

            try
            {
                // Trigger the creation of recurring transactions (like a cron job).
                apiInstance.TriggerRecurrence();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecurrencesApi.TriggerRecurrence: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

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
| **204** | Not triggered (not yet due or unable to). |  -  |
| **200** | Triggered. Due to the way it&#39;s fired (an asynchronous job), the result cannot be shown to you. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterecurrence"></a>
# **UpdateRecurrence**
> RecurrenceSingle UpdateRecurrence (int id, Recurrence recurrence)

Update existing recurring transaction.

Update existing recurring transaction.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class UpdateRecurrenceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RecurrencesApi(Configuration.Default);
            var id = 1;  // int | The ID of the recurring transaction.
            var recurrence = new Recurrence(); // Recurrence | JSON array with updated recurring transaction information. See the model for the exact specifications.

            try
            {
                // Update existing recurring transaction.
                RecurrenceSingle result = apiInstance.UpdateRecurrence(id, recurrence);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecurrencesApi.UpdateRecurrence: " + e.Message );
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
 **id** | **int**| The ID of the recurring transaction. | 
 **recurrence** | [**Recurrence**](Recurrence.md)| JSON array with updated recurring transaction information. See the model for the exact specifications. | 

### Return type

[**RecurrenceSingle**](RecurrenceSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated recurring transaction stored, result in response |  -  |
| **422** | Validation errors (see body) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

