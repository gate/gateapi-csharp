# Io.Gate.GateApi.Api.P2PApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**P2pMerchantAccountGetUserInfo**](P2PApi.md#p2pmerchantaccountgetuserinfo) | **POST** /p2p/merchant/account/get_user_info | Get account information
[**P2pMerchantAccountGetCounterpartyUserInfo**](P2PApi.md#p2pmerchantaccountgetcounterpartyuserinfo) | **POST** /p2p/merchant/account/get_counterparty_user_info | Get counterparty information
[**P2pMerchantAccountGetMyselfPayment**](P2PApi.md#p2pmerchantaccountgetmyselfpayment) | **POST** /p2p/merchant/account/get_myself_payment | Get payment method list
[**P2pMerchantTransactionGetPendingTransactionList**](P2PApi.md#p2pmerchanttransactiongetpendingtransactionlist) | **POST** /p2p/merchant/transaction/get_pending_transaction_list | Get pending orders
[**P2pMerchantTransactionGetCompletedTransactionList**](P2PApi.md#p2pmerchanttransactiongetcompletedtransactionlist) | **POST** /p2p/merchant/transaction/get_completed_transaction_list | Get all/historical orders
[**P2pMerchantTransactionGetTransactionDetails**](P2PApi.md#p2pmerchanttransactiongettransactiondetails) | **POST** /p2p/merchant/transaction/get_transaction_details | Query order details
[**P2pMerchantTransactionConfirmPayment**](P2PApi.md#p2pmerchanttransactionconfirmpayment) | **POST** /p2p/merchant/transaction/confirm-payment | Confirm payment
[**P2pMerchantTransactionConfirmReceipt**](P2PApi.md#p2pmerchanttransactionconfirmreceipt) | **POST** /p2p/merchant/transaction/confirm-receipt | Confirm receipt
[**P2pMerchantTransactionCancel**](P2PApi.md#p2pmerchanttransactioncancel) | **POST** /p2p/merchant/transaction/cancel | Cancel order
[**P2pMerchantBooksPlaceBizPushOrder**](P2PApi.md#p2pmerchantbooksplacebizpushorder) | **POST** /p2p/merchant/books/place_biz_push_order | Publish ad order
[**P2pMerchantBooksAdsUpdateStatus**](P2PApi.md#p2pmerchantbooksadsupdatestatus) | **POST** /p2p/merchant/books/ads_update_status | Update ad status
[**P2pMerchantBooksAdsDetail**](P2PApi.md#p2pmerchantbooksadsdetail) | **POST** /p2p/merchant/books/ads_detail | Query ad details
[**P2pMerchantBooksMyAdsList**](P2PApi.md#p2pmerchantbooksmyadslist) | **POST** /p2p/merchant/books/my_ads_list | Get my ad list
[**P2pMerchantChatGetChatsList**](P2PApi.md#p2pmerchantchatgetchatslist) | **POST** /p2p/merchant/chat/get_chats_list | Get chat history
[**P2pMerchantChatSendChatMessage**](P2PApi.md#p2pmerchantchatsendchatmessage) | **POST** /p2p/merchant/chat/send_chat_message | Send text message
[**P2pMerchantChatUploadChatFile**](P2PApi.md#p2pmerchantchatuploadchatfile) | **POST** /p2p/merchant/chat/upload_chat_file | Upload chat file


<a name="p2pmerchantaccountgetuserinfo"></a>
# **P2pMerchantAccountGetUserInfo**
> InlineResponse20013 P2pMerchantAccountGetUserInfo ()

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
            var apiInstance = new P2PApi(config);

            try
            {
                // Get account information
                InlineResponse20013 result = apiInstance.P2pMerchantAccountGetUserInfo();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2PApi.P2pMerchantAccountGetUserInfo: " + e.Message);
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

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

No authorization required

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
> InlineResponse20014 P2pMerchantAccountGetCounterpartyUserInfo (string bizUid)

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
            var apiInstance = new P2PApi(config);
            var bizUid = "bizUid_example";  // string | Counterparty UID (encrypted)

            try
            {
                // Get counterparty information
                InlineResponse20014 result = apiInstance.P2pMerchantAccountGetCounterpartyUserInfo(bizUid);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2PApi.P2pMerchantAccountGetCounterpartyUserInfo: " + e.Message);
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
 **bizUid** | **string**| Counterparty UID (encrypted) | 

### Return type

[**InlineResponse20014**](InlineResponse20014.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="p2pmerchantaccountgetmyselfpayment"></a>
# **P2pMerchantAccountGetMyselfPayment**
> InlineResponse20015 P2pMerchantAccountGetMyselfPayment (string fiat = null)

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
            var apiInstance = new P2PApi(config);
            var fiat = "fiat_example";  // string | Fiat currency (optional) 

            try
            {
                // Get payment method list
                InlineResponse20015 result = apiInstance.P2pMerchantAccountGetMyselfPayment(fiat);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2PApi.P2pMerchantAccountGetMyselfPayment: " + e.Message);
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
 **fiat** | **string**| Fiat currency | [optional] 

### Return type

[**InlineResponse20015**](InlineResponse20015.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="p2pmerchanttransactiongetpendingtransactionlist"></a>
# **P2pMerchantTransactionGetPendingTransactionList**
> InlineResponse20016 P2pMerchantTransactionGetPendingTransactionList (string cryptoCurrency, string fiatCurrency, string orderTab = null, string selectType = null, string status = null, int? txid = null, int? startTime = null, int? endTime = null)

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
            var apiInstance = new P2PApi(config);
            var cryptoCurrency = "cryptoCurrency_example";  // string | Cryptocurrency
            var fiatCurrency = "fiatCurrency_example";  // string | Fiat currency
            var orderTab = "orderTab_example";  // string | Order tab, default is pending (pending: Processing (pending: AND status in ('OPEN',  'PAID', 'LOCKED', 'TEMP')); dispute: In dispute (status in ('ACCEPT',  'BCLOSED', 'CANCEL', 'BECANCEL', 'SCLOSED', 'SCANCEL'))) (optional) 
            var selectType = "selectType_example";  // string | Buy/Sell (sell=Sell, buy=Buy, others=All) (optional) 
            var status = "status_example";  // string | 订单状态（dispute: 申诉订单； closed: ACCEPT、BCLOSED； cancel： CANCEL、BECANCEL、SCLOSED、SCANCEL； locked: LOCKED； open: OPEN； paid： PAID； completed： CANCEL、BECANCEL、SCLOSED、SCANCEL、ACCEPT、BCLOSED） (optional) 
            var txid = 56;  // int? | Order ID (optional) 
            var startTime = 56;  // int? | Start timestamp, default is 00:00 89 days ago (optional) 
            var endTime = 56;  // int? | End timestamp, default is 23:59:59 today (optional) 

            try
            {
                // Get pending orders
                InlineResponse20016 result = apiInstance.P2pMerchantTransactionGetPendingTransactionList(cryptoCurrency, fiatCurrency, orderTab, selectType, status, txid, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2PApi.P2pMerchantTransactionGetPendingTransactionList: " + e.Message);
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
 **cryptoCurrency** | **string**| Cryptocurrency | 
 **fiatCurrency** | **string**| Fiat currency | 
 **orderTab** | **string**| Order tab, default is pending (pending: Processing (pending: AND status in (&#39;OPEN&#39;,  &#39;PAID&#39;, &#39;LOCKED&#39;, &#39;TEMP&#39;)); dispute: In dispute (status in (&#39;ACCEPT&#39;,  &#39;BCLOSED&#39;, &#39;CANCEL&#39;, &#39;BECANCEL&#39;, &#39;SCLOSED&#39;, &#39;SCANCEL&#39;))) | [optional] 
 **selectType** | **string**| Buy/Sell (sell&#x3D;Sell, buy&#x3D;Buy, others&#x3D;All) | [optional] 
 **status** | **string**| 订单状态（dispute: 申诉订单； closed: ACCEPT、BCLOSED； cancel： CANCEL、BECANCEL、SCLOSED、SCANCEL； locked: LOCKED； open: OPEN； paid： PAID； completed： CANCEL、BECANCEL、SCLOSED、SCANCEL、ACCEPT、BCLOSED） | [optional] 
 **txid** | **int?**| Order ID | [optional] 
 **startTime** | **int?**| Start timestamp, default is 00:00 89 days ago | [optional] 
 **endTime** | **int?**| End timestamp, default is 23:59:59 today | [optional] 

### Return type

[**InlineResponse20016**](InlineResponse20016.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="p2pmerchanttransactiongetcompletedtransactionlist"></a>
# **P2pMerchantTransactionGetCompletedTransactionList**
> InlineResponse20016 P2pMerchantTransactionGetCompletedTransactionList (string cryptoCurrency, string fiatCurrency, string selectType = null, string status = null, int? txid = null, int? startTime = null, int? endTime = null, int? queryDispute = null, int? page = null, int? perPage = null)

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
            var apiInstance = new P2PApi(config);
            var cryptoCurrency = "cryptoCurrency_example";  // string | Cryptocurrency
            var fiatCurrency = "fiatCurrency_example";  // string | Fiat currency
            var selectType = "selectType_example";  // string | Buy/Sell (sell=Sell, buy=Buy, others=All) (optional) 
            var status = "status_example";  // string | 订单状态（dispute: 申诉订单； closed: ACCEPT、BCLOSED； cancel： CANCEL、BECANCEL、SCLOSED、SCANCEL； locked: LOCKED； open: OPEN； paid： PAID； completed： CANCEL、BECANCEL、SCLOSED、SCANCEL、ACCEPT、BCLOSED） (optional) 
            var txid = 56;  // int? | Order ID (optional) 
            var startTime = 56;  // int? | Start timestamp, default is 00:00 89 days ago (optional) 
            var endTime = 56;  // int? | End timestamp, default is 23:59:59 today (optional) 
            var queryDispute = 56;  // int? | 1: Include appeal status, 0: None (optional) 
            var page = 56;  // int? | page number (optional) 
            var perPage = 56;  // int? | Number of orders per page (optional) 

            try
            {
                // Get all/historical orders
                InlineResponse20016 result = apiInstance.P2pMerchantTransactionGetCompletedTransactionList(cryptoCurrency, fiatCurrency, selectType, status, txid, startTime, endTime, queryDispute, page, perPage);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2PApi.P2pMerchantTransactionGetCompletedTransactionList: " + e.Message);
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
 **cryptoCurrency** | **string**| Cryptocurrency | 
 **fiatCurrency** | **string**| Fiat currency | 
 **selectType** | **string**| Buy/Sell (sell&#x3D;Sell, buy&#x3D;Buy, others&#x3D;All) | [optional] 
 **status** | **string**| 订单状态（dispute: 申诉订单； closed: ACCEPT、BCLOSED； cancel： CANCEL、BECANCEL、SCLOSED、SCANCEL； locked: LOCKED； open: OPEN； paid： PAID； completed： CANCEL、BECANCEL、SCLOSED、SCANCEL、ACCEPT、BCLOSED） | [optional] 
 **txid** | **int?**| Order ID | [optional] 
 **startTime** | **int?**| Start timestamp, default is 00:00 89 days ago | [optional] 
 **endTime** | **int?**| End timestamp, default is 23:59:59 today | [optional] 
 **queryDispute** | **int?**| 1: Include appeal status, 0: None | [optional] 
 **page** | **int?**| page number | [optional] 
 **perPage** | **int?**| Number of orders per page | [optional] 

### Return type

[**InlineResponse20016**](InlineResponse20016.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="p2pmerchanttransactiongettransactiondetails"></a>
# **P2pMerchantTransactionGetTransactionDetails**
> InlineResponse20017 P2pMerchantTransactionGetTransactionDetails (int txid, string channel = null)

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
            var apiInstance = new P2PApi(config);
            var txid = 56;  // int | Order ID
            var channel = "channel_example";  // string | Empty or web3 (optional) 

            try
            {
                // Query order details
                InlineResponse20017 result = apiInstance.P2pMerchantTransactionGetTransactionDetails(txid, channel);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2PApi.P2pMerchantTransactionGetTransactionDetails: " + e.Message);
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
 **txid** | **int**| Order ID | 
 **channel** | **string**| Empty or web3 | [optional] 

### Return type

[**InlineResponse20017**](InlineResponse20017.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="p2pmerchanttransactionconfirmpayment"></a>
# **P2pMerchantTransactionConfirmPayment**
> InlineResponse2007 P2pMerchantTransactionConfirmPayment (InlineObject10 inlineObject10 = null)

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
            var apiInstance = new P2PApi(config);
            var inlineObject10 = new InlineObject10(); // InlineObject10 |  (optional) 

            try
            {
                // Confirm payment
                InlineResponse2007 result = apiInstance.P2pMerchantTransactionConfirmPayment(inlineObject10);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2PApi.P2pMerchantTransactionConfirmPayment: " + e.Message);
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
 **inlineObject10** | [**InlineObject10**](InlineObject10.md)|  | [optional] 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

No authorization required

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
> InlineResponse2007 P2pMerchantTransactionConfirmReceipt (InlineObject11 inlineObject11 = null)

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
            var apiInstance = new P2PApi(config);
            var inlineObject11 = new InlineObject11(); // InlineObject11 |  (optional) 

            try
            {
                // Confirm receipt
                InlineResponse2007 result = apiInstance.P2pMerchantTransactionConfirmReceipt(inlineObject11);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2PApi.P2pMerchantTransactionConfirmReceipt: " + e.Message);
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
 **inlineObject11** | [**InlineObject11**](InlineObject11.md)|  | [optional] 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

No authorization required

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
> InlineResponse2007 P2pMerchantTransactionCancel (InlineObject12 inlineObject12 = null)

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
            var apiInstance = new P2PApi(config);
            var inlineObject12 = new InlineObject12(); // InlineObject12 |  (optional) 

            try
            {
                // Cancel order
                InlineResponse2007 result = apiInstance.P2pMerchantTransactionCancel(inlineObject12);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2PApi.P2pMerchantTransactionCancel: " + e.Message);
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
 **inlineObject12** | [**InlineObject12**](InlineObject12.md)|  | [optional] 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

No authorization required

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
> Object P2pMerchantBooksPlaceBizPushOrder (string currencyType, string exchangeType, string type, string unitPrice, string number, string minAmount, string maxAmount, string payType = null, string payTypeJson = null, string rateFixed = null, string oid = null, string tierLimit = null, string verifiedLimit = null, string regTimeLimit = null, string advertisersLimit = null, string hidePayment = null, string expireMin = null, string tradeTips = null, string autoReply = null, string minCompletedLimit = null, string maxCompletedLimit = null, string completedRateLimit = null, string userCountryLimit = null, string userOrderLimit = null, string rateReferenceId = null, string rateOffset = null, string floatTrend = null)

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
            var apiInstance = new P2PApi(config);
            var currencyType = "currencyType_example";  // string | Cryptocurrency
            var exchangeType = "exchangeType_example";  // string | Fiat currency
            var type = "type_example";  // string | Ad type: 0=Sell, 1=Buy, 2=Edit sell, 3=Edit buy
            var unitPrice = "unitPrice_example";  // string | Unit price
            var number = "number_example";  // string | Size
            var minAmount = "minAmount_example";  // string | Minimum transaction amount per order
            var maxAmount = "maxAmount_example";  // string | Maximum transaction amount per order
            var payType = "payType_example";  // string | Payment method (optional) 
            var payTypeJson = "payTypeJson_example";  // string | Payment method JSON string (optional) 
            var rateFixed = "rateFixed_example";  // string | Price type: 0-Floating price, 1-Fixed price (optional) 
            var oid = "oid_example";  // string | Ad ID when editing (optional) 
            var tierLimit = "tierLimit_example";  // string | Order tier limit (optional) 
            var verifiedLimit = "verifiedLimit_example";  // string | Verification level limit (optional) 
            var regTimeLimit = "regTimeLimit_example";  // string | Registration time limit (optional) 
            var advertisersLimit = "advertisersLimit_example";  // string | Advertiser restriction (optional) 
            var hidePayment = "hidePayment_example";  // string | Whether to hide payment method: 1=Yes, 0=No (optional) 
            var expireMin = "expireMin_example";  // string | Ad expiration time (minutes) (optional) 
            var tradeTips = "tradeTips_example";  // string | Trading terms (optional) 
            var autoReply = "autoReply_example";  // string | Auto reply (optional) 
            var minCompletedLimit = "minCompletedLimit_example";  // string | Minimum limit of completed orders (optional) 
            var maxCompletedLimit = "maxCompletedLimit_example";  // string | Maximum limit of completed orders (optional) 
            var completedRateLimit = "completedRateLimit_example";  // string | 30-day completion rate limit (optional) 
            var userCountryLimit = "userCountryLimit_example";  // string | KYC nationality restriction (optional) 
            var userOrderLimit = "userOrderLimit_example";  // string | Order count limit (optional) 
            var rateReferenceId = "rateReferenceId_example";  // string | Reference exchange rate ID (optional) 
            var rateOffset = "rateOffset_example";  // string | Reference exchange rate offset (optional) 
            var floatTrend = "floatTrend_example";  // string | 444 (optional) 

            try
            {
                // Publish ad order
                Object result = apiInstance.P2pMerchantBooksPlaceBizPushOrder(currencyType, exchangeType, type, unitPrice, number, minAmount, maxAmount, payType, payTypeJson, rateFixed, oid, tierLimit, verifiedLimit, regTimeLimit, advertisersLimit, hidePayment, expireMin, tradeTips, autoReply, minCompletedLimit, maxCompletedLimit, completedRateLimit, userCountryLimit, userOrderLimit, rateReferenceId, rateOffset, floatTrend);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2PApi.P2pMerchantBooksPlaceBizPushOrder: " + e.Message);
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
 **currencyType** | **string**| Cryptocurrency | 
 **exchangeType** | **string**| Fiat currency | 
 **type** | **string**| Ad type: 0&#x3D;Sell, 1&#x3D;Buy, 2&#x3D;Edit sell, 3&#x3D;Edit buy | 
 **unitPrice** | **string**| Unit price | 
 **number** | **string**| Size | 
 **minAmount** | **string**| Minimum transaction amount per order | 
 **maxAmount** | **string**| Maximum transaction amount per order | 
 **payType** | **string**| Payment method | [optional] 
 **payTypeJson** | **string**| Payment method JSON string | [optional] 
 **rateFixed** | **string**| Price type: 0-Floating price, 1-Fixed price | [optional] 
 **oid** | **string**| Ad ID when editing | [optional] 
 **tierLimit** | **string**| Order tier limit | [optional] 
 **verifiedLimit** | **string**| Verification level limit | [optional] 
 **regTimeLimit** | **string**| Registration time limit | [optional] 
 **advertisersLimit** | **string**| Advertiser restriction | [optional] 
 **hidePayment** | **string**| Whether to hide payment method: 1&#x3D;Yes, 0&#x3D;No | [optional] 
 **expireMin** | **string**| Ad expiration time (minutes) | [optional] 
 **tradeTips** | **string**| Trading terms | [optional] 
 **autoReply** | **string**| Auto reply | [optional] 
 **minCompletedLimit** | **string**| Minimum limit of completed orders | [optional] 
 **maxCompletedLimit** | **string**| Maximum limit of completed orders | [optional] 
 **completedRateLimit** | **string**| 30-day completion rate limit | [optional] 
 **userCountryLimit** | **string**| KYC nationality restriction | [optional] 
 **userOrderLimit** | **string**| Order count limit | [optional] 
 **rateReferenceId** | **string**| Reference exchange rate ID | [optional] 
 **rateOffset** | **string**| Reference exchange rate offset | [optional] 
 **floatTrend** | **string**| 444 | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="p2pmerchantbooksadsupdatestatus"></a>
# **P2pMerchantBooksAdsUpdateStatus**
> InlineResponse20018 P2pMerchantBooksAdsUpdateStatus (int advNo, int advStatus, string tradeType = null)

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
            var apiInstance = new P2PApi(config);
            var advNo = 56;  // int | Ad ID
            var advStatus = 56;  // int | Ad status: 1=Active, 3=Inactive, 4=Closed
            var tradeType = "sell";  // string | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME <EMAIL@ADDRESS> Language: en Language-Team: en <L@li.org> Plural-Forms: nplurals=2; plural=(n !=1) MIME-Version: 1.0 Content-Type: text/plain; charset=utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  (optional) 

            try
            {
                // Update ad status
                InlineResponse20018 result = apiInstance.P2pMerchantBooksAdsUpdateStatus(advNo, advStatus, tradeType);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2PApi.P2pMerchantBooksAdsUpdateStatus: " + e.Message);
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
 **advNo** | **int**| Ad ID | 
 **advStatus** | **int**| Ad status: 1&#x3D;Active, 3&#x3D;Inactive, 4&#x3D;Closed | 
 **tradeType** | **string**| Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  | [optional] 

### Return type

[**InlineResponse20018**](InlineResponse20018.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="p2pmerchantbooksadsdetail"></a>
# **P2pMerchantBooksAdsDetail**
> InlineResponse20019 P2pMerchantBooksAdsDetail (string advNo, int?  = null)

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
            var apiInstance = new P2PApi(config);
            var advNo = "advNo_example";  // string | 
            var  = 56;  // int? | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME <EMAIL@ADDRESS> Language: en Language-Team: en <L@li.org> Plural-Forms: nplurals=2; plural=(n !=1) MIME-Version: 1.0 Content-Type: text/plain; charset=utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  (optional) 

            try
            {
                // Query ad details
                InlineResponse20019 result = apiInstance.P2pMerchantBooksAdsDetail(advNo, );
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2PApi.P2pMerchantBooksAdsDetail: " + e.Message);
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
 **advNo** | **string**|  | 
 **** | **int?**| Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  | [optional] 

### Return type

[**InlineResponse20019**](InlineResponse20019.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="p2pmerchantbooksmyadslist"></a>
# **P2pMerchantBooksMyAdsList**
> InlineResponse20020 P2pMerchantBooksMyAdsList (string asset = null, string fiatUnit = null, string tradeType = null)

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
            var apiInstance = new P2PApi(config);
            var asset = "asset_example";  // string | Cryptocurrency (optional) 
            var fiatUnit = "fiatUnit_example";  // string | Fiat currency (optional) 
            var tradeType = "tradeType_example";  // string | Buy/Sell (optional) 

            try
            {
                // Get my ad list
                InlineResponse20020 result = apiInstance.P2pMerchantBooksMyAdsList(asset, fiatUnit, tradeType);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2PApi.P2pMerchantBooksMyAdsList: " + e.Message);
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
 **asset** | **string**| Cryptocurrency | [optional] 
 **fiatUnit** | **string**| Fiat currency | [optional] 
 **tradeType** | **string**| Buy/Sell | [optional] 

### Return type

[**InlineResponse20020**](InlineResponse20020.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="p2pmerchantchatgetchatslist"></a>
# **P2pMerchantChatGetChatsList**
> InlineResponse20021 P2pMerchantChatGetChatsList (int txid, int? lastreceived = null, int? firstreceived = null)

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
            var apiInstance = new P2PApi(config);
            var txid = 56;  // int | Order ID
            var lastreceived = 56;  // int? | Pagination timestamp (forward) (optional) 
            var firstreceived = 56;  // int? | Pagination timestamp (backward) (optional) 

            try
            {
                // Get chat history
                InlineResponse20021 result = apiInstance.P2pMerchantChatGetChatsList(txid, lastreceived, firstreceived);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2PApi.P2pMerchantChatGetChatsList: " + e.Message);
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
 **txid** | **int**| Order ID | 
 **lastreceived** | **int?**| Pagination timestamp (forward) | [optional] 
 **firstreceived** | **int?**| Pagination timestamp (backward) | [optional] 

### Return type

[**InlineResponse20021**](InlineResponse20021.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="p2pmerchantchatsendchatmessage"></a>
# **P2pMerchantChatSendChatMessage**
> InlineResponse20022 P2pMerchantChatSendChatMessage (int txid, string message, int? type = null)

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
            var apiInstance = new P2PApi(config);
            var txid = 56;  // int | Order ID
            var message = "message_example";  // string | Message content
            var type = 56;  // int? | 0=Text, 1=File (video or image), default is 0 if not provided (optional) 

            try
            {
                // Send text message
                InlineResponse20022 result = apiInstance.P2pMerchantChatSendChatMessage(txid, message, type);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2PApi.P2pMerchantChatSendChatMessage: " + e.Message);
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
 **txid** | **int**| Order ID | 
 **message** | **string**| Message content | 
 **type** | **int?**| 0&#x3D;Text, 1&#x3D;File (video or image), default is 0 if not provided | [optional] 

### Return type

[**InlineResponse20022**](InlineResponse20022.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="p2pmerchantchatuploadchatfile"></a>
# **P2pMerchantChatUploadChatFile**
> InlineResponse20023 P2pMerchantChatUploadChatFile (string imageContentType, string base64Img)

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
            var apiInstance = new P2PApi(config);
            var imageContentType = "imageContentType_example";  // string | File type, currently only images and videos are supported
            var base64Img = "base64Img_example";  // string | File content (base64 encoded)

            try
            {
                // Upload chat file
                InlineResponse20023 result = apiInstance.P2pMerchantChatUploadChatFile(imageContentType, base64Img);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling P2PApi.P2pMerchantChatUploadChatFile: " + e.Message);
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
 **imageContentType** | **string**| File type, currently only images and videos are supported | 
 **base64Img** | **string**| File content (base64 encoded) | 

### Return type

[**InlineResponse20023**](InlineResponse20023.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Project-Id-Version: GateApiTools 1.0.0 Report-Msgid-Bugs-To: EMAIL@ADDRESS POT-Creation-Date: 2025-11-12 18:14+0800 PO-Revision-Date: 2019-01-02 17:30+0800 Last-Translator: FULL NAME &lt;EMAIL@ADDRESS&gt; Language: en Language-Team: en &lt;L@li.org&gt; Plural-Forms: nplurals&#x3D;2; plural&#x3D;(n !&#x3D;1) MIME-Version: 1.0 Content-Type: text/plain; charset&#x3D;utf-8 Content-Transfer-Encoding: 8bit Generated-By: Babel 2.8.0  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

