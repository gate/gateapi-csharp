
# Io.Gate.GateApi.Model.ApiResponseAssetSwapOrderQueryV1

Asset allocation optimization - unified response to query orders

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **int** | Business error code, 0 means success | 
**Label** | **string** | Error identification code, empty string on success | [optional] 
**Message** | **string** | Description information | 
**Data** | [**CreateOrder**](CreateOrder.md) | Order details on success, null on failure | 
**Timestamp** | **long** | Server timestamp (milliseconds) | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
