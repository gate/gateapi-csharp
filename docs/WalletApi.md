# Io.Gate.GateApi.Api.WalletApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListCurrencyChains**](WalletApi.md#listcurrencychains) | **GET** /wallet/currency_chains | Query chains supported for specified currency
[**GetDepositAddress**](WalletApi.md#getdepositaddress) | **GET** /wallet/deposit_address | Generate currency deposit address
[**ListWithdrawals**](WalletApi.md#listwithdrawals) | **GET** /wallet/withdrawals | Get withdrawal records
[**ListDeposits**](WalletApi.md#listdeposits) | **GET** /wallet/deposits | Get deposit records
[**Transfer**](WalletApi.md#transfer) | **POST** /wallet/transfers | Transfer between trading accounts
[**ListSubAccountTransfers**](WalletApi.md#listsubaccounttransfers) | **GET** /wallet/sub_account_transfers | Get transfer records between main and sub accounts
[**TransferWithSubAccount**](WalletApi.md#transferwithsubaccount) | **POST** /wallet/sub_account_transfers | Transfer between main and sub accounts
[**SubAccountToSubAccount**](WalletApi.md#subaccounttosubaccount) | **POST** /wallet/sub_account_to_sub_account | Transfer between sub-accounts
[**GetTransferOrderStatus**](WalletApi.md#gettransferorderstatus) | **GET** /wallet/order_status | Main-Sub Account Transfer Status Query
[**ListWithdrawStatus**](WalletApi.md#listwithdrawstatus) | **GET** /wallet/withdraw_status | Query withdrawal status
[**ListSubAccountBalances**](WalletApi.md#listsubaccountbalances) | **GET** /wallet/sub_account_balances | Query sub-account balance information
[**ListSubAccountMarginBalances**](WalletApi.md#listsubaccountmarginbalances) | **GET** /wallet/sub_account_margin_balances | Query sub-account isolated margin account balance information
[**ListSubAccountFuturesBalances**](WalletApi.md#listsubaccountfuturesbalances) | **GET** /wallet/sub_account_futures_balances | Query sub-account perpetual futures account balance information
[**ListSubAccountCrossMarginBalances**](WalletApi.md#listsubaccountcrossmarginbalances) | **GET** /wallet/sub_account_cross_margin_balances | Query sub-account cross margin account balance information
[**ListSavedAddress**](WalletApi.md#listsavedaddress) | **GET** /wallet/saved_address | Query withdrawal address whitelist
[**GetTradeFee**](WalletApi.md#gettradefee) | **GET** /wallet/fee | Query personal trading fees
[**GetTotalBalance**](WalletApi.md#gettotalbalance) | **GET** /wallet/total_balance | Query personal account totals
[**ListSmallBalance**](WalletApi.md#listsmallbalance) | **GET** /wallet/small_balance | Get list of convertible small balance currencies
[**ConvertSmallBalance**](WalletApi.md#convertsmallbalance) | **POST** /wallet/small_balance | Convert small balance currency
[**ListSmallBalanceHistory**](WalletApi.md#listsmallbalancehistory) | **GET** /wallet/small_balance_history | Get convertible small balance currency history
[**ListPushOrders**](WalletApi.md#listpushorders) | **GET** /wallet/push | Get UID transfer history
[**GetLowCapExchangeList**](WalletApi.md#getlowcapexchangelist) | **GET** /wallet/getLowCapExchangeList | Retrieve the list of low-liquidity or low-cap tokens


<a name="listcurrencychains"></a>
# **ListCurrencyChains**
> List&lt;CurrencyChain&gt; ListCurrencyChains (string currency)

Query chains supported for specified currency

API operations are not supported for tokens with low liquidity or extremely low value. Please use the Web or App interface to query and process.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListCurrencyChainsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new WalletApi(config);
            var currency = "GT";  // string | Currency name

            try
            {
                // Query chains supported for specified currency
                List<CurrencyChain> result = apiInstance.ListCurrencyChains(currency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.ListCurrencyChains: " + e.Message);
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
 **currency** | **string**| Currency name | 

### Return type

[**List&lt;CurrencyChain&gt;**](CurrencyChain.md)

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

<a name="getdepositaddress"></a>
# **GetDepositAddress**
> DepositAddress GetDepositAddress (string currency)

Generate currency deposit address

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetDepositAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var currency = "USDT";  // string | Currency name

            try
            {
                // Generate currency deposit address
                DepositAddress result = apiInstance.GetDepositAddress(currency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.GetDepositAddress: " + e.Message);
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
 **currency** | **string**| Currency name | 

### Return type

[**DepositAddress**](DepositAddress.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Address successfully generated |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listwithdrawals"></a>
# **ListWithdrawals**
> List&lt;WithdrawalRecord&gt; ListWithdrawals (string currency = null, string withdrawId = null, string assetClass = null, string withdrawOrderId = null, long? from = null, long? to = null, int? limit = null, int? offset = null)

Get withdrawal records

Record query time range cannot exceed 30 days

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListWithdrawalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var currency = "BTC";  // string | Specify the currency. If not specified, returns all currencies (optional) 
            var withdrawId = "withdrawId_example";  // string | Withdrawal record ID starts with 'w', such as: w1879219868. When withdraw_id is not empty, only this specific withdrawal record will be queried, and time-based querying will be disabled (optional) 
            var assetClass = "assetClass_example";  // string | Currency type of withdrawal record, empty by default. Supports querying withdrawal records in main zone and innovation zone on demand. Value range: SPOT, PILOT  SPOT: Main Zone PILOT: Innovation Zone (optional) 
            var withdrawOrderId = "withdrawOrderId_example";  // string | User-defined order number for withdrawal. Default is empty. When not empty, the specified user-defined order number record will be queried (optional) 
            var from = 1602120000;  // long? | Start time for querying records. If not specified, defaults to 7 days before current time (optional) 
            var to = 1602123600;  // long? | End timestamp for the query, defaults to current time if not specified (optional) 
            var limit = 100;  // int? | Maximum number of records returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)

            try
            {
                // Get withdrawal records
                List<WithdrawalRecord> result = apiInstance.ListWithdrawals(currency, withdrawId, assetClass, withdrawOrderId, from, to, limit, offset);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.ListWithdrawals: " + e.Message);
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
 **currency** | **string**| Specify the currency. If not specified, returns all currencies | [optional] 
 **withdrawId** | **string**| Withdrawal record ID starts with &#39;w&#39;, such as: w1879219868. When withdraw_id is not empty, only this specific withdrawal record will be queried, and time-based querying will be disabled | [optional] 
 **assetClass** | **string**| Currency type of withdrawal record, empty by default. Supports querying withdrawal records in main zone and innovation zone on demand. Value range: SPOT, PILOT  SPOT: Main Zone PILOT: Innovation Zone | [optional] 
 **withdrawOrderId** | **string**| User-defined order number for withdrawal. Default is empty. When not empty, the specified user-defined order number record will be queried | [optional] 
 **from** | **long?**| Start time for querying records. If not specified, defaults to 7 days before current time | [optional] 
 **to** | **long?**| End timestamp for the query, defaults to current time if not specified | [optional] 
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]

### Return type

[**List&lt;WithdrawalRecord&gt;**](WithdrawalRecord.md)

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

<a name="listdeposits"></a>
# **ListDeposits**
> List&lt;DepositRecord&gt; ListDeposits (string currency = null, long? from = null, long? to = null, int? limit = null, int? offset = null)

Get deposit records

Record query time range cannot exceed 30 days

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListDepositsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var currency = "BTC";  // string | Specify the currency. If not specified, returns all currencies (optional) 
            var from = 1602120000;  // long? | Start time for querying records. If not specified, defaults to 7 days before current time (optional) 
            var to = 1602123600;  // long? | End timestamp for the query, defaults to current time if not specified (optional) 
            var limit = 100;  // int? | Maximum number of entries returned in the list, limited to 500 transactions (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)

            try
            {
                // Get deposit records
                List<DepositRecord> result = apiInstance.ListDeposits(currency, from, to, limit, offset);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.ListDeposits: " + e.Message);
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
 **currency** | **string**| Specify the currency. If not specified, returns all currencies | [optional] 
 **from** | **long?**| Start time for querying records. If not specified, defaults to 7 days before current time | [optional] 
 **to** | **long?**| End timestamp for the query, defaults to current time if not specified | [optional] 
 **limit** | **int?**| Maximum number of entries returned in the list, limited to 500 transactions | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]

### Return type

[**List&lt;DepositRecord&gt;**](DepositRecord.md)

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

<a name="transfer"></a>
# **Transfer**
> TransactionID Transfer (Transfer transfer)

Transfer between trading accounts

Balance transfers between personal trading accounts. Currently supports the following transfer operations:  1. Spot account - Margin account 2. Spot account - Perpetual futures account 3. Spot account - Delivery futures account 4. Spot account - Options account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class TransferExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var transfer = new Transfer(); // Transfer | 

            try
            {
                // Transfer between trading accounts
                TransactionID result = apiInstance.Transfer(transfer);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.Transfer: " + e.Message);
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
 **transfer** | [**Transfer**](Transfer.md)|  | 

### Return type

[**TransactionID**](TransactionID.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Transfer operation successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsubaccounttransfers"></a>
# **ListSubAccountTransfers**
> List&lt;SubAccountTransferRecordItem&gt; ListSubAccountTransfers (string subUid = null, long? from = null, long? to = null, int? limit = null, int? offset = null)

Get transfer records between main and sub accounts

Record query time range cannot exceed 30 days  > Note: Only records after 2020-04-10 can be retrieved

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListSubAccountTransfersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var subUid = "10003";  // string | Sub-account user ID, you can query multiple records separated by `,`. If not specified, it will return records of all sub-accounts (optional) 
            var from = 1602120000;  // long? | Start time for querying records. If not specified, defaults to 7 days before current time (optional) 
            var to = 1602123600;  // long? | End timestamp for the query, defaults to current time if not specified (optional) 
            var limit = 100;  // int? | Maximum number of records returned in a single list (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)

            try
            {
                // Get transfer records between main and sub accounts
                List<SubAccountTransferRecordItem> result = apiInstance.ListSubAccountTransfers(subUid, from, to, limit, offset);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.ListSubAccountTransfers: " + e.Message);
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
 **subUid** | **string**| Sub-account user ID, you can query multiple records separated by &#x60;,&#x60;. If not specified, it will return records of all sub-accounts | [optional] 
 **from** | **long?**| Start time for querying records. If not specified, defaults to 7 days before current time | [optional] 
 **to** | **long?**| End timestamp for the query, defaults to current time if not specified | [optional] 
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]

### Return type

[**List&lt;SubAccountTransferRecordItem&gt;**](SubAccountTransferRecordItem.md)

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

<a name="transferwithsubaccount"></a>
# **TransferWithSubAccount**
> TransactionID TransferWithSubAccount (SubAccountTransfer subAccountTransfer)

Transfer between main and sub accounts

Supports transfers to/from sub-account's spot or futures accounts. Note that regardless of which sub-account is operated, only the main account's spot account is used

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class TransferWithSubAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var subAccountTransfer = new SubAccountTransfer(); // SubAccountTransfer | 

            try
            {
                // Transfer between main and sub accounts
                TransactionID result = apiInstance.TransferWithSubAccount(subAccountTransfer);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.TransferWithSubAccount: " + e.Message);
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
 **subAccountTransfer** | [**SubAccountTransfer**](SubAccountTransfer.md)|  | 

### Return type

[**TransactionID**](TransactionID.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Transfer operation successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="subaccounttosubaccount"></a>
# **SubAccountToSubAccount**
> TransactionID SubAccountToSubAccount (SubAccountToSubAccount subAccountToSubAccount)

Transfer between sub-accounts

Supports balance transfers between two sub-accounts under the same main account. You can use either the main account's API Key or the source sub-account's API Key to perform the operation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class SubAccountToSubAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var subAccountToSubAccount = new SubAccountToSubAccount(); // SubAccountToSubAccount | 

            try
            {
                // Transfer between sub-accounts
                TransactionID result = apiInstance.SubAccountToSubAccount(subAccountToSubAccount);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.SubAccountToSubAccount: " + e.Message);
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
 **subAccountToSubAccount** | [**SubAccountToSubAccount**](SubAccountToSubAccount.md)|  | 

### Return type

[**TransactionID**](TransactionID.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Transfer operation successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransferorderstatus"></a>
# **GetTransferOrderStatus**
> TransferOrderStatus GetTransferOrderStatus (string clientOrderId = null, string txId = null)

Main-Sub Account Transfer Status Query

Supports querying Main-Sub Account Transfer Status based on user-defined client_order_id or tx_id returned by the transfer interface

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetTransferOrderStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var clientOrderId = "da3ce7a088c8b0372b741419c7829033";  // string | Customer-defined ID to prevent duplicate transfers. Can be a combination of letters (case-sensitive), numbers, hyphens '-', and underscores '_'. Can be pure letters or pure numbers with length between 1-64 characters (optional) 
            var txId = "59636381286";  // string | Transfer operation number, cannot be empty at the same time as client_order_id (optional) 

            try
            {
                // Main-Sub Account Transfer Status Query
                TransferOrderStatus result = apiInstance.GetTransferOrderStatus(clientOrderId, txId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.GetTransferOrderStatus: " + e.Message);
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
 **clientOrderId** | **string**| Customer-defined ID to prevent duplicate transfers. Can be a combination of letters (case-sensitive), numbers, hyphens &#39;-&#39;, and underscores &#39;_&#39;. Can be pure letters or pure numbers with length between 1-64 characters | [optional] 
 **txId** | **string**| Transfer operation number, cannot be empty at the same time as client_order_id | [optional] 

### Return type

[**TransferOrderStatus**](TransferOrderStatus.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Main-Sub Account Transfer Status Retrieval Successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listwithdrawstatus"></a>
# **ListWithdrawStatus**
> List&lt;WithdrawStatus&gt; ListWithdrawStatus (string currency = null)

Query withdrawal status

API operations are not supported for tokens with low liquidity or extremely low value. Please use the Web or App interface to query and process.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListWithdrawStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var currency = "BTC";  // string | Query by specified currency name (optional) 

            try
            {
                // Query withdrawal status
                List<WithdrawStatus> result = apiInstance.ListWithdrawStatus(currency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.ListWithdrawStatus: " + e.Message);
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

### Return type

[**List&lt;WithdrawStatus&gt;**](WithdrawStatus.md)

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

<a name="listsubaccountbalances"></a>
# **ListSubAccountBalances**
> List&lt;SubAccountBalance&gt; ListSubAccountBalances (string subUid = null)

Query sub-account balance information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListSubAccountBalancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var subUid = "10003";  // string | Sub-account user ID, you can query multiple records separated by `,`. If not specified, it will return records of all sub-accounts (optional) 

            try
            {
                // Query sub-account balance information
                List<SubAccountBalance> result = apiInstance.ListSubAccountBalances(subUid);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.ListSubAccountBalances: " + e.Message);
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
 **subUid** | **string**| Sub-account user ID, you can query multiple records separated by &#x60;,&#x60;. If not specified, it will return records of all sub-accounts | [optional] 

### Return type

[**List&lt;SubAccountBalance&gt;**](SubAccountBalance.md)

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

<a name="listsubaccountmarginbalances"></a>
# **ListSubAccountMarginBalances**
> List&lt;SubAccountMarginBalance&gt; ListSubAccountMarginBalances (string subUid = null)

Query sub-account isolated margin account balance information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListSubAccountMarginBalancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var subUid = "10003";  // string | Sub-account user ID, you can query multiple records separated by `,`. If not specified, it will return records of all sub-accounts (optional) 

            try
            {
                // Query sub-account isolated margin account balance information
                List<SubAccountMarginBalance> result = apiInstance.ListSubAccountMarginBalances(subUid);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.ListSubAccountMarginBalances: " + e.Message);
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
 **subUid** | **string**| Sub-account user ID, you can query multiple records separated by &#x60;,&#x60;. If not specified, it will return records of all sub-accounts | [optional] 

### Return type

[**List&lt;SubAccountMarginBalance&gt;**](SubAccountMarginBalance.md)

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

<a name="listsubaccountfuturesbalances"></a>
# **ListSubAccountFuturesBalances**
> List&lt;SubAccountFuturesBalance&gt; ListSubAccountFuturesBalances (string subUid = null, string settle = null)

Query sub-account perpetual futures account balance information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListSubAccountFuturesBalancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var subUid = "10003";  // string | Sub-account user ID, you can query multiple records separated by `,`. If not specified, it will return records of all sub-accounts (optional) 
            var settle = "usdt";  // string | Query balance of specified settlement currency (optional) 

            try
            {
                // Query sub-account perpetual futures account balance information
                List<SubAccountFuturesBalance> result = apiInstance.ListSubAccountFuturesBalances(subUid, settle);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.ListSubAccountFuturesBalances: " + e.Message);
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
 **subUid** | **string**| Sub-account user ID, you can query multiple records separated by &#x60;,&#x60;. If not specified, it will return records of all sub-accounts | [optional] 
 **settle** | **string**| Query balance of specified settlement currency | [optional] 

### Return type

[**List&lt;SubAccountFuturesBalance&gt;**](SubAccountFuturesBalance.md)

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

<a name="listsubaccountcrossmarginbalances"></a>
# **ListSubAccountCrossMarginBalances**
> List&lt;SubAccountCrossMarginBalance&gt; ListSubAccountCrossMarginBalances (string subUid = null)

Query sub-account cross margin account balance information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListSubAccountCrossMarginBalancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var subUid = "10003";  // string | Sub-account user ID, you can query multiple records separated by `,`. If not specified, it will return records of all sub-accounts (optional) 

            try
            {
                // Query sub-account cross margin account balance information
                List<SubAccountCrossMarginBalance> result = apiInstance.ListSubAccountCrossMarginBalances(subUid);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.ListSubAccountCrossMarginBalances: " + e.Message);
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
 **subUid** | **string**| Sub-account user ID, you can query multiple records separated by &#x60;,&#x60;. If not specified, it will return records of all sub-accounts | [optional] 

### Return type

[**List&lt;SubAccountCrossMarginBalance&gt;**](SubAccountCrossMarginBalance.md)

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

<a name="listsavedaddress"></a>
# **ListSavedAddress**
> List&lt;SavedAddress&gt; ListSavedAddress (string currency, string chain = null, string limit = null, int? page = null)

Query withdrawal address whitelist

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListSavedAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var currency = "USDT";  // string | Currency
            var chain = "\"\"";  // string | Chain name (optional)  (default to "")
            var limit = "\"50\"";  // string | Maximum number returned, up to 100 (optional)  (default to "50")
            var page = 1;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Query withdrawal address whitelist
                List<SavedAddress> result = apiInstance.ListSavedAddress(currency, chain, limit, page);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.ListSavedAddress: " + e.Message);
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
 **currency** | **string**| Currency | 
 **chain** | **string**| Chain name | [optional] [default to &quot;&quot;]
 **limit** | **string**| Maximum number returned, up to 100 | [optional] [default to &quot;50&quot;]
 **page** | **int?**| Page number | [optional] [default to 1]

### Return type

[**List&lt;SavedAddress&gt;**](SavedAddress.md)

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

<a name="gettradefee"></a>
# **GetTradeFee**
> TradeFee GetTradeFee (string currencyPair = null, string settle = null)

Query personal trading fees

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetTradeFeeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var currencyPair = "BTC_USDT";  // string | Specify currency pair to get more accurate fee settings.  This field is optional. Usually fee settings are the same for all currency pairs. (optional) 
            var settle = "BTC";  // string | Specify the settlement currency of the contract to get more accurate fee settings.  This field is optional. Generally, the fee settings for all settlement currencies are the same. (optional) 

            try
            {
                // Query personal trading fees
                TradeFee result = apiInstance.GetTradeFee(currencyPair, settle);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.GetTradeFee: " + e.Message);
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
 **currencyPair** | **string**| Specify currency pair to get more accurate fee settings.  This field is optional. Usually fee settings are the same for all currency pairs. | [optional] 
 **settle** | **string**| Specify the settlement currency of the contract to get more accurate fee settings.  This field is optional. Generally, the fee settings for all settlement currencies are the same. | [optional] 

### Return type

[**TradeFee**](TradeFee.md)

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

<a name="gettotalbalance"></a>
# **GetTotalBalance**
> TotalBalance GetTotalBalance (string currency = null)

Query personal account totals

This query endpoint returns the total *estimated value* of all currencies in each account converted to the input currency. Exchange rates and related account balance information may be cached for up to 1 minute. It is not recommended to use this interface data for real-time calculations.  For real-time calculations, query the corresponding balance interface based on account type, such as:  - `GET /spot/accounts` to query spot account - `GET /margin/accounts` to query margin account - `GET /futures/{settle}/accounts` to query futures account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetTotalBalanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var currency = "\"USDT\"";  // string | Target currency type for statistical conversion. Accepts BTC, CNY, USD, and USDT. USDT is the default value (optional)  (default to "USDT")

            try
            {
                // Query personal account totals
                TotalBalance result = apiInstance.GetTotalBalance(currency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.GetTotalBalance: " + e.Message);
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
 **currency** | **string**| Target currency type for statistical conversion. Accepts BTC, CNY, USD, and USDT. USDT is the default value | [optional] [default to &quot;USDT&quot;]

### Return type

[**TotalBalance**](TotalBalance.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request is valid and successfully returned |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsmallbalance"></a>
# **ListSmallBalance**
> List&lt;SmallBalance&gt; ListSmallBalance ()

Get list of convertible small balance currencies

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListSmallBalanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);

            try
            {
                // Get list of convertible small balance currencies
                List<SmallBalance> result = apiInstance.ListSmallBalance();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.ListSmallBalance: " + e.Message);
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

[**List&lt;SmallBalance&gt;**](SmallBalance.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertsmallbalance"></a>
# **ConvertSmallBalance**
> void ConvertSmallBalance (ConvertSmallBalance convertSmallBalance)

Convert small balance currency

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ConvertSmallBalanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var convertSmallBalance = new ConvertSmallBalance(); // ConvertSmallBalance | 

            try
            {
                // Convert small balance currency
                apiInstance.ConvertSmallBalance(convertSmallBalance);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.ConvertSmallBalance: " + e.Message);
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
 **convertSmallBalance** | [**ConvertSmallBalance**](ConvertSmallBalance.md)|  | 

### Return type

void (empty response body)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsmallbalancehistory"></a>
# **ListSmallBalanceHistory**
> List&lt;SmallBalanceHistory&gt; ListSmallBalanceHistory (string currency = null, int? page = null, int? limit = null)

Get convertible small balance currency history

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListSmallBalanceHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var currency = "currency_example";  // string | Currency to convert (optional) 
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var limit = 100;  // int? | Maximum number of items returned. Default: 100, minimum: 1, maximum: 100 (optional)  (default to 100)

            try
            {
                // Get convertible small balance currency history
                List<SmallBalanceHistory> result = apiInstance.ListSmallBalanceHistory(currency, page, limit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.ListSmallBalanceHistory: " + e.Message);
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
 **currency** | **string**| Currency to convert | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]
 **limit** | **int?**| Maximum number of items returned. Default: 100, minimum: 1, maximum: 100 | [optional] [default to 100]

### Return type

[**List&lt;SmallBalanceHistory&gt;**](SmallBalanceHistory.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpushorders"></a>
# **ListPushOrders**
> List&lt;UidPushOrder&gt; ListPushOrders (int? id = null, int? from = null, int? to = null, int? limit = null, int? offset = null, string transactionType = null)

Get UID transfer history

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListPushOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);
            var id = 56;  // int? | Order ID (optional) 
            var from = 56;  // int? | Start time for querying records. If not specified, defaults to 7 days before the current time. Unix timestamp in seconds (optional) 
            var to = 56;  // int? | End time for querying records. If not specified, defaults to the current time. Unix timestamp in seconds (optional) 
            var limit = 100;  // int? | Maximum number of items returned in the list, default value is 100 (optional)  (default to 100)
            var offset = 0;  // int? | List offset, starting from 0 (optional)  (default to 0)
            var transactionType = "\"withdraw\"";  // string | Order type returned in the list: `withdraw`, `deposit`. Default is `withdraw`. (optional)  (default to "withdraw")

            try
            {
                // Get UID transfer history
                List<UidPushOrder> result = apiInstance.ListPushOrders(id, from, to, limit, offset, transactionType);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.ListPushOrders: " + e.Message);
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
 **id** | **int?**| Order ID | [optional] 
 **from** | **int?**| Start time for querying records. If not specified, defaults to 7 days before the current time. Unix timestamp in seconds | [optional] 
 **to** | **int?**| End time for querying records. If not specified, defaults to the current time. Unix timestamp in seconds | [optional] 
 **limit** | **int?**| Maximum number of items returned in the list, default value is 100 | [optional] [default to 100]
 **offset** | **int?**| List offset, starting from 0 | [optional] [default to 0]
 **transactionType** | **string**| Order type returned in the list: &#x60;withdraw&#x60;, &#x60;deposit&#x60;. Default is &#x60;withdraw&#x60;. | [optional] [default to &quot;withdraw&quot;]

### Return type

[**List&lt;UidPushOrder&gt;**](UidPushOrder.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlowcapexchangelist"></a>
# **GetLowCapExchangeList**
> List&lt;string&gt; GetLowCapExchangeList ()

Retrieve the list of low-liquidity or low-cap tokens

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetLowCapExchangeListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WalletApi(config);

            try
            {
                // Retrieve the list of low-liquidity or low-cap tokens
                List<string> result = apiInstance.GetLowCapExchangeList();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WalletApi.GetLowCapExchangeList: " + e.Message);
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

**List<string>**

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a string array on success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

