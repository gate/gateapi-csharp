# Io.Gate.GateApi.Api.LaunchApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListLaunchPoolProjects**](LaunchApi.md#listlaunchpoolprojects) | **GET** /launch/project-list | Query LaunchPool project list
[**CreateLaunchPoolOrder**](LaunchApi.md#createlaunchpoolorder) | **POST** /launch/create-order | Create LaunchPool staking order
[**RedeemLaunchPool**](LaunchApi.md#redeemlaunchpool) | **POST** /launch/redeem | Redeem LaunchPool staked assets
[**ListLaunchPoolPledgeRecords**](LaunchApi.md#listlaunchpoolpledgerecords) | **GET** /launch/user-pledge-records | Query user pledge records
[**ListLaunchPoolRewardRecords**](LaunchApi.md#listlaunchpoolrewardrecords) | **GET** /launch/get-user-reward-records | Query user reward records
[**GetHodlerAirdropProjectList**](LaunchApi.md#gethodlerairdropprojectlist) | **GET** /launch/hodler-airdrop/project-list | 查询HODLer Airdrop活动列表
[**HodlerAirdropOrder**](LaunchApi.md#hodlerairdroporder) | **POST** /launch/hodler-airdrop/order | 参与HODLer Airdrop活动
[**GetHodlerAirdropUserOrderRecords**](LaunchApi.md#gethodlerairdropuserorderrecords) | **GET** /launch/hodler-airdrop/user-order-records | 查询HODLer Airdrop参与记录
[**GetHodlerAirdropUserAirdropRecords**](LaunchApi.md#gethodlerairdropuserairdroprecords) | **GET** /launch/hodler-airdrop/user-airdrop-records | 查询HODLer Airdrop空投记录
[**GetCandyDropActivityListV4**](LaunchApi.md#getcandydropactivitylistv4) | **GET** /launch/candydrop/activity-list | 查询活动列表
[**RegisterCandyDropV4**](LaunchApi.md#registercandydropv4) | **POST** /launch/candydrop/register | 报名参与活动
[**GetCandyDropActivityRulesV4**](LaunchApi.md#getcandydropactivityrulesv4) | **GET** /launch/candydrop/activity-rules | 查询活动规则
[**GetCandyDropTaskProgressV4**](LaunchApi.md#getcandydroptaskprogressv4) | **GET** /launch/candydrop/task-progress | 查询任务完成进度
[**GetCandyDropParticipationRecordsV4**](LaunchApi.md#getcandydropparticipationrecordsv4) | **GET** /launch/candydrop/participation-records | 查询参与记录
[**GetCandyDropAirdropRecordsV4**](LaunchApi.md#getcandydropairdroprecordsv4) | **GET** /launch/candydrop/airdrop-records | 查询空投记录


<a name="listlaunchpoolprojects"></a>
# **ListLaunchPoolProjects**
> List&lt;LaunchPoolV4Project&gt; ListLaunchPoolProjects (int? status = null, string mortgageCoin = null, string searchCoin = null, int? limitRule = null, int? sortType = null, int? page = null, int? pageSize = null)

Query LaunchPool project list

Retrieve the list of available LaunchPool projects, including basic project information and reward pool configuration. This endpoint does not require user authentication.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListLaunchPoolProjectsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new LaunchApi(config);
            var status = 56;  // int? | Filter by project status: 0 for all, 1 for ongoing, 2 for warming up, 3 for ended, 4 for ongoing and warming up (optional) 
            var mortgageCoin = "mortgageCoin_example";  // string | Exact match by staking currency (optional) 
            var searchCoin = "searchCoin_example";  // string | Fuzzy match by reward currency and name (optional) 
            var limitRule = 56;  // int? | Limit rule: 0 for regular pool, 1 for beginner pool (optional) 
            var sortType = 56;  // int? | Sort type: 1 for max APR descending, 2 for max APR ascending (optional) 
            var page = 1;  // int? | Page number, default 1 (optional)  (default to 1)
            var pageSize = 10;  // int? | Number of items per page, default 10, maximum 30 (optional)  (default to 10)

            try
            {
                // Query LaunchPool project list
                List<LaunchPoolV4Project> result = apiInstance.ListLaunchPoolProjects(status, mortgageCoin, searchCoin, limitRule, sortType, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling LaunchApi.ListLaunchPoolProjects: " + e.Message);
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
 **status** | **int?**| Filter by project status: 0 for all, 1 for ongoing, 2 for warming up, 3 for ended, 4 for ongoing and warming up | [optional] 
 **mortgageCoin** | **string**| Exact match by staking currency | [optional] 
 **searchCoin** | **string**| Fuzzy match by reward currency and name | [optional] 
 **limitRule** | **int?**| Limit rule: 0 for regular pool, 1 for beginner pool | [optional] 
 **sortType** | **int?**| Sort type: 1 for max APR descending, 2 for max APR ascending | [optional] 
 **page** | **int?**| Page number, default 1 | [optional] [default to 1]
 **pageSize** | **int?**| Number of items per page, default 10, maximum 30 | [optional] [default to 10]

### Return type

[**List&lt;LaunchPoolV4Project&gt;**](LaunchPoolV4Project.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully returns project list |  -  |
| **400** | Invalid request parameters |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createlaunchpoolorder"></a>
# **CreateLaunchPoolOrder**
> LaunchPoolV4CreateOrderResponse CreateLaunchPoolOrder (CreateOrderV4 createOrderV4)

Create LaunchPool staking order

Create a new staking order for asset staking mining. This endpoint requires API Key signature authentication.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateLaunchPoolOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new LaunchApi(config);
            var createOrderV4 = new CreateOrderV4(); // CreateOrderV4 | 

            try
            {
                // Create LaunchPool staking order
                LaunchPoolV4CreateOrderResponse result = apiInstance.CreateLaunchPoolOrder(createOrderV4);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling LaunchApi.CreateLaunchPoolOrder: " + e.Message);
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
 **createOrderV4** | [**CreateOrderV4**](CreateOrderV4.md)|  | 

### Return type

[**LaunchPoolV4CreateOrderResponse**](LaunchPoolV4CreateOrderResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully created staking order |  -  |
| **400** | Invalid request parameters |  -  |
| **401** | User not authenticated |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="redeemlaunchpool"></a>
# **RedeemLaunchPool**
> RedeemLaunchPoolResponse RedeemLaunchPool (RedeemV4 redeemV4)

Redeem LaunchPool staked assets

Redeem staked assets and end staking mining. This endpoint requires API Key signature authentication.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class RedeemLaunchPoolExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new LaunchApi(config);
            var redeemV4 = new RedeemV4(); // RedeemV4 | 

            try
            {
                // Redeem LaunchPool staked assets
                RedeemLaunchPoolResponse result = apiInstance.RedeemLaunchPool(redeemV4);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling LaunchApi.RedeemLaunchPool: " + e.Message);
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
 **redeemV4** | [**RedeemV4**](RedeemV4.md)|  | 

### Return type

[**RedeemLaunchPoolResponse**](RedeemLaunchPoolResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully redeemed pledged assets |  -  |
| **400** | Invalid request parameters |  -  |
| **401** | User not authenticated |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listlaunchpoolpledgerecords"></a>
# **ListLaunchPoolPledgeRecords**
> List&lt;LaunchPoolV4PledgeRecord&gt; ListLaunchPoolPledgeRecords (long? page = null, long? pageSize = null, int? type = null, string startTime = null, string endTime = null, string coin = null)

Query user pledge records

Query user's staking and redemption operation records. This endpoint requires user authentication.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListLaunchPoolPledgeRecordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new LaunchApi(config);
            var page = 1;  // long? | Page number, default 1 (optional)  (default to 1)
            var pageSize = 10;  // long? | Number of items per page, maximum 30 (optional)  (default to 10)
            var type = 56;  // int? | Type: 1 for pledge, 2 for redemption (optional) 
            var startTime = "2026-03-17 00:00:00";  // string | Start time, format: YYYY-MM-DD HH:MM:SS (optional) 
            var endTime = "2026-03-17 23:59:59";  // string | End time, format: YYYY-MM-DD HH:MM:SS (optional) 
            var coin = "coin_example";  // string | Collateral currency (optional) 

            try
            {
                // Query user pledge records
                List<LaunchPoolV4PledgeRecord> result = apiInstance.ListLaunchPoolPledgeRecords(page, pageSize, type, startTime, endTime, coin);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling LaunchApi.ListLaunchPoolPledgeRecords: " + e.Message);
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
 **page** | **long?**| Page number, default 1 | [optional] [default to 1]
 **pageSize** | **long?**| Number of items per page, maximum 30 | [optional] [default to 10]
 **type** | **int?**| Type: 1 for pledge, 2 for redemption | [optional] 
 **startTime** | **string**| Start time, format: YYYY-MM-DD HH:MM:SS | [optional] 
 **endTime** | **string**| End time, format: YYYY-MM-DD HH:MM:SS | [optional] 
 **coin** | **string**| Collateral currency | [optional] 

### Return type

[**List&lt;LaunchPoolV4PledgeRecord&gt;**](LaunchPoolV4PledgeRecord.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully returns user staking records |  -  |
| **400** | Invalid request parameters |  -  |
| **401** | User not authenticated |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listlaunchpoolrewardrecords"></a>
# **ListLaunchPoolRewardRecords**
> List&lt;LaunchPoolV4RewardRecord&gt; ListLaunchPoolRewardRecords (long? page = null, long? pageSize = null, long? startTime = null, long? endTime = null, string coin = null)

Query user reward records

Query the user's staking reward records. This endpoint requires user authentication.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListLaunchPoolRewardRecordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new LaunchApi(config);
            var page = 1;  // long? | Page number, default 1 (optional)  (default to 1)
            var pageSize = 10;  // long? | Number of items per page, maximum 30 (optional)  (default to 10)
            var startTime = 56;  // long? | Start timestamp (optional) 
            var endTime = 56;  // long? | End Timestamp (optional) 
            var coin = "coin_example";  // string | Reward currency (optional) 

            try
            {
                // Query user reward records
                List<LaunchPoolV4RewardRecord> result = apiInstance.ListLaunchPoolRewardRecords(page, pageSize, startTime, endTime, coin);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling LaunchApi.ListLaunchPoolRewardRecords: " + e.Message);
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
 **page** | **long?**| Page number, default 1 | [optional] [default to 1]
 **pageSize** | **long?**| Number of items per page, maximum 30 | [optional] [default to 10]
 **startTime** | **long?**| Start timestamp | [optional] 
 **endTime** | **long?**| End Timestamp | [optional] 
 **coin** | **string**| Reward currency | [optional] 

### Return type

[**List&lt;LaunchPoolV4RewardRecord&gt;**](LaunchPoolV4RewardRecord.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully returns user reward records |  -  |
| **400** | Invalid request parameters |  -  |
| **401** | User not authenticated |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethodlerairdropprojectlist"></a>
# **GetHodlerAirdropProjectList**
> List&lt;HodlerAirdropV4ProjectItem&gt; GetHodlerAirdropProjectList (string status = null, string keyword = null, int? join = null, int? page = null, int? size = null)

查询HODLer Airdrop活动列表

获取HODLer Airdrop活动列表，支持按状态、币种/项目名称、参与情况筛选。此接口无需用户登录，登录用户可获取个人参与信息。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetHodlerAirdropProjectListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new LaunchApi(config);
            var status = "status_example";  // string | 活动状态筛选，可选值：ACTIVE（进行中+预热中）、UNDERWAY（进行中）、PREHEAT（预热中）、FINISH（已结束），不传返回全部 (optional) 
            var keyword = "keyword_example";  // string | 币种/项目名称关键词，模糊匹配 (optional) 
            var join = 0;  // int? | 参与情况筛选：0全部（默认），1仅已参与 (optional)  (default to 0)
            var page = 1;  // int? | 页码，默认1 (optional)  (default to 1)
            var size = 10;  // int? | 每页条数，默认10 (optional)  (default to 10)

            try
            {
                // 查询HODLer Airdrop活动列表
                List<HodlerAirdropV4ProjectItem> result = apiInstance.GetHodlerAirdropProjectList(status, keyword, join, page, size);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling LaunchApi.GetHodlerAirdropProjectList: " + e.Message);
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
 **status** | **string**| 活动状态筛选，可选值：ACTIVE（进行中+预热中）、UNDERWAY（进行中）、PREHEAT（预热中）、FINISH（已结束），不传返回全部 | [optional] 
 **keyword** | **string**| 币种/项目名称关键词，模糊匹配 | [optional] 
 **join** | **int?**| 参与情况筛选：0全部（默认），1仅已参与 | [optional] [default to 0]
 **page** | **int?**| 页码，默认1 | [optional] [default to 1]
 **size** | **int?**| 每页条数，默认10 | [optional] [default to 10]

### Return type

[**List&lt;HodlerAirdropV4ProjectItem&gt;**](HodlerAirdropV4ProjectItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully returns activity list |  -  |
| **400** | Invalid request parameters |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hodlerairdroporder"></a>
# **HodlerAirdropOrder**
> HodlerAirdropV4OrderResponse HodlerAirdropOrder (HodlerAirdropV4OrderRequest hodlerAirdropV4OrderRequest)

参与HODLer Airdrop活动

参与指定的HODLer Airdrop活动，需持有GT。此接口需要用户登录认证，且须满足KYC要求，不支持子账户、企业/机构用户。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class HodlerAirdropOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new LaunchApi(config);
            var hodlerAirdropV4OrderRequest = new HodlerAirdropV4OrderRequest(); // HodlerAirdropV4OrderRequest | 

            try
            {
                // 参与HODLer Airdrop活动
                HodlerAirdropV4OrderResponse result = apiInstance.HodlerAirdropOrder(hodlerAirdropV4OrderRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling LaunchApi.HodlerAirdropOrder: " + e.Message);
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
 **hodlerAirdropV4OrderRequest** | [**HodlerAirdropV4OrderRequest**](HodlerAirdropV4OrderRequest.md)|  | 

### Return type

[**HodlerAirdropV4OrderResponse**](HodlerAirdropV4OrderResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 成功参与活动 |  -  |
| **400** | 请求参数错误或业务校验失败（KYC不足、子账户限制、企业用户限制等） |  -  |
| **401** | 用户未登录 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethodlerairdropuserorderrecords"></a>
# **GetHodlerAirdropUserOrderRecords**
> List&lt;HodlerAirdropV4UserOrderRecord&gt; GetHodlerAirdropUserOrderRecords (string keyword = null, int? startTimest = null, int? endTimest = null, int? page = null, int? size = null)

查询HODLer Airdrop参与记录

查询用户的HODLer Airdrop参与记录，返回每个活动的有效持仓和空投金额。此接口需要用户登录认证。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetHodlerAirdropUserOrderRecordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new LaunchApi(config);
            var keyword = "keyword_example";  // string | 币种名称关键词筛选 (optional) 
            var startTimest = 56;  // int? | 开始时间戳（秒） (optional) 
            var endTimest = 56;  // int? | 结束时间戳（秒） (optional) 
            var page = 1;  // int? | 页码，默认1 (optional)  (default to 1)
            var size = 10;  // int? | 每页条数，默认10 (optional)  (default to 10)

            try
            {
                // 查询HODLer Airdrop参与记录
                List<HodlerAirdropV4UserOrderRecord> result = apiInstance.GetHodlerAirdropUserOrderRecords(keyword, startTimest, endTimest, page, size);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling LaunchApi.GetHodlerAirdropUserOrderRecords: " + e.Message);
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
 **keyword** | **string**| 币种名称关键词筛选 | [optional] 
 **startTimest** | **int?**| 开始时间戳（秒） | [optional] 
 **endTimest** | **int?**| 结束时间戳（秒） | [optional] 
 **page** | **int?**| 页码，默认1 | [optional] [default to 1]
 **size** | **int?**| 每页条数，默认10 | [optional] [default to 10]

### Return type

[**List&lt;HodlerAirdropV4UserOrderRecord&gt;**](HodlerAirdropV4UserOrderRecord.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 成功返回参与记录列表 |  -  |
| **400** | Invalid request parameters |  -  |
| **401** | 用户未登录 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethodlerairdropuserairdroprecords"></a>
# **GetHodlerAirdropUserAirdropRecords**
> List&lt;HodlerAirdropV4UserAirdropRecord&gt; GetHodlerAirdropUserAirdropRecords (string keyword = null, int? startTimest = null, int? endTimest = null, int? page = null, int? size = null)

查询HODLer Airdrop空投记录

查询用户已获得的HODLer Airdrop空投发放记录，包含基础空投、额外空投和自动兑换状态。此接口需要用户登录认证。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetHodlerAirdropUserAirdropRecordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new LaunchApi(config);
            var keyword = "keyword_example";  // string | 币种名称关键词筛选 (optional) 
            var startTimest = 56;  // int? | 开始时间戳（秒） (optional) 
            var endTimest = 56;  // int? | 结束时间戳（秒） (optional) 
            var page = 1;  // int? | 页码，默认1 (optional)  (default to 1)
            var size = 10;  // int? | 每页条数，默认10 (optional)  (default to 10)

            try
            {
                // 查询HODLer Airdrop空投记录
                List<HodlerAirdropV4UserAirdropRecord> result = apiInstance.GetHodlerAirdropUserAirdropRecords(keyword, startTimest, endTimest, page, size);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling LaunchApi.GetHodlerAirdropUserAirdropRecords: " + e.Message);
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
 **keyword** | **string**| 币种名称关键词筛选 | [optional] 
 **startTimest** | **int?**| 开始时间戳（秒） | [optional] 
 **endTimest** | **int?**| 结束时间戳（秒） | [optional] 
 **page** | **int?**| 页码，默认1 | [optional] [default to 1]
 **size** | **int?**| 每页条数，默认10 | [optional] [default to 10]

### Return type

[**List&lt;HodlerAirdropV4UserAirdropRecord&gt;**](HodlerAirdropV4UserAirdropRecord.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 成功返回空投记录列表 |  -  |
| **400** | Invalid request parameters |  -  |
| **401** | 用户未登录 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcandydropactivitylistv4"></a>
# **GetCandyDropActivityListV4**
> List&lt;CandyDropV4ActivityCd01&gt; GetCandyDropActivityListV4 (string status = null, string ruleName = null, string registerStatus = null, string currency = null, int? limit = null, int? offset = null)

查询活动列表

支持多维度筛选 CandyDrop 活动，每次查询返回列表排序的前十条数据。不需要登录。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetCandyDropActivityListV4Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new LaunchApi(config);
            var status = "status_example";  // string | 活动状态筛选：ongoing(进行中)、upcoming(即将开始)、ended(已结束)，不传则返回全部 (optional) 
            var ruleName = "ruleName_example";  // string | 任务类型筛选：spot(现货)、futures(合约)、deposit(充值)、invite(邀请)、trading_bot(交易机器人)、simple_earn(余币宝)、first_deposit(首笔入金)、alpha(Alpha)、flash_swap(闪兑)、tradfi(TradFi)、etf(ETF) (optional) 
            var registerStatus = "registerStatus_example";  // string | 参与情况筛选：registered(已参与)、unregistered(未参与)，不传则返回全部 (optional) 
            var currency = "currency_example";  // string | 币种名称筛选 (optional) 
            var limit = 10;  // int? | 返回条数，默认10，最大30 (optional)  (default to 10)
            var offset = 0;  // int? | 偏移量，默认0 (optional)  (default to 0)

            try
            {
                // 查询活动列表
                List<CandyDropV4ActivityCd01> result = apiInstance.GetCandyDropActivityListV4(status, ruleName, registerStatus, currency, limit, offset);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling LaunchApi.GetCandyDropActivityListV4: " + e.Message);
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
 **status** | **string**| 活动状态筛选：ongoing(进行中)、upcoming(即将开始)、ended(已结束)，不传则返回全部 | [optional] 
 **ruleName** | **string**| 任务类型筛选：spot(现货)、futures(合约)、deposit(充值)、invite(邀请)、trading_bot(交易机器人)、simple_earn(余币宝)、first_deposit(首笔入金)、alpha(Alpha)、flash_swap(闪兑)、tradfi(TradFi)、etf(ETF) | [optional] 
 **registerStatus** | **string**| 参与情况筛选：registered(已参与)、unregistered(未参与)，不传则返回全部 | [optional] 
 **currency** | **string**| 币种名称筛选 | [optional] 
 **limit** | **int?**| 返回条数，默认10，最大30 | [optional] [default to 10]
 **offset** | **int?**| 偏移量，默认0 | [optional] [default to 0]

### Return type

[**List&lt;CandyDropV4ActivityCd01&gt;**](CandyDropV4ActivityCd01.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 成功返回活动列表数组 |  -  |
| **400** | Invalid request parameters |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registercandydropv4"></a>
# **RegisterCandyDropV4**
> CandyDropV4RegisterRespCd02 RegisterCandyDropV4 (CandyDropV4RegisterReqCd02 candyDropV4RegisterReqCd02)

报名参与活动

报名参与特定 CandyDrop 活动。需要登录，需要 API Key 签名认证。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class RegisterCandyDropV4Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new LaunchApi(config);
            var candyDropV4RegisterReqCd02 = new CandyDropV4RegisterReqCd02(); // CandyDropV4RegisterReqCd02 | 

            try
            {
                // 报名参与活动
                CandyDropV4RegisterRespCd02 result = apiInstance.RegisterCandyDropV4(candyDropV4RegisterReqCd02);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling LaunchApi.RegisterCandyDropV4: " + e.Message);
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
 **candyDropV4RegisterReqCd02** | [**CandyDropV4RegisterReqCd02**](CandyDropV4RegisterReqCd02.md)|  | 

### Return type

[**CandyDropV4RegisterRespCd02**](CandyDropV4RegisterRespCd02.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 报名成功 |  -  |
| **400** | Request failed |  -  |
| **401** | User not authenticated |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcandydropactivityrulesv4"></a>
# **GetCandyDropActivityRulesV4**
> CandyDropV4ActivityRulesCd03 GetCandyDropActivityRulesV4 (long? activityId = null, string currency = null)

查询活动规则

查询特定活动的规则，包括奖池及对应任务数据。不需要登录。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetCandyDropActivityRulesV4Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new LaunchApi(config);
            var activityId = 56;  // long? | 活动ID，与 currency 二选一，至少须传其一 (optional) 
            var currency = "currency_example";  // string | 项目/币种名称，与 activity_id 二选一，至少须传其一 (optional) 

            try
            {
                // 查询活动规则
                CandyDropV4ActivityRulesCd03 result = apiInstance.GetCandyDropActivityRulesV4(activityId, currency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling LaunchApi.GetCandyDropActivityRulesV4: " + e.Message);
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
 **activityId** | **long?**| 活动ID，与 currency 二选一，至少须传其一 | [optional] 
 **currency** | **string**| 项目/币种名称，与 activity_id 二选一，至少须传其一 | [optional] 

### Return type

[**CandyDropV4ActivityRulesCd03**](CandyDropV4ActivityRulesCd03.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 成功返回活动规则 |  -  |
| **400** | Invalid request parameters |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcandydroptaskprogressv4"></a>
# **GetCandyDropTaskProgressV4**
> CandyDropV4TaskProgressCd04 GetCandyDropTaskProgressV4 (long? activityId = null, string currency = null)

查询任务完成进度

查询进行中且已报名/参与的任务完成进度。需要登录。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetCandyDropTaskProgressV4Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new LaunchApi(config);
            var activityId = 56;  // long? | 活动ID，与 currency 二选一，至少须传其一 (optional) 
            var currency = "currency_example";  // string | 项目/币种名称，与 activity_id 二选一，至少须传其一 (optional) 

            try
            {
                // 查询任务完成进度
                CandyDropV4TaskProgressCd04 result = apiInstance.GetCandyDropTaskProgressV4(activityId, currency);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling LaunchApi.GetCandyDropTaskProgressV4: " + e.Message);
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
 **activityId** | **long?**| 活动ID，与 currency 二选一，至少须传其一 | [optional] 
 **currency** | **string**| 项目/币种名称，与 activity_id 二选一，至少须传其一 | [optional] 

### Return type

[**CandyDropV4TaskProgressCd04**](CandyDropV4TaskProgressCd04.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 成功返回任务进度 |  -  |
| **400** | Invalid request parameters |  -  |
| **401** | User not authenticated |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcandydropparticipationrecordsv4"></a>
# **GetCandyDropParticipationRecordsV4**
> List&lt;CandyDropV4ParticipationRecordCd05&gt; GetCandyDropParticipationRecordsV4 (string currency = null, string status = null, long? startTime = null, long? endTime = null, int? page = null, int? limit = null)

查询参与记录

查询用户的 CandyDrop 参与详情。需要登录。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetCandyDropParticipationRecordsV4Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new LaunchApi(config);
            var currency = "currency_example";  // string | 币种名称筛选 (optional) 
            var status = "status_example";  // string | 状态筛选：ongoing(进行中)、awaiting_draw(待开奖)、won(已中奖)、not_win(未中奖) (optional) 
            var startTime = 56;  // long? | 开始时间（Unix 时间戳秒） (optional) 
            var endTime = 56;  // long? | 结束时间（Unix 时间戳秒） (optional) 
            var page = 1;  // int? | 页码，默认1 (optional)  (default to 1)
            var limit = 10;  // int? | 每页条数，默认10，最大30 (optional)  (default to 10)

            try
            {
                // 查询参与记录
                List<CandyDropV4ParticipationRecordCd05> result = apiInstance.GetCandyDropParticipationRecordsV4(currency, status, startTime, endTime, page, limit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling LaunchApi.GetCandyDropParticipationRecordsV4: " + e.Message);
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
 **currency** | **string**| 币种名称筛选 | [optional] 
 **status** | **string**| 状态筛选：ongoing(进行中)、awaiting_draw(待开奖)、won(已中奖)、not_win(未中奖) | [optional] 
 **startTime** | **long?**| 开始时间（Unix 时间戳秒） | [optional] 
 **endTime** | **long?**| 结束时间（Unix 时间戳秒） | [optional] 
 **page** | **int?**| 页码，默认1 | [optional] [default to 1]
 **limit** | **int?**| 每页条数，默认10，最大30 | [optional] [default to 10]

### Return type

[**List&lt;CandyDropV4ParticipationRecordCd05&gt;**](CandyDropV4ParticipationRecordCd05.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 成功返回参与记录列表 |  -  |
| **400** | Invalid request parameters |  -  |
| **401** | User not authenticated |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcandydropairdroprecordsv4"></a>
# **GetCandyDropAirdropRecordsV4**
> List&lt;CandyDropV4AirdropRecordCd06&gt; GetCandyDropAirdropRecordsV4 (string currency = null, long? startTime = null, long? endTime = null, int? page = null, int? limit = null)

查询空投记录

查询用户的 CandyDrop 空投详情。需要登录。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetCandyDropAirdropRecordsV4Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new LaunchApi(config);
            var currency = "currency_example";  // string | 币种名称筛选 (optional) 
            var startTime = 56;  // long? | 开始时间（Unix 时间戳秒） (optional) 
            var endTime = 56;  // long? | 结束时间（Unix 时间戳秒） (optional) 
            var page = 1;  // int? | 页码，默认1 (optional)  (default to 1)
            var limit = 10;  // int? | 每页条数，默认10，最大30 (optional)  (default to 10)

            try
            {
                // 查询空投记录
                List<CandyDropV4AirdropRecordCd06> result = apiInstance.GetCandyDropAirdropRecordsV4(currency, startTime, endTime, page, limit);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling LaunchApi.GetCandyDropAirdropRecordsV4: " + e.Message);
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
 **currency** | **string**| 币种名称筛选 | [optional] 
 **startTime** | **long?**| 开始时间（Unix 时间戳秒） | [optional] 
 **endTime** | **long?**| 结束时间（Unix 时间戳秒） | [optional] 
 **page** | **int?**| 页码，默认1 | [optional] [default to 1]
 **limit** | **int?**| 每页条数，默认10，最大30 | [optional] [default to 10]

### Return type

[**List&lt;CandyDropV4AirdropRecordCd06&gt;**](CandyDropV4AirdropRecordCd06.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 成功返回空投记录列表 |  -  |
| **400** | Invalid request parameters |  -  |
| **401** | User not authenticated |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

