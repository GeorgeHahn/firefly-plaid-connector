# FireflyIII.Net.Api.TagsApi

All URIs are relative to *https://demo.firefly-iii.org*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteTag**](TagsApi.md#deletetag) | **DELETE** /api/v1/tags/{tag} | Delete an tag.
[**GetTag**](TagsApi.md#gettag) | **GET** /api/v1/tags/{tag} | Get a single tag.
[**GetTagCloud**](TagsApi.md#gettagcloud) | **GET** /api/v1/tag-cloud | Returns a basic tag cloud.
[**ListTag**](TagsApi.md#listtag) | **GET** /api/v1/tags | List all tags.
[**ListTransactionByTag**](TagsApi.md#listtransactionbytag) | **GET** /api/v1/tags/{tag}/transactions | List all transactions with this tag.
[**StoreTag**](TagsApi.md#storetag) | **POST** /api/v1/tags | Store a new tag
[**UpdateTag**](TagsApi.md#updatetag) | **PUT** /api/v1/tags/{tag} | Update existing tag.


<a name="deletetag"></a>
# **DeleteTag**
> void DeleteTag (string tag)

Delete an tag.

Delete an tag.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class DeleteTagExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TagsApi(Configuration.Default);
            var tag = groceries;  // string | Either the tag itself or the tag ID.

            try
            {
                // Delete an tag.
                apiInstance.DeleteTag(tag);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagsApi.DeleteTag: " + e.Message );
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
 **tag** | **string**| Either the tag itself or the tag ID. | 

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
| **204** | Tag deleted. |  -  |
| **404** | No such tag |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettag"></a>
# **GetTag**
> TagSingle GetTag (string tag, int? page = null)

Get a single tag.

Get a single tag.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class GetTagExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TagsApi(Configuration.Default);
            var tag = groceries;  // string | Either the tag itself or the tag ID.
            var page = 56;  // int? | Page number (optional) 

            try
            {
                // Get a single tag.
                TagSingle result = apiInstance.GetTag(tag, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagsApi.GetTag: " + e.Message );
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
 **tag** | **string**| Either the tag itself or the tag ID. | 
 **page** | **int?**| Page number | [optional] 

### Return type

[**TagSingle**](TagSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested tag |  -  |
| **404** | Tag not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettagcloud"></a>
# **GetTagCloud**
> TagCloud GetTagCloud (DateTime start, DateTime end)

Returns a basic tag cloud.

Returns a list of tags, which can be used to draw a basic tag cloud.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class GetTagCloudExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TagsApi(Configuration.Default);
            var start = 2013-10-20;  // DateTime | A date formatted YYYY-MM-DD. 
            var end = 2013-10-20;  // DateTime | A date formatted YYYY-MM-DD. 

            try
            {
                // Returns a basic tag cloud.
                TagCloud result = apiInstance.GetTagCloud(start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagsApi.GetTagCloud: " + e.Message );
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

### Return type

[**TagCloud**](TagCloud.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A tag cloud |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtag"></a>
# **ListTag**
> TagArray ListTag (int? page = null)

List all tags.

List all of the user's tags.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class ListTagExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TagsApi(Configuration.Default);
            var page = 56;  // int? | Page number (optional) 

            try
            {
                // List all tags.
                TagArray result = apiInstance.ListTag(page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagsApi.ListTag: " + e.Message );
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
 **page** | **int?**| Page number | [optional] 

### Return type

[**TagArray**](TagArray.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of tags |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtransactionbytag"></a>
# **ListTransactionByTag**
> TransactionArray ListTransactionByTag (string tag, int? page = null, DateTime? start = null, DateTime? end = null, TransactionTypeFilter type = null)

List all transactions with this tag.

List all transactions with this tag.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class ListTransactionByTagExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TagsApi(Configuration.Default);
            var tag = groceries;  // string | Either the tag itself or the tag ID.
            var page = 1;  // int? | Page number. The default pagination is 50. (optional) 
            var start = Sun Sep 16 19:00:00 CDT 2018;  // DateTime? | A date formatted YYYY-MM-DD. This is the start date of the selected range (inclusive).  (optional) 
            var end = Sun Sep 16 19:00:00 CDT 2018;  // DateTime? | A date formatted YYYY-MM-DD. This is the end date of the selected range (inclusive).  (optional) 
            var type = new TransactionTypeFilter(); // TransactionTypeFilter | Optional filter on the transaction type(s) returned. (optional) 

            try
            {
                // List all transactions with this tag.
                TransactionArray result = apiInstance.ListTransactionByTag(tag, page, start, end, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagsApi.ListTransactionByTag: " + e.Message );
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
 **tag** | **string**| Either the tag itself or the tag ID. | 
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

<a name="storetag"></a>
# **StoreTag**
> TagSingle StoreTag (TagModel tagModel)

Store a new tag

Creates a new tag. The data required can be submitted as a JSON body or as a list of parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class StoreTagExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TagsApi(Configuration.Default);
            var tagModel = new TagModel(); // TagModel | JSON array or key=value pairs with the necessary tag information. See the model for the exact specifications.

            try
            {
                // Store a new tag
                TagSingle result = apiInstance.StoreTag(tagModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagsApi.StoreTag: " + e.Message );
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
 **tagModel** | [**TagModel**](TagModel.md)| JSON array or key&#x3D;value pairs with the necessary tag information. See the model for the exact specifications. | 

### Return type

[**TagSingle**](TagSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | New tag stored, result in response. |  -  |
| **422** | Validation errors (see body) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetag"></a>
# **UpdateTag**
> TagSingle UpdateTag (string tag, TagModel tagModel)

Update existing tag.

Update existing tag.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class UpdateTagExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TagsApi(Configuration.Default);
            var tag = groceries;  // string | Either the tag itself or the tag ID.
            var tagModel = new TagModel(); // TagModel | JSON array with updated tag information. See the model for the exact specifications.

            try
            {
                // Update existing tag.
                TagSingle result = apiInstance.UpdateTag(tag, tagModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TagsApi.UpdateTag: " + e.Message );
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
 **tag** | **string**| Either the tag itself or the tag ID. | 
 **tagModel** | [**TagModel**](TagModel.md)| JSON array with updated tag information. See the model for the exact specifications. | 

### Return type

[**TagSingle**](TagSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated tag stored, result in response |  -  |
| **422** | Validation errors (see body) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

