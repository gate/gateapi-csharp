# Io.Gate.GateApi.Api.BotApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAIHubStrategyRecommend**](BotApi.md#getaihubstrategyrecommend) | **GET** /bot/strategy/recommend | Get AIHub strategy recommendations
[**PostAIHubSpotGridCreate**](BotApi.md#postaihubspotgridcreate) | **POST** /bot/spot-grid/create | Create spot grid
[**PostAIHubMarginGridCreate**](BotApi.md#postaihubmargingridcreate) | **POST** /bot/margin-grid/create | Create a lever grid
[**PostAIHubInfiniteGridCreate**](BotApi.md#postaihubinfinitegridcreate) | **POST** /bot/infinite-grid/create | Create infinite grid
[**PostAIHubFuturesGridCreate**](BotApi.md#postaihubfuturesgridcreate) | **POST** /bot/futures-grid/create | Create a contract grid
[**PostAIHubSpotMartingaleCreate**](BotApi.md#postaihubspotmartingalecreate) | **POST** /bot/spot-martingale/create | Create Spot Martin
[**PostAIHubContractMartingaleCreate**](BotApi.md#postaihubcontractmartingalecreate) | **POST** /bot/contract-martingale/create | Create contract martin
[**GetAIHubPortfolioRunning**](BotApi.md#getaihubportfoliorunning) | **GET** /bot/portfolio/running | Query the list of running policies
[**GetAIHubPortfolioDetail**](BotApi.md#getaihubportfoliodetail) | **GET** /bot/portfolio/detail | Query order policy details
[**PostAIHubPortfolioStop**](BotApi.md#postaihubportfoliostop) | **POST** /bot/portfolio/stop | Terminate a single running policy


<a name="getaihubstrategyrecommend"></a>
# **GetAIHubStrategyRecommend**
> AIHubDiscoverSuccessResponse GetAIHubStrategyRecommend (string market = null, string strategyType = null, string direction = null, string investAmount = null, string scene = null, string refreshRecommendationId = null, int? limit = null, string maxDrawdownLte = null, string backtestAprGte = null, string xGateServiceId = null, string xGateAppLang = null, string xRequestId = null, string xTraceId = null)

Get AIHub strategy recommendations

discover 域唯一正式接口。  支持场景： - `top1` - `bundle` - `filter` - `refresh`  约束： - 主动推荐池仅包含 `spot_grid`、`futures_grid`、`spot_martingale` - 可返回但不主动推荐 `infinite_grid`、`margin_grid` - 不得返回 `contract_martingale`、`smart-position`、`spot-future-arbitrage` - `scene=filter` 时只允许按 `market`、`backtest_apr_gte`、`max_drawdown_lte` 过滤 - `scene=refresh` 通过 `refresh_recommendation_id` 承接刷新上下文；正式最小格式只要求 `strategy_type|market` - 若上游直接透传上一条推荐的 `recommendation_id`，其中第三段 `backtest_id` 当前会被忽略

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetAIHubStrategyRecommendExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new BotApi(config);
            var market = "market_example";  // string | Trading pair, such as `BTC_USDT` (optional) 
            var strategyType = "strategyType_example";  // string | Recommended target policy type; `contract_martingale` not allowed (optional) 
            var direction = "direction_example";  // string | Market direction (optional) 
            var investAmount = "investAmount_example";  // string | Investment amount, string transparent transmission (optional) 
            var scene = "scene_example";  // string | Recommended scenario; when empty, bot-service can automatically infer according to the implementation logic. (optional) 
            var refreshRecommendationId = "refreshRecommendationId_example";  // string | It is recommended to refresh the context. Used when `scene=refresh` is used; when `scene` is empty but the field exists, bot-service will also automatically determine as `refresh`. The official minimum format is `strategy_type|market`; if the `recommendation_id` of the previous recommendation is directly passed through, the third paragraph `backtest_id` will be ignored. (optional) 
            var limit = 56;  // int? | Return quantity; when `scene=filter` is used, the actual results are up to 10 (optional) 
            var maxDrawdownLte = "maxDrawdownLte_example";  // string | Maximum drawdown limit (optional) 
            var backtestAprGte = "backtestAprGte_example";  // string | Backtest annualized lower limit (optional) 
            var xGateServiceId = "xGateServiceId_example";  // string | Call source identifier; injected by APIv4 if necessary (optional) 
            var xGateAppLang = "xGateAppLang_example";  // string | Language context, such as `zh-CN` / `en-US` (optional) 
            var xRequestId = "xRequestId_example";  // string | Request link ID; caller can transmit transparently (optional) 
            var xTraceId = "xTraceId_example";  // string | trace header; can be generated uniformly by APIv4 (optional) 

            try
            {
                // Get AIHub strategy recommendations
                AIHubDiscoverSuccessResponse result = apiInstance.GetAIHubStrategyRecommend(market, strategyType, direction, investAmount, scene, refreshRecommendationId, limit, maxDrawdownLte, backtestAprGte, xGateServiceId, xGateAppLang, xRequestId, xTraceId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling BotApi.GetAIHubStrategyRecommend: " + e.Message);
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
 **market** | **string**| Trading pair, such as &#x60;BTC_USDT&#x60; | [optional] 
 **strategyType** | **string**| Recommended target policy type; &#x60;contract_martingale&#x60; not allowed | [optional] 
 **direction** | **string**| Market direction | [optional] 
 **investAmount** | **string**| Investment amount, string transparent transmission | [optional] 
 **scene** | **string**| Recommended scenario; when empty, bot-service can automatically infer according to the implementation logic. | [optional] 
 **refreshRecommendationId** | **string**| It is recommended to refresh the context. Used when &#x60;scene&#x3D;refresh&#x60; is used; when &#x60;scene&#x60; is empty but the field exists, bot-service will also automatically determine as &#x60;refresh&#x60;. The official minimum format is &#x60;strategy_type|market&#x60;; if the &#x60;recommendation_id&#x60; of the previous recommendation is directly passed through, the third paragraph &#x60;backtest_id&#x60; will be ignored. | [optional] 
 **limit** | **int?**| Return quantity; when &#x60;scene&#x3D;filter&#x60; is used, the actual results are up to 10 | [optional] 
 **maxDrawdownLte** | **string**| Maximum drawdown limit | [optional] 
 **backtestAprGte** | **string**| Backtest annualized lower limit | [optional] 
 **xGateServiceId** | **string**| Call source identifier; injected by APIv4 if necessary | [optional] 
 **xGateAppLang** | **string**| Language context, such as &#x60;zh-CN&#x60; / &#x60;en-US&#x60; | [optional] 
 **xRequestId** | **string**| Request link ID; caller can transmit transparently | [optional] 
 **xTraceId** | **string**| trace header; can be generated uniformly by APIv4 | [optional] 

### Return type

[**AIHubDiscoverSuccessResponse**](AIHubDiscoverSuccessResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Unified business response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postaihubspotgridcreate"></a>
# **PostAIHubSpotGridCreate**
> AIHubCreateSuccessResponse PostAIHubSpotGridCreate (SpotGridCreateRequest spotGridCreateRequest, string xGateServiceId = null, string xGateAppLang = null, string xRequestId = null, string xTraceId = null)

Create spot grid

Create a spot grid strategy based on the incoming parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class PostAIHubSpotGridCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new BotApi(config);
            var spotGridCreateRequest = new SpotGridCreateRequest(); // SpotGridCreateRequest | 
            var xGateServiceId = "xGateServiceId_example";  // string | Call source identifier; injected by APIv4 if necessary (optional) 
            var xGateAppLang = "xGateAppLang_example";  // string | Language context, such as `zh-CN` / `en-US` (optional) 
            var xRequestId = "xRequestId_example";  // string | Request link ID; caller can transmit transparently (optional) 
            var xTraceId = "xTraceId_example";  // string | trace header; can be generated uniformly by APIv4 (optional) 

            try
            {
                // Create spot grid
                AIHubCreateSuccessResponse result = apiInstance.PostAIHubSpotGridCreate(spotGridCreateRequest, xGateServiceId, xGateAppLang, xRequestId, xTraceId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling BotApi.PostAIHubSpotGridCreate: " + e.Message);
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
 **spotGridCreateRequest** | [**SpotGridCreateRequest**](SpotGridCreateRequest.md)|  | 
 **xGateServiceId** | **string**| Call source identifier; injected by APIv4 if necessary | [optional] 
 **xGateAppLang** | **string**| Language context, such as &#x60;zh-CN&#x60; / &#x60;en-US&#x60; | [optional] 
 **xRequestId** | **string**| Request link ID; caller can transmit transparently | [optional] 
 **xTraceId** | **string**| trace header; can be generated uniformly by APIv4 | [optional] 

### Return type

[**AIHubCreateSuccessResponse**](AIHubCreateSuccessResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Unified business response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postaihubmargingridcreate"></a>
# **PostAIHubMarginGridCreate**
> AIHubCreateSuccessResponse PostAIHubMarginGridCreate (MarginGridCreateRequest marginGridCreateRequest, string xGateServiceId = null, string xGateAppLang = null, string xRequestId = null, string xTraceId = null)

Create a lever grid

Create a leverage grid strategy based on the passed parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class PostAIHubMarginGridCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new BotApi(config);
            var marginGridCreateRequest = new MarginGridCreateRequest(); // MarginGridCreateRequest | 
            var xGateServiceId = "xGateServiceId_example";  // string | Call source identifier; injected by APIv4 if necessary (optional) 
            var xGateAppLang = "xGateAppLang_example";  // string | Language context, such as `zh-CN` / `en-US` (optional) 
            var xRequestId = "xRequestId_example";  // string | Request link ID; caller can transmit transparently (optional) 
            var xTraceId = "xTraceId_example";  // string | trace header; can be generated uniformly by APIv4 (optional) 

            try
            {
                // Create a lever grid
                AIHubCreateSuccessResponse result = apiInstance.PostAIHubMarginGridCreate(marginGridCreateRequest, xGateServiceId, xGateAppLang, xRequestId, xTraceId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling BotApi.PostAIHubMarginGridCreate: " + e.Message);
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
 **marginGridCreateRequest** | [**MarginGridCreateRequest**](MarginGridCreateRequest.md)|  | 
 **xGateServiceId** | **string**| Call source identifier; injected by APIv4 if necessary | [optional] 
 **xGateAppLang** | **string**| Language context, such as &#x60;zh-CN&#x60; / &#x60;en-US&#x60; | [optional] 
 **xRequestId** | **string**| Request link ID; caller can transmit transparently | [optional] 
 **xTraceId** | **string**| trace header; can be generated uniformly by APIv4 | [optional] 

### Return type

[**AIHubCreateSuccessResponse**](AIHubCreateSuccessResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Unified business response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postaihubinfinitegridcreate"></a>
# **PostAIHubInfiniteGridCreate**
> AIHubCreateSuccessResponse PostAIHubInfiniteGridCreate (InfiniteGridCreateRequest infiniteGridCreateRequest, string xGateServiceId = null, string xGateAppLang = null, string xRequestId = null, string xTraceId = null)

Create infinite grid

Create an infinite grid strategy based on passed parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class PostAIHubInfiniteGridCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new BotApi(config);
            var infiniteGridCreateRequest = new InfiniteGridCreateRequest(); // InfiniteGridCreateRequest | 
            var xGateServiceId = "xGateServiceId_example";  // string | Call source identifier; injected by APIv4 if necessary (optional) 
            var xGateAppLang = "xGateAppLang_example";  // string | Language context, such as `zh-CN` / `en-US` (optional) 
            var xRequestId = "xRequestId_example";  // string | Request link ID; caller can transmit transparently (optional) 
            var xTraceId = "xTraceId_example";  // string | trace header; can be generated uniformly by APIv4 (optional) 

            try
            {
                // Create infinite grid
                AIHubCreateSuccessResponse result = apiInstance.PostAIHubInfiniteGridCreate(infiniteGridCreateRequest, xGateServiceId, xGateAppLang, xRequestId, xTraceId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling BotApi.PostAIHubInfiniteGridCreate: " + e.Message);
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
 **infiniteGridCreateRequest** | [**InfiniteGridCreateRequest**](InfiniteGridCreateRequest.md)|  | 
 **xGateServiceId** | **string**| Call source identifier; injected by APIv4 if necessary | [optional] 
 **xGateAppLang** | **string**| Language context, such as &#x60;zh-CN&#x60; / &#x60;en-US&#x60; | [optional] 
 **xRequestId** | **string**| Request link ID; caller can transmit transparently | [optional] 
 **xTraceId** | **string**| trace header; can be generated uniformly by APIv4 | [optional] 

### Return type

[**AIHubCreateSuccessResponse**](AIHubCreateSuccessResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Unified business response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postaihubfuturesgridcreate"></a>
# **PostAIHubFuturesGridCreate**
> AIHubCreateSuccessResponse PostAIHubFuturesGridCreate (FuturesGridCreateRequest futuresGridCreateRequest, string xGateServiceId = null, string xGateAppLang = null, string xRequestId = null, string xTraceId = null)

Create a contract grid

Create a contract grid strategy based on the incoming parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class PostAIHubFuturesGridCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new BotApi(config);
            var futuresGridCreateRequest = new FuturesGridCreateRequest(); // FuturesGridCreateRequest | 
            var xGateServiceId = "xGateServiceId_example";  // string | Call source identifier; injected by APIv4 if necessary (optional) 
            var xGateAppLang = "xGateAppLang_example";  // string | Language context, such as `zh-CN` / `en-US` (optional) 
            var xRequestId = "xRequestId_example";  // string | Request link ID; caller can transmit transparently (optional) 
            var xTraceId = "xTraceId_example";  // string | trace header; can be generated uniformly by APIv4 (optional) 

            try
            {
                // Create a contract grid
                AIHubCreateSuccessResponse result = apiInstance.PostAIHubFuturesGridCreate(futuresGridCreateRequest, xGateServiceId, xGateAppLang, xRequestId, xTraceId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling BotApi.PostAIHubFuturesGridCreate: " + e.Message);
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
 **futuresGridCreateRequest** | [**FuturesGridCreateRequest**](FuturesGridCreateRequest.md)|  | 
 **xGateServiceId** | **string**| Call source identifier; injected by APIv4 if necessary | [optional] 
 **xGateAppLang** | **string**| Language context, such as &#x60;zh-CN&#x60; / &#x60;en-US&#x60; | [optional] 
 **xRequestId** | **string**| Request link ID; caller can transmit transparently | [optional] 
 **xTraceId** | **string**| trace header; can be generated uniformly by APIv4 | [optional] 

### Return type

[**AIHubCreateSuccessResponse**](AIHubCreateSuccessResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Unified business response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postaihubspotmartingalecreate"></a>
# **PostAIHubSpotMartingaleCreate**
> AIHubCreateSuccessResponse PostAIHubSpotMartingaleCreate (SpotMartingaleCreateRequest spotMartingaleCreateRequest, string xGateServiceId = null, string xGateAppLang = null, string xRequestId = null, string xTraceId = null)

Create Spot Martin

Create a spot Martin strategy based on the passed parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class PostAIHubSpotMartingaleCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new BotApi(config);
            var spotMartingaleCreateRequest = new SpotMartingaleCreateRequest(); // SpotMartingaleCreateRequest | 
            var xGateServiceId = "xGateServiceId_example";  // string | Call source identifier; injected by APIv4 if necessary (optional) 
            var xGateAppLang = "xGateAppLang_example";  // string | Language context, such as `zh-CN` / `en-US` (optional) 
            var xRequestId = "xRequestId_example";  // string | Request link ID; caller can transmit transparently (optional) 
            var xTraceId = "xTraceId_example";  // string | trace header; can be generated uniformly by APIv4 (optional) 

            try
            {
                // Create Spot Martin
                AIHubCreateSuccessResponse result = apiInstance.PostAIHubSpotMartingaleCreate(spotMartingaleCreateRequest, xGateServiceId, xGateAppLang, xRequestId, xTraceId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling BotApi.PostAIHubSpotMartingaleCreate: " + e.Message);
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
 **spotMartingaleCreateRequest** | [**SpotMartingaleCreateRequest**](SpotMartingaleCreateRequest.md)|  | 
 **xGateServiceId** | **string**| Call source identifier; injected by APIv4 if necessary | [optional] 
 **xGateAppLang** | **string**| Language context, such as &#x60;zh-CN&#x60; / &#x60;en-US&#x60; | [optional] 
 **xRequestId** | **string**| Request link ID; caller can transmit transparently | [optional] 
 **xTraceId** | **string**| trace header; can be generated uniformly by APIv4 | [optional] 

### Return type

[**AIHubCreateSuccessResponse**](AIHubCreateSuccessResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Unified business response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postaihubcontractmartingalecreate"></a>
# **PostAIHubContractMartingaleCreate**
> AIHubCreateSuccessResponse PostAIHubContractMartingaleCreate (ContractMartingaleCreateRequest contractMartingaleCreateRequest, string xGateServiceId = null, string xGateAppLang = null, string xRequestId = null, string xTraceId = null)

Create contract martin

Create a contract Martin strategy based on the input parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class PostAIHubContractMartingaleCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new BotApi(config);
            var contractMartingaleCreateRequest = new ContractMartingaleCreateRequest(); // ContractMartingaleCreateRequest | 
            var xGateServiceId = "xGateServiceId_example";  // string | Call source identifier; injected by APIv4 if necessary (optional) 
            var xGateAppLang = "xGateAppLang_example";  // string | Language context, such as `zh-CN` / `en-US` (optional) 
            var xRequestId = "xRequestId_example";  // string | Request link ID; caller can transmit transparently (optional) 
            var xTraceId = "xTraceId_example";  // string | trace header; can be generated uniformly by APIv4 (optional) 

            try
            {
                // Create contract martin
                AIHubCreateSuccessResponse result = apiInstance.PostAIHubContractMartingaleCreate(contractMartingaleCreateRequest, xGateServiceId, xGateAppLang, xRequestId, xTraceId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling BotApi.PostAIHubContractMartingaleCreate: " + e.Message);
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
 **contractMartingaleCreateRequest** | [**ContractMartingaleCreateRequest**](ContractMartingaleCreateRequest.md)|  | 
 **xGateServiceId** | **string**| Call source identifier; injected by APIv4 if necessary | [optional] 
 **xGateAppLang** | **string**| Language context, such as &#x60;zh-CN&#x60; / &#x60;en-US&#x60; | [optional] 
 **xRequestId** | **string**| Request link ID; caller can transmit transparently | [optional] 
 **xTraceId** | **string**| trace header; can be generated uniformly by APIv4 | [optional] 

### Return type

[**AIHubCreateSuccessResponse**](AIHubCreateSuccessResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Unified business response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaihubportfoliorunning"></a>
# **GetAIHubPortfolioRunning**
> AIHubPortfolioRunningSuccessResponse GetAIHubPortfolioRunning (string strategyType = null, string market = null, int? page = null, int? pageSize = null, string xGateServiceId = null, string xGateAppLang = null, string xRequestId = null, string xTraceId = null)

Query the list of running policies

Query the list of AIHub strategies currently running by the user, and support filtering by strategy type, trading pair and paging conditions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetAIHubPortfolioRunningExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new BotApi(config);
            var strategyType = "strategyType_example";  // string | Filter by policy type (optional) 
            var market = "market_example";  // string | Filter by trading pair (optional) 
            var page = 1;  // int? | Page number, default 1 (optional)  (default to 1)
            var pageSize = 20;  // int? | Paging size, default 20, maximum 50 (optional)  (default to 20)
            var xGateServiceId = "xGateServiceId_example";  // string | Call source identifier; injected by APIv4 if necessary (optional) 
            var xGateAppLang = "xGateAppLang_example";  // string | Language context, such as `zh-CN` / `en-US` (optional) 
            var xRequestId = "xRequestId_example";  // string | Request link ID; caller can transmit transparently (optional) 
            var xTraceId = "xTraceId_example";  // string | trace header; can be generated uniformly by APIv4 (optional) 

            try
            {
                // Query the list of running policies
                AIHubPortfolioRunningSuccessResponse result = apiInstance.GetAIHubPortfolioRunning(strategyType, market, page, pageSize, xGateServiceId, xGateAppLang, xRequestId, xTraceId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling BotApi.GetAIHubPortfolioRunning: " + e.Message);
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
 **strategyType** | **string**| Filter by policy type | [optional] 
 **market** | **string**| Filter by trading pair | [optional] 
 **page** | **int?**| Page number, default 1 | [optional] [default to 1]
 **pageSize** | **int?**| Paging size, default 20, maximum 50 | [optional] [default to 20]
 **xGateServiceId** | **string**| Call source identifier; injected by APIv4 if necessary | [optional] 
 **xGateAppLang** | **string**| Language context, such as &#x60;zh-CN&#x60; / &#x60;en-US&#x60; | [optional] 
 **xRequestId** | **string**| Request link ID; caller can transmit transparently | [optional] 
 **xTraceId** | **string**| trace header; can be generated uniformly by APIv4 | [optional] 

### Return type

[**AIHubPortfolioRunningSuccessResponse**](AIHubPortfolioRunningSuccessResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Unified business response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaihubportfoliodetail"></a>
# **GetAIHubPortfolioDetail**
> AIHubPortfolioDetailSuccessResponse GetAIHubPortfolioDetail (string strategyId, string strategyType, string xGateServiceId = null, string xGateAppLang = null, string xRequestId = null, string xTraceId = null)

Query order policy details

Both `strategy_id` and `strategy_type` must be passed in the request, where `strategy_type` is used to distribute to the underlying detailed implementation by strategy type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetAIHubPortfolioDetailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new BotApi(config);
            var strategyId = "strategyId_example";  // string | Policy ID
            var strategyType = "strategyType_example";  // string | Policy type; used for underlying detail distribution
            var xGateServiceId = "xGateServiceId_example";  // string | Call source identifier; injected by APIv4 if necessary (optional) 
            var xGateAppLang = "xGateAppLang_example";  // string | Language context, such as `zh-CN` / `en-US` (optional) 
            var xRequestId = "xRequestId_example";  // string | Request link ID; caller can transmit transparently (optional) 
            var xTraceId = "xTraceId_example";  // string | trace header; can be generated uniformly by APIv4 (optional) 

            try
            {
                // Query order policy details
                AIHubPortfolioDetailSuccessResponse result = apiInstance.GetAIHubPortfolioDetail(strategyId, strategyType, xGateServiceId, xGateAppLang, xRequestId, xTraceId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling BotApi.GetAIHubPortfolioDetail: " + e.Message);
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
 **strategyId** | **string**| Policy ID | 
 **strategyType** | **string**| Policy type; used for underlying detail distribution | 
 **xGateServiceId** | **string**| Call source identifier; injected by APIv4 if necessary | [optional] 
 **xGateAppLang** | **string**| Language context, such as &#x60;zh-CN&#x60; / &#x60;en-US&#x60; | [optional] 
 **xRequestId** | **string**| Request link ID; caller can transmit transparently | [optional] 
 **xTraceId** | **string**| trace header; can be generated uniformly by APIv4 | [optional] 

### Return type

[**AIHubPortfolioDetailSuccessResponse**](AIHubPortfolioDetailSuccessResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Unified business response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postaihubportfoliostop"></a>
# **PostAIHubPortfolioStop**
> AIHubPortfolioStopSuccessResponse PostAIHubPortfolioStop (AIHubPortfolioStopRequest aIHubPortfolioStopRequest, string xGateServiceId = null, string xGateAppLang = null, string xRequestId = null, string xTraceId = null)

Terminate a single running policy

Only one policy is allowed to be terminated per request. Risk warning and secondary confirmation are borne by the upper layer of OpenClaw; this interface is only responsible for executing stop.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class PostAIHubPortfolioStopExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new BotApi(config);
            var aIHubPortfolioStopRequest = new AIHubPortfolioStopRequest(); // AIHubPortfolioStopRequest | 
            var xGateServiceId = "xGateServiceId_example";  // string | Call source identifier; injected by APIv4 if necessary (optional) 
            var xGateAppLang = "xGateAppLang_example";  // string | Language context, such as `zh-CN` / `en-US` (optional) 
            var xRequestId = "xRequestId_example";  // string | Request link ID; caller can transmit transparently (optional) 
            var xTraceId = "xTraceId_example";  // string | trace header; can be generated uniformly by APIv4 (optional) 

            try
            {
                // Terminate a single running policy
                AIHubPortfolioStopSuccessResponse result = apiInstance.PostAIHubPortfolioStop(aIHubPortfolioStopRequest, xGateServiceId, xGateAppLang, xRequestId, xTraceId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling BotApi.PostAIHubPortfolioStop: " + e.Message);
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
 **aIHubPortfolioStopRequest** | [**AIHubPortfolioStopRequest**](AIHubPortfolioStopRequest.md)|  | 
 **xGateServiceId** | **string**| Call source identifier; injected by APIv4 if necessary | [optional] 
 **xGateAppLang** | **string**| Language context, such as &#x60;zh-CN&#x60; / &#x60;en-US&#x60; | [optional] 
 **xRequestId** | **string**| Request link ID; caller can transmit transparently | [optional] 
 **xTraceId** | **string**| trace header; can be generated uniformly by APIv4 | [optional] 

### Return type

[**AIHubPortfolioStopSuccessResponse**](AIHubPortfolioStopSuccessResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Unified business response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

