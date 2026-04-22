
# Io.Gate.GateApi.Model.CreateParam

**For order only**. Represents a currency and its **amount** on a certain side (&#x60;from&#x60; or &#x60;to&#x60;). Used with &#x60;OrderCreateV1Req&#x60;; **Don&#39;t** be used with &#x60;to&#x60; of the preview interface (preview &#x60;to&#x60; uses &#x60;PreviewToParam.ratio&#x60;).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Asset** | **string** | Currency symbol, consistent with &#x60;GET /asset-swap/asset/list&#x60; and business support scope. | 
**Amount** | **string** | The quantity of this currency on this side, **decimal string** (non-scientific notation). &#x60;from&#x60; represents the selling quantity, and &#x60;to&#x60; represents the target side quantity. Different from preview interface &#x60;to[].ratio&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
