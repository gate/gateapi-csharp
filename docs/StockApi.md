# Io.Gate.GateApi.Api.StockApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**QueryStockUserAssets**](StockApi.md#querystockuserassets) | **GET** /stock/users/assets | Query user assets
[**QueryStockSymbols**](StockApi.md#querystocksymbols) | **GET** /stock/symbols | Query symbol list
[**QueryStockSymbolDetail**](StockApi.md#querystocksymboldetail) | **GET** /stock/symbols/detail | Query symbol details
[**QueryStockOrderBook**](StockApi.md#querystockorderbook) | **GET** /stock/market/{symbol}/orderbook | Query market order book
[**QueryStockOrderList**](StockApi.md#querystockorderlist) | **GET** /stock/orders | Query open order list
[**CreateStockOrder**](StockApi.md#createstockorder) | **POST** /stock/orders | Create order
[**DeleteAllStockOrders**](StockApi.md#deleteallstockorders) | **DELETE** /stock/orders | Cancel all open orders
[**QueryStockOrderHistory**](StockApi.md#querystockorderhistory) | **GET** /stock/orders/history | Query historical order list
[**UpdateStockOrder**](StockApi.md#updatestockorder) | **PUT** /stock/orders/{order_id} | Modify order
[**DeleteStockOrder**](StockApi.md#deletestockorder) | **DELETE** /stock/orders/{order_id} | Cancel order
[**QueryStockPositions**](StockApi.md#querystockpositions) | **GET** /stock/positions | Query current position list
[**CloseStockPosition**](StockApi.md#closestockposition) | **POST** /stock/positions/close | Close position
[**QueryStockTransactions**](StockApi.md#querystocktransactions) | **GET** /stock/transactions | Query transaction records
[**CreateStockTransaction**](StockApi.md#createstocktransaction) | **POST** /stock/transactions | Fund transfer
[**QueryStockExchanges**](StockApi.md#querystockexchanges) | **GET** /stock/exchanges | Query supported exchanges
[**QueryStockFeeRate**](StockApi.md#querystockfeerate) | **GET** /stock/fee-rate | Query fee rates for Japanese and Korean stocks


<a name="querystockuserassets"></a>
# **QueryStockUserAssets**
> UserAssetResp2 QueryStockUserAssets (int? pnlCalcType = null, int? pnlCalcPrice = null)

Query user assets

Rate limit: 5 qps.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class QueryStockUserAssetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new StockApi(config);
            var pnlCalcType = 1;  // int? | PnL calculation cost type. Defaults to average cost price when omitted (1 = average cost price, 2 = diluted cost price) (optional) 
            var pnlCalcPrice = 1;  // int? | PnL calculation price type. Defaults to intraday price when omitted (1 = intraday price, 2 = latest extended-hours price) (optional) 

            try
            {
                // Query user assets
                UserAssetResp2 result = apiInstance.QueryStockUserAssets(pnlCalcType, pnlCalcPrice);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling StockApi.QueryStockUserAssets: " + e.Message);
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
 **pnlCalcType** | **int?**| PnL calculation cost type. Defaults to average cost price when omitted (1 &#x3D; average cost price, 2 &#x3D; diluted cost price) | [optional] 
 **pnlCalcPrice** | **int?**| PnL calculation price type. Defaults to intraday price when omitted (1 &#x3D; intraday price, 2 &#x3D; latest extended-hours price) | [optional] 

### Return type

[**UserAssetResp2**](UserAssetResp2.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request success |  -  |
| **400** | Request failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="querystocksymbols"></a>
# **QueryStockSymbols**
> Symbols2 QueryStockSymbols (string symbols = null, string exchange = null, bool? withDescI18n = null, int? page = null, int? pageSize = null)

Query symbol list

Rate limit: 5 qps.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class QueryStockSymbolsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new StockApi(config);
            var symbols = "AAPL,TSLA";  // string | Symbol list, multiple separated by commas (optional) 
            var exchange = "us";  // string | Exchange, supports us, hk, and kr (optional) 
            var withDescI18n = true;  // bool? | Whether to return multilingual symbol description (optional) 
            var page = 1;  // int? | Page number, defaults to 1 (optional) 
            var pageSize = 100;  // int? | Page size, defaults to 10, max 500; server caps at 500 (optional) 

            try
            {
                // Query symbol list
                Symbols2 result = apiInstance.QueryStockSymbols(symbols, exchange, withDescI18n, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling StockApi.QueryStockSymbols: " + e.Message);
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
 **symbols** | **string**| Symbol list, multiple separated by commas | [optional] 
 **exchange** | **string**| Exchange, supports us, hk, and kr | [optional] 
 **withDescI18n** | **bool?**| Whether to return multilingual symbol description | [optional] 
 **page** | **int?**| Page number, defaults to 1 | [optional] 
 **pageSize** | **int?**| Page size, defaults to 10, max 500; server caps at 500 | [optional] 

### Return type

[**Symbols2**](Symbols2.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request success |  -  |
| **400** | Request failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="querystocksymboldetail"></a>
# **QueryStockSymbolDetail**
> SymbolDetail QueryStockSymbolDetail (string symbols = null, string exchange = null, int? page = null, int? pageSize = null)

Query symbol details

Rate limit: 5 qps.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class QueryStockSymbolDetailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new StockApi(config);
            var symbols = "AAPL,TSLA";  // string | Symbol list, multiple separated by commas (optional) 
            var exchange = "us";  // string | Exchange, supports us, hk, and kr (optional) 
            var page = 1;  // int? | Page number, defaults to 1 (optional) 
            var pageSize = 100;  // int? | Page size, defaults to 10, max 500; server caps at 500 (optional) 

            try
            {
                // Query symbol details
                SymbolDetail result = apiInstance.QueryStockSymbolDetail(symbols, exchange, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling StockApi.QueryStockSymbolDetail: " + e.Message);
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
 **symbols** | **string**| Symbol list, multiple separated by commas | [optional] 
 **exchange** | **string**| Exchange, supports us, hk, and kr | [optional] 
 **page** | **int?**| Page number, defaults to 1 | [optional] 
 **pageSize** | **int?**| Page size, defaults to 10, max 500; server caps at 500 | [optional] 

### Return type

[**SymbolDetail**](SymbolDetail.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request success |  -  |
| **400** | Request failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="querystockorderbook"></a>
# **QueryStockOrderBook**
> OrderBook2 QueryStockOrderBook (string symbol)

Query market order book

Rate limit: 5 qps.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class QueryStockOrderBookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new StockApi(config);
            var symbol = "AAPL";  // string | Symbol

            try
            {
                // Query market order book
                OrderBook2 result = apiInstance.QueryStockOrderBook(symbol);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling StockApi.QueryStockOrderBook: " + e.Message);
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
 **symbol** | **string**| Symbol | 

### Return type

[**OrderBook2**](OrderBook2.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request success |  -  |
| **400** | Request failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="querystockorderlist"></a>
# **QueryStockOrderList**
> OrderList2 QueryStockOrderList (string symbol = null)

Query open order list

Rate limit: 5 qps.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class QueryStockOrderListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new StockApi(config);
            var symbol = "AAPL";  // string | Symbol (optional) 

            try
            {
                // Query open order list
                OrderList2 result = apiInstance.QueryStockOrderList(symbol);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling StockApi.QueryStockOrderList: " + e.Message);
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
 **symbol** | **string**| Symbol | [optional] 

### Return type

[**OrderList2**](OrderList2.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request success |  -  |
| **400** | Request failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createstockorder"></a>
# **CreateStockOrder**
> CreateOrder2 CreateStockOrder (TradFiSpotOrderRequest tradFiSpotOrderRequest)

Create order

Rate limit: 5 qps.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateStockOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new StockApi(config);
            var tradFiSpotOrderRequest = new TradFiSpotOrderRequest(); // TradFiSpotOrderRequest | 

            try
            {
                // Create order
                CreateOrder2 result = apiInstance.CreateStockOrder(tradFiSpotOrderRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling StockApi.CreateStockOrder: " + e.Message);
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
 **tradFiSpotOrderRequest** | [**TradFiSpotOrderRequest**](TradFiSpotOrderRequest.md)|  | 

### Return type

[**CreateOrder2**](CreateOrder2.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Order placed successfully |  -  |
| **400** | Request failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteallstockorders"></a>
# **DeleteAllStockOrders**
> DeleteOrder DeleteAllStockOrders ()

Cancel all open orders

Rate limit: 5 qps.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class DeleteAllStockOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new StockApi(config);

            try
            {
                // Cancel all open orders
                DeleteOrder result = apiInstance.DeleteAllStockOrders();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling StockApi.DeleteAllStockOrders: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
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

[**DeleteOrder**](DeleteOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request success |  -  |
| **400** | Request failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="querystockorderhistory"></a>
# **QueryStockOrderHistory**
> OrderHistoryList2 QueryStockOrderHistory (string symbol = null, string orderIds = null, int? beginTime = null, int? endTime = null, int? side = null, int? page = null, int? pageSize = null)

Query historical order list

Rate limit: 5 qps.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class QueryStockOrderHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new StockApi(config);
            var symbol = "AAPL";  // string | Symbol (optional) 
            var orderIds = "123456,123457";  // string | Order ID list, multiple separated by commas; max 20, each must be a positive integer (optional) 
            var beginTime = 1769378400;  // int? | Start time (Unix timestamp, seconds). When both begin_time and end_time are provided, end_time must be >= begin_time, query range must not exceed 3 months. (optional) 
            var endTime = 1769464800;  // int? | End time (Unix timestamp, seconds). When both begin_time and end_time are provided, end_time must be >= begin_time, query range must not exceed 3 months. (optional) 
            var side = 2;  // int? | Side (1=sell, 2=buy) (optional) 
            var page = 1;  // int? | Page number, defaults to 1 (optional) 
            var pageSize = 100;  // int? | Page size, defaults to 10, max 500; server caps at 500 (optional) 

            try
            {
                // Query historical order list
                OrderHistoryList2 result = apiInstance.QueryStockOrderHistory(symbol, orderIds, beginTime, endTime, side, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling StockApi.QueryStockOrderHistory: " + e.Message);
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
 **symbol** | **string**| Symbol | [optional] 
 **orderIds** | **string**| Order ID list, multiple separated by commas; max 20, each must be a positive integer | [optional] 
 **beginTime** | **int?**| Start time (Unix timestamp, seconds). When both begin_time and end_time are provided, end_time must be &gt;&#x3D; begin_time, query range must not exceed 3 months. | [optional] 
 **endTime** | **int?**| End time (Unix timestamp, seconds). When both begin_time and end_time are provided, end_time must be &gt;&#x3D; begin_time, query range must not exceed 3 months. | [optional] 
 **side** | **int?**| Side (1&#x3D;sell, 2&#x3D;buy) | [optional] 
 **page** | **int?**| Page number, defaults to 1 | [optional] 
 **pageSize** | **int?**| Page size, defaults to 10, max 500; server caps at 500 | [optional] 

### Return type

[**OrderHistoryList2**](OrderHistoryList2.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request success |  -  |
| **400** | Request failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatestockorder"></a>
# **UpdateStockOrder**
> UpdateOrder2 UpdateStockOrder (long orderId, TradFiSpotOrderUpdateRequest tradFiSpotOrderUpdateRequest)

Modify order

Rate limit: 5 qps.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class UpdateStockOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new StockApi(config);
            var orderId = 123456;  // long | Order ID
            var tradFiSpotOrderUpdateRequest = new TradFiSpotOrderUpdateRequest(); // TradFiSpotOrderUpdateRequest | 

            try
            {
                // Modify order
                UpdateOrder2 result = apiInstance.UpdateStockOrder(orderId, tradFiSpotOrderUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling StockApi.UpdateStockOrder: " + e.Message);
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
 **orderId** | **long**| Order ID | 
 **tradFiSpotOrderUpdateRequest** | [**TradFiSpotOrderUpdateRequest**](TradFiSpotOrderUpdateRequest.md)|  | 

### Return type

[**UpdateOrder2**](UpdateOrder2.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request success |  -  |
| **400** | Request failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletestockorder"></a>
# **DeleteStockOrder**
> DeleteOrder DeleteStockOrder (long orderId)

Cancel order

Rate limit: 5 qps.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class DeleteStockOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new StockApi(config);
            var orderId = 123456;  // long | Order ID

            try
            {
                // Cancel order
                DeleteOrder result = apiInstance.DeleteStockOrder(orderId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling StockApi.DeleteStockOrder: " + e.Message);
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
 **orderId** | **long**| Order ID | 

### Return type

[**DeleteOrder**](DeleteOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request success |  -  |
| **400** | Request failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="querystockpositions"></a>
# **QueryStockPositions**
> PositionList2 QueryStockPositions (int? pnlCalcType = null, int? pnlCalcPrice = null, string symbol = null, string exchange = null)

Query current position list

Rate limit: 5 qps.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class QueryStockPositionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new StockApi(config);
            var pnlCalcType = 1;  // int? | PnL calculation cost type. Defaults to average cost price when omitted (1 = average cost price, 2 = diluted cost price) (optional) 
            var pnlCalcPrice = 1;  // int? | PnL calculation price type. Defaults to intraday price when omitted (1 = intraday price, 2 = latest extended-hours price) (optional) 
            var symbol = "AAPL";  // string | Symbol (optional) 
            var exchange = "us";  // string | Exchange, supports us, hk, and kr (optional) 

            try
            {
                // Query current position list
                PositionList2 result = apiInstance.QueryStockPositions(pnlCalcType, pnlCalcPrice, symbol, exchange);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling StockApi.QueryStockPositions: " + e.Message);
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
 **pnlCalcType** | **int?**| PnL calculation cost type. Defaults to average cost price when omitted (1 &#x3D; average cost price, 2 &#x3D; diluted cost price) | [optional] 
 **pnlCalcPrice** | **int?**| PnL calculation price type. Defaults to intraday price when omitted (1 &#x3D; intraday price, 2 &#x3D; latest extended-hours price) | [optional] 
 **symbol** | **string**| Symbol | [optional] 
 **exchange** | **string**| Exchange, supports us, hk, and kr | [optional] 

### Return type

[**PositionList2**](PositionList2.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request success |  -  |
| **400** | Request failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="closestockposition"></a>
# **CloseStockPosition**
> ClosePosition CloseStockPosition (TradFiSpotClosePositionRequest tradFiSpotClosePositionRequest)

Close position

Rate limit: 5 qps.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CloseStockPositionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new StockApi(config);
            var tradFiSpotClosePositionRequest = new TradFiSpotClosePositionRequest(); // TradFiSpotClosePositionRequest | 

            try
            {
                // Close position
                ClosePosition result = apiInstance.CloseStockPosition(tradFiSpotClosePositionRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling StockApi.CloseStockPosition: " + e.Message);
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
 **tradFiSpotClosePositionRequest** | [**TradFiSpotClosePositionRequest**](TradFiSpotClosePositionRequest.md)|  | 

### Return type

[**ClosePosition**](ClosePosition.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request success |  -  |
| **400** | Request failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="querystocktransactions"></a>
# **QueryStockTransactions**
> TransactionList2 QueryStockTransactions (long? beginTime = null, long? endTime = null, string refId = null, string type = null, int? page = null, int? pageSize = null)

Query transaction records

Rate limit: 5 qps.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class QueryStockTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new StockApi(config);
            var beginTime = 1769378400;  // long? | Start time (Unix timestamp, seconds). When both begin_time and end_time are provided, end_time must be >= begin_time, query range must not exceed 3 months. (optional) 
            var endTime = 1769464800;  // long? | End time (Unix timestamp, seconds). When both begin_time and end_time are provided, end_time must be >= begin_time, query range must not exceed 3 months. (optional) 
            var refId = "transfer-202607070001";  // string | Business idempotent ID. When ref_id is provided, the server queries by ref_id, ignoring other parameters such as begin_time, end_time, type, page, page_size (optional) 
            var type = "deposit";  // string | Transaction type (optional) 
            var page = 1;  // int? | Page number, defaults to 1 (optional) 
            var pageSize = 100;  // int? | Page size, defaults to 10, max 500; server caps at 500 (optional) 

            try
            {
                // Query transaction records
                TransactionList2 result = apiInstance.QueryStockTransactions(beginTime, endTime, refId, type, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling StockApi.QueryStockTransactions: " + e.Message);
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
 **beginTime** | **long?**| Start time (Unix timestamp, seconds). When both begin_time and end_time are provided, end_time must be &gt;&#x3D; begin_time, query range must not exceed 3 months. | [optional] 
 **endTime** | **long?**| End time (Unix timestamp, seconds). When both begin_time and end_time are provided, end_time must be &gt;&#x3D; begin_time, query range must not exceed 3 months. | [optional] 
 **refId** | **string**| Business idempotent ID. When ref_id is provided, the server queries by ref_id, ignoring other parameters such as begin_time, end_time, type, page, page_size | [optional] 
 **type** | **string**| Transaction type | [optional] 
 **page** | **int?**| Page number, defaults to 1 | [optional] 
 **pageSize** | **int?**| Page size, defaults to 10, max 500; server caps at 500 | [optional] 

### Return type

[**TransactionList2**](TransactionList2.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request success |  -  |
| **400** | Request failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createstocktransaction"></a>
# **CreateStockTransaction**
> CreateTransaction2 CreateStockTransaction (TradFiSpotTransactionRequest tradFiSpotTransactionRequest)

Fund transfer

Rate limit: 5 qps.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateStockTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new StockApi(config);
            var tradFiSpotTransactionRequest = new TradFiSpotTransactionRequest(); // TradFiSpotTransactionRequest | 

            try
            {
                // Fund transfer
                CreateTransaction2 result = apiInstance.CreateStockTransaction(tradFiSpotTransactionRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling StockApi.CreateStockTransaction: " + e.Message);
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
 **tradFiSpotTransactionRequest** | [**TradFiSpotTransactionRequest**](TradFiSpotTransactionRequest.md)|  | 

### Return type

[**CreateTransaction2**](CreateTransaction2.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request success |  -  |
| **400** | Request failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="querystockexchanges"></a>
# **QueryStockExchanges**
> Exchanges QueryStockExchanges ()

Query supported exchanges

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class QueryStockExchangesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new StockApi(config);

            try
            {
                // Query supported exchanges
                Exchanges result = apiInstance.QueryStockExchanges();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling StockApi.QueryStockExchanges: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
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

[**Exchanges**](Exchanges.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request success |  -  |
| **400** | Request failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="querystockfeerate"></a>
# **QueryStockFeeRate**
> FeeRate QueryStockFeeRate ()

Query fee rates for Japanese and Korean stocks

Query fee rates for Japanese and Korean stocks. Rate limit: 5 qps.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class QueryStockFeeRateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new StockApi(config);

            try
            {
                // Query fee rates for Japanese and Korean stocks
                FeeRate result = apiInstance.QueryStockFeeRate();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling StockApi.QueryStockFeeRate: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
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

[**FeeRate**](FeeRate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request success |  -  |
| **400** | Request failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

