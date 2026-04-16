
# Io.Gate.GateApi.Model.ApiResponseAssetSwapEvaluate

资产配置优化-估值统一响应

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **int** | 业务错误码，0 表示成功 | 
**Label** | **string** | 错误标识码，成功时为空字符串 | [optional] 
**Message** | **string** | 描述信息 | 
**Data** | [**EvaluateResp**](EvaluateResp.md) | 成功时为估值分页数据，失败时为 null | 
**Timestamp** | **long** | Server timestamp (milliseconds) | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
