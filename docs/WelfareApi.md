# Io.Gate.GateApi.Api.WelfareApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUserIdentity**](WelfareApi.md#getuseridentity) | **GET** /rewards/getUserIdentity | Get user identity
[**GetBeginnerTaskList**](WelfareApi.md#getbeginnertasklist) | **GET** /rewards/getBeginnerTaskList | Get beginner task list
[**ClaimTask**](WelfareApi.md#claimtask) | **POST** /rewards/claimTask | 领取任务
[**ClaimReward**](WelfareApi.md#claimreward) | **POST** /rewards/claimReward | 领取任务奖励


<a name="getuseridentity"></a>
# **GetUserIdentity**
> ApiResponseExSkillGetUserIdentityResp GetUserIdentity ()

Get user identity

Validate whether the user is eligible for new user rewards. Returns the corresponding error code on validation failure, data is an empty object on success.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetUserIdentityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WelfareApi(config);

            try
            {
                // Get user identity
                ApiResponseExSkillGetUserIdentityResp result = apiInstance.GetUserIdentity();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WelfareApi.GetUserIdentity: " + e.Message);
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

[**ApiResponseExSkillGetUserIdentityResp**](ApiResponseExSkillGetUserIdentityResp.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The endpoint always returns HTTP 200. Business results are distinguished by the code field |  -  |
| **400** | Invalid request parameters |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbeginnertasklist"></a>
# **GetBeginnerTaskList**
> ApiResponseExSkillGetBeginnerTaskListResp GetBeginnerTaskList ()

Get beginner task list

获取当前用户的新客入门任务列表。  默认返回已经归属到当前用户的注册任务（type=10）和引导任务（type=11），注册任务排在前面，引导任务排在后面。 当用户尚未拥有下载任务、且系统判断用户未下载过 App 时，会动态补充一条“待领取下载任务”卡片。  其中： - 下载任务的 `task_type = 23` - 待领取下载任务的 `status = 0`  结果缓存 60 秒。任务列表数量有限（通常不超过 10 条），无需分页。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetBeginnerTaskListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WelfareApi(config);

            try
            {
                // Get beginner task list
                ApiResponseExSkillGetBeginnerTaskListResp result = apiInstance.GetBeginnerTaskList();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WelfareApi.GetBeginnerTaskList: " + e.Message);
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

[**ApiResponseExSkillGetBeginnerTaskListResp**](ApiResponseExSkillGetBeginnerTaskListResp.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The endpoint always returns HTTP 200. Business results are distinguished by the code field |  -  |
| **400** | Invalid request parameters |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="claimtask"></a>
# **ClaimTask**
> ApiResponseExSkillClaimTaskResp ClaimTask (ExSkillClaimTaskReq exSkillClaimTaskReq)

领取任务

领取单个福利任务。  当前主场景为新客下载任务领取，但接口本身支持新客注册、引导、进阶任务类型。  处理流程： 1. 读取登录用户 2. 做用户资格校验 3. 风控校验（事件码 `task_center`） 4. 校验任务配置与任务中心任务 5. 校验是否已存在进行中任务 6. 若为下载任务，校验是否已下载 App 7. 写入 `welfare_user_tasks_xx` 8. 上报任务中心  风控透传字段： - 老字段：`user_id`、`ip`、`const_id`、`is_async`、`action`、`task_id` - 新增字段：`req_method`、`traceid` - 其中：   - `req_method` 来自 `X-Gate-Request-Source`   - `ip` 来自 `X-Gate-Ip`   - `traceid` 来自 `X-Gate-Trace-Id`   - `const_id` 固定为空字符串

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ClaimTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WelfareApi(config);
            var exSkillClaimTaskReq = new ExSkillClaimTaskReq(); // ExSkillClaimTaskReq | 

            try
            {
                // 领取任务
                ApiResponseExSkillClaimTaskResp result = apiInstance.ClaimTask(exSkillClaimTaskReq);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WelfareApi.ClaimTask: " + e.Message);
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
 **exSkillClaimTaskReq** | [**ExSkillClaimTaskReq**](ExSkillClaimTaskReq.md)|  | 

### Return type

[**ApiResponseExSkillClaimTaskResp**](ApiResponseExSkillClaimTaskResp.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The endpoint always returns HTTP 200. Business results are distinguished by the code field |  -  |
| **400** | Invalid request parameters |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="claimreward"></a>
# **ClaimReward**
> ApiResponseExSkillClaimRewardResp ClaimReward (ExSkillClaimRewardReq exSkillClaimRewardReq)

领取任务奖励

领取单个福利任务奖励。  处理流程： 1. 读取登录用户 2. 做用户资格校验 3. 查询 `welfare_user_tasks_xx`，要求任务状态为 `StatusDone(2)` 4. 风控校验（事件码 `index_page_check`） 5. 查询任务中心任务详情与奖励信息 6. 若奖励为 m 选 n 奖池，则返回 `has_m_n_task = true`，不实际发奖 7. 普通奖励则进入福利中心原领奖逻辑  风控透传字段： - 老字段：`user_id`、`ip`、`const_id`、`is_async` - 新增字段：`req_method`、`traceid` - 其中：   - `req_method` 来自 `X-Gate-Request-Source`   - `ip` 来自 `X-Gate-Ip`   - `traceid` 来自 `X-Gate-Trace-Id`   - `const_id` 固定为空字符串

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ClaimRewardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new WelfareApi(config);
            var exSkillClaimRewardReq = new ExSkillClaimRewardReq(); // ExSkillClaimRewardReq | 

            try
            {
                // 领取任务奖励
                ApiResponseExSkillClaimRewardResp result = apiInstance.ClaimReward(exSkillClaimRewardReq);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling WelfareApi.ClaimReward: " + e.Message);
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
 **exSkillClaimRewardReq** | [**ExSkillClaimRewardReq**](ExSkillClaimRewardReq.md)|  | 

### Return type

[**ApiResponseExSkillClaimRewardResp**](ApiResponseExSkillClaimRewardResp.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The endpoint always returns HTTP 200. Business results are distinguished by the code field |  -  |
| **400** | Invalid request parameters |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

