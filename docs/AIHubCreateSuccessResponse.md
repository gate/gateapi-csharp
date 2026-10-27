
# Io.Gate.GateApi.Model.AIHubCreateSuccessResponse

The response body when the creation strategy is successful.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **int** |  | 
**Message** | **string** |  | 
**Data** | [**AIHubCreateData**](AIHubCreateData.md) |  | [optional] 
**TraceId** | **string** |  | [optional] 
**Label** | **string** | Stable business error label when present. HTTP 200 can contain a non-200 business code; data may retain a real identity on failure. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
