
# Io.Gate.GateApi.Model.OrderCreateV1Req

Asset allocation optimization order request. **The array elements of &#x60;from&#x60; and &#x60;to&#x60; are both &#x60;CreateParam&#x60;, and the fields are &#x60;asset&#x60; + &#x60;amount&#x60;. ** There is no &#x60;ratio&#x60; field; if you copy parameters from the preview interface, you must convert the &#x60;to[].ratio&#x60; in the preview into the &#x60;to[].amount&#x60; required for placing an order (according to the product agreement, usually based on the order details returned by the preview, etc.). The &#x60;ratio&#x60; string cannot be directly reused as &#x60;amount&#x60;.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**From** | [**List&lt;CreateParam&gt;**](CreateParam.md) | Sell ​​side list, at least one item; each item is the currency and amount &#x60;amount&#x60; to be swapped out. | 
**To** | [**List&lt;CreateParam&gt;**](CreateParam.md) | Target side list, at least one item; each item is the target currency and **amount** &#x60;amount&#x60; (non-proportional). The structural semantics are different from &#x60;OrderPreviewV1Req.to&#x60; (&#x60;PreviewToParam&#x60;, including &#x60;ratio&#x60;), so do not mix them. | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
