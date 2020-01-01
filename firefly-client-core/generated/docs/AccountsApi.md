# FireflyIII.Net.Api.AccountsApi

All URIs are relative to *https://demo.firefly-iii.org*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAccount**](AccountsApi.md#deleteaccount) | **DELETE** /api/v1/accounts/{id} | Permanently delete account.
[**GetAccount**](AccountsApi.md#getaccount) | **GET** /api/v1/accounts/{id} | Get single account.
[**ListAccount**](AccountsApi.md#listaccount) | **GET** /api/v1/accounts | List all accounts.
[**ListPiggyBankByAccount**](AccountsApi.md#listpiggybankbyaccount) | **GET** /api/v1/accounts/{id}/piggy_banks | List all piggy banks related to the account.
[**ListTransactionByAccount**](AccountsApi.md#listtransactionbyaccount) | **GET** /api/v1/accounts/{id}/transactions | List all transactions related to the account.
[**StoreAccount**](AccountsApi.md#storeaccount) | **POST** /api/v1/accounts | Create new account.
[**UpdateAccount**](AccountsApi.md#updateaccount) | **PUT** /api/v1/accounts/{id} | Update existing account.


<a name="deleteaccount"></a>
# **DeleteAccount**
> void DeleteAccount (int id)

Permanently delete account.

Will permanently delete an account. Any associated transactions and piggy banks are ALSO deleted. Cannot be recovered from. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class DeleteAccountExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi(Configuration.Default);
            var id = 1;  // int | The ID of the account.

            try
            {
                // Permanently delete account.
                apiInstance.DeleteAccount(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.DeleteAccount: " + e.Message );
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
 **id** | **int**| The ID of the account. | 

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
| **204** | Account deleted |  -  |
| **404** | No such account |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccount"></a>
# **GetAccount**
> AccountSingle GetAccount (int id, DateTime? date = null)

Get single account.

Returns a single account by its ID. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class GetAccountExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi(Configuration.Default);
            var id = 1;  // int | The ID of the account.
            var date = 2013-10-20;  // DateTime? | A date formatted YYYY-MM-DD. When added to the request, Firefly III will show the account's balance on that day.  (optional) 

            try
            {
                // Get single account.
                AccountSingle result = apiInstance.GetAccount(id, date);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.GetAccount: " + e.Message );
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
 **id** | **int**| The ID of the account. | 
 **date** | **DateTime?**| A date formatted YYYY-MM-DD. When added to the request, Firefly III will show the account&#39;s balance on that day.  | [optional] 

### Return type

[**AccountSingle**](AccountSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested account |  -  |
| **404** | Account not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listaccount"></a>
# **ListAccount**
> AccountArray ListAccount (int? page = null, DateTime? date = null, AccountTypeFilter type = null)

List all accounts.

This endpoint returns a list of all the accounts owned by the authenticated user. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class ListAccountExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi(Configuration.Default);
            var page = 1;  // int? | Page number. The default pagination is per 50 items. (optional) 
            var date = 2013-10-20;  // DateTime? | A date formatted YYYY-MM-DD. When added to the request, Firefly III will show the account's balance on that day.  (optional) 
            var type = new AccountTypeFilter(); // AccountTypeFilter | Optional filter on the account type(s) returned (optional) 

            try
            {
                // List all accounts.
                AccountArray result = apiInstance.ListAccount(page, date, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.ListAccount: " + e.Message );
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
 **date** | **DateTime?**| A date formatted YYYY-MM-DD. When added to the request, Firefly III will show the account&#39;s balance on that day.  | [optional] 
 **type** | [**AccountTypeFilter**](AccountTypeFilter.md)| Optional filter on the account type(s) returned | [optional] 

### Return type

[**AccountArray**](AccountArray.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of accounts |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpiggybankbyaccount"></a>
# **ListPiggyBankByAccount**
> PiggyBankArray ListPiggyBankByAccount (int id, int? page = null)

List all piggy banks related to the account.

This endpoint returns a list of all the piggy banks connected to the account. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class ListPiggyBankByAccountExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi(Configuration.Default);
            var id = 1;  // int | The ID of the account.
            var page = 56;  // int? | Page number. The default pagination is per 50 items. (optional) 

            try
            {
                // List all piggy banks related to the account.
                PiggyBankArray result = apiInstance.ListPiggyBankByAccount(id, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.ListPiggyBankByAccount: " + e.Message );
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
 **id** | **int**| The ID of the account. | 
 **page** | **int?**| Page number. The default pagination is per 50 items. | [optional] 

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

<a name="listtransactionbyaccount"></a>
# **ListTransactionByAccount**
> TransactionArray ListTransactionByAccount (int id, int? page = null, int? limit = null, DateTime? start = null, DateTime? end = null, TransactionTypeFilter type = null)

List all transactions related to the account.

This endpoint returns a list of all the transactions connected to the account. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class ListTransactionByAccountExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi(Configuration.Default);
            var id = 1;  // int | The ID of the account.
            var page = 1;  // int? | Page number. The default pagination is per 50 items. (optional) 
            var limit = 5;  // int? | Limits the number of results on one page. (optional) 
            var start = Sun Sep 16 19:00:00 CDT 2018;  // DateTime? | A date formatted YYYY-MM-DD.  (optional) 
            var end = Sun Sep 16 19:00:00 CDT 2018;  // DateTime? | A date formatted YYYY-MM-DD.  (optional) 
            var type = new TransactionTypeFilter(); // TransactionTypeFilter | Optional filter on the transaction type(s) returned. (optional) 

            try
            {
                // List all transactions related to the account.
                TransactionArray result = apiInstance.ListTransactionByAccount(id, page, limit, start, end, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.ListTransactionByAccount: " + e.Message );
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
 **id** | **int**| The ID of the account. | 
 **page** | **int?**| Page number. The default pagination is per 50 items. | [optional] 
 **limit** | **int?**| Limits the number of results on one page. | [optional] 
 **start** | **DateTime?**| A date formatted YYYY-MM-DD.  | [optional] 
 **end** | **DateTime?**| A date formatted YYYY-MM-DD.  | [optional] 
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
| **200** | A list of transactions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="storeaccount"></a>
# **StoreAccount**
> AccountSingle StoreAccount (Account account)

Create new account.

Creates a new account. The data required can be submitted as a JSON body or as a list of parameters (in key=value pairs, like a webform).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class StoreAccountExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi(Configuration.Default);
            var account = new Account(); // Account | JSON array with the necessary account information or key=value pairs. See the model for the exact specifications.

            try
            {
                // Create new account.
                AccountSingle result = apiInstance.StoreAccount(account);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.StoreAccount: " + e.Message );
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
 **account** | [**Account**](Account.md)| JSON array with the necessary account information or key&#x3D;value pairs. See the model for the exact specifications. | 

### Return type

[**AccountSingle**](AccountSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | New account stored, result in response. |  -  |
| **422** | Validation errors (see body) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateaccount"></a>
# **UpdateAccount**
> AccountSingle UpdateAccount (int id, Account account)

Update existing account.

Used to update a single account. All fields that are not submitted will be cleared (set to NULL). The model will tell you which fields are mandatory. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class UpdateAccountExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsApi(Configuration.Default);
            var id = 1;  // int | The ID of the account.
            var account = new Account(); // Account | JSON array or formdata with updated account information. See the model for the exact specifications.

            try
            {
                // Update existing account.
                AccountSingle result = apiInstance.UpdateAccount(id, account);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.UpdateAccount: " + e.Message );
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
 **id** | **int**| The ID of the account. | 
 **account** | [**Account**](Account.md)| JSON array or formdata with updated account information. See the model for the exact specifications. | 

### Return type

[**AccountSingle**](AccountSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated account stored, result in response |  -  |
| **422** | Validation errors (see body) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

