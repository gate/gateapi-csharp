# Io.Gate.GateApi.Api.AnnouncementApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListAnnouncementArticles**](AnnouncementApi.md#listannouncementarticles) | **POST** /ann/list_article | List announcement articles


<a name="listannouncementarticles"></a>
# **ListAnnouncementArticles**
> AnnouncementArticleListResponse ListAnnouncementArticles (AnnouncementArticleListRequest announcementArticleListRequest)

List announcement articles

Query announcement articles with pagination and filters for title, category, language, time, and other criteria. Send query parameters in the JSON request body. Both page and size are optional and must be strings when provided. No API key is required.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListAnnouncementArticlesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new AnnouncementApi(config);
            var announcementArticleListRequest = new AnnouncementArticleListRequest(); // AnnouncementArticleListRequest | 

            try
            {
                // List announcement articles
                AnnouncementArticleListResponse result = apiInstance.ListAnnouncementArticles(announcementArticleListRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling AnnouncementApi.ListAnnouncementArticles: " + e.Message);
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
 **announcementArticleListRequest** | [**AnnouncementArticleListRequest**](AnnouncementArticleListRequest.md)|  | 

### Return type

[**AnnouncementArticleListResponse**](AnnouncementArticleListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Announcement article list response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

