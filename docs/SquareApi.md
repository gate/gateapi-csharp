# Io.Gate.GateApi.Api.SquareApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListSquareAiSearch**](SquareApi.md#listsquareaisearch) | **GET** /social/message/search | AI MCP Dynamic Search
[**ListLiveReplay**](SquareApi.md#listlivereplay) | **GET** /social/live/tag_coin_live_replay | Gate AI Assistant live stream data retrieval


<a name="listsquareaisearch"></a>
# **ListSquareAiSearch**
> ListSquareAiSearchResponse ListSquareAiSearch (string keyword = null, string currency = null, int? timeRange = null, int? sort = null, int? limit = null, int? page = null)

AI MCP Dynamic Search

Dynamic search endpoint for AI MCP platform. All parameters are passed via query string. Returns simplified fields. Designed for LLM function calling / MCP tool scenarios.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListSquareAiSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new SquareApi(config);
            var keyword = "keyword_example";  // string | Search keyword (currency name or content keyword, e.g., BTC, ETH) (optional) 
            var currency = "currency_example";  // string | Filter by currency (exact currency code, e.g., BTC, ETH, SOL) (optional) 
            var timeRange = 0;  // int? | Time range: 0 = unlimited (default), 1 = last day, 2 = last week, 3 = last month (optional)  (default to 0)
            var sort = 0;  // int? | Sort order: 0 = most popular (default), 1 = latest (optional)  (default to 0)
            var limit = 10;  // int? | Return count, 1-50, default 10 (optional)  (default to 10)
            var page = 1;  // int? | Page number (optional)  (default to 1)

            try
            {
                // AI MCP Dynamic Search
                ListSquareAiSearchResponse result = apiInstance.ListSquareAiSearch(keyword, currency, timeRange, sort, limit, page);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SquareApi.ListSquareAiSearch: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
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
 **keyword** | **string**| Search keyword (currency name or content keyword, e.g., BTC, ETH) | [optional] 
 **currency** | **string**| Filter by currency (exact currency code, e.g., BTC, ETH, SOL) | [optional] 
 **timeRange** | **int?**| Time range: 0 &#x3D; unlimited (default), 1 &#x3D; last day, 2 &#x3D; last week, 3 &#x3D; last month | [optional] [default to 0]
 **sort** | **int?**| Sort order: 0 &#x3D; most popular (default), 1 &#x3D; latest | [optional] [default to 0]
 **limit** | **int?**| Return count, 1-50, default 10 | [optional] [default to 10]
 **page** | **int?**| Page number | [optional] [default to 1]

### Return type

[**ListSquareAiSearchResponse**](ListSquareAiSearchResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The endpoint always returns HTTP 200. Business results are distinguished by the code field (code&#x3D;0 means success) |  -  |
| **400** | Invalid request parameters |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listlivereplay"></a>
# **ListLiveReplay**
> ListLiveReplayResponse ListLiveReplay (string tag = null, string coin = null, string sort = null, int? limit = null)

Gate AI Assistant live stream data retrieval

AI assistant live stream/replay search endpoint. Filters live rooms or replay videos by business tags and currency. Each record in the returned list is distinguished by content_type: streaming = live broadcast (live field has value), video = replay video (video field has value). The number of results is controlled by the limit parameter (max 10), no additional pagination needed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListLiveReplayExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new SquareApi(config);
            var tag = "tag_example";  // string | Business type filter. Available values: Market Analysis, Hot Topics, Blockchain, Others (optional) 
            var coin = "coin_example";  // string | Filter by currency name (e.g., BTC, ETH) (optional) 
            var sort = "hot";  // string | Sort order: hot = most popular (default), new = latest (optional)  (default to hot)
            var limit = 3;  // int? | Return count, 1-10, default 3 (optional)  (default to 3)

            try
            {
                // Gate AI Assistant live stream data retrieval
                ListLiveReplayResponse result = apiInstance.ListLiveReplay(tag, coin, sort, limit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling SquareApi.ListLiveReplay: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
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
 **tag** | **string**| Business type filter. Available values: Market Analysis, Hot Topics, Blockchain, Others | [optional] 
 **coin** | **string**| Filter by currency name (e.g., BTC, ETH) | [optional] 
 **sort** | **string**| Sort order: hot &#x3D; most popular (default), new &#x3D; latest | [optional] [default to hot]
 **limit** | **int?**| Return count, 1-10, default 3 | [optional] [default to 3]

### Return type

[**ListLiveReplayResponse**](ListLiveReplayResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The endpoint always returns HTTP 200. Business results are distinguished by the code field (code&#x3D;200 means success) |  -  |
| **400** | Invalid request parameters |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

