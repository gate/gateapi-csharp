
# Io.Gate.GateApi.Model.P2pMerchantBooksPlaceBizPushOrderResponseDataRiskEvent

Risk control prompt event for advertisement content

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Prompt display type | [optional] 
**Title** | **string** | Risk control prompt title | [optional] 
**Msg** | **string** | Risk control prompt message generated based on the field that hit risk control | [optional] 
**Action** | [**List&lt;P2pMerchantBooksPlaceBizPushOrderResponseDataRiskEventAction&gt;**](P2pMerchantBooksPlaceBizPushOrderResponseDataRiskEventAction.md) | Available actions; advertisement content risk control only returns the close action | [optional] 
**ContentRiskType** | **string** | Advertisement content field that hit risk control | [optional] 
**TradeTips** | **string** | Prompt message returned when the trade terms hit risk control | [optional] 
**AutoReply** | **string** | Prompt message returned when the auto reply hits risk control | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
