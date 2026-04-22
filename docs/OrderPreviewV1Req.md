
# Io.Gate.GateApi.Model.OrderPreviewV1Req

Asset allocation optimization **preview** request. &#x60;from&#x60; is the selling quantity; &#x60;to&#x60; is the target currency and **distribution ratio ratio** (not the absolute quantity). Please use &#x60;OrderCreateV1Req&#x60; to place a formal order, and its &#x60;to&#x60; is &#x60;amount&#x60;.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**From** | [**List&lt;PreviewFromParam&gt;**](PreviewFromParam.md) | Sell ​​side; each item is the currency + the swap amount &#x60;amount&#x60; (string decimal). | 
**To** | [**List&lt;PreviewToParam&gt;**](PreviewToParam.md) | Target side; each item is currency + **ratio** &#x60;ratio&#x60; (string decimal, such as &#x60;0.5&#x60;). Typical source: &#x60;GET /asset-swap/config&#x60; → &#x60;recommend_v2&#x60; &#x60;schemes[].name&#x60; / &#x60;schemes[].ratio&#x60; of the strategy under a certain group. | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
