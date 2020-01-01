# FireflyIII.Net.Api.TransactionsApi

All URIs are relative to *https://demo.firefly-iii.org*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteTransaction**](TransactionsApi.md#deletetransaction) | **DELETE** /api/v1/transactions/{id} | Delete a transaction.
[**GetTransaction**](TransactionsApi.md#gettransaction) | **GET** /api/v1/transactions/{id} | Get a single transaction.
[**GetTransactionByJournal**](TransactionsApi.md#gettransactionbyjournal) | **GET** /api/v1/transaction-journals/{id} | Get a single transaction, based on one of the underlying transaction journals.
[**ListAttachmentByTransaction**](TransactionsApi.md#listattachmentbytransaction) | **GET** /api/v1/transactions/{id}/attachments | Lists all attachments.
[**ListEventByTransaction**](TransactionsApi.md#listeventbytransaction) | **GET** /api/v1/transactions/{id}/piggy_bank_events | Lists all piggy bank events.
[**ListTransaction**](TransactionsApi.md#listtransaction) | **GET** /api/v1/transactions | List all the user&#39;s transactions. 
[**StoreTransaction**](TransactionsApi.md#storetransaction) | **POST** /api/v1/transactions | Store a new transaction
[**UpdateTransaction**](TransactionsApi.md#updatetransaction) | **PUT** /api/v1/transactions/{id} | Update existing transaction.


<a name="deletetransaction"></a>
# **DeleteTransaction**
> void DeleteTransaction (int id)

Delete a transaction.

Delete a transaction.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class DeleteTransactionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionsApi(Configuration.Default);
            var id = 1;  // int | The ID of the transaction.

            try
            {
                // Delete a transaction.
                apiInstance.DeleteTransaction(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.DeleteTransaction: " + e.Message );
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
 **id** | **int**| The ID of the transaction. | 

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
| **204** | Transaction deleted. |  -  |
| **404** | No such transaction. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransaction"></a>
# **GetTransaction**
> TransactionSingle GetTransaction (int id)

Get a single transaction.

Get a single transaction.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class GetTransactionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionsApi(Configuration.Default);
            var id = 1;  // int | The ID of the transaction.

            try
            {
                // Get a single transaction.
                TransactionSingle result = apiInstance.GetTransaction(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetTransaction: " + e.Message );
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
 **id** | **int**| The ID of the transaction. | 

### Return type

[**TransactionSingle**](TransactionSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested transaction. |  -  |
| **404** | Transaction not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactionbyjournal"></a>
# **GetTransactionByJournal**
> TransactionSingle GetTransactionByJournal (int id)

Get a single transaction, based on one of the underlying transaction journals.

Get a single transaction by underlying journal.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class GetTransactionByJournalExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionsApi(Configuration.Default);
            var id = 1;  // int | The ID of the transaction journal.

            try
            {
                // Get a single transaction, based on one of the underlying transaction journals.
                TransactionSingle result = apiInstance.GetTransactionByJournal(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetTransactionByJournal: " + e.Message );
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
 **id** | **int**| The ID of the transaction journal. | 

### Return type

[**TransactionSingle**](TransactionSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested transaction. |  -  |
| **404** | Transaction not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listattachmentbytransaction"></a>
# **ListAttachmentByTransaction**
> AttachmentArray ListAttachmentByTransaction (int id, int? page = null)

Lists all attachments.

Lists all attachments.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class ListAttachmentByTransactionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionsApi(Configuration.Default);
            var id = 1;  // int | The ID of the transaction.
            var page = 1;  // int? | Page number. The default pagination is 50. (optional) 

            try
            {
                // Lists all attachments.
                AttachmentArray result = apiInstance.ListAttachmentByTransaction(id, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.ListAttachmentByTransaction: " + e.Message );
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
 **id** | **int**| The ID of the transaction. | 
 **page** | **int?**| Page number. The default pagination is 50. | [optional] 

### Return type

[**AttachmentArray**](AttachmentArray.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of attachments |  -  |
| **404** | No such transaction. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listeventbytransaction"></a>
# **ListEventByTransaction**
> PiggyBankEventArray ListEventByTransaction (int id, int? page = null)

Lists all piggy bank events.

Lists all piggy bank events.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class ListEventByTransactionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionsApi(Configuration.Default);
            var id = 1;  // int | The ID of the transaction.
            var page = 1;  // int? | Page number. The default pagination is 50. (optional) 

            try
            {
                // Lists all piggy bank events.
                PiggyBankEventArray result = apiInstance.ListEventByTransaction(id, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.ListEventByTransaction: " + e.Message );
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
 **id** | **int**| The ID of the transaction. | 
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
| **200** | A list of piggy bank events. |  -  |
| **404** | No such transaction. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtransaction"></a>
# **ListTransaction**
> TransactionArray ListTransaction (int? page = null, DateTime? start = null, DateTime? end = null, TransactionTypeFilter type = null)

List all the user's transactions. 

List all the user's transactions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class ListTransactionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionsApi(Configuration.Default);
            var page = 1;  // int? | Page number. The default pagination is 50. (optional) 
            var start = Sun Sep 16 19:00:00 CDT 2018;  // DateTime? | A date formatted YYYY-MM-DD. This is the start date of the selected range (inclusive).  (optional) 
            var end = Sun Sep 16 19:00:00 CDT 2018;  // DateTime? | A date formatted YYYY-MM-DD. This is the end date of the selected range (inclusive).  (optional) 
            var type = new TransactionTypeFilter(); // TransactionTypeFilter | Optional filter on the transaction type(s) returned. (optional) 

            try
            {
                // List all the user's transactions. 
                TransactionArray result = apiInstance.ListTransaction(page, start, end, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.ListTransaction: " + e.Message );
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

<a name="storetransaction"></a>
# **StoreTransaction**
> TransactionSingle StoreTransaction (Transaction transaction)

Store a new transaction

Creates a new transaction. The data required can be submitted as a JSON body or as a list of parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class StoreTransactionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionsApi(Configuration.Default);
            var transaction = new Transaction(); // Transaction | JSON array or key=value pairs with the necessary transaction information. See the model for the exact specifications.

            try
            {
                // Store a new transaction
                TransactionSingle result = apiInstance.StoreTransaction(transaction);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.StoreTransaction: " + e.Message );
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
 **transaction** | [**Transaction**](Transaction.md)| JSON array or key&#x3D;value pairs with the necessary transaction information. See the model for the exact specifications. | 

### Return type

[**TransactionSingle**](TransactionSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | New transaction stored(s), result in response. |  -  |
| **422** | Validation errors (see body) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetransaction"></a>
# **UpdateTransaction**
> TransactionSingle UpdateTransaction (int id, Transaction transaction)

Update existing transaction.

Update an existing transaction.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class UpdateTransactionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionsApi(Configuration.Default);
            var id = 1;  // int | The ID of the transaction.
            var transaction = new Transaction(); // Transaction | JSON array with updated transaction information. See the model for the exact specifications.

            try
            {
                // Update existing transaction.
                TransactionSingle result = apiInstance.UpdateTransaction(id, transaction);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.UpdateTransaction: " + e.Message );
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
 **id** | **int**| The ID of the transaction. | 
 **transaction** | [**Transaction**](Transaction.md)| JSON array with updated transaction information. See the model for the exact specifications. | 

### Return type

[**TransactionSingle**](TransactionSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated transaction stored, result in response |  -  |
| **422** | Validation errors (see body) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

