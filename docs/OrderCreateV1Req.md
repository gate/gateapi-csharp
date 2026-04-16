
# Io.Gate.GateApi.Model.OrderCreateV1Req

资产配置优化下单请求。**&#x60;from&#x60; 与 &#x60;to&#x60; 数组元素均为 &#x60;CreateParam&#x60;，字段均为 &#x60;asset&#x60; + &#x60;amount&#x60;。** 不存在 &#x60;ratio&#x60; 字段；若从预览接口抄参，须将预览中的 &#x60;to[].ratio&#x60; 转换为下单所需的 &#x60;to[].amount&#x60;（按产品约定，通常依据预览返回的订单明细等），不可直接复用 &#x60;ratio&#x60; 字符串作为 &#x60;amount&#x60;。

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**From** | [**List&lt;CreateParam&gt;**](CreateParam.md) | 卖出侧列表，至少一项；每项为要换出的币种及数量 &#x60;amount&#x60;。 | 
**To** | [**List&lt;CreateParam&gt;**](CreateParam.md) | 目标侧列表，至少一项；每项为目标币种及**数量** &#x60;amount&#x60;（非比例）。 与 &#x60;OrderPreviewV1Req.to&#x60;（&#x60;PreviewToParam&#x60;，含 &#x60;ratio&#x60;）结构语义不同，勿混用。 | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
