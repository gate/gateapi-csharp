
# Io.Gate.GateApi.Model.AIHubRebalanceCreateParams

Creation parameters for a smart-position strategy.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BeginMoneyAmount** | **string** |  | 
**BeginMoneyCurrency** | **string** |  | 
**AssetInfo** | [**List&lt;AIHubRebalanceAsset&gt;**](AIHubRebalanceAsset.md) |  | 
**Period** | **string** | Product interval between 1m and 28d. | [optional] 
**Threshold** | **string** | Positive ratio below 1, at most four decimal places. | [optional] 
**CloseFlag** | **int** |  | [optional] [default to CloseFlagEnum.NUMBER_1]
**IsUseBase** | **bool** |  | [optional] 
**StopProfit** | **string** |  | [optional] 
**StopLoss** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
