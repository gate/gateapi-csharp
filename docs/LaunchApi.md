# Io.Gate.GateApi.Api.LaunchApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListLaunchPoolProjects**](LaunchApi.md#listlaunchpoolprojects) | **GET** /launch/project-list | Query LaunchPool project list
[**CreateLaunchPoolOrder**](LaunchApi.md#createlaunchpoolorder) | **POST** /launch/create-order | Create LaunchPool staking order
[**RedeemLaunchPool**](LaunchApi.md#redeemlaunchpool) | **POST** /launch/redeem | Redeem LaunchPool staked assets
[**ListLaunchPoolPledgeRecords**](LaunchApi.md#listlaunchpoolpledgerecords) | **GET** /launch/user-pledge-records | Query user pledge records
[**ListLaunchPoolRewardRecords**](LaunchApi.md#listlaunchpoolrewardrecords) | **GET** /launch/get-user-reward-records | Query user reward records


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

