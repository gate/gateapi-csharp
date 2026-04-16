
# Io.Gate.GateApi.Model.CreateParam

**下单专用**。表示某一侧（&#x60;from&#x60; 或 &#x60;to&#x60;）的一个币种及其**数量 amount**。 用于 &#x60;OrderCreateV1Req&#x60;；**不要**用于预览接口的 &#x60;to&#x60;（预览 &#x60;to&#x60; 使用 &#x60;PreviewToParam.ratio&#x60;）。

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Asset** | **string** | 币种符号，与 &#x60;GET /asset-swap/asset/list&#x60; 及业务支持范围一致。 | 
**Amount** | **string** | 该币种在本侧的数量，**十进制字符串**（非科学计数法）。&#x60;from&#x60; 表示卖出数量，&#x60;to&#x60; 表示目标侧数量。 与预览接口 &#x60;to[].ratio&#x60; 不同。 | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
