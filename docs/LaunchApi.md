# Io.Gate.GateApi.Api.LaunchApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListLaunchPoolProjects**](LaunchApi.md#listlaunchpoolprojects) | **GET** /launch/project-list | Query LaunchPool project list
[**CreateLaunchPoolOrder**](LaunchApi.md#createlaunchpoolorder) | **POST** /launch/create-order | Create LaunchPool staking order
[**RedeemLaunchPool**](LaunchApi.md#redeemlaunchpool) | **POST** /launch/redeem | Redeem LaunchPool staked assets
[**ListLaunchPoolPledgeRecords**](LaunchApi.md#listlaunchpoolpledgerecords) | **GET** /launch/user-pledge-records | Query user pledge records
[**ListLaunchPoolRewardRecords**](LaunchApi.md#listlaunchpoolrewardrecords) | **GET** /launch/get-user-reward-records | Query user reward records
[**GetHodlerAirdropProjectList**](LaunchApi.md#gethodlerairdropprojectlist) | **GET** /launch/hodler-airdrop/project-list | Check the list of HODLer Airdrop activities
[**HodlerAirdropOrder**](LaunchApi.md#hodlerairdroporder) | **POST** /launch/hodler-airdrop/order | Participate in the HODLer Airdrop event
[**GetHodlerAirdropUserOrderRecords**](LaunchApi.md#gethodlerairdropuserorderrecords) | **GET** /launch/hodler-airdrop/user-order-records | Check HODLer Airdrop participation records
[**GetHodlerAirdropUserAirdropRecords**](LaunchApi.md#gethodlerairdropuserairdroprecords) | **GET** /launch/hodler-airdrop/user-airdrop-records | Query HODLer Airdrop records
[**GetCandyDropActivityListV4**](LaunchApi.md#getcandydropactivitylistv4) | **GET** /launch/candydrop/activity-list | Query activity list
[**RegisterCandyDropV4**](LaunchApi.md#registercandydropv4) | **POST** /launch/candydrop/register | Sign up for events
[**GetCandyDropActivityRulesV4**](LaunchApi.md#getcandydropactivityrulesv4) | **GET** /launch/candydrop/activity-rules | Query activity rules
[**GetCandyDropTaskProgressV4**](LaunchApi.md#getcandydroptaskprogressv4) | **GET** /launch/candydrop/task-progress | Query task completion progress
[**GetCandyDropParticipationRecordsV4**](LaunchApi.md#getcandydropparticipationrecordsv4) | **GET** /launch/candydrop/participation-records | Query participation records
[**GetCandyDropAirdropRecordsV4**](LaunchApi.md#getcandydropairdroprecordsv4) | **GET** /launch/candydrop/airdrop-records | Query airdrop records


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

Check the list of HODLer Airdrop activities

Get the HODLer Airdrop activity list, which supports filtering by status, currency/project name, and participation status. This interface does not require user login, and logged in users can obtain personal participation information.

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
            var status = "status_example";  // string | Activity status filtering, optional values: ACTIVE (in progress + preheating), UNDERWAY (in progress), PREHEAT (preheating), FINISH (ended), return all if not passed (optional) 
            var keyword = "keyword_example";  // string | Currency/project name keywords, fuzzy matching (optional) 
            var join = 0;  // int? | Participation filter: 0 all (default), 1 only participated (optional)  (default to 0)
            var page = 1;  // int? | Page number, default 1 (optional)  (default to 1)
            var size = 10;  // int? | Number of items per page, default 10 (optional)  (default to 10)

            try
            {
                // Check the list of HODLer Airdrop activities
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
 **status** | **string**| Activity status filtering, optional values: ACTIVE (in progress + preheating), UNDERWAY (in progress), PREHEAT (preheating), FINISH (ended), return all if not passed | [optional] 
 **keyword** | **string**| Currency/project name keywords, fuzzy matching | [optional] 
 **join** | **int?**| Participation filter: 0 all (default), 1 only participated | [optional] [default to 0]
 **page** | **int?**| Page number, default 1 | [optional] [default to 1]
 **size** | **int?**| Number of items per page, default 10 | [optional] [default to 10]

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

Participate in the HODLer Airdrop event

To participate in designated HODLer Airdrop activities, you need to hold GT. This interface requires user login authentication and must meet KYC requirements. It does not support sub-accounts and enterprise/institutional users.

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
                // Participate in the HODLer Airdrop event
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
| **200** | Successfully participated in the event |  -  |
| **400** | Incorrect request parameters or failed business verification (insufficient KYC, sub-account restrictions, enterprise user restrictions, etc.) |  -  |
| **401** | User is not logged in |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethodlerairdropuserorderrecords"></a>
# **GetHodlerAirdropUserOrderRecords**
> List&lt;HodlerAirdropV4UserOrderRecord&gt; GetHodlerAirdropUserOrderRecords (string keyword = null, int? startTimest = null, int? endTimest = null, int? page = null, int? size = null)

Check HODLer Airdrop participation records

Query the user's HODLer Airdrop participation record and return the effective holdings and airdrop amount of each activity. This interface requires user login authentication.

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
            var keyword = "keyword_example";  // string | Currency name keyword filtering (optional) 
            var startTimest = 56;  // int? | Start timestamp (seconds) (optional) 
            var endTimest = 56;  // int? | end timestamp (seconds) (optional) 
            var page = 1;  // int? | Page number, default 1 (optional)  (default to 1)
            var size = 10;  // int? | Number of items per page, default 10 (optional)  (default to 10)

            try
            {
                // Check HODLer Airdrop participation records
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
 **keyword** | **string**| Currency name keyword filtering | [optional] 
 **startTimest** | **int?**| Start timestamp (seconds) | [optional] 
 **endTimest** | **int?**| end timestamp (seconds) | [optional] 
 **page** | **int?**| Page number, default 1 | [optional] [default to 1]
 **size** | **int?**| Number of items per page, default 10 | [optional] [default to 10]

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
| **200** | Successfully returned the participation record list |  -  |
| **400** | Invalid request parameters |  -  |
| **401** | User is not logged in |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gethodlerairdropuserairdroprecords"></a>
# **GetHodlerAirdropUserAirdropRecords**
> List&lt;HodlerAirdropV4UserAirdropRecord&gt; GetHodlerAirdropUserAirdropRecords (string keyword = null, int? startTimest = null, int? endTimest = null, int? page = null, int? size = null)

Query HODLer Airdrop records

Query the HODLer Airdrop airdrop distribution record that the user has obtained, including basic airdrops, additional airdrops and automatic redemption status. This interface requires user login authentication.

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
            var keyword = "keyword_example";  // string | Currency name keyword filtering (optional) 
            var startTimest = 56;  // int? | Start timestamp (seconds) (optional) 
            var endTimest = 56;  // int? | end timestamp (seconds) (optional) 
            var page = 1;  // int? | Page number, default 1 (optional)  (default to 1)
            var size = 10;  // int? | Number of items per page, default 10 (optional)  (default to 10)

            try
            {
                // Query HODLer Airdrop records
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
 **keyword** | **string**| Currency name keyword filtering | [optional] 
 **startTimest** | **int?**| Start timestamp (seconds) | [optional] 
 **endTimest** | **int?**| end timestamp (seconds) | [optional] 
 **page** | **int?**| Page number, default 1 | [optional] [default to 1]
 **size** | **int?**| Number of items per page, default 10 | [optional] [default to 10]

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
| **200** | Successfully returns the airdrop record list |  -  |
| **400** | Invalid request parameters |  -  |
| **401** | User is not logged in |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcandydropactivitylistv4"></a>
# **GetCandyDropActivityListV4**
> List&lt;CandyDropV4ActivityCd01&gt; GetCandyDropActivityListV4 (string status = null, string ruleName = null, string registerStatus = null, string currency = null, int? limit = null, int? offset = null)

Query activity list

Supports multi-dimensional filtering of CandyDrop activities, and each query returns the top ten data sorted by the list. No login required.

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
            var status = "status_example";  // string | Activity status filtering: ongoing (in progress), upcoming (about to start), ended (ended), if not passed, all will be returned (optional) 
            var ruleName = "ruleName_example";  // string | Task type filtering: spot (spot), futures (contract), deposit (recharge), invite (invitation), trading_bot (trading robot), simple_earn (Yu Bibao), first_deposit (first deposit), alpha (Alpha), flash_swap (flash swap), tradfi (TradFi), etf (ETF) (optional) 
            var registerStatus = "registerStatus_example";  // string | Participation status screening: registered (already participated), unregistered (not participated), if not passed, all will be returned (optional) 
            var currency = "currency_example";  // string | Currency name filter (optional) 
            var limit = 10;  // int? | Number of items returned, default 10, maximum 30 (optional)  (default to 10)
            var offset = 0;  // int? | Offset, default 0 (optional)  (default to 0)

            try
            {
                // Query activity list
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
 **status** | **string**| Activity status filtering: ongoing (in progress), upcoming (about to start), ended (ended), if not passed, all will be returned | [optional] 
 **ruleName** | **string**| Task type filtering: spot (spot), futures (contract), deposit (recharge), invite (invitation), trading_bot (trading robot), simple_earn (Yu Bibao), first_deposit (first deposit), alpha (Alpha), flash_swap (flash swap), tradfi (TradFi), etf (ETF) | [optional] 
 **registerStatus** | **string**| Participation status screening: registered (already participated), unregistered (not participated), if not passed, all will be returned | [optional] 
 **currency** | **string**| Currency name filter | [optional] 
 **limit** | **int?**| Number of items returned, default 10, maximum 30 | [optional] [default to 10]
 **offset** | **int?**| Offset, default 0 | [optional] [default to 0]

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
| **200** | Successfully returns the activity list array |  -  |
| **400** | Invalid request parameters |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registercandydropv4"></a>
# **RegisterCandyDropV4**
> CandyDropV4RegisterRespCd02 RegisterCandyDropV4 (CandyDropV4RegisterReqCd02 candyDropV4RegisterReqCd02)

Sign up for events

Sign up for select CandyDrop events. Login is required and API Key signature authentication is required.

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
                // Sign up for events
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
| **200** | Registration successful |  -  |
| **400** | Request failed |  -  |
| **401** | User not authenticated |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcandydropactivityrulesv4"></a>
# **GetCandyDropActivityRulesV4**
> CandyDropV4ActivityRulesCd03 GetCandyDropActivityRulesV4 (long? activityId = null, string currency = null)

Query activity rules

Query the rules of a specific activity, including prize pool and corresponding task data. No login required.

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
            var activityId = 56;  // long? | Activity ID, choose one from currency, at least one of them must be passed (optional) 
            var currency = "currency_example";  // string | Project/currency name, choose one from activity_id, at least one of them must be passed (optional) 

            try
            {
                // Query activity rules
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
 **activityId** | **long?**| Activity ID, choose one from currency, at least one of them must be passed | [optional] 
 **currency** | **string**| Project/currency name, choose one from activity_id, at least one of them must be passed | [optional] 

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
| **200** | Successful return to activity rules |  -  |
| **400** | Invalid request parameters |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcandydroptaskprogressv4"></a>
# **GetCandyDropTaskProgressV4**
> CandyDropV4TaskProgressCd04 GetCandyDropTaskProgressV4 (long? activityId = null, string currency = null)

Query task completion progress

Check the completion progress of tasks that are in progress and have been registered/participated. Login required.

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
            var activityId = 56;  // long? | Activity ID, choose one from currency, at least one of them must be passed (optional) 
            var currency = "currency_example";  // string | Project/currency name, choose one from activity_id, at least one of them must be passed (optional) 

            try
            {
                // Query task completion progress
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
 **activityId** | **long?**| Activity ID, choose one from currency, at least one of them must be passed | [optional] 
 **currency** | **string**| Project/currency name, choose one from activity_id, at least one of them must be passed | [optional] 

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
| **200** | Successfully return task progress |  -  |
| **400** | Invalid request parameters |  -  |
| **401** | User not authenticated |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcandydropparticipationrecordsv4"></a>
# **GetCandyDropParticipationRecordsV4**
> List&lt;CandyDropV4ParticipationRecordCd05&gt; GetCandyDropParticipationRecordsV4 (string currency = null, string status = null, long? startTime = null, long? endTime = null, int? page = null, int? limit = null)

Query participation records

Query the user's CandyDrop participation details. Login required.

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
            var currency = "currency_example";  // string | Currency name filter (optional) 
            var status = "status_example";  // string | Status filtering: ongoing (in progress), awaiting_draw (to be drawn), won (already won), not_win (not won) (optional) 
            var startTime = 56;  // long? | Start time (Unix timestamp seconds) (optional) 
            var endTime = 56;  // long? | End time (Unix timestamp seconds) (optional) 
            var page = 1;  // int? | Page number, default 1 (optional)  (default to 1)
            var limit = 10;  // int? | Number of items per page, default 10, maximum 30 (optional)  (default to 10)

            try
            {
                // Query participation records
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
 **currency** | **string**| Currency name filter | [optional] 
 **status** | **string**| Status filtering: ongoing (in progress), awaiting_draw (to be drawn), won (already won), not_win (not won) | [optional] 
 **startTime** | **long?**| Start time (Unix timestamp seconds) | [optional] 
 **endTime** | **long?**| End time (Unix timestamp seconds) | [optional] 
 **page** | **int?**| Page number, default 1 | [optional] [default to 1]
 **limit** | **int?**| Number of items per page, default 10, maximum 30 | [optional] [default to 10]

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
| **200** | Successfully returned the participation record list |  -  |
| **400** | Invalid request parameters |  -  |
| **401** | User not authenticated |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcandydropairdroprecordsv4"></a>
# **GetCandyDropAirdropRecordsV4**
> List&lt;CandyDropV4AirdropRecordCd06&gt; GetCandyDropAirdropRecordsV4 (string currency = null, long? startTime = null, long? endTime = null, int? page = null, int? limit = null)

Query airdrop records

Query the user's CandyDrop airdrop details. Login required.

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
            var currency = "currency_example";  // string | Currency name filter (optional) 
            var startTime = 56;  // long? | Start time (Unix timestamp seconds) (optional) 
            var endTime = 56;  // long? | End time (Unix timestamp seconds) (optional) 
            var page = 1;  // int? | Page number, default 1 (optional)  (default to 1)
            var limit = 10;  // int? | Number of items per page, default 10, maximum 30 (optional)  (default to 10)

            try
            {
                // Query airdrop records
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
 **currency** | **string**| Currency name filter | [optional] 
 **startTime** | **long?**| Start time (Unix timestamp seconds) | [optional] 
 **endTime** | **long?**| End time (Unix timestamp seconds) | [optional] 
 **page** | **int?**| Page number, default 1 | [optional] [default to 1]
 **limit** | **int?**| Number of items per page, default 10, maximum 30 | [optional] [default to 10]

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
| **200** | Successfully returns the airdrop record list |  -  |
| **400** | Invalid request parameters |  -  |
| **401** | User not authenticated |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

