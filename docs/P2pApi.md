# Io.Gate.GateApi.Api.P2pApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**P2pMerchantAccountGetUserInfo**](P2pApi.md#p2pmerchantaccountgetuserinfo) | **POST** /p2p/merchant/account/get_user_info | Get account information
[**P2pMerchantAccountGetCounterpartyUserInfo**](P2pApi.md#p2pmerchantaccountgetcounterpartyuserinfo) | **POST** /p2p/merchant/account/get_counterparty_user_info | Get counterparty information
[**P2pMerchantAccountGetMyselfPayment**](P2pApi.md#p2pmerchantaccountgetmyselfpayment) | **POST** /p2p/merchant/account/get_myself_payment | Get payment method list
[**P2pMerchantTransactionGetPendingTransactionList**](P2pApi.md#p2pmerchanttransactiongetpendingtransactionlist) | **POST** /p2p/merchant/transaction/get_pending_transaction_list | Get pending orders
[**P2pMerchantTransactionGetCompletedTransactionList**](P2pApi.md#p2pmerchanttransactiongetcompletedtransactionlist) | **POST** /p2p/merchant/transaction/get_completed_transaction_list | Get all/historical orders
[**P2pMerchantTransactionGetTransactionDetails**](P2pApi.md#p2pmerchanttransactiongettransactiondetails) | **POST** /p2p/merchant/transaction/get_transaction_details | Query order details
[**P2pMerchantTransactionConfirmPayment**](P2pApi.md#p2pmerchanttransactionconfirmpayment) | **POST** /p2p/merchant/transaction/confirm-payment | Confirm payment
[**P2pMerchantTransactionConfirmReceipt**](P2pApi.md#p2pmerchanttransactionconfirmreceipt) | **POST** /p2p/merchant/transaction/confirm-receipt | Confirm receipt
[**P2pMerchantTransactionCancel**](P2pApi.md#p2pmerchanttransactioncancel) | **POST** /p2p/merchant/transaction/cancel | Cancel order
[**P2pMerchantBooksPlaceBizPushOrder**](P2pApi.md#p2pmerchantbooksplacebizpushorder) | **POST** /p2p/merchant/books/place_biz_push_order | Publish ad order
[**P2pMerchantBooksAdsUpdateStatus**](P2pApi.md#p2pmerchantbooksadsupdatestatus) | **POST** /p2p/merchant/books/ads_update_status | Update ad status
[**P2pMerchantBooksAdsDetail**](P2pApi.md#p2pmerchantbooksadsdetail) | **POST** /p2p/merchant/books/ads_detail | Query ad details
[**P2pMerchantBooksMyAdsList**](P2pApi.md#p2pmerchantbooksmyadslist) | **POST** /p2p/merchant/books/my_ads_list | Get my ad list
[**P2pMerchantBooksAdsList**](P2pApi.md#p2pmerchantbooksadslist) | **POST** /p2p/merchant/books/ads_list | Get Advertisement List
[**P2pMerchantChatGetChatsList**](P2pApi.md#p2pmerchantchatgetchatslist) | **POST** /p2p/merchant/chat/get_chats_list | Get chat history
[**P2pMerchantChatSendChatMessage**](P2pApi.md#p2pmerchantchatsendchatmessage) | **POST** /p2p/merchant/chat/send_chat_message | Send text message
[**P2pMerchantChatUploadChatFile**](P2pApi.md#p2pmerchantchatuploadchatfile) | **POST** /p2p/merchant/chat/upload_chat_file | Upload chat file


<a name="p2pmerchantaccountgetuserinfo"></a>
# **P2pMerchantAccountGetUserInfo**
> InlineResponse20014 P2pMerchantAccountGetUserInfo ()

Get account information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class P2pMerchantAccountGetUserInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new P2pApi(config);

            try
            {
                // Get account information
                InlineResponse20014 result = apiInstance.P2pMerchantAccountGetUserInfo();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2pApi.P2pMerchantAccountGetUserInfo: " + e.Message);
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

[**InlineResponse20014**](InlineResponse20014.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="p2pmerchantaccountgetcounterpartyuserinfo"></a>
# **P2pMerchantAccountGetCounterpartyUserInfo**
> InlineResponse20015 P2pMerchantAccountGetCounterpartyUserInfo (GetCounterpartyUserInfoRequest getCounterpartyUserInfoRequest)

Get counterparty information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class P2pMerchantAccountGetCounterpartyUserInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new P2pApi(config);
            var getCounterpartyUserInfoRequest = new GetCounterpartyUserInfoRequest(); // GetCounterpartyUserInfoRequest | 

            try
            {
                // Get counterparty information
                InlineResponse20015 result = apiInstance.P2pMerchantAccountGetCounterpartyUserInfo(getCounterpartyUserInfoRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2pApi.P2pMerchantAccountGetCounterpartyUserInfo: " + e.Message);
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
 **getCounterpartyUserInfoRequest** | [**GetCounterpartyUserInfoRequest**](GetCounterpartyUserInfoRequest.md)|  | 

### Return type

[**InlineResponse20015**](InlineResponse20015.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="p2pmerchantaccountgetmyselfpayment"></a>
# **P2pMerchantAccountGetMyselfPayment**
> InlineResponse20016 P2pMerchantAccountGetMyselfPayment (GetMyselfPaymentRequest getMyselfPaymentRequest = null)

Get payment method list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class P2pMerchantAccountGetMyselfPaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new P2pApi(config);
            var getMyselfPaymentRequest = new GetMyselfPaymentRequest(); // GetMyselfPaymentRequest |  (optional) 

            try
            {
                // Get payment method list
                InlineResponse20016 result = apiInstance.P2pMerchantAccountGetMyselfPayment(getMyselfPaymentRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2pApi.P2pMerchantAccountGetMyselfPayment: " + e.Message);
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
 **getMyselfPaymentRequest** | [**GetMyselfPaymentRequest**](GetMyselfPaymentRequest.md)|  | [optional] 

### Return type

[**InlineResponse20016**](InlineResponse20016.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="p2pmerchanttransactiongetpendingtransactionlist"></a>
# **P2pMerchantTransactionGetPendingTransactionList**
> InlineResponse20017 P2pMerchantTransactionGetPendingTransactionList (GetPendingTransactionListRequest getPendingTransactionListRequest)

Get pending orders

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class P2pMerchantTransactionGetPendingTransactionListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new P2pApi(config);
            var getPendingTransactionListRequest = new GetPendingTransactionListRequest(); // GetPendingTransactionListRequest | 

            try
            {
                // Get pending orders
                InlineResponse20017 result = apiInstance.P2pMerchantTransactionGetPendingTransactionList(getPendingTransactionListRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2pApi.P2pMerchantTransactionGetPendingTransactionList: " + e.Message);
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
 **getPendingTransactionListRequest** | [**GetPendingTransactionListRequest**](GetPendingTransactionListRequest.md)|  | 

### Return type

[**InlineResponse20017**](InlineResponse20017.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="p2pmerchanttransactiongetcompletedtransactionlist"></a>
# **P2pMerchantTransactionGetCompletedTransactionList**
> InlineResponse20017 P2pMerchantTransactionGetCompletedTransactionList (GetCompletedTransactionListRequest getCompletedTransactionListRequest)

Get all/historical orders

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class P2pMerchantTransactionGetCompletedTransactionListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new P2pApi(config);
            var getCompletedTransactionListRequest = new GetCompletedTransactionListRequest(); // GetCompletedTransactionListRequest | 

            try
            {
                // Get all/historical orders
                InlineResponse20017 result = apiInstance.P2pMerchantTransactionGetCompletedTransactionList(getCompletedTransactionListRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2pApi.P2pMerchantTransactionGetCompletedTransactionList: " + e.Message);
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
 **getCompletedTransactionListRequest** | [**GetCompletedTransactionListRequest**](GetCompletedTransactionListRequest.md)|  | 

### Return type

[**InlineResponse20017**](InlineResponse20017.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="p2pmerchanttransactiongettransactiondetails"></a>
# **P2pMerchantTransactionGetTransactionDetails**
> InlineResponse20018 P2pMerchantTransactionGetTransactionDetails (GetTransactionDetailsRequest getTransactionDetailsRequest)

Query order details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class P2pMerchantTransactionGetTransactionDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new P2pApi(config);
            var getTransactionDetailsRequest = new GetTransactionDetailsRequest(); // GetTransactionDetailsRequest | 

            try
            {
                // Query order details
                InlineResponse20018 result = apiInstance.P2pMerchantTransactionGetTransactionDetails(getTransactionDetailsRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2pApi.P2pMerchantTransactionGetTransactionDetails: " + e.Message);
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
 **getTransactionDetailsRequest** | [**GetTransactionDetailsRequest**](GetTransactionDetailsRequest.md)|  | 

### Return type

[**InlineResponse20018**](InlineResponse20018.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="p2pmerchanttransactionconfirmpayment"></a>
# **P2pMerchantTransactionConfirmPayment**
> InlineResponse20019 P2pMerchantTransactionConfirmPayment (ConfirmPayment confirmPayment)

Confirm payment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class P2pMerchantTransactionConfirmPaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new P2pApi(config);
            var confirmPayment = new ConfirmPayment(); // ConfirmPayment | 

            try
            {
                // Confirm payment
                InlineResponse20019 result = apiInstance.P2pMerchantTransactionConfirmPayment(confirmPayment);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2pApi.P2pMerchantTransactionConfirmPayment: " + e.Message);
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
 **confirmPayment** | [**ConfirmPayment**](ConfirmPayment.md)|  | 

### Return type

[**InlineResponse20019**](InlineResponse20019.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="p2pmerchanttransactionconfirmreceipt"></a>
# **P2pMerchantTransactionConfirmReceipt**
> InlineResponse20019 P2pMerchantTransactionConfirmReceipt (ConfirmReceipt confirmReceipt)

Confirm receipt

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class P2pMerchantTransactionConfirmReceiptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new P2pApi(config);
            var confirmReceipt = new ConfirmReceipt(); // ConfirmReceipt | 

            try
            {
                // Confirm receipt
                InlineResponse20019 result = apiInstance.P2pMerchantTransactionConfirmReceipt(confirmReceipt);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2pApi.P2pMerchantTransactionConfirmReceipt: " + e.Message);
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
 **confirmReceipt** | [**ConfirmReceipt**](ConfirmReceipt.md)|  | 

### Return type

[**InlineResponse20019**](InlineResponse20019.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="p2pmerchanttransactioncancel"></a>
# **P2pMerchantTransactionCancel**
> InlineResponse20019 P2pMerchantTransactionCancel (CancelOrder cancelOrder)

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
    public class P2pMerchantTransactionCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new P2pApi(config);
            var cancelOrder = new CancelOrder(); // CancelOrder | 

            try
            {
                // Cancel order
                InlineResponse20019 result = apiInstance.P2pMerchantTransactionCancel(cancelOrder);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2pApi.P2pMerchantTransactionCancel: " + e.Message);
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
 **cancelOrder** | [**CancelOrder**](CancelOrder.md)|  | 

### Return type

[**InlineResponse20019**](InlineResponse20019.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="p2pmerchantbooksplacebizpushorder"></a>
# **P2pMerchantBooksPlaceBizPushOrder**
> Object P2pMerchantBooksPlaceBizPushOrder (PlaceBizPushOrder placeBizPushOrder)

Publish ad order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class P2pMerchantBooksPlaceBizPushOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new P2pApi(config);
            var placeBizPushOrder = new PlaceBizPushOrder(); // PlaceBizPushOrder | 

            try
            {
                // Publish ad order
                Object result = apiInstance.P2pMerchantBooksPlaceBizPushOrder(placeBizPushOrder);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2pApi.P2pMerchantBooksPlaceBizPushOrder: " + e.Message);
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
 **placeBizPushOrder** | [**PlaceBizPushOrder**](PlaceBizPushOrder.md)|  | 

### Return type

**Object**

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="p2pmerchantbooksadsupdatestatus"></a>
# **P2pMerchantBooksAdsUpdateStatus**
> InlineResponse20020 P2pMerchantBooksAdsUpdateStatus (AdsUpdateStatus adsUpdateStatus, string tradeType = null)

Update ad status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class P2pMerchantBooksAdsUpdateStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new P2pApi(config);
            var adsUpdateStatus = new AdsUpdateStatus(); // AdsUpdateStatus | 
            var tradeType = "sell";  // string | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME <EMAIL@ADDRESS> Language: en Language-Team: en <L@li.org> Plural-Forms: nplurals=2; plural=(n !=1) MIME-Version: 1.0 Content-Type: text/plain; charset=utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  (optional) 

            try
            {
                // Update ad status
                InlineResponse20020 result = apiInstance.P2pMerchantBooksAdsUpdateStatus(adsUpdateStatus, tradeType);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2pApi.P2pMerchantBooksAdsUpdateStatus: " + e.Message);
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
 **adsUpdateStatus** | [**AdsUpdateStatus**](AdsUpdateStatus.md)|  | 
 **tradeType** | **string**| Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  | [optional] 

### Return type

[**InlineResponse20020**](InlineResponse20020.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="p2pmerchantbooksadsdetail"></a>
# **P2pMerchantBooksAdsDetail**
> InlineResponse20021 P2pMerchantBooksAdsDetail (AdsDetailRequest adsDetailRequest)

Query ad details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class P2pMerchantBooksAdsDetailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new P2pApi(config);
            var adsDetailRequest = new AdsDetailRequest(); // AdsDetailRequest | 

            try
            {
                // Query ad details
                InlineResponse20021 result = apiInstance.P2pMerchantBooksAdsDetail(adsDetailRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2pApi.P2pMerchantBooksAdsDetail: " + e.Message);
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
 **adsDetailRequest** | [**AdsDetailRequest**](AdsDetailRequest.md)|  | 

### Return type

[**InlineResponse20021**](InlineResponse20021.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="p2pmerchantbooksmyadslist"></a>
# **P2pMerchantBooksMyAdsList**
> InlineResponse20022 P2pMerchantBooksMyAdsList (MyAdsListRequest myAdsListRequest = null)

Get my ad list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class P2pMerchantBooksMyAdsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new P2pApi(config);
            var myAdsListRequest = new MyAdsListRequest(); // MyAdsListRequest |  (optional) 

            try
            {
                // Get my ad list
                InlineResponse20022 result = apiInstance.P2pMerchantBooksMyAdsList(myAdsListRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2pApi.P2pMerchantBooksMyAdsList: " + e.Message);
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
 **myAdsListRequest** | [**MyAdsListRequest**](MyAdsListRequest.md)|  | [optional] 

### Return type

[**InlineResponse20022**](InlineResponse20022.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="p2pmerchantbooksadslist"></a>
# **P2pMerchantBooksAdsList**
> InlineResponse20023 P2pMerchantBooksAdsList (AdsListRequest adsListRequest)

Get Advertisement List

Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME <EMAIL@ADDRESS> Language: en Language-Team: en <L@li.org> Plural-Forms: nplurals=2; plural=(n !=1) MIME-Version: 1.0 Content-Type: text/plain; charset=utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class P2pMerchantBooksAdsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new P2pApi(config);
            var adsListRequest = new AdsListRequest(); // AdsListRequest | 

            try
            {
                // Get Advertisement List
                InlineResponse20023 result = apiInstance.P2pMerchantBooksAdsList(adsListRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2pApi.P2pMerchantBooksAdsList: " + e.Message);
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
 **adsListRequest** | [**AdsListRequest**](AdsListRequest.md)|  | 

### Return type

[**InlineResponse20023**](InlineResponse20023.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="p2pmerchantchatgetchatslist"></a>
# **P2pMerchantChatGetChatsList**
> InlineResponse20024 P2pMerchantChatGetChatsList (GetChatsListRequest getChatsListRequest)

Get chat history

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class P2pMerchantChatGetChatsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new P2pApi(config);
            var getChatsListRequest = new GetChatsListRequest(); // GetChatsListRequest | 

            try
            {
                // Get chat history
                InlineResponse20024 result = apiInstance.P2pMerchantChatGetChatsList(getChatsListRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2pApi.P2pMerchantChatGetChatsList: " + e.Message);
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
 **getChatsListRequest** | [**GetChatsListRequest**](GetChatsListRequest.md)|  | 

### Return type

[**InlineResponse20024**](InlineResponse20024.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="p2pmerchantchatsendchatmessage"></a>
# **P2pMerchantChatSendChatMessage**
> InlineResponse20025 P2pMerchantChatSendChatMessage (SendChatMessageRequest sendChatMessageRequest)

Send text message

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class P2pMerchantChatSendChatMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new P2pApi(config);
            var sendChatMessageRequest = new SendChatMessageRequest(); // SendChatMessageRequest | 

            try
            {
                // Send text message
                InlineResponse20025 result = apiInstance.P2pMerchantChatSendChatMessage(sendChatMessageRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2pApi.P2pMerchantChatSendChatMessage: " + e.Message);
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
 **sendChatMessageRequest** | [**SendChatMessageRequest**](SendChatMessageRequest.md)|  | 

### Return type

[**InlineResponse20025**](InlineResponse20025.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="p2pmerchantchatuploadchatfile"></a>
# **P2pMerchantChatUploadChatFile**
> InlineResponse20026 P2pMerchantChatUploadChatFile (UploadChatFile uploadChatFile)

Upload chat file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class P2pMerchantChatUploadChatFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new P2pApi(config);
            var uploadChatFile = new UploadChatFile(); // UploadChatFile | 

            try
            {
                // Upload chat file
                InlineResponse20026 result = apiInstance.P2pMerchantChatUploadChatFile(uploadChatFile);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2pApi.P2pMerchantChatUploadChatFile: " + e.Message);
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
 **uploadChatFile** | [**UploadChatFile**](UploadChatFile.md)|  | 

### Return type

[**InlineResponse20026**](InlineResponse20026.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

