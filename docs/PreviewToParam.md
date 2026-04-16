
# Io.Gate.GateApi.Model.PreviewToParam

**仅用于预览** &#x60;OrderPreviewV1Req.to&#x60;。目标币种 + **比例 ratio**。 **禁止**与下单 &#x60;CreateParam&#x60; 混淆：下单的 &#x60;to&#x60; 必须使用 **&#x60;amount&#x60;**，没有 &#x60;ratio&#x60; 字段。

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Asset** | **string** | 目标币种符号；常与 config 中 &#x60;recommend_v2.*[].schemes[].name&#x60; 对应。 | 
**Ratio** | **string** | 该目标币种在组合中的权重比例，**十进制字符串**（如 &#x60;0.2&#x60;、&#x60;0.5&#x60;）。 常与 &#x60;GET /asset-swap/config&#x60; 的 &#x60;recommend_v2&#x60; 下某策略的 &#x60;schemes[].ratio&#x60; 一致。 | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
