# Io.Gate.GateApi.Api.BotApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAIHubStrategyRecommend**](BotApi.md#getaihubstrategyrecommend) | **GET** /bot/strategy/recommend | 获取 AIHub 策略推荐
[**PostAIHubSpotGridCreate**](BotApi.md#postaihubspotgridcreate) | **POST** /bot/spot-grid/create | 创建现货网格
[**PostAIHubMarginGridCreate**](BotApi.md#postaihubmargingridcreate) | **POST** /bot/margin-grid/create | 创建杠杆网格
[**PostAIHubInfiniteGridCreate**](BotApi.md#postaihubinfinitegridcreate) | **POST** /bot/infinite-grid/create | 创建无限网格
[**PostAIHubFuturesGridCreate**](BotApi.md#postaihubfuturesgridcreate) | **POST** /bot/futures-grid/create | 创建合约网格
[**PostAIHubSpotMartingaleCreate**](BotApi.md#postaihubspotmartingalecreate) | **POST** /bot/spot-martingale/create | 创建现货马丁
[**PostAIHubContractMartingaleCreate**](BotApi.md#postaihubcontractmartingalecreate) | **POST** /bot/contract-martingale/create | 创建合约马丁
[**GetAIHubPortfolioRunning**](BotApi.md#getaihubportfoliorunning) | **GET** /bot/portfolio/running | 查询运行中策略列表
[**GetAIHubPortfolioDetail**](BotApi.md#getaihubportfoliodetail) | **GET** /bot/portfolio/detail | 查询单策略详情
[**PostAIHubPortfolioStop**](BotApi.md#postaihubportfoliostop) | **POST** /bot/portfolio/stop | 终止单个运行中策略


<a name="getaihubstrategyrecommend"></a>
# **GetAIHubStrategyRecommend**
> AIHubDiscoverSuccessResponse GetAIHubStrategyRecommend (string market = null, string strategyType = null, string direction = null, string investAmount = null, string scene = null, string refreshRecommendationId = null, int? limit = null, string maxDrawdownLte = null, string backtestAprGte = null, string xGateServiceId = null, string xGateAppLang = null, string xRequestId = null, string xTraceId = null)

获取 AIHub 策略推荐

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
            var market = "market_example";  // string | 交易对，例如 `BTC_USDT` (optional) 
            var strategyType = "strategyType_example";  // string | 推荐目标策略类型；`contract_martingale` 不允许 (optional) 
            var direction = "direction_example";  // string | 行情方向 (optional) 
            var investAmount = "investAmount_example";  // string | 投入金额，字符串透传 (optional) 
            var scene = "scene_example";  // string | 推荐场景；为空时 bot-service 可按实现逻辑自动推断 (optional) 
            var refreshRecommendationId = "refreshRecommendationId_example";  // string | 推荐刷新上下文。`scene=refresh` 时使用；当 `scene` 为空但该字段存在时，bot-service 也会自动判定为 `refresh`。 正式最小格式为 `strategy_type|market`；若直接透传上一条推荐的 `recommendation_id`，第三段 `backtest_id` 会被忽略。 (optional) 
            var limit = 56;  // int? | 返回数量；`scene=filter` 时实际结果最多 10 条 (optional) 
            var maxDrawdownLte = "maxDrawdownLte_example";  // string | 最大回撤上限 (optional) 
            var backtestAprGte = "backtestAprGte_example";  // string | 回测年化下限 (optional) 
            var xGateServiceId = "xGateServiceId_example";  // string | 调用来源标识；如有需要由 APIv4 注入 (optional) 
            var xGateAppLang = "xGateAppLang_example";  // string | 语言上下文，例如 `zh-CN` / `en-US` (optional) 
            var xRequestId = "xRequestId_example";  // string | 请求链路 ID；调用方可透传 (optional) 
            var xTraceId = "xTraceId_example";  // string | trace header；可由 APIv4 统一生成 (optional) 

            try
            {
                // 获取 AIHub 策略推荐
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
 **market** | **string**| 交易对，例如 &#x60;BTC_USDT&#x60; | [optional] 
 **strategyType** | **string**| 推荐目标策略类型；&#x60;contract_martingale&#x60; 不允许 | [optional] 
 **direction** | **string**| 行情方向 | [optional] 
 **investAmount** | **string**| 投入金额，字符串透传 | [optional] 
 **scene** | **string**| 推荐场景；为空时 bot-service 可按实现逻辑自动推断 | [optional] 
 **refreshRecommendationId** | **string**| 推荐刷新上下文。&#x60;scene&#x3D;refresh&#x60; 时使用；当 &#x60;scene&#x60; 为空但该字段存在时，bot-service 也会自动判定为 &#x60;refresh&#x60;。 正式最小格式为 &#x60;strategy_type|market&#x60;；若直接透传上一条推荐的 &#x60;recommendation_id&#x60;，第三段 &#x60;backtest_id&#x60; 会被忽略。 | [optional] 
 **limit** | **int?**| 返回数量；&#x60;scene&#x3D;filter&#x60; 时实际结果最多 10 条 | [optional] 
 **maxDrawdownLte** | **string**| 最大回撤上限 | [optional] 
 **backtestAprGte** | **string**| 回测年化下限 | [optional] 
 **xGateServiceId** | **string**| 调用来源标识；如有需要由 APIv4 注入 | [optional] 
 **xGateAppLang** | **string**| 语言上下文，例如 &#x60;zh-CN&#x60; / &#x60;en-US&#x60; | [optional] 
 **xRequestId** | **string**| 请求链路 ID；调用方可透传 | [optional] 
 **xTraceId** | **string**| trace header；可由 APIv4 统一生成 | [optional] 

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
| **200** | 统一业务响应 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postaihubspotgridcreate"></a>
# **PostAIHubSpotGridCreate**
> AIHubCreateSuccessResponse PostAIHubSpotGridCreate (SpotGridCreateRequest spotGridCreateRequest, string xGateServiceId = null, string xGateAppLang = null, string xRequestId = null, string xTraceId = null)

创建现货网格

根据传入参数创建现货网格策略。

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
            var xGateServiceId = "xGateServiceId_example";  // string | 调用来源标识；如有需要由 APIv4 注入 (optional) 
            var xGateAppLang = "xGateAppLang_example";  // string | 语言上下文，例如 `zh-CN` / `en-US` (optional) 
            var xRequestId = "xRequestId_example";  // string | 请求链路 ID；调用方可透传 (optional) 
            var xTraceId = "xTraceId_example";  // string | trace header；可由 APIv4 统一生成 (optional) 

            try
            {
                // 创建现货网格
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
 **xGateServiceId** | **string**| 调用来源标识；如有需要由 APIv4 注入 | [optional] 
 **xGateAppLang** | **string**| 语言上下文，例如 &#x60;zh-CN&#x60; / &#x60;en-US&#x60; | [optional] 
 **xRequestId** | **string**| 请求链路 ID；调用方可透传 | [optional] 
 **xTraceId** | **string**| trace header；可由 APIv4 统一生成 | [optional] 

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
| **200** | 统一业务响应 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postaihubmargingridcreate"></a>
# **PostAIHubMarginGridCreate**
> AIHubCreateSuccessResponse PostAIHubMarginGridCreate (MarginGridCreateRequest marginGridCreateRequest, string xGateServiceId = null, string xGateAppLang = null, string xRequestId = null, string xTraceId = null)

创建杠杆网格

根据传入参数创建杠杆网格策略。

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
            var xGateServiceId = "xGateServiceId_example";  // string | 调用来源标识；如有需要由 APIv4 注入 (optional) 
            var xGateAppLang = "xGateAppLang_example";  // string | 语言上下文，例如 `zh-CN` / `en-US` (optional) 
            var xRequestId = "xRequestId_example";  // string | 请求链路 ID；调用方可透传 (optional) 
            var xTraceId = "xTraceId_example";  // string | trace header；可由 APIv4 统一生成 (optional) 

            try
            {
                // 创建杠杆网格
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
 **xGateServiceId** | **string**| 调用来源标识；如有需要由 APIv4 注入 | [optional] 
 **xGateAppLang** | **string**| 语言上下文，例如 &#x60;zh-CN&#x60; / &#x60;en-US&#x60; | [optional] 
 **xRequestId** | **string**| 请求链路 ID；调用方可透传 | [optional] 
 **xTraceId** | **string**| trace header；可由 APIv4 统一生成 | [optional] 

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
| **200** | 统一业务响应 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postaihubinfinitegridcreate"></a>
# **PostAIHubInfiniteGridCreate**
> AIHubCreateSuccessResponse PostAIHubInfiniteGridCreate (InfiniteGridCreateRequest infiniteGridCreateRequest, string xGateServiceId = null, string xGateAppLang = null, string xRequestId = null, string xTraceId = null)

创建无限网格

根据传入参数创建无限网格策略。

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
            var xGateServiceId = "xGateServiceId_example";  // string | 调用来源标识；如有需要由 APIv4 注入 (optional) 
            var xGateAppLang = "xGateAppLang_example";  // string | 语言上下文，例如 `zh-CN` / `en-US` (optional) 
            var xRequestId = "xRequestId_example";  // string | 请求链路 ID；调用方可透传 (optional) 
            var xTraceId = "xTraceId_example";  // string | trace header；可由 APIv4 统一生成 (optional) 

            try
            {
                // 创建无限网格
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
 **xGateServiceId** | **string**| 调用来源标识；如有需要由 APIv4 注入 | [optional] 
 **xGateAppLang** | **string**| 语言上下文，例如 &#x60;zh-CN&#x60; / &#x60;en-US&#x60; | [optional] 
 **xRequestId** | **string**| 请求链路 ID；调用方可透传 | [optional] 
 **xTraceId** | **string**| trace header；可由 APIv4 统一生成 | [optional] 

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
| **200** | 统一业务响应 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postaihubfuturesgridcreate"></a>
# **PostAIHubFuturesGridCreate**
> AIHubCreateSuccessResponse PostAIHubFuturesGridCreate (FuturesGridCreateRequest futuresGridCreateRequest, string xGateServiceId = null, string xGateAppLang = null, string xRequestId = null, string xTraceId = null)

创建合约网格

根据传入参数创建合约网格策略。

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
            var xGateServiceId = "xGateServiceId_example";  // string | 调用来源标识；如有需要由 APIv4 注入 (optional) 
            var xGateAppLang = "xGateAppLang_example";  // string | 语言上下文，例如 `zh-CN` / `en-US` (optional) 
            var xRequestId = "xRequestId_example";  // string | 请求链路 ID；调用方可透传 (optional) 
            var xTraceId = "xTraceId_example";  // string | trace header；可由 APIv4 统一生成 (optional) 

            try
            {
                // 创建合约网格
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
 **xGateServiceId** | **string**| 调用来源标识；如有需要由 APIv4 注入 | [optional] 
 **xGateAppLang** | **string**| 语言上下文，例如 &#x60;zh-CN&#x60; / &#x60;en-US&#x60; | [optional] 
 **xRequestId** | **string**| 请求链路 ID；调用方可透传 | [optional] 
 **xTraceId** | **string**| trace header；可由 APIv4 统一生成 | [optional] 

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
| **200** | 统一业务响应 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postaihubspotmartingalecreate"></a>
# **PostAIHubSpotMartingaleCreate**
> AIHubCreateSuccessResponse PostAIHubSpotMartingaleCreate (SpotMartingaleCreateRequest spotMartingaleCreateRequest, string xGateServiceId = null, string xGateAppLang = null, string xRequestId = null, string xTraceId = null)

创建现货马丁

根据传入参数创建现货马丁策略。

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
            var xGateServiceId = "xGateServiceId_example";  // string | 调用来源标识；如有需要由 APIv4 注入 (optional) 
            var xGateAppLang = "xGateAppLang_example";  // string | 语言上下文，例如 `zh-CN` / `en-US` (optional) 
            var xRequestId = "xRequestId_example";  // string | 请求链路 ID；调用方可透传 (optional) 
            var xTraceId = "xTraceId_example";  // string | trace header；可由 APIv4 统一生成 (optional) 

            try
            {
                // 创建现货马丁
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
 **xGateServiceId** | **string**| 调用来源标识；如有需要由 APIv4 注入 | [optional] 
 **xGateAppLang** | **string**| 语言上下文，例如 &#x60;zh-CN&#x60; / &#x60;en-US&#x60; | [optional] 
 **xRequestId** | **string**| 请求链路 ID；调用方可透传 | [optional] 
 **xTraceId** | **string**| trace header；可由 APIv4 统一生成 | [optional] 

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
| **200** | 统一业务响应 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postaihubcontractmartingalecreate"></a>
# **PostAIHubContractMartingaleCreate**
> AIHubCreateSuccessResponse PostAIHubContractMartingaleCreate (ContractMartingaleCreateRequest contractMartingaleCreateRequest, string xGateServiceId = null, string xGateAppLang = null, string xRequestId = null, string xTraceId = null)

创建合约马丁

根据传入参数创建合约马丁策略。

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
            var xGateServiceId = "xGateServiceId_example";  // string | 调用来源标识；如有需要由 APIv4 注入 (optional) 
            var xGateAppLang = "xGateAppLang_example";  // string | 语言上下文，例如 `zh-CN` / `en-US` (optional) 
            var xRequestId = "xRequestId_example";  // string | 请求链路 ID；调用方可透传 (optional) 
            var xTraceId = "xTraceId_example";  // string | trace header；可由 APIv4 统一生成 (optional) 

            try
            {
                // 创建合约马丁
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
 **xGateServiceId** | **string**| 调用来源标识；如有需要由 APIv4 注入 | [optional] 
 **xGateAppLang** | **string**| 语言上下文，例如 &#x60;zh-CN&#x60; / &#x60;en-US&#x60; | [optional] 
 **xRequestId** | **string**| 请求链路 ID；调用方可透传 | [optional] 
 **xTraceId** | **string**| trace header；可由 APIv4 统一生成 | [optional] 

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
| **200** | 统一业务响应 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaihubportfoliorunning"></a>
# **GetAIHubPortfolioRunning**
> AIHubPortfolioRunningSuccessResponse GetAIHubPortfolioRunning (string strategyType = null, string market = null, int? page = null, int? pageSize = null, string xGateServiceId = null, string xGateAppLang = null, string xRequestId = null, string xTraceId = null)

查询运行中策略列表

查询当前用户运行中的 AIHub 策略列表，支持按策略类型、交易对和分页条件过滤。

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
            var strategyType = "strategyType_example";  // string | 按策略类型过滤 (optional) 
            var market = "market_example";  // string | 按交易对过滤 (optional) 
            var page = 1;  // int? | 页码，默认 1 (optional)  (default to 1)
            var pageSize = 20;  // int? | 分页大小，默认 20，最大 50 (optional)  (default to 20)
            var xGateServiceId = "xGateServiceId_example";  // string | 调用来源标识；如有需要由 APIv4 注入 (optional) 
            var xGateAppLang = "xGateAppLang_example";  // string | 语言上下文，例如 `zh-CN` / `en-US` (optional) 
            var xRequestId = "xRequestId_example";  // string | 请求链路 ID；调用方可透传 (optional) 
            var xTraceId = "xTraceId_example";  // string | trace header；可由 APIv4 统一生成 (optional) 

            try
            {
                // 查询运行中策略列表
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
 **strategyType** | **string**| 按策略类型过滤 | [optional] 
 **market** | **string**| 按交易对过滤 | [optional] 
 **page** | **int?**| 页码，默认 1 | [optional] [default to 1]
 **pageSize** | **int?**| 分页大小，默认 20，最大 50 | [optional] [default to 20]
 **xGateServiceId** | **string**| 调用来源标识；如有需要由 APIv4 注入 | [optional] 
 **xGateAppLang** | **string**| 语言上下文，例如 &#x60;zh-CN&#x60; / &#x60;en-US&#x60; | [optional] 
 **xRequestId** | **string**| 请求链路 ID；调用方可透传 | [optional] 
 **xTraceId** | **string**| trace header；可由 APIv4 统一生成 | [optional] 

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
| **200** | 统一业务响应 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaihubportfoliodetail"></a>
# **GetAIHubPortfolioDetail**
> AIHubPortfolioDetailSuccessResponse GetAIHubPortfolioDetail (string strategyId, string strategyType, string xGateServiceId = null, string xGateAppLang = null, string xRequestId = null, string xTraceId = null)

查询单策略详情

请求中必须同时传 `strategy_id` 与 `strategy_type`，其中 `strategy_type` 用于按策略类型分发到底层详情实现。

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
            var strategyId = "strategyId_example";  // string | 策略 ID
            var strategyType = "strategyType_example";  // string | 策略类型；用于底层详情分发
            var xGateServiceId = "xGateServiceId_example";  // string | 调用来源标识；如有需要由 APIv4 注入 (optional) 
            var xGateAppLang = "xGateAppLang_example";  // string | 语言上下文，例如 `zh-CN` / `en-US` (optional) 
            var xRequestId = "xRequestId_example";  // string | 请求链路 ID；调用方可透传 (optional) 
            var xTraceId = "xTraceId_example";  // string | trace header；可由 APIv4 统一生成 (optional) 

            try
            {
                // 查询单策略详情
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
 **strategyId** | **string**| 策略 ID | 
 **strategyType** | **string**| 策略类型；用于底层详情分发 | 
 **xGateServiceId** | **string**| 调用来源标识；如有需要由 APIv4 注入 | [optional] 
 **xGateAppLang** | **string**| 语言上下文，例如 &#x60;zh-CN&#x60; / &#x60;en-US&#x60; | [optional] 
 **xRequestId** | **string**| 请求链路 ID；调用方可透传 | [optional] 
 **xTraceId** | **string**| trace header；可由 APIv4 统一生成 | [optional] 

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
| **200** | 统一业务响应 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postaihubportfoliostop"></a>
# **PostAIHubPortfolioStop**
> AIHubPortfolioStopSuccessResponse PostAIHubPortfolioStop (AIHubPortfolioStopRequest aIHubPortfolioStopRequest, string xGateServiceId = null, string xGateAppLang = null, string xRequestId = null, string xTraceId = null)

终止单个运行中策略

单次请求只允许终止一个策略。 风险提示与二次确认由 OpenClaw 上层承担；本接口只负责执行 stop。

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
            var xGateServiceId = "xGateServiceId_example";  // string | 调用来源标识；如有需要由 APIv4 注入 (optional) 
            var xGateAppLang = "xGateAppLang_example";  // string | 语言上下文，例如 `zh-CN` / `en-US` (optional) 
            var xRequestId = "xRequestId_example";  // string | 请求链路 ID；调用方可透传 (optional) 
            var xTraceId = "xTraceId_example";  // string | trace header；可由 APIv4 统一生成 (optional) 

            try
            {
                // 终止单个运行中策略
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
 **xGateServiceId** | **string**| 调用来源标识；如有需要由 APIv4 注入 | [optional] 
 **xGateAppLang** | **string**| 语言上下文，例如 &#x60;zh-CN&#x60; / &#x60;en-US&#x60; | [optional] 
 **xRequestId** | **string**| 请求链路 ID；调用方可透传 | [optional] 
 **xTraceId** | **string**| trace header；可由 APIv4 统一生成 | [optional] 

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
| **200** | 统一业务响应 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

