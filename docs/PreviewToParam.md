
# Io.Gate.GateApi.Model.PreviewToParam

**For preview only** &#x60;OrderPreviewV1Req.to&#x60;. Target currency + **ratio ratio**. **Forbidden** is confused with the order &#x60;CreateParam&#x60;: the &#x60;to&#x60; of the order must be **&#x60;amount&#x60;**, and there is no &#x60;ratio&#x60; field.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Asset** | **string** | Target currency symbol; often corresponds to &#x60;recommend_v2.*[].schemes[].name&#x60; in config. | 
**Ratio** | **string** | The weight ratio of the target currency in the portfolio, **decimal string** (such as &#x60;0.2&#x60;, &#x60;0.5&#x60;). Often consistent with the &#x60;schemes[].ratio&#x60; of a strategy under &#x60;recommend_v2&#x60; of &#x60;GET /asset-swap/config&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
