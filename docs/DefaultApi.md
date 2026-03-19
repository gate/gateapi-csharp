# Io.Gate.GateApi.Api.DefaultApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMyActivityEntry**](DefaultApi.md#getmyactivityentry) | **GET** /rewards/activity/my-activity-entry | My activity entry
[**ListActivities**](DefaultApi.md#listactivities) | **GET** /rewards/activity/activity-list | Recommended activity list
[**ListActivityTypes**](DefaultApi.md#listactivitytypes) | **GET** /rewards/activity/activity-type | Activity type list


<a name="getmyactivityentry"></a>
# **GetMyActivityEntry**
> InlineResponse20011 GetMyActivityEntry ()

My activity entry

Query user's Activity Center entry information, including activity icon and redirect link

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetMyActivityEntryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new DefaultApi(config);

            try
            {
                // My activity entry
                InlineResponse20011 result = apiInstance.GetMyActivityEntry();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.GetMyActivityEntry: " + e.Message);
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

[**InlineResponse20011**](InlineResponse20011.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully returns activity entry information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listactivities"></a>
# **ListActivities**
> InlineResponse20012 ListActivities (string recommendType = null, string typeIds = null, string keywords = null, int? page = null, int? pageSize = null, string sortBy = null)

Recommended activity list

Query recommended activity list from Activity Center, supports pagination and sorting

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListActivitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new DefaultApi(config);
            var recommendType = "recommendType_example";  // string | Recommendation type: hot for popular activities, type for filtering by activity type (type_ids), scenario for matching by activity name (optional) 
            var typeIds = "typeIds_example";  // string | Activity type ID, multiple IDs separated by commas (supports filtering by activity type through this field) (optional) 
            var keywords = "keywords_example";  // string | Activity name. When scenario type is used, keyword matching is applied (optional) 
            var page = 1;  // int? | Page number, starting from 1 (optional)  (default to 1)
            var pageSize = 10;  // int? | Items per page (optional)  (default to 10)
            var sortBy = "sortBy_example";  // string | Sort order, e.g., hot for sorting by popularity (optional) 

            try
            {
                // Recommended activity list
                InlineResponse20012 result = apiInstance.ListActivities(recommendType, typeIds, keywords, page, pageSize, sortBy);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.ListActivities: " + e.Message);
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
 **recommendType** | **string**| Recommendation type: hot for popular activities, type for filtering by activity type (type_ids), scenario for matching by activity name | [optional] 
 **typeIds** | **string**| Activity type ID, multiple IDs separated by commas (supports filtering by activity type through this field) | [optional] 
 **keywords** | **string**| Activity name. When scenario type is used, keyword matching is applied | [optional] 
 **page** | **int?**| Page number, starting from 1 | [optional] [default to 1]
 **pageSize** | **int?**| Items per page | [optional] [default to 10]
 **sortBy** | **string**| Sort order, e.g., hot for sorting by popularity | [optional] 

### Return type

[**InlineResponse20012**](InlineResponse20012.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully returns activity list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listactivitytypes"></a>
# **ListActivityTypes**
> InlineResponse20013 ListActivityTypes ()

Activity type list

Query all activity types supported by Activity Center

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListActivityTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new DefaultApi(config);

            try
            {
                // Activity type list
                InlineResponse20013 result = apiInstance.ListActivityTypes();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.ListActivityTypes: " + e.Message);
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
| **200** | Successfully returns activity type list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

