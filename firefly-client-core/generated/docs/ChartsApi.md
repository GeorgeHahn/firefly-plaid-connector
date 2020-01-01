# FireflyIII.Net.Api.ChartsApi

All URIs are relative to *https://demo.firefly-iii.org*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetChartABOverview**](ChartsApi.md#getchartaboverview) | **GET** /api/v1/chart/ab/overview/{id} | Dashboard chart with an overview of the available budget.
[**GetChartAccountExpense**](ChartsApi.md#getchartaccountexpense) | **GET** /api/v1/chart/account/expense | Dashboard chart with expense account balance information.
[**GetChartAccountOverview**](ChartsApi.md#getchartaccountoverview) | **GET** /api/v1/chart/account/overview | Dashboard chart with asset account balance information.
[**GetChartAccountRevenue**](ChartsApi.md#getchartaccountrevenue) | **GET** /api/v1/chart/account/revenue | Dashboard chart with revenue account balance information.
[**GetChartCategoryOverview**](ChartsApi.md#getchartcategoryoverview) | **GET** /api/v1/chart/category/overview | Dashboard chart with an overview of the users categories.


<a name="getchartaboverview"></a>
# **GetChartABOverview**
> List&lt;ChartDataSet&gt; GetChartABOverview (int id, DateTime start, DateTime end)

Dashboard chart with an overview of the available budget.

This endpoint returns the data required to generate a pie chart for the available budget. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class GetChartABOverviewExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChartsApi(Configuration.Default);
            var id = 1;  // int | The ID of the available budget.
            var start = 2013-10-20;  // DateTime | A date formatted YYYY-MM-DD. 
            var end = 2013-10-20;  // DateTime | A date formatted YYYY-MM-DD. 

            try
            {
                // Dashboard chart with an overview of the available budget.
                List<ChartDataSet> result = apiInstance.GetChartABOverview(id, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChartsApi.GetChartABOverview: " + e.Message );
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
 **start** | **DateTime**| A date formatted YYYY-MM-DD.  | 
 **end** | **DateTime**| A date formatted YYYY-MM-DD.  | 

### Return type

[**List&lt;ChartDataSet&gt;**](ChartDataSet.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Pie chart oriented chart information. Check out the model for more details. Each entry is a piece of the pie in the chart. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchartaccountexpense"></a>
# **GetChartAccountExpense**
> List&lt;ChartDataSet&gt; GetChartAccountExpense (DateTime start, DateTime end)

Dashboard chart with expense account balance information.

This endpoint returns the data required to generate a chart that shows the user how much they've spent on their expense accounts. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class GetChartAccountExpenseExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChartsApi(Configuration.Default);
            var start = 2013-10-20;  // DateTime | A date formatted YYYY-MM-DD. 
            var end = 2013-10-20;  // DateTime | A date formatted YYYY-MM-DD. 

            try
            {
                // Dashboard chart with expense account balance information.
                List<ChartDataSet> result = apiInstance.GetChartAccountExpense(start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChartsApi.GetChartAccountExpense: " + e.Message );
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

[**List&lt;ChartDataSet&gt;**](ChartDataSet.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Bar chart oriented chart information. Check out the model for more details. Each entry is a line (or bar) in the chart. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchartaccountoverview"></a>
# **GetChartAccountOverview**
> List&lt;ChartDataSet&gt; GetChartAccountOverview (DateTime start, DateTime end)

Dashboard chart with asset account balance information.

This endpoint returns the data required to generate a chart with basic asset account balance information. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class GetChartAccountOverviewExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChartsApi(Configuration.Default);
            var start = 2013-10-20;  // DateTime | A date formatted YYYY-MM-DD. 
            var end = 2013-10-20;  // DateTime | A date formatted YYYY-MM-DD. 

            try
            {
                // Dashboard chart with asset account balance information.
                List<ChartDataSet> result = apiInstance.GetChartAccountOverview(start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChartsApi.GetChartAccountOverview: " + e.Message );
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

[**List&lt;ChartDataSet&gt;**](ChartDataSet.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Line chart oriented chart information. Check out the model for more details. Each entry is a line (or bar) in the chart. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchartaccountrevenue"></a>
# **GetChartAccountRevenue**
> List&lt;ChartDataSet&gt; GetChartAccountRevenue (DateTime start, DateTime end)

Dashboard chart with revenue account balance information.

This endpoint returns the data required to generate a chart that shows the user how much they've earned from their revenue accounts. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class GetChartAccountRevenueExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChartsApi(Configuration.Default);
            var start = 2013-10-20;  // DateTime | A date formatted YYYY-MM-DD. 
            var end = 2013-10-20;  // DateTime | A date formatted YYYY-MM-DD. 

            try
            {
                // Dashboard chart with revenue account balance information.
                List<ChartDataSet> result = apiInstance.GetChartAccountRevenue(start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChartsApi.GetChartAccountRevenue: " + e.Message );
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

[**List&lt;ChartDataSet&gt;**](ChartDataSet.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Bar chart oriented chart information. Check out the model for more details. Each entry is a line (or bar) in the chart. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchartcategoryoverview"></a>
# **GetChartCategoryOverview**
> List&lt;ChartDataSet&gt; GetChartCategoryOverview (DateTime start, DateTime end)

Dashboard chart with an overview of the users categories.

This endpoint returns the data required to generate a bar chart for the expenses and incomes on the users categories. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using FireflyIII.Net.Api;
using FireflyIII.Net.Client;
using FireflyIII.Net.Model;

namespace Example
{
    public class GetChartCategoryOverviewExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://demo.firefly-iii.org";
            // Configure OAuth2 access token for authorization: firefly_iii_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChartsApi(Configuration.Default);
            var start = 2013-10-20;  // DateTime | A date formatted YYYY-MM-DD. 
            var end = 2013-10-20;  // DateTime | A date formatted YYYY-MM-DD. 

            try
            {
                // Dashboard chart with an overview of the users categories.
                List<ChartDataSet> result = apiInstance.GetChartCategoryOverview(start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChartsApi.GetChartCategoryOverview: " + e.Message );
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

[**List&lt;ChartDataSet&gt;**](ChartDataSet.md)

### Authorization

[firefly_iii_auth](../README.md#firefly_iii_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Bar chart oriented chart information. Check out the model for more details. Each entry is a set of bars in the chart. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

