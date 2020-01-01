# FireflyIII.Net.Api.LinksApi

All URIs are relative to *https://demo.firefly-iii.org*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteLinkType**](LinksApi.md#deletelinktype) | **DELETE** /api/v1/link_types/{id} | Permanently delete link type.
[**DeleteTransactionLink**](LinksApi.md#deletetransactionlink) | **DELETE** /api/v1/transaction_links/{id} | Permanently delete link between transactions.
[**GetLinkType**](LinksApi.md#getlinktype) | **GET** /api/v1/link_types/{id} | Get single a link type.
[**GetTransactionLink**](LinksApi.md#gettransactionlink) | **GET** /api/v1/transaction_links/{id} | Get a single link.
[**ListLinkType**](LinksApi.md#listlinktype) | **GET** /api/v1/link_types | List all types of links.
[**ListTransactionByLinkType**](LinksApi.md#listtransactionbylinktype) | **GET** /api/v1/link_types/{id}/transactions | List all transactions under this link type.
[**ListTransactionLink**](LinksApi.md#listtransactionlink) | **GET** /api/v1/transaction_links | List all transaction links.
[**StoreLinkType**](LinksApi.md#storelinktype) | **POST** /api/v1/link_types | Create a new link type
[**StoreTransactionLink**](LinksApi.md#storetransactionlink) | **POST** /api/v1/transaction_links | Create a new link between transactions
[**UpdateLinkType**](LinksApi.md#updatelinktype) | **PUT** /api/v1/link_types/{id} | Update existing link type.
[**UpdateTransactionLink**](LinksApi.md#updatetransactionlink) | **PUT** /api/v1/transaction_links/{id} | Update an existing link between transactions.


<a name="deletelinktype"></a>
# **DeleteLinkType**
> void DeleteLinkType (int id)

Permanently delete link type.

Will permanently delete a link type. The links between transactions will be removed. The transactions themselves remain. You cannot delete some of the system provided link types, indicated by the editable=false flag when you list it. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class DeleteLinkTypeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LinksApi(Configuration.Default);
            var id = 1;  // int | The ID of the link type.

            try
            {
                // Permanently delete link type.
                apiInstance.DeleteLinkType(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinksApi.DeleteLinkType: " + e.Message );
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
 **id** | **int**| The ID of the link type. | 

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
| **204** | Link type deleted |  -  |
| **404** | No such link type |  -  |
| **500** | Cannot delete this link type. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetransactionlink"></a>
# **DeleteTransactionLink**
> void DeleteTransactionLink (int id)

Permanently delete link between transactions.

Will permanently delete link. Transactions remain. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class DeleteTransactionLinkExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LinksApi(Configuration.Default);
            var id = 1;  // int | The ID of the transaction link.

            try
            {
                // Permanently delete link between transactions.
                apiInstance.DeleteTransactionLink(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinksApi.DeleteTransactionLink: " + e.Message );
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
 **id** | **int**| The ID of the transaction link. | 

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
| **204** | Transaction link deleted |  -  |
| **404** | No such transaction link |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlinktype"></a>
# **GetLinkType**
> LinkTypeSingle GetLinkType (int id)

Get single a link type.

Returns a single link type by its ID. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class GetLinkTypeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LinksApi(Configuration.Default);
            var id = 1;  // int | The ID of the link type.

            try
            {
                // Get single a link type.
                LinkTypeSingle result = apiInstance.GetLinkType(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinksApi.GetLinkType: " + e.Message );
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
 **id** | **int**| The ID of the link type. | 

### Return type

[**LinkTypeSingle**](LinkTypeSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested link type |  -  |
| **404** | Link type not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactionlink"></a>
# **GetTransactionLink**
> TransactionLinkSingle GetTransactionLink (int id)

Get a single link.

Returns a single link by its ID. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class GetTransactionLinkExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LinksApi(Configuration.Default);
            var id = 1;  // int | The ID of the transaction link.

            try
            {
                // Get a single link.
                TransactionLinkSingle result = apiInstance.GetTransactionLink(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinksApi.GetTransactionLink: " + e.Message );
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
 **id** | **int**| The ID of the transaction link. | 

### Return type

[**TransactionLinkSingle**](TransactionLinkSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested link |  -  |
| **404** | No such transaction link. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listlinktype"></a>
# **ListLinkType**
> LinkTypeArray ListLinkType (int? page = null)

List all types of links.

List all the link types the system has. These include the default ones as well as any new ones. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class ListLinkTypeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LinksApi(Configuration.Default);
            var page = 1;  // int? | Page number. The default pagination is 50 items. (optional) 

            try
            {
                // List all types of links.
                LinkTypeArray result = apiInstance.ListLinkType(page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinksApi.ListLinkType: " + e.Message );
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
 **page** | **int?**| Page number. The default pagination is 50 items. | [optional] 

### Return type

[**LinkTypeArray**](LinkTypeArray.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of link types. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtransactionbylinktype"></a>
# **ListTransactionByLinkType**
> TransactionArray ListTransactionByLinkType (int id, int? page = null, DateTime? start = null, DateTime? end = null, TransactionTypeFilter type = null)

List all transactions under this link type.

List all transactions under this link type, both the inward and outward transactions. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class ListTransactionByLinkTypeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LinksApi(Configuration.Default);
            var id = 1;  // int | The ID of the link type.
            var page = 1;  // int? | Page number. The default pagination is per 50 items. (optional) 
            var start = Sun Sep 16 19:00:00 CDT 2018;  // DateTime? | A date formatted YYYY-MM-DD, to limit the results.  (optional) 
            var end = Sun Sep 16 19:00:00 CDT 2018;  // DateTime? | A date formatted YYYY-MM-DD, to limit the results.  (optional) 
            var type = new TransactionTypeFilter(); // TransactionTypeFilter | Optional filter on the transaction type(s) returned. (optional) 

            try
            {
                // List all transactions under this link type.
                TransactionArray result = apiInstance.ListTransactionByLinkType(id, page, start, end, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinksApi.ListTransactionByLinkType: " + e.Message );
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
 **id** | **int**| The ID of the link type. | 
 **page** | **int?**| Page number. The default pagination is per 50 items. | [optional] 
 **start** | **DateTime?**| A date formatted YYYY-MM-DD, to limit the results.  | [optional] 
 **end** | **DateTime?**| A date formatted YYYY-MM-DD, to limit the results.  | [optional] 
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

<a name="listtransactionlink"></a>
# **ListTransactionLink**
> TransactionLinkArray ListTransactionLink (int? page = null)

List all transaction links.

List all the transaction links. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class ListTransactionLinkExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LinksApi(Configuration.Default);
            var page = 1;  // int? | Page number. The default pagination is per 50 items. (optional) 

            try
            {
                // List all transaction links.
                TransactionLinkArray result = apiInstance.ListTransactionLink(page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinksApi.ListTransactionLink: " + e.Message );
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

[**TransactionLinkArray**](TransactionLinkArray.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of transaction links |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="storelinktype"></a>
# **StoreLinkType**
> LinkTypeSingle StoreLinkType (LinkType linkType)

Create a new link type

Creates a new link type. The data required can be submitted as a JSON body or as a list of parameters (in key=value pairs, like a webform).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class StoreLinkTypeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LinksApi(Configuration.Default);
            var linkType = new LinkType(); // LinkType | JSON array with the necessary link type information or key=value pairs. See the model for the exact specifications.

            try
            {
                // Create a new link type
                LinkTypeSingle result = apiInstance.StoreLinkType(linkType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinksApi.StoreLinkType: " + e.Message );
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
 **linkType** | [**LinkType**](LinkType.md)| JSON array with the necessary link type information or key&#x3D;value pairs. See the model for the exact specifications. | 

### Return type

[**LinkTypeSingle**](LinkTypeSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | New link type stored, result in response. |  -  |
| **422** | Validation errors (see body) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="storetransactionlink"></a>
# **StoreTransactionLink**
> TransactionLinkSingle StoreTransactionLink (TransactionLink transactionLink)

Create a new link between transactions

Store a new link between two transactions. For this end point you need the journal_id from a transaction.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class StoreTransactionLinkExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LinksApi(Configuration.Default);
            var transactionLink = new TransactionLink(); // TransactionLink | JSON array with the necessary link type information or key=value pairs. See the model for the exact specifications.

            try
            {
                // Create a new link between transactions
                TransactionLinkSingle result = apiInstance.StoreTransactionLink(transactionLink);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinksApi.StoreTransactionLink: " + e.Message );
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
 **transactionLink** | [**TransactionLink**](TransactionLink.md)| JSON array with the necessary link type information or key&#x3D;value pairs. See the model for the exact specifications. | 

### Return type

[**TransactionLinkSingle**](TransactionLinkSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | New transaction link stored, result in response. |  -  |
| **422** | Validation errors (see body) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelinktype"></a>
# **UpdateLinkType**
> LinkTypeSingle UpdateLinkType (int id, LinkType linkType)

Update existing link type.

Used to update a single link type. All fields that are not submitted will be cleared (set to NULL). The model will tell you which fields are mandatory. You cannot update some of the system provided link types, indicated by the editable=false flag when you list it. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class UpdateLinkTypeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LinksApi(Configuration.Default);
            var id = 1;  // int | The ID of the link type.
            var linkType = new LinkType(); // LinkType | JSON array or formdata with updated link type information. See the model for the exact specifications.

            try
            {
                // Update existing link type.
                LinkTypeSingle result = apiInstance.UpdateLinkType(id, linkType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinksApi.UpdateLinkType: " + e.Message );
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
 **id** | **int**| The ID of the link type. | 
 **linkType** | [**LinkType**](LinkType.md)| JSON array or formdata with updated link type information. See the model for the exact specifications. | 

### Return type

[**LinkTypeSingle**](LinkTypeSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated link type stored, result in response |  -  |
| **422** | Validation errors (see body) |  -  |
| **500** | Cannot delete this link type. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetransactionlink"></a>
# **UpdateTransactionLink**
> TransactionLinkSingle UpdateTransactionLink (int id, TransactionLink transactionLink)

Update an existing link between transactions.

Used to update a single existing link. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class UpdateTransactionLinkExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LinksApi(Configuration.Default);
            var id = 1;  // int | The ID of the transaction link.
            var transactionLink = new TransactionLink(); // TransactionLink | JSON array or formdata with updated link type information. See the model for the exact specifications.

            try
            {
                // Update an existing link between transactions.
                TransactionLinkSingle result = apiInstance.UpdateTransactionLink(id, transactionLink);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinksApi.UpdateTransactionLink: " + e.Message );
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
 **id** | **int**| The ID of the transaction link. | 
 **transactionLink** | [**TransactionLink**](TransactionLink.md)| JSON array or formdata with updated link type information. See the model for the exact specifications. | 

### Return type

[**TransactionLinkSingle**](TransactionLinkSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated link type stored, result in response |  -  |
| **422** | Validation errors (see body) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

