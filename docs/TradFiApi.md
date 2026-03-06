# Io.Gate.GateApi.Api.TradFiApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**QueryMt5AccountInfo**](TradFiApi.md#querymt5accountinfo) | **GET** /tradfi/users/mt5-account | Query MT5 account information
[**QueryCategories**](TradFiApi.md#querycategories) | **GET** /tradfi/symbols/categories | Query trading symbol categories
[**QuerySymbols**](TradFiApi.md#querysymbols) | **GET** /tradfi/symbols | Query trading symbol list
[**QuerySymbolDetail**](TradFiApi.md#querysymboldetail) | **GET** /tradfi/symbols/detail | Query trading symbol details
[**QuerySymbolKline**](TradFiApi.md#querysymbolkline) | **GET** /tradfi/symbols/{symbol}/klines | Query trading symbol klines
[**QuerySymbolTicker**](TradFiApi.md#querysymbolticker) | **GET** /tradfi/symbols/{symbol}/tickers | Query trading symbol ticker
[**CreateTradFiUser**](TradFiApi.md#createtradfiuser) | **POST** /tradfi/users | Create TradFi user
[**QueryUserAssets**](TradFiApi.md#queryuserassets) | **GET** /tradfi/users/assets | Query account assets
[**QueryTransaction**](TradFiApi.md#querytransaction) | **GET** /tradfi/transactions | Query Fund Transfer In/Out Records
[**CreateTransaction**](TradFiApi.md#createtransaction) | **POST** /tradfi/transactions | Fund Deposit and Withdrawal
[**QueryOrderList**](TradFiApi.md#queryorderlist) | **GET** /tradfi/orders | Query active order list
[**CreateTradFiOrder**](TradFiApi.md#createtradfiorder) | **POST** /tradfi/orders | Create an order
[**UpdateOrder**](TradFiApi.md#updateorder) | **PUT** /tradfi/orders/{order_id} | Modify order
[**DeleteOrder**](TradFiApi.md#deleteorder) | **DELETE** /tradfi/orders/{order_id} | Cancel order
[**QueryOrderHistoryList**](TradFiApi.md#queryorderhistorylist) | **GET** /tradfi/orders/history | Query historical order list
[**QueryPositionList**](TradFiApi.md#querypositionlist) | **GET** /tradfi/positions | Query active position list
[**UpdatePosition**](TradFiApi.md#updateposition) | **PUT** /tradfi/positions/{position_id} | Modify position
[**ClosePosition**](TradFiApi.md#closeposition) | **POST** /tradfi/positions/{position_id}/close | Close position
[**QueryPositionHistoryList**](TradFiApi.md#querypositionhistorylist) | **GET** /tradfi/positions/history | Query historical position list


<a name="querymt5accountinfo"></a>
# **QueryMt5AccountInfo**
> Mt5Account QueryMt5AccountInfo ()

Query MT5 account information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class QueryMt5AccountInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new TradFiApi(config);

            try
            {
                // Query MT5 account information
                Mt5Account result = apiInstance.QueryMt5AccountInfo();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling TradFiApi.QueryMt5AccountInfo: " + e.Message);
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

[**Mt5Account**](Mt5Account.md)

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

<a name="querycategories"></a>
# **QueryCategories**
> Categories QueryCategories ()

Query trading symbol categories

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class QueryCategoriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new TradFiApi(config);

            try
            {
                // Query trading symbol categories
                Categories result = apiInstance.QueryCategories();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling TradFiApi.QueryCategories: " + e.Message);
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

[**Categories**](Categories.md)

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

<a name="querysymbols"></a>
# **QuerySymbols**
> Symbols QuerySymbols ()

Query trading symbol list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class QuerySymbolsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new TradFiApi(config);

            try
            {
                // Query trading symbol list
                Symbols result = apiInstance.QuerySymbols();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling TradFiApi.QuerySymbols: " + e.Message);
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

[**Symbols**](Symbols.md)

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

<a name="querysymboldetail"></a>
# **QuerySymbolDetail**
> ContractDetail QuerySymbolDetail (string symbols)

Query trading symbol details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class QuerySymbolDetailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new TradFiApi(config);
            var symbols = "EURUSD,XAGUSD";  // string | Trading symbol code list (comma-separated, max 10 symbols)

            try
            {
                // Query trading symbol details
                ContractDetail result = apiInstance.QuerySymbolDetail(symbols);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling TradFiApi.QuerySymbolDetail: " + e.Message);
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
 **symbols** | **string**| Trading symbol code list (comma-separated, max 10 symbols) | 

### Return type

[**ContractDetail**](ContractDetail.md)

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

<a name="querysymbolkline"></a>
# **QuerySymbolKline**
> Klines QuerySymbolKline (string symbol, string klineType, long? beginTime = null, long? endTime = null, int? limit = null)

Query trading symbol klines

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class QuerySymbolKlineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new TradFiApi(config);
            var symbol = "EURUSD";  // string | Trading symbol code
            var klineType = "1m";  // string | Kline type (time period)
            var beginTime = 1769378400;  // long? | Start time (Unix timestamp in seconds) (optional) 
            var endTime = 1769464800;  // long? | End time (Unix timestamp in seconds) (optional) 
            var limit = 100;  // int? | Kline limit (max 500, error if exceeded) (optional) 

            try
            {
                // Query trading symbol klines
                Klines result = apiInstance.QuerySymbolKline(symbol, klineType, beginTime, endTime, limit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling TradFiApi.QuerySymbolKline: " + e.Message);
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
 **symbol** | **string**| Trading symbol code | 
 **klineType** | **string**| Kline type (time period) | 
 **beginTime** | **long?**| Start time (Unix timestamp in seconds) | [optional] 
 **endTime** | **long?**| End time (Unix timestamp in seconds) | [optional] 
 **limit** | **int?**| Kline limit (max 500, error if exceeded) | [optional] 

### Return type

[**Klines**](Klines.md)

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

<a name="querysymbolticker"></a>
# **QuerySymbolTicker**
> Ticker2 QuerySymbolTicker (string symbol)

Query trading symbol ticker

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class QuerySymbolTickerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new TradFiApi(config);
            var symbol = "EURUSD";  // string | Trading symbol code

            try
            {
                // Query trading symbol ticker
                Ticker2 result = apiInstance.QuerySymbolTicker(symbol);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling TradFiApi.QuerySymbolTicker: " + e.Message);
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
 **symbol** | **string**| Trading symbol code | 

### Return type

[**Ticker2**](Ticker2.md)

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

<a name="createtradfiuser"></a>
# **CreateTradFiUser**
> CreateUserResp CreateTradFiUser ()

Create TradFi user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateTradFiUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new TradFiApi(config);

            try
            {
                // Create TradFi user
                CreateUserResp result = apiInstance.CreateTradFiUser();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling TradFiApi.CreateTradFiUser: " + e.Message);
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

[**CreateUserResp**](CreateUserResp.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Account opened successfully |  -  |
| **400** | Request failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryuserassets"></a>
# **QueryUserAssets**
> UserAssetResp QueryUserAssets ()

Query account assets

Query account assets

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class QueryUserAssetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new TradFiApi(config);

            try
            {
                // Query account assets
                UserAssetResp result = apiInstance.QueryUserAssets();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling TradFiApi.QueryUserAssets: " + e.Message);
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

[**UserAssetResp**](UserAssetResp.md)

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

<a name="querytransaction"></a>
# **QueryTransaction**
> TransactionList QueryTransaction (long? beginTime = null, long? endTime = null, string type = null, int? page = null, int? pageSize = null)

Query Fund Transfer In/Out Records

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class QueryTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new TradFiApi(config);
            var beginTime = 1704067200;  // long? | Start Time (Second-level Timestamp) (optional) 
            var endTime = 1706745599;  // long? | End Time (Second-level Timestamp) (optional) 
            var type = "withdraw";  // string | Transaction Type (deposit - transfer in, withdraw - transfer out, dividend - dividend payment, fill_negative - cover negative balance) (optional) 
            var page = 1;  // int? | page number (optional) 
            var pageSize = 20;  // int? | Number per page, default 10, maximum 50 (optional) 

            try
            {
                // Query Fund Transfer In/Out Records
                TransactionList result = apiInstance.QueryTransaction(beginTime, endTime, type, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling TradFiApi.QueryTransaction: " + e.Message);
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
 **beginTime** | **long?**| Start Time (Second-level Timestamp) | [optional] 
 **endTime** | **long?**| End Time (Second-level Timestamp) | [optional] 
 **type** | **string**| Transaction Type (deposit - transfer in, withdraw - transfer out, dividend - dividend payment, fill_negative - cover negative balance) | [optional] 
 **page** | **int?**| page number | [optional] 
 **pageSize** | **int?**| Number per page, default 10, maximum 50 | [optional] 

### Return type

[**TransactionList**](TransactionList.md)

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

<a name="createtransaction"></a>
# **CreateTransaction**
> CreateTransaction CreateTransaction (InlineObject1 inlineObject1)

Fund Deposit and Withdrawal

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new TradFiApi(config);
            var inlineObject1 = new InlineObject1(); // InlineObject1 | 

            try
            {
                // Fund Deposit and Withdrawal
                CreateTransaction result = apiInstance.CreateTransaction(inlineObject1);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling TradFiApi.CreateTransaction: " + e.Message);
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
 **inlineObject1** | [**InlineObject1**](InlineObject1.md)|  | 

### Return type

[**CreateTransaction**](CreateTransaction.md)

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

<a name="queryorderlist"></a>
# **QueryOrderList**
> OrderList QueryOrderList ()

Query active order list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class QueryOrderListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new TradFiApi(config);

            try
            {
                // Query active order list
                OrderList result = apiInstance.QueryOrderList();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling TradFiApi.QueryOrderList: " + e.Message);
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

[**OrderList**](OrderList.md)

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

<a name="createtradfiorder"></a>
# **CreateTradFiOrder**
> CreateOrder CreateTradFiOrder (InlineObject2 inlineObject2)

Create an order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateTradFiOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new TradFiApi(config);
            var inlineObject2 = new InlineObject2(); // InlineObject2 | 

            try
            {
                // Create an order
                CreateOrder result = apiInstance.CreateTradFiOrder(inlineObject2);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling TradFiApi.CreateTradFiOrder: " + e.Message);
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
 **inlineObject2** | [**InlineObject2**](InlineObject2.md)|  | 

### Return type

[**CreateOrder**](CreateOrder.md)

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

<a name="updateorder"></a>
# **UpdateOrder**
> UpdateOrder UpdateOrder (int orderId, InlineObject3 inlineObject3)

Modify order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class UpdateOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new TradFiApi(config);
            var orderId = 1223;  // int | Order ID
            var inlineObject3 = new InlineObject3(); // InlineObject3 | 

            try
            {
                // Modify order
                UpdateOrder result = apiInstance.UpdateOrder(orderId, inlineObject3);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling TradFiApi.UpdateOrder: " + e.Message);
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
 **orderId** | **int**| Order ID | 
 **inlineObject3** | [**InlineObject3**](InlineObject3.md)|  | 

### Return type

[**UpdateOrder**](UpdateOrder.md)

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

<a name="deleteorder"></a>
# **DeleteOrder**
> Object DeleteOrder (int orderId)

Cancel order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class DeleteOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new TradFiApi(config);
            var orderId = 1223;  // int | Order ID

            try
            {
                // Cancel order
                Object result = apiInstance.DeleteOrder(orderId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling TradFiApi.DeleteOrder: " + e.Message);
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
 **orderId** | **int**| Order ID | 

### Return type

**Object**

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Deleted successfully |  -  |
| **400** | Request failed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="queryorderhistorylist"></a>
# **QueryOrderHistoryList**
> OrderHistoryList QueryOrderHistoryList (long? beginTime = null, long? endTime = null, string symbol = null, int? side = null)

Query historical order list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class QueryOrderHistoryListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new TradFiApi(config);
            var beginTime = 1769397000;  // long? | Start time (Unix timestamp in seconds), earliest query is one month ago (optional) 
            var endTime = 1769398000;  // long? | End time (Unix timestamp in seconds) (optional) 
            var symbol = "USDCAD";  // string | Currency pair (optional) 
            var side = 2;  // int? | Order side (1=sell, 2=buy) (optional) 

            try
            {
                // Query historical order list
                OrderHistoryList result = apiInstance.QueryOrderHistoryList(beginTime, endTime, symbol, side);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling TradFiApi.QueryOrderHistoryList: " + e.Message);
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
 **beginTime** | **long?**| Start time (Unix timestamp in seconds), earliest query is one month ago | [optional] 
 **endTime** | **long?**| End time (Unix timestamp in seconds) | [optional] 
 **symbol** | **string**| Currency pair | [optional] 
 **side** | **int?**| Order side (1&#x3D;sell, 2&#x3D;buy) | [optional] 

### Return type

[**OrderHistoryList**](OrderHistoryList.md)

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

<a name="querypositionlist"></a>
# **QueryPositionList**
> PositionList QueryPositionList ()

Query active position list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class QueryPositionListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new TradFiApi(config);

            try
            {
                // Query active position list
                PositionList result = apiInstance.QueryPositionList();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling TradFiApi.QueryPositionList: " + e.Message);
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

[**PositionList**](PositionList.md)

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

<a name="updateposition"></a>
# **UpdatePosition**
> UpdatePosition UpdatePosition (int positionId, InlineObject4 inlineObject4)

Modify position

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class UpdatePositionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new TradFiApi(config);
            var positionId = 1223;  // int | Position ID
            var inlineObject4 = new InlineObject4(); // InlineObject4 | 

            try
            {
                // Modify position
                UpdatePosition result = apiInstance.UpdatePosition(positionId, inlineObject4);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling TradFiApi.UpdatePosition: " + e.Message);
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
 **positionId** | **int**| Position ID | 
 **inlineObject4** | [**InlineObject4**](InlineObject4.md)|  | 

### Return type

[**UpdatePosition**](UpdatePosition.md)

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

<a name="closeposition"></a>
# **ClosePosition**
> DeletePosition ClosePosition (int positionId, InlineObject5 inlineObject5)

Close position

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ClosePositionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new TradFiApi(config);
            var positionId = 1223;  // int | Position ID
            var inlineObject5 = new InlineObject5(); // InlineObject5 | 

            try
            {
                // Close position
                DeletePosition result = apiInstance.ClosePosition(positionId, inlineObject5);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling TradFiApi.ClosePosition: " + e.Message);
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
 **positionId** | **int**| Position ID | 
 **inlineObject5** | [**InlineObject5**](InlineObject5.md)|  | 

### Return type

[**DeletePosition**](DeletePosition.md)

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

<a name="querypositionhistorylist"></a>
# **QueryPositionHistoryList**
> PositionHistoryList QueryPositionHistoryList (long? beginTime = null, long? endTime = null, string symbol = null, string positionDir = null)

Query historical position list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class QueryPositionHistoryListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new TradFiApi(config);
            var beginTime = 56;  // long? | Start Time (Unix Timestamp, seconds). The earliest queryable time is one month ago (optional) 
            var endTime = 56;  // long? | End time (timestamp in seconds) (optional) 
            var symbol = "symbol_example";  // string | Trading symbol (e.g., EURUSD) (optional) 
            var positionDir = "positionDir_example";  // string | Position direction (Long=long position, Short=short position) (optional) 

            try
            {
                // Query historical position list
                PositionHistoryList result = apiInstance.QueryPositionHistoryList(beginTime, endTime, symbol, positionDir);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling TradFiApi.QueryPositionHistoryList: " + e.Message);
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
 **beginTime** | **long?**| Start Time (Unix Timestamp, seconds). The earliest queryable time is one month ago | [optional] 
 **endTime** | **long?**| End time (timestamp in seconds) | [optional] 
 **symbol** | **string**| Trading symbol (e.g., EURUSD) | [optional] 
 **positionDir** | **string**| Position direction (Long&#x3D;long position, Short&#x3D;short position) | [optional] 

### Return type

[**PositionHistoryList**](PositionHistoryList.md)

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

