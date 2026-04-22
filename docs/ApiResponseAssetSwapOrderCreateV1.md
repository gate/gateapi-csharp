
# Io.Gate.GateApi.Model.ApiResponseAssetSwapOrderCreateV1

Asset allocation optimization - unified response to orders

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **int** | Business error code, 0 means success | 
**Label** | **string** | Error identification code, empty string on success | [optional] 
**Message** | **string** | Description information | 
**Data** | [**OrderCreateV1Resp**](OrderCreateV1Resp.md) | It is the order result when successful, and null when it fails. | 
**Timestamp** | **long** | Server timestamp (milliseconds) | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
