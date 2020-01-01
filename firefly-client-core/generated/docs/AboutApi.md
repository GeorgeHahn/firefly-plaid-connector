# FireflyIII.Net.Api.AboutApi

All URIs are relative to *https://demo.firefly-iii.org*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAbout**](AboutApi.md#getabout) | **GET** /api/v1/about | System information end point.
[**GetCurrentUser**](AboutApi.md#getcurrentuser) | **GET** /api/v1/about/user | Currently authenticated user endpoint.


<a name="getabout"></a>
# **GetAbout**
> SystemInfo GetAbout ()

System information end point.

Returns general system information and versions of the (supporting) software. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class GetAboutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AboutApi(Configuration.Default);

            try
            {
                // System information end point.
                SystemInfo result = apiInstance.GetAbout();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AboutApi.GetAbout: " + e.Message );
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

[**SystemInfo**](SystemInfo.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The available system information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrentuser"></a>
# **GetCurrentUser**
> UserSingle GetCurrentUser ()

Currently authenticated user endpoint.

Returns the currently authenticated user. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class GetCurrentUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AboutApi(Configuration.Default);

            try
            {
                // Currently authenticated user endpoint.
                UserSingle result = apiInstance.GetCurrentUser();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AboutApi.GetCurrentUser: " + e.Message );
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

[**UserSingle**](UserSingle.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The user |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

