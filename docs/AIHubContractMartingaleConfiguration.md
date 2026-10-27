
# Io.Gate.GateApi.Model.AIHubContractMartingaleConfiguration

AIHub-supported persisted contract settings. This is not a complete advanced native configuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvestAmount** | **string** |  | [optional] 
**InvestmentCurrency** | **string** |  | [optional] 
**PriceDeviation** | **string** |  | [optional] 
**TakeProfitRatio** | **string** |  | [optional] 
**Direction** | **string** |  | [optional] 
**FirstOrderSize** | **string** | Exact decimal contract quantity from the product snapshot; empty remains unverified, never inferred from the total budget. | [optional] 
**MaxOrders** | **long** | Maximum additional entries excluding the first. | [optional] 
**Leverage** | **int** |  | [optional] 
**StopLossPriceRule** | [**AIHubMartingalePriceRule**](AIHubMartingalePriceRule.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
