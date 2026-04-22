
# Io.Gate.GateApi.Model.ApiResponseAssetSwapListAssets

Asset allocation optimization - unified response to currency list

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **int** | Business error code, 0 means success | 
**Label** | **string** | Error identification code, empty string on success | [optional] 
**Message** | **string** | Description information | 
**Data** | [**AssetListResp**](AssetListResp.md) | Currency list data on success, null on failure | 
**Timestamp** | **long** | Server timestamp (milliseconds) | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
