# Io.Gate.GateApi.Api.AlphaApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListAlphaAccounts**](AlphaApi.md#listalphaaccounts) | **GET** /alpha/accounts | Alpha Account API
[**ListAlphaAccountBook**](AlphaApi.md#listalphaaccountbook) | **GET** /alpha/account_book | Alpha Account Transaction History API
[**QuoteAlphaOrder**](AlphaApi.md#quotealphaorder) | **POST** /alpha/quote | Alpha Quote API
[**ListAlphaOrder**](AlphaApi.md#listalphaorder) | **GET** /alpha/orders | Alpha Order List API
[**PlaceAlphaOrder**](AlphaApi.md#placealphaorder) | **POST** /alpha/orders | Alpha Order API
[**GetAlphaOrder**](AlphaApi.md#getalphaorder) | **GET** /alpha/order | Alpha Single Order Query API
[**ListAlphaCurrencies**](AlphaApi.md#listalphacurrencies) | **GET** /alpha/currencies | Query currency information
[**ListAlphaTickers**](AlphaApi.md#listalphatickers) | **GET** /alpha/tickers | Query currency ticker
[**ListAlphaTokens**](AlphaApi.md#listalphatokens) | **GET** /alpha/tokens | Query Token Information


<a name="listalphaaccounts"></a>
# **ListAlphaAccounts**
> List&lt;AccountsResponse&gt; ListAlphaAccounts ()

Alpha Account API

Query position assets

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListAlphaAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new AlphaApi(config);

            try
            {
                // Alpha Account API
                List<AccountsResponse> result = apiInstance.ListAlphaAccounts();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling AlphaApi.ListAlphaAccounts: " + e.Message);
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

[**List&lt;AccountsResponse&gt;**](AccountsResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Positions queried successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listalphaaccountbook"></a>
# **ListAlphaAccountBook**
> List&lt;AccountBookResponse&gt; ListAlphaAccountBook (long from, long? to = null, int? page = null, int? limit = null)

Alpha Account Transaction History API

Query asset transactions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListAlphaAccountBookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new AlphaApi(config);
            var from = 56;  // long | Start timestamp for the query
            var to = 56;  // long? | End timestamp for the query, defaults to current time if not specified (optional) 
            var page = 56;  // int? | Page number (optional) 
            var limit = 56;  // int? | Maximum 100 items per page (optional) 

            try
            {
                // Alpha Account Transaction History API
                List<AccountBookResponse> result = apiInstance.ListAlphaAccountBook(from, to, page, limit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling AlphaApi.ListAlphaAccountBook: " + e.Message);
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
 **from** | **long**| Start timestamp for the query | 
 **to** | **long?**| End timestamp for the query, defaults to current time if not specified | [optional] 
 **page** | **int?**| Page number | [optional] 
 **limit** | **int?**| Maximum 100 items per page | [optional] 

### Return type

[**List&lt;AccountBookResponse&gt;**](AccountBookResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Transaction history retrieved successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotealphaorder"></a>
# **QuoteAlphaOrder**
> QuoteResponse QuoteAlphaOrder (QuoteRequest quoteRequest)

Alpha Quote API

The quote_id returned by the price inquiry interface is valid for one minute; an order must be placed within this minute. If it times out, a new price inquiry is required. Rate-limited at 10 requests per second per user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class QuoteAlphaOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new AlphaApi(config);
            var quoteRequest = new QuoteRequest(); // QuoteRequest | 

            try
            {
                // Alpha Quote API
                QuoteResponse result = apiInstance.QuoteAlphaOrder(quoteRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling AlphaApi.QuoteAlphaOrder: " + e.Message);
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
 **quoteRequest** | [**QuoteRequest**](QuoteRequest.md)|  | 

### Return type

[**QuoteResponse**](QuoteResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Quote retrieved successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listalphaorder"></a>
# **ListAlphaOrder**
> List&lt;OrderResponse&gt; ListAlphaOrder (string currency = null, string side = null, int? status = null, long? from = null, long? to = null, int? limit = null, int? page = null)

Alpha Order List API

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListAlphaOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new AlphaApi(config);
            var currency = "memeboxsst";  // string | Trading symbol (optional) 
            var side = "buy";  // string | Buy or sell orders - buy - sell (optional) 
            var status = 2;  // int? | Order Status - `0` : All - `1` : Processing - `2` : Successful - `3` : Failed - `4` : Cancelled - `5` : Buy order placed but transfer not completed - `6` : Order cancelled but transfer not completed (optional) 
            var from = 1627706330;  // long? | Start time for order query (optional) 
            var to = 1635329650;  // long? | End time for order query, defaults to current time if not specified (optional) 
            var limit = 100;  // int? | Maximum number of items returned. Default: 100, minimum: 1, maximum: 100 (optional)  (default to 100)
            var page = 1;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Alpha Order List API
                List<OrderResponse> result = apiInstance.ListAlphaOrder(currency, side, status, from, to, limit, page);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling AlphaApi.ListAlphaOrder: " + e.Message);
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
 **currency** | **string**| Trading symbol | [optional] 
 **side** | **string**| Buy or sell orders - buy - sell | [optional] 
 **status** | **int?**| Order Status - &#x60;0&#x60; : All - &#x60;1&#x60; : Processing - &#x60;2&#x60; : Successful - &#x60;3&#x60; : Failed - &#x60;4&#x60; : Cancelled - &#x60;5&#x60; : Buy order placed but transfer not completed - &#x60;6&#x60; : Order cancelled but transfer not completed | [optional] 
 **from** | **long?**| Start time for order query | [optional] 
 **to** | **long?**| End time for order query, defaults to current time if not specified | [optional] 
 **limit** | **int?**| Maximum number of items returned. Default: 100, minimum: 1, maximum: 100 | [optional] [default to 100]
 **page** | **int?**| Page number | [optional] [default to 1]

### Return type

[**List&lt;OrderResponse&gt;**](OrderResponse.md)

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

<a name="placealphaorder"></a>
# **PlaceAlphaOrder**
> PlaceOrderResponse PlaceAlphaOrder (PlaceOrderRequest placeOrderRequest)

Alpha Order API

Order placement interface, rate-limited at 5 requests per second per user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class PlaceAlphaOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new AlphaApi(config);
            var placeOrderRequest = new PlaceOrderRequest(); // PlaceOrderRequest | 

            try
            {
                // Alpha Order API
                PlaceOrderResponse result = apiInstance.PlaceAlphaOrder(placeOrderRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling AlphaApi.PlaceAlphaOrder: " + e.Message);
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
 **placeOrderRequest** | [**PlaceOrderRequest**](PlaceOrderRequest.md)|  | 

### Return type

[**PlaceOrderResponse**](PlaceOrderResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Order placed successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalphaorder"></a>
# **GetAlphaOrder**
> OrderResponse GetAlphaOrder (string orderId)

Alpha Single Order Query API

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetAlphaOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new AlphaApi(config);
            var orderId = "fdaf12321";  // string | Order ID

            try
            {
                // Alpha Single Order Query API
                OrderResponse result = apiInstance.GetAlphaOrder(orderId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling AlphaApi.GetAlphaOrder: " + e.Message);
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
 **orderId** | **string**| Order ID | 

### Return type

[**OrderResponse**](OrderResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Order queried successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listalphacurrencies"></a>
# **ListAlphaCurrencies**
> List&lt;Currency2&gt; ListAlphaCurrencies (string currency = null, int? limit = null, int? page = null)

Query currency information

When currency is provided, query and return specified currency information; when currency is not provided, return paginated currency list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListAlphaCurrenciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new AlphaApi(config);
            var currency = "memeboxtrump";  // string | Query currency information by currency symbol (optional) 
            var limit = 100;  // int? | Maximum number of records returned in a single list (optional)  (default to 100)
            var page = 1;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Query currency information
                List<Currency2> result = apiInstance.ListAlphaCurrencies(currency, limit, page);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling AlphaApi.ListAlphaCurrencies: " + e.Message);
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
 **currency** | **string**| Query currency information by currency symbol | [optional] 
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 100]
 **page** | **int?**| Page number | [optional] [default to 1]

### Return type

[**List&lt;Currency2&gt;**](Currency2.md)

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

<a name="listalphatickers"></a>
# **ListAlphaTickers**
> List&lt;Ticker2&gt; ListAlphaTickers (string currency = null, int? limit = null, int? page = null)

Query currency ticker

When currency is provided, returns ticker information for the specified currency. When currency is not provided, returns paginated ticker list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListAlphaTickersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new AlphaApi(config);
            var currency = "memeboxtrump";  // string | Query by specified currency name (optional) 
            var limit = 100;  // int? | Maximum number of records returned in a single list (optional)  (default to 100)
            var page = 1;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Query currency ticker
                List<Ticker2> result = apiInstance.ListAlphaTickers(currency, limit, page);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling AlphaApi.ListAlphaTickers: " + e.Message);
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
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 100]
 **page** | **int?**| Page number | [optional] [default to 1]

### Return type

[**List&lt;Ticker2&gt;**](Ticker2.md)

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

<a name="listalphatokens"></a>
# **ListAlphaTokens**
> List&lt;Tokens&gt; ListAlphaTokens (string chain = null, string launchPlatform = null, string address = null, int? page = null)

Query Token Information

Supports passing chain, platform, and address

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListAlphaTokensExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new AlphaApi(config);
            var chain = "solana";  // string | Query Token List by Chain  - solana - eth - bsc - base - world - sui - arbitrum - avalanche - polygon - linea - optimism - zksync - gatelayer (optional) 
            var launchPlatform = "pump";  // string | Query Token List by Launch Platform  - meteora_dbc - fourmeme - moonshot - pump - raydium_launchlab - letsbonk - gatefun - virtuals (optional) 
            var address = "0x1234p";  // string | Query Token List by Contract Address (optional) 
            var page = 1;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Query Token Information
                List<Tokens> result = apiInstance.ListAlphaTokens(chain, launchPlatform, address, page);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling AlphaApi.ListAlphaTokens: " + e.Message);
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
 **chain** | **string**| Query Token List by Chain  - solana - eth - bsc - base - world - sui - arbitrum - avalanche - polygon - linea - optimism - zksync - gatelayer | [optional] 
 **launchPlatform** | **string**| Query Token List by Launch Platform  - meteora_dbc - fourmeme - moonshot - pump - raydium_launchlab - letsbonk - gatefun - virtuals | [optional] 
 **address** | **string**| Query Token List by Contract Address | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]

### Return type

[**List&lt;Tokens&gt;**](Tokens.md)

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

