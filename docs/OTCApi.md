# Io.Gate.GateApi.Api.OTCApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOtcQuote**](OTCApi.md#createotcquote) | **POST** /otc/quote | Fiat and stablecoin quote
[**CreateOtcOrder**](OTCApi.md#createotcorder) | **POST** /otc/order/create | Create fiat order
[**CreateStableCoinOrder**](OTCApi.md#createstablecoinorder) | **POST** /otc/stable_coin/order/create | Create stablecoin order
[**GetUserDefaultBank**](OTCApi.md#getuserdefaultbank) | **GET** /otc/get_user_def_bank | Get user&#39;s default bank account information
[**GetBankList**](OTCApi.md#getbanklist) | **GET** /otc/bank_list | Get user bank card list
[**MarkOtcOrderPaid**](OTCApi.md#markotcorderpaid) | **POST** /otc/order/paid | Mark fiat order as paid
[**CancelOtcOrder**](OTCApi.md#cancelotcorder) | **POST** /otc/order/cancel | Fiat order cancellation
[**ListOtcOrders**](OTCApi.md#listotcorders) | **GET** /otc/order/list | Fiat order list
[**ListStableCoinOrders**](OTCApi.md#liststablecoinorders) | **GET** /otc/stable_coin/order/list | Stablecoin order list
[**GetOtcOrderDetail**](OTCApi.md#getotcorderdetail) | **GET** /otc/order/detail | Fiat order details


<a name="createotcquote"></a>
# **CreateOtcQuote**
> OtcQuoteResponse CreateOtcQuote (OtcQuoteRequest otcQuoteRequest)

Fiat and stablecoin quote

Create fiat and stablecoin quotes, supporting both PAY and GET directions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateOtcQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OTCApi(config);
            var otcQuoteRequest = new OtcQuoteRequest(); // OtcQuoteRequest | 

            try
            {
                // Fiat and stablecoin quote
                OtcQuoteResponse result = apiInstance.CreateOtcQuote(otcQuoteRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OTCApi.CreateOtcQuote: " + e.Message);
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
 **otcQuoteRequest** | [**OtcQuoteRequest**](OtcQuoteRequest.md)|  | 

### Return type

[**OtcQuoteResponse**](OtcQuoteResponse.md)

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

<a name="createotcorder"></a>
# **CreateOtcOrder**
> OtcActionResponse CreateOtcOrder (OtcOrderRequest otcOrderRequest)

Create fiat order

Create a fiat order, supporting BUY for on-ramp and SELL for off-ramp

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateOtcOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OTCApi(config);
            var otcOrderRequest = new OtcOrderRequest(); // OtcOrderRequest | 

            try
            {
                // Create fiat order
                OtcActionResponse result = apiInstance.CreateOtcOrder(otcOrderRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OTCApi.CreateOtcOrder: " + e.Message);
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
 **otcOrderRequest** | [**OtcOrderRequest**](OtcOrderRequest.md)|  | 

### Return type

[**OtcActionResponse**](OtcActionResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Order created successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createstablecoinorder"></a>
# **CreateStableCoinOrder**
> OtcStableCoinOrderCreateResponse CreateStableCoinOrder (OtcStableCoinOrderRequest otcStableCoinOrderRequest)

Create stablecoin order

Create stablecoin order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateStableCoinOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OTCApi(config);
            var otcStableCoinOrderRequest = new OtcStableCoinOrderRequest(); // OtcStableCoinOrderRequest | 

            try
            {
                // Create stablecoin order
                OtcStableCoinOrderCreateResponse result = apiInstance.CreateStableCoinOrder(otcStableCoinOrderRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OTCApi.CreateStableCoinOrder: " + e.Message);
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
 **otcStableCoinOrderRequest** | [**OtcStableCoinOrderRequest**](OtcStableCoinOrderRequest.md)|  | 

### Return type

[**OtcStableCoinOrderCreateResponse**](OtcStableCoinOrderCreateResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Stablecoin order created successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserdefaultbank"></a>
# **GetUserDefaultBank**
> OtcUserDefaultBankResponse GetUserDefaultBank ()

Get user's default bank account information

Get user's default bank account information for order placement

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetUserDefaultBankExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OTCApi(config);

            try
            {
                // Get user's default bank account information
                OtcUserDefaultBankResponse result = apiInstance.GetUserDefaultBank();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OTCApi.GetUserDefaultBank: " + e.Message);
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

[**OtcUserDefaultBankResponse**](OtcUserDefaultBankResponse.md)

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

<a name="getbanklist"></a>
# **GetBankList**
> OtcBankListResponse GetBankList ()

Get user bank card list

Get user bank card list for selecting bank card when placing orders

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetBankListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OTCApi(config);

            try
            {
                // Get user bank card list
                OtcBankListResponse result = apiInstance.GetBankList();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OTCApi.GetBankList: " + e.Message);
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

[**OtcBankListResponse**](OtcBankListResponse.md)

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

<a name="markotcorderpaid"></a>
# **MarkOtcOrderPaid**
> OtcActionResponse MarkOtcOrderPaid (OtcMarkOrderPaidRequest otcMarkOrderPaidRequest)

Mark fiat order as paid

Mark fiat order as paid

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class MarkOtcOrderPaidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OTCApi(config);
            var otcMarkOrderPaidRequest = new OtcMarkOrderPaidRequest(); // OtcMarkOrderPaidRequest | 

            try
            {
                // Mark fiat order as paid
                OtcActionResponse result = apiInstance.MarkOtcOrderPaid(otcMarkOrderPaidRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OTCApi.MarkOtcOrderPaid: " + e.Message);
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
 **otcMarkOrderPaidRequest** | [**OtcMarkOrderPaidRequest**](OtcMarkOrderPaidRequest.md)|  | 

### Return type

[**OtcActionResponse**](OtcActionResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The order has been marked as paid |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelotcorder"></a>
# **CancelOtcOrder**
> OtcActionResponse CancelOtcOrder (string orderId)

Fiat order cancellation

Cancel fiat order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CancelOtcOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OTCApi(config);
            var orderId = "orderId_example";  // string | Order ID

            try
            {
                // Fiat order cancellation
                OtcActionResponse result = apiInstance.CancelOtcOrder(orderId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OTCApi.CancelOtcOrder: " + e.Message);
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

[**OtcActionResponse**](OtcActionResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Order cancelled successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listotcorders"></a>
# **ListOtcOrders**
> OtcOrderListResponse ListOtcOrders (string type = null, string fiatCurrency = null, string cryptoCurrency = null, string startTime = null, string endTime = null, string status = null, string pn = null, string ps = null)

Fiat order list

Query the fiat order list with filters such as type, currency, time range, and status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListOtcOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OTCApi(config);
            var type = "type_example";  // string | BUY for on-ramp, SELL for off-ramp (optional) 
            var fiatCurrency = "fiatCurrency_example";  // string | Fiat currency (optional) 
            var cryptoCurrency = "cryptoCurrency_example";  // string | Digital currency (optional) 
            var startTime = "startTime_example";  // string | starttime   for example : 2025-09-09 (optional) 
            var endTime = "endTime_example";  // string | endtime  for example :2025-09-09 (optional) 
            var status = "status_example";  // string | DONE: Completed CANCEL: Canceled PROCESSING: In Progress (optional) 
            var pn = "pn_example";  // string | Page number (optional) 
            var ps = "ps_example";  // string | Number of items per page (optional) 

            try
            {
                // Fiat order list
                OtcOrderListResponse result = apiInstance.ListOtcOrders(type, fiatCurrency, cryptoCurrency, startTime, endTime, status, pn, ps);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OTCApi.ListOtcOrders: " + e.Message);
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
 **type** | **string**| BUY for on-ramp, SELL for off-ramp | [optional] 
 **fiatCurrency** | **string**| Fiat currency | [optional] 
 **cryptoCurrency** | **string**| Digital currency | [optional] 
 **startTime** | **string**| starttime   for example : 2025-09-09 | [optional] 
 **endTime** | **string**| endtime  for example :2025-09-09 | [optional] 
 **status** | **string**| DONE: Completed CANCEL: Canceled PROCESSING: In Progress | [optional] 
 **pn** | **string**| Page number | [optional] 
 **ps** | **string**| Number of items per page | [optional] 

### Return type

[**OtcOrderListResponse**](OtcOrderListResponse.md)

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

<a name="liststablecoinorders"></a>
# **ListStableCoinOrders**
> OtcStableCoinOrderListResponse ListStableCoinOrders (string pageSize = null, string pageNumber = null, string coinName = null, string startTime = null, string endTime = null, string status = null)

Stablecoin order list

Query stablecoin order list with filtering by currency, time range, status, etc.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListStableCoinOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OTCApi(config);
            var pageSize = "10";  // string | Number of records per page (optional) 
            var pageNumber = "1";  // string | Page number (optional) 
            var coinName = "USDT";  // string | ordercurrency (optional) 
            var startTime = "startTime_example";  // string | Start Time (optional) 
            var endTime = "endTime_example";  // string | End time (optional) 
            var status = "status_example";  // string | Status: PROCESSING: in progress / DONE：completed / FAILED: failed (optional) 

            try
            {
                // Stablecoin order list
                OtcStableCoinOrderListResponse result = apiInstance.ListStableCoinOrders(pageSize, pageNumber, coinName, startTime, endTime, status);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OTCApi.ListStableCoinOrders: " + e.Message);
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
 **pageSize** | **string**| Number of records per page | [optional] 
 **pageNumber** | **string**| Page number | [optional] 
 **coinName** | **string**| ordercurrency | [optional] 
 **startTime** | **string**| Start Time | [optional] 
 **endTime** | **string**| End time | [optional] 
 **status** | **string**| Status: PROCESSING: in progress / DONE：completed / FAILED: failed | [optional] 

### Return type

[**OtcStableCoinOrderListResponse**](OtcStableCoinOrderListResponse.md)

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

<a name="getotcorderdetail"></a>
# **GetOtcOrderDetail**
> OtcOrderDetailResponse GetOtcOrderDetail (string orderId)

Fiat order details

Query fiat order details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetOtcOrderDetailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OTCApi(config);
            var orderId = "orderId_example";  // string | Order ID

            try
            {
                // Fiat order details
                OtcOrderDetailResponse result = apiInstance.GetOtcOrderDetail(orderId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OTCApi.GetOtcOrderDetail: " + e.Message);
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

[**OtcOrderDetailResponse**](OtcOrderDetailResponse.md)

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

