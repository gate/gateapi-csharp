# Io.Gate.GateApi.Api.WelfareApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUserIdentity**](WelfareApi.md#getuseridentity) | **GET** /rewards/getUserIdentity | Get user identity
[**GetBeginnerTaskList**](WelfareApi.md#getbeginnertasklist) | **GET** /rewards/getBeginnerTaskList | Get beginner task list
[**ClaimTask**](WelfareApi.md#claimtask) | **POST** /rewards/claimTask | Get the task
[**ClaimReward**](WelfareApi.md#claimreward) | **POST** /rewards/claimReward | Receive mission rewards


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

Get the current user's onboarding task list. By default, the registration tasks (type=10) and guidance tasks (type=11) that have been assigned to the current user are returned. The registration tasks are ranked first and the guidance tasks are ranked behind. When the user does not have a download task and the system determines that the user has not downloaded the app, a \"Download task to be received\" card will be dynamically added. Among them: - `task_type = 23` for download tasks - `status = 0` for download tasks to be collected Results are cached for 60 seconds. Task lists are limited in number (usually no more than 10) and do not require pagination.

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

Get the task

Receive a single welfare task. The current main scene is for new customer download tasks to be collected, but the interface itself supports new customer registration, guidance, and advanced task types. Processing flow: 1. Read the logged in user 2. Verify user qualifications 3. Risk control verification (event code `task_center`) 4. Verify task configuration and task center tasks 5. Verify whether there is an ongoing task 6. If it is a download task, verify whether the App has been downloaded 7. Write `welfare_user_tasks_xx` 8. Report to task center Risk control transparent transmission fields: - Old fields: `user_id`, `ip`, `const_id`, `is_async`, `action`, `task_id` - New fields: `req_method`, `traceid` - Among them:   - `req_method` from `X-Gate-Request-Source`   - `ip` from `X-Gate-Ip`   - `traceid` from `X-Gate-Trace-Id`   - `const_id` is fixed to an empty string

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
                // Get the task
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

Receive mission rewards

Receive rewards from a single welfare task. Processing flow: 1. Read the logged in user 2. Verify user qualifications 3. Query `welfare_user_tasks_xx` and require the task status to be `StatusDone(2)` 4. Risk control verification (event code `index_page_check`) 5. Query task details and reward information in the task center 6. If the reward is m and n is selected from the prize pool, then `has_m_n_task = true` will be returned and the reward will not be actually issued. 7. Ordinary rewards will enter the original reward collection logic of the Welfare Center Risk control transparent transmission fields: - Old fields: `user_id`, `ip`, `const_id`, `is_async` - New fields: `req_method`, `traceid` - Among them:   - `req_method` from `X-Gate-Request-Source`   - `ip` from `X-Gate-Ip`   - `traceid` from `X-Gate-Trace-Id`   - `const_id` is fixed to an empty string

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
                // Receive mission rewards
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

