# Io.Gate.GateApi.Api.FlashSwapApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListFlashSwapCurrencyPair**](FlashSwapApi.md#listflashswapcurrencypair) | **GET** /flash_swap/currency_pairs | List All Supported Currency Pairs In Flash Swap
[**ListFlashSwapOrders**](FlashSwapApi.md#listflashswaporders) | **GET** /flash_swap/orders | Query flash swap order list
[**CreateFlashSwapOrder**](FlashSwapApi.md#createflashswaporder) | **POST** /flash_swap/orders | Create a flash swap order
[**GetFlashSwapOrder**](FlashSwapApi.md#getflashswaporder) | **GET** /flash_swap/orders/{order_id} | Query single flash swap order
[**PreviewFlashSwapOrder**](FlashSwapApi.md#previewflashswaporder) | **POST** /flash_swap/orders/preview | Flash swap order preview


<a name="listflashswapcurrencypair"></a>
# **ListFlashSwapCurrencyPair**
> List&lt;FlashSwapCurrencyPair&gt; ListFlashSwapCurrencyPair (string currency = null, int? page = null, int? limit = null)

List All Supported Currency Pairs In Flash Swap

`BTC_GT` represents selling BTC and buying GT. The limits for each currency may vary across different currency pairs.  It is not necessary that two currencies that can be swapped instantaneously can be exchanged with each other. For example, it is possible to sell BTC and buy GT, but it does not necessarily mean that GT can be sold to buy BTC.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListFlashSwapCurrencyPairExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new FlashSwapApi(config);
            var currency = "BTC";  // string | Query by specified currency name (optional) 
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var limit = 1000;  // int? | Maximum number of items returned. Default: 1000, minimum: 1, maximum: 1000 (optional)  (default to 1000)

            try
            {
                // List All Supported Currency Pairs In Flash Swap
                List<FlashSwapCurrencyPair> result = apiInstance.ListFlashSwapCurrencyPair(currency, page, limit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FlashSwapApi.ListFlashSwapCurrencyPair: " + e.Message);
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
 **currency** | **string**| Query by specified currency name | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]
 **limit** | **int?**| Maximum number of items returned. Default: 1000, minimum: 1, maximum: 1000 | [optional] [default to 1000]

### Return type

[**List&lt;FlashSwapCurrencyPair&gt;**](FlashSwapCurrencyPair.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Query successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listflashswaporders"></a>
# **ListFlashSwapOrders**
> List&lt;FlashSwapOrder&gt; ListFlashSwapOrders (int? status = null, string sellCurrency = null, string buyCurrency = null, bool? reverse = null, int? limit = null, int? page = null)

Query flash swap order list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListFlashSwapOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FlashSwapApi(config);
            var status = 1;  // int? | Flash swap order status  `1` - success `2` - failed (optional) 
            var sellCurrency = "BTC";  // string | Asset name to sell - Retrieved from API `GET /flash_swap/currencies` for supported flash swap currencies (optional) 
            var buyCurrency = "BTC";  // string | Asset name to buy - Retrieved from API `GET /flash_swap/currencies` for supported flash swap currencies (optional) 
            var reverse = true;  // bool? | Sort by ID in ascending or descending order, default `true` - `true`: ID descending order (most recent data first) - `false`: ID ascending order (oldest data first) (optional) 
            var limit = 100;  // int? | Maximum number of records returned in a single list (optional)  (default to 100)
            var page = 1;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Query flash swap order list
                List<FlashSwapOrder> result = apiInstance.ListFlashSwapOrders(status, sellCurrency, buyCurrency, reverse, limit, page);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FlashSwapApi.ListFlashSwapOrders: " + e.Message);
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
 **status** | **int?**| Flash swap order status  &#x60;1&#x60; - success &#x60;2&#x60; - failed | [optional] 
 **sellCurrency** | **string**| Asset name to sell - Retrieved from API &#x60;GET /flash_swap/currencies&#x60; for supported flash swap currencies | [optional] 
 **buyCurrency** | **string**| Asset name to buy - Retrieved from API &#x60;GET /flash_swap/currencies&#x60; for supported flash swap currencies | [optional] 
 **reverse** | **bool?**| Sort by ID in ascending or descending order, default &#x60;true&#x60; - &#x60;true&#x60;: ID descending order (most recent data first) - &#x60;false&#x60;: ID ascending order (oldest data first) | [optional] 
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 100]
 **page** | **int?**| Page number | [optional] [default to 1]

### Return type

[**List&lt;FlashSwapOrder&gt;**](FlashSwapOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createflashswaporder"></a>
# **CreateFlashSwapOrder**
> FlashSwapOrder CreateFlashSwapOrder (FlashSwapOrderRequest flashSwapOrderRequest)

Create a flash swap order

Initiate a flash swap preview in advance because order creation requires a preview result

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateFlashSwapOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FlashSwapApi(config);
            var flashSwapOrderRequest = new FlashSwapOrderRequest(); // FlashSwapOrderRequest | 

            try
            {
                // Create a flash swap order
                FlashSwapOrder result = apiInstance.CreateFlashSwapOrder(flashSwapOrderRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FlashSwapApi.CreateFlashSwapOrder: " + e.Message);
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
 **flashSwapOrderRequest** | [**FlashSwapOrderRequest**](FlashSwapOrderRequest.md)|  | 

### Return type

[**FlashSwapOrder**](FlashSwapOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Flash swap order created successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getflashswaporder"></a>
# **GetFlashSwapOrder**
> FlashSwapOrder GetFlashSwapOrder (int orderId)

Query single flash swap order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetFlashSwapOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FlashSwapApi(config);
            var orderId = 1;  // int | Flash swap order ID

            try
            {
                // Query single flash swap order
                FlashSwapOrder result = apiInstance.GetFlashSwapOrder(orderId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FlashSwapApi.GetFlashSwapOrder: " + e.Message);
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
 **orderId** | **int**| Flash swap order ID | 

### Return type

[**FlashSwapOrder**](FlashSwapOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Query successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="previewflashswaporder"></a>
# **PreviewFlashSwapOrder**
> FlashSwapOrderPreview PreviewFlashSwapOrder (FlashSwapPreviewRequest flashSwapPreviewRequest)

Flash swap order preview

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class PreviewFlashSwapOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new FlashSwapApi(config);
            var flashSwapPreviewRequest = new FlashSwapPreviewRequest(); // FlashSwapPreviewRequest | 

            try
            {
                // Flash swap order preview
                FlashSwapOrderPreview result = apiInstance.PreviewFlashSwapOrder(flashSwapPreviewRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling FlashSwapApi.PreviewFlashSwapOrder: " + e.Message);
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
 **flashSwapPreviewRequest** | [**FlashSwapPreviewRequest**](FlashSwapPreviewRequest.md)|  | 

### Return type

[**FlashSwapOrderPreview**](FlashSwapOrderPreview.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Flash swap order preview successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

