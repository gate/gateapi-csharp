# Io.Gate.GateApi.Api.EarnApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListDualInvestmentPlans**](EarnApi.md#listdualinvestmentplans) | **GET** /earn/dual/investment_plan | Dual Investment product list
[**ListDualOrders**](EarnApi.md#listdualorders) | **GET** /earn/dual/orders | Dual Investment order list
[**PlaceDualOrder**](EarnApi.md#placedualorder) | **POST** /earn/dual/orders | Place Dual Investment order
[**ListDualBalance**](EarnApi.md#listdualbalance) | **GET** /earn/dual/balance | Dual-Currency Earning Assets
[**FindCoin**](EarnApi.md#findcoin) | **GET** /earn/staking/coins | Staking coins
[**SwapStakingCoin**](EarnApi.md#swapstakingcoin) | **POST** /earn/staking/swap | On-chain token swap for earned coins
[**OrderList**](EarnApi.md#orderlist) | **GET** /earn/staking/order_list | List of on-chain coin-earning orders
[**AwardList**](EarnApi.md#awardlist) | **GET** /earn/staking/award_list | On-chain coin-earning dividend records
[**AssetList**](EarnApi.md#assetlist) | **GET** /earn/staking/assets | On-chain coin-earning assets
[**CreateAutoInvestPlan**](EarnApi.md#createautoinvestplan) | **POST** /earn/autoinvest/plans/create | Create auto invest plan
[**UpdateAutoInvestPlan**](EarnApi.md#updateautoinvestplan) | **POST** /earn/autoinvest/plans/update | UpdateAuto invest plan
[**StopAutoInvestPlan**](EarnApi.md#stopautoinvestplan) | **POST** /earn/autoinvest/plans/stop | StopAuto invest plan
[**AddPositionAutoInvestPlan**](EarnApi.md#addpositionautoinvestplan) | **POST** /earn/autoinvest/plans/add_position | Add position immediately
[**ListAutoInvestCoins**](EarnApi.md#listautoinvestcoins) | **GET** /earn/autoinvest/coins | QueryCurrencies supporting auto invest
[**GetAutoInvestMinAmount**](EarnApi.md#getautoinvestminamount) | **POST** /earn/autoinvest/min_invest_amount | Get minimum investment amount
[**ListAutoInvestPlanRecords**](EarnApi.md#listautoinvestplanrecords) | **GET** /earn/autoinvest/plans/records | List plan execution records
[**ListAutoInvestOrders**](EarnApi.md#listautoinvestorders) | **GET** /earn/autoinvest/orders | List plan execution recordsDetails（OrderDetails）
[**ListAutoInvestConfig**](EarnApi.md#listautoinvestconfig) | **GET** /earn/autoinvest/config | List investment currency configuration
[**GetAutoInvestPlanDetail**](EarnApi.md#getautoinvestplandetail) | **GET** /earn/autoinvest/plans/detail | QueryAuto invest planDetails
[**ListAutoInvestPlans**](EarnApi.md#listautoinvestplans) | **GET** /earn/autoinvest/plans/list_info | QueryAuto invest planList
[**ListEarnFixedTermProducts**](EarnApi.md#listearnfixedtermproducts) | **GET** /earn/fixed-term/product | Get product list
[**ListEarnFixedTermProductsByAsset**](EarnApi.md#listearnfixedtermproductsbyasset) | **GET** /earn/fixed-term/product/{asset}/list | Get product list by single currency
[**ListEarnFixedTermLends**](EarnApi.md#listearnfixedtermlends) | **GET** /earn/fixed-term/user/lend | Subscription list
[**CreateEarnFixedTermLend**](EarnApi.md#createearnfixedtermlend) | **POST** /earn/fixed-term/user/lend | Subscription
[**CreateEarnFixedTermPreRedeem**](EarnApi.md#createearnfixedtermpreredeem) | **POST** /earn/fixed-term/user/pre-redeem | Redeem
[**ListEarnFixedTermHistory**](EarnApi.md#listearnfixedtermhistory) | **GET** /earn/fixed-term/user/history | Subscription history


<a name="listdualinvestmentplans"></a>
# **ListDualInvestmentPlans**
> List&lt;DualGetPlans&gt; ListDualInvestmentPlans (long? planId = null)

Dual Investment product list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListDualInvestmentPlansExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new EarnApi(config);
            var planId = 1;  // long? | Financial project ID (optional) 

            try
            {
                // Dual Investment product list
                List<DualGetPlans> result = apiInstance.ListDualInvestmentPlans(planId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.ListDualInvestmentPlans: " + e.Message);
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
 **planId** | **long?**| Financial project ID | [optional] 

### Return type

[**List&lt;DualGetPlans&gt;**](DualGetPlans.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listdualorders"></a>
# **ListDualOrders**
> List&lt;DualGetOrders&gt; ListDualOrders (long? from = null, long? to = null, int? page = null, int? limit = null)

Dual Investment order list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListDualOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new EarnApi(config);
            var from = 1740727000;  // long? | Start settlement time (optional) 
            var to = 1740729000;  // long? | End settlement time (optional) 
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var limit = 100;  // int? | Maximum number of records returned in a single list (optional)  (default to 100)

            try
            {
                // Dual Investment order list
                List<DualGetOrders> result = apiInstance.ListDualOrders(from, to, page, limit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.ListDualOrders: " + e.Message);
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
 **from** | **long?**| Start settlement time | [optional] 
 **to** | **long?**| End settlement time | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]
 **limit** | **int?**| Maximum number of records returned in a single list | [optional] [default to 100]

### Return type

[**List&lt;DualGetOrders&gt;**](DualGetOrders.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="placedualorder"></a>
# **PlaceDualOrder**
> PlaceDualInvestmentOrder PlaceDualOrder (PlaceDualInvestmentOrderParams placeDualInvestmentOrderParams)

Place Dual Investment order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class PlaceDualOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new EarnApi(config);
            var placeDualInvestmentOrderParams = new PlaceDualInvestmentOrderParams(); // PlaceDualInvestmentOrderParams | 

            try
            {
                // Place Dual Investment order
                PlaceDualInvestmentOrder result = apiInstance.PlaceDualOrder(placeDualInvestmentOrderParams);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.PlaceDualOrder: " + e.Message);
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
 **placeDualInvestmentOrderParams** | [**PlaceDualInvestmentOrderParams**](PlaceDualInvestmentOrderParams.md)|  | 

### Return type

[**PlaceDualInvestmentOrder**](PlaceDualInvestmentOrder.md)

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

<a name="listdualbalance"></a>
# **ListDualBalance**
> DualGetBalance ListDualBalance ()

Dual-Currency Earning Assets

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListDualBalanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new EarnApi(config);

            try
            {
                // Dual-Currency Earning Assets
                DualGetBalance result = apiInstance.ListDualBalance();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.ListDualBalance: " + e.Message);
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

[**DualGetBalance**](DualGetBalance.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findcoin"></a>
# **FindCoin**
> List&lt;Object&gt; FindCoin (string cointype = null)

Staking coins

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class FindCoinExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new EarnApi(config);
            var cointype = "cointype_example";  // string | Currency type: swap - voucher; lock - locked position; debt - US Treasury bond. (optional) 

            try
            {
                // Staking coins
                List<Object> result = apiInstance.FindCoin(cointype);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.FindCoin: " + e.Message);
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
 **cointype** | **string**| Currency type: swap - voucher; lock - locked position; debt - US Treasury bond. | [optional] 

### Return type

**List<Object>**

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="swapstakingcoin"></a>
# **SwapStakingCoin**
> SwapCoinStruct SwapStakingCoin (SwapCoin swapCoin)

On-chain token swap for earned coins

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class SwapStakingCoinExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new EarnApi(config);
            var swapCoin = new SwapCoin(); // SwapCoin | 

            try
            {
                // On-chain token swap for earned coins
                SwapCoinStruct result = apiInstance.SwapStakingCoin(swapCoin);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.SwapStakingCoin: " + e.Message);
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
 **swapCoin** | [**SwapCoin**](SwapCoin.md)|  | 

### Return type

[**SwapCoinStruct**](SwapCoinStruct.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Swap successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderlist"></a>
# **OrderList**
> OrderListStruct OrderList (int? pid = null, string coin = null, int? type = null, int? page = null)

List of on-chain coin-earning orders

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class OrderListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new EarnApi(config);
            var pid = 7;  // int? | Product ID (optional) 
            var coin = "ETH";  // string | Currency name (optional) 
            var type = 0;  // int? | Type 0-staking 1-redemption (optional) 
            var page = 1;  // int? | Page number (optional)  (default to 1)

            try
            {
                // List of on-chain coin-earning orders
                OrderListStruct result = apiInstance.OrderList(pid, coin, type, page);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.OrderList: " + e.Message);
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
 **pid** | **int?**| Product ID | [optional] 
 **coin** | **string**| Currency name | [optional] 
 **type** | **int?**| Type 0-staking 1-redemption | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]

### Return type

[**OrderListStruct**](OrderListStruct.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="awardlist"></a>
# **AwardList**
> AwardListStruct AwardList (int? pid = null, string coin = null, int? page = null)

On-chain coin-earning dividend records

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class AwardListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new EarnApi(config);
            var pid = 7;  // int? | Product ID (optional) 
            var coin = "ETH";  // string | Currency name (optional) 
            var page = 1;  // int? | Page number (optional)  (default to 1)

            try
            {
                // On-chain coin-earning dividend records
                AwardListStruct result = apiInstance.AwardList(pid, coin, page);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.AwardList: " + e.Message);
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
 **pid** | **int?**| Product ID | [optional] 
 **coin** | **string**| Currency name | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]

### Return type

[**AwardListStruct**](AwardListStruct.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assetlist"></a>
# **AssetList**
> List&lt;Object&gt; AssetList (string coin = null)

On-chain coin-earning assets

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class AssetListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new EarnApi(config);
            var coin = "ETH";  // string | Currency name (optional) 

            try
            {
                // On-chain coin-earning assets
                List<Object> result = apiInstance.AssetList(coin);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.AssetList: " + e.Message);
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
 **coin** | **string**| Currency name | [optional] 

### Return type

**List<Object>**

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createautoinvestplan"></a>
# **CreateAutoInvestPlan**
> AutoInvestPlanCreateResp CreateAutoInvestPlan (AutoInvestPlanCreate autoInvestPlanCreate)

Create auto invest plan

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateAutoInvestPlanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new EarnApi(config);
            var autoInvestPlanCreate = new AutoInvestPlanCreate(); // AutoInvestPlanCreate | 

            try
            {
                // Create auto invest plan
                AutoInvestPlanCreateResp result = apiInstance.CreateAutoInvestPlan(autoInvestPlanCreate);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.CreateAutoInvestPlan: " + e.Message);
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
 **autoInvestPlanCreate** | [**AutoInvestPlanCreate**](AutoInvestPlanCreate.md)|  | 

### Return type

[**AutoInvestPlanCreateResp**](AutoInvestPlanCreateResp.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Created successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateautoinvestplan"></a>
# **UpdateAutoInvestPlan**
> void UpdateAutoInvestPlan (AutoInvestPlanUpdate autoInvestPlanUpdate)

UpdateAuto invest plan

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class UpdateAutoInvestPlanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new EarnApi(config);
            var autoInvestPlanUpdate = new AutoInvestPlanUpdate(); // AutoInvestPlanUpdate | 

            try
            {
                // UpdateAuto invest plan
                apiInstance.UpdateAutoInvestPlan(autoInvestPlanUpdate);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.UpdateAutoInvestPlan: " + e.Message);
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
 **autoInvestPlanUpdate** | [**AutoInvestPlanUpdate**](AutoInvestPlanUpdate.md)|  | 

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
| **200** | Updated successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stopautoinvestplan"></a>
# **StopAutoInvestPlan**
> void StopAutoInvestPlan (AutoInvestPlanStop autoInvestPlanStop)

StopAuto invest plan

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class StopAutoInvestPlanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new EarnApi(config);
            var autoInvestPlanStop = new AutoInvestPlanStop(); // AutoInvestPlanStop | 

            try
            {
                // StopAuto invest plan
                apiInstance.StopAutoInvestPlan(autoInvestPlanStop);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.StopAutoInvestPlan: " + e.Message);
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
 **autoInvestPlanStop** | [**AutoInvestPlanStop**](AutoInvestPlanStop.md)|  | 

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
| **200** | Stopped successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addpositionautoinvestplan"></a>
# **AddPositionAutoInvestPlan**
> void AddPositionAutoInvestPlan (AutoInvestPlanAddPosition autoInvestPlanAddPosition)

Add position immediately

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class AddPositionAutoInvestPlanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new EarnApi(config);
            var autoInvestPlanAddPosition = new AutoInvestPlanAddPosition(); // AutoInvestPlanAddPosition | 

            try
            {
                // Add position immediately
                apiInstance.AddPositionAutoInvestPlan(autoInvestPlanAddPosition);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.AddPositionAutoInvestPlan: " + e.Message);
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
 **autoInvestPlanAddPosition** | [**AutoInvestPlanAddPosition**](AutoInvestPlanAddPosition.md)|  | 

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
| **200** | Add PositionSuccess |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listautoinvestcoins"></a>
# **ListAutoInvestCoins**
> List&lt;AutoInvestCoinsItem&gt; ListAutoInvestCoins (string planMoney = null)

QueryCurrencies supporting auto invest

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListAutoInvestCoinsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new EarnApi(config);
            var planMoney = "USDT";  // string | Pricing currency，Optional: USDT or BTC，Default: USDT (optional) 

            try
            {
                // QueryCurrencies supporting auto invest
                List<AutoInvestCoinsItem> result = apiInstance.ListAutoInvestCoins(planMoney);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.ListAutoInvestCoins: " + e.Message);
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
 **planMoney** | **string**| Pricing currency，Optional: USDT or BTC，Default: USDT | [optional] 

### Return type

[**List&lt;AutoInvestCoinsItem&gt;**](AutoInvestCoinsItem.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getautoinvestminamount"></a>
# **GetAutoInvestMinAmount**
> AutoInvestMinInvestAmountResp GetAutoInvestMinAmount (AutoInvestMinInvestAmount autoInvestMinInvestAmount)

Get minimum investment amount

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetAutoInvestMinAmountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new EarnApi(config);
            var autoInvestMinInvestAmount = new AutoInvestMinInvestAmount(); // AutoInvestMinInvestAmount | 

            try
            {
                // Get minimum investment amount
                AutoInvestMinInvestAmountResp result = apiInstance.GetAutoInvestMinAmount(autoInvestMinInvestAmount);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.GetAutoInvestMinAmount: " + e.Message);
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
 **autoInvestMinInvestAmount** | [**AutoInvestMinInvestAmount**](AutoInvestMinInvestAmount.md)|  | 

### Return type

[**AutoInvestMinInvestAmountResp**](AutoInvestMinInvestAmountResp.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listautoinvestplanrecords"></a>
# **ListAutoInvestPlanRecords**
> AutoInvestPlanRecordsResp ListAutoInvestPlanRecords (long planId, long? page = null, long? pageSize = null)

List plan execution records

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListAutoInvestPlanRecordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new EarnApi(config);
            var planId = 141378;  // long | Plan ID
            var page = 1;  // long? | page number (optional) 
            var pageSize = 10;  // long? | Items per page，Maximum 100 (optional) 

            try
            {
                // List plan execution records
                AutoInvestPlanRecordsResp result = apiInstance.ListAutoInvestPlanRecords(planId, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.ListAutoInvestPlanRecords: " + e.Message);
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
 **planId** | **long**| Plan ID | 
 **page** | **long?**| page number | [optional] 
 **pageSize** | **long?**| Items per page，Maximum 100 | [optional] 

### Return type

[**AutoInvestPlanRecordsResp**](AutoInvestPlanRecordsResp.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listautoinvestorders"></a>
# **ListAutoInvestOrders**
> List&lt;AutoInvestOrderItem&gt; ListAutoInvestOrders (long planId, long recordId)

List plan execution recordsDetails（OrderDetails）

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListAutoInvestOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new EarnApi(config);
            var planId = 142583;  // long | Plan ID
            var recordId = 1770805384904919;  // long | Record ID

            try
            {
                // List plan execution recordsDetails（OrderDetails）
                List<AutoInvestOrderItem> result = apiInstance.ListAutoInvestOrders(planId, recordId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.ListAutoInvestOrders: " + e.Message);
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
 **planId** | **long**| Plan ID | 
 **recordId** | **long**| Record ID | 

### Return type

[**List&lt;AutoInvestOrderItem&gt;**](AutoInvestOrderItem.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listautoinvestconfig"></a>
# **ListAutoInvestConfig**
> List&lt;AutoInvestConfigItem&gt; ListAutoInvestConfig ()

List investment currency configuration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListAutoInvestConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new EarnApi(config);

            try
            {
                // List investment currency configuration
                List<AutoInvestConfigItem> result = apiInstance.ListAutoInvestConfig();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.ListAutoInvestConfig: " + e.Message);
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

[**List&lt;AutoInvestConfigItem&gt;**](AutoInvestConfigItem.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getautoinvestplandetail"></a>
# **GetAutoInvestPlanDetail**
> AutoInvestPlanDetail GetAutoInvestPlanDetail (long planId)

QueryAuto invest planDetails

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetAutoInvestPlanDetailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new EarnApi(config);
            var planId = 142609;  // long | Plan ID

            try
            {
                // QueryAuto invest planDetails
                AutoInvestPlanDetail result = apiInstance.GetAutoInvestPlanDetail(planId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.GetAutoInvestPlanDetail: " + e.Message);
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
 **planId** | **long**| Plan ID | 

### Return type

[**AutoInvestPlanDetail**](AutoInvestPlanDetail.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listautoinvestplans"></a>
# **ListAutoInvestPlans**
> AutoInvestPlanListInfoResp ListAutoInvestPlans (string status, long? page = null, long? pageSize = null)

QueryAuto invest planList

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListAutoInvestPlansExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new EarnApi(config);
            var status = "active";  // string | Plan status，History history，Active active
            var page = 56;  // long? | page number (optional) 
            var pageSize = 56;  // long? | Items per page，Maximum 100 (optional) 

            try
            {
                // QueryAuto invest planList
                AutoInvestPlanListInfoResp result = apiInstance.ListAutoInvestPlans(status, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.ListAutoInvestPlans: " + e.Message);
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
 **status** | **string**| Plan status，History history，Active active | 
 **page** | **long?**| page number | [optional] 
 **pageSize** | **long?**| Items per page，Maximum 100 | [optional] 

### Return type

[**AutoInvestPlanListInfoResp**](AutoInvestPlanListInfoResp.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listearnfixedtermproducts"></a>
# **ListEarnFixedTermProducts**
> ListEarnFixedTermProductsResponse ListEarnFixedTermProducts (int page, int limit, string asset = null, int? type = null)

Get product list

Query fixed-term earn product list. Supports filtering by currency, product type, status, etc. Returns product interest rate, lock-up period, quota, and reward campaign information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListEarnFixedTermProductsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new EarnApi(config);
            var page = 1;  // int | Page number
            var limit = 100;  // int | Page size
            var asset = "USDT";  // string | Currency (optional) 
            var type = 1;  // int? | Product type: 1 for regular, 2 for VIP (optional) 

            try
            {
                // Get product list
                ListEarnFixedTermProductsResponse result = apiInstance.ListEarnFixedTermProducts(page, limit, asset, type);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.ListEarnFixedTermProducts: " + e.Message);
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
 **page** | **int**| Page number | 
 **limit** | **int**| Page size | 
 **asset** | **string**| Currency | [optional] 
 **type** | **int?**| Product type: 1 for regular, 2 for VIP | [optional] 

### Return type

[**ListEarnFixedTermProductsResponse**](ListEarnFixedTermProductsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Product list retrieved successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listearnfixedtermproductsbyasset"></a>
# **ListEarnFixedTermProductsByAsset**
> ListEarnFixedTermProductsByAssetResponse ListEarnFixedTermProductsByAsset (string asset, string type = null)

Get product list by single currency

Sort by product term in ascending order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListEarnFixedTermProductsByAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new EarnApi(config);
            var asset = "USDT";  // string | Currency name, e.g., USDT, BTC
            var type = "1";  // string | Product type: \"\" or 1 for regular product list, 2 for VIP product list, 0 for all products (optional) 

            try
            {
                // Get product list by single currency
                ListEarnFixedTermProductsByAssetResponse result = apiInstance.ListEarnFixedTermProductsByAsset(asset, type);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.ListEarnFixedTermProductsByAsset: " + e.Message);
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
 **asset** | **string**| Currency name, e.g., USDT, BTC | 
 **type** | **string**| Product type: \&quot;\&quot; or 1 for regular product list, 2 for VIP product list, 0 for all products | [optional] 

### Return type

[**ListEarnFixedTermProductsByAssetResponse**](ListEarnFixedTermProductsByAssetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Single currency product list retrieved successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listearnfixedtermlends"></a>
# **ListEarnFixedTermLends**
> ListEarnFixedTermLendsResponse ListEarnFixedTermLends (string orderType, int page, int limit, int? productId = null, long? orderId = null, string asset = null, int? subBusiness = null, string businessFilter = null)

Subscription list

Query the user's fixed-term earn subscription order list. Supports filtering by product, currency, order type, etc. Returns order details, earnings, rewards, and interest rate boost coupon information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListEarnFixedTermLendsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new EarnApi(config);
            var orderType = "1";  // string | Order type: 1 for current orders, 2 for historical orders
            var page = 1;  // int | Page number
            var limit = 10;  // int | Page size
            var productId = 56;  // int? | Product ID (optional) 
            var orderId = 56;  // long? | Order ID (optional) 
            var asset = "asset_example";  // string | Currency (optional) 
            var subBusiness = 56;  // int? | Sub-business (optional) 
            var businessFilter = "[{\"business\":1, \"sub_business\": 0},{\"business\":2, \"sub_business\": 0}]";  // string | Business filter conditions, JSON array format, e.g., [{\"business\":1, \"sub_business\": 0}]. business: 1 for regular, 2 for VIP (optional) 

            try
            {
                // Subscription list
                ListEarnFixedTermLendsResponse result = apiInstance.ListEarnFixedTermLends(orderType, page, limit, productId, orderId, asset, subBusiness, businessFilter);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.ListEarnFixedTermLends: " + e.Message);
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
 **orderType** | **string**| Order type: 1 for current orders, 2 for historical orders | 
 **page** | **int**| Page number | 
 **limit** | **int**| Page size | 
 **productId** | **int?**| Product ID | [optional] 
 **orderId** | **long?**| Order ID | [optional] 
 **asset** | **string**| Currency | [optional] 
 **subBusiness** | **int?**| Sub-business | [optional] 
 **businessFilter** | **string**| Business filter conditions, JSON array format, e.g., [{\&quot;business\&quot;:1, \&quot;sub_business\&quot;: 0}]. business: 1 for regular, 2 for VIP | [optional] 

### Return type

[**ListEarnFixedTermLendsResponse**](ListEarnFixedTermLendsResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Subscription order list retrieved successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createearnfixedtermlend"></a>
# **CreateEarnFixedTermLend**
> CreateEarnFixedTermLendResponse CreateEarnFixedTermLend (FixedTermLendRequest fixedTermLendRequest = null)

Subscription

Subscribe to a fixed-term earn product by specifying the product ID and subscription amount. Optionally enable auto-renewal and apply an interest rate boost coupon

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateEarnFixedTermLendExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new EarnApi(config);
            var fixedTermLendRequest = new FixedTermLendRequest(); // FixedTermLendRequest |  (optional) 

            try
            {
                // Subscription
                CreateEarnFixedTermLendResponse result = apiInstance.CreateEarnFixedTermLend(fixedTermLendRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.CreateEarnFixedTermLend: " + e.Message);
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
 **fixedTermLendRequest** | [**FixedTermLendRequest**](FixedTermLendRequest.md)|  | [optional] 

### Return type

[**CreateEarnFixedTermLendResponse**](CreateEarnFixedTermLendResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Subscription successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createearnfixedtermpreredeem"></a>
# **CreateEarnFixedTermPreRedeem**
> CreateEarnFixedTermPreRedeemResponse CreateEarnFixedTermPreRedeem (EarnFixedTermPreRedeemRequest earnFixedTermPreRedeemRequest = null)

Redeem

Early redemption of a fixed-term earn order, order ID is required

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateEarnFixedTermPreRedeemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new EarnApi(config);
            var earnFixedTermPreRedeemRequest = new EarnFixedTermPreRedeemRequest(); // EarnFixedTermPreRedeemRequest |  (optional) 

            try
            {
                // Redeem
                CreateEarnFixedTermPreRedeemResponse result = apiInstance.CreateEarnFixedTermPreRedeem(earnFixedTermPreRedeemRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.CreateEarnFixedTermPreRedeem: " + e.Message);
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
 **earnFixedTermPreRedeemRequest** | [**EarnFixedTermPreRedeemRequest**](EarnFixedTermPreRedeemRequest.md)|  | [optional] 

### Return type

[**CreateEarnFixedTermPreRedeemResponse**](CreateEarnFixedTermPreRedeemResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Redemption successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listearnfixedtermhistory"></a>
# **ListEarnFixedTermHistory**
> ListEarnFixedTermHistoryResponse ListEarnFixedTermHistory (string type, int page, int limit, int? productId = null, string orderId = null, string asset = null, int? startAt = null, int? endAt = null, int? subBusiness = null, string businessFilter = null)

Subscription history

Query the user's fixed-term earn history records. Supports filtering by type (subscription, redemption, interest, bonus rewards) and time range

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListEarnFixedTermHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new EarnApi(config);
            var type = "1";  // string | 1 for subscription, 2 for redemption, 3 for interest, 4 for bonus reward
            var page = 1;  // int | Page number
            var limit = 10;  // int | Page size
            var productId = 56;  // int? | Product ID (optional) 
            var orderId = "orderId_example";  // string | Order ID (optional) 
            var asset = "asset_example";  // string | Currency (optional) 
            var startAt = 56;  // int? | Start timestamp (optional) 
            var endAt = 56;  // int? | End Timestamp (optional) 
            var subBusiness = 56;  // int? | Sub-business (optional) 
            var businessFilter = "[{\"business\":1, \"sub_business\": 0},{\"business\":2, \"sub_business\": 0}]";  // string | Business filter conditions, JSON array format, e.g., [{\"business\":1, \"sub_business\": 0}]. business: 1 for regular, 2 for VIP (optional) 

            try
            {
                // Subscription history
                ListEarnFixedTermHistoryResponse result = apiInstance.ListEarnFixedTermHistory(type, page, limit, productId, orderId, asset, startAt, endAt, subBusiness, businessFilter);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling EarnApi.ListEarnFixedTermHistory: " + e.Message);
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
 **type** | **string**| 1 for subscription, 2 for redemption, 3 for interest, 4 for bonus reward | 
 **page** | **int**| Page number | 
 **limit** | **int**| Page size | 
 **productId** | **int?**| Product ID | [optional] 
 **orderId** | **string**| Order ID | [optional] 
 **asset** | **string**| Currency | [optional] 
 **startAt** | **int?**| Start timestamp | [optional] 
 **endAt** | **int?**| End Timestamp | [optional] 
 **subBusiness** | **int?**| Sub-business | [optional] 
 **businessFilter** | **string**| Business filter conditions, JSON array format, e.g., [{\&quot;business\&quot;:1, \&quot;sub_business\&quot;: 0}]. business: 1 for regular, 2 for VIP | [optional] 

### Return type

[**ListEarnFixedTermHistoryResponse**](ListEarnFixedTermHistoryResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | History records retrieved successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

