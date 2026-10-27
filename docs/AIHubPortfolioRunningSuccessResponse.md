
# Io.Gate.GateApi.Model.AIHubPortfolioRunningSuccessResponse

The response body when querying the running policy list is successful.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **int** |  | 
**Message** | **string** |  | 
**Data** | [**AIHubPortfolioRunningData**](AIHubPortfolioRunningData.md) |  | [optional] 
**TraceId** | **string** |  | [optional] 
**Label** | **string** | Stable business error label when present. HTTP 200 can contain a non-200 business code; data may retain a real identity on failure. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
