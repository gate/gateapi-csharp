
# Io.Gate.GateApi.Model.ContractMartingaleCreateParams

The creation parameters of the contract Martin strategy.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvestAmount** | **string** | Total strategy budget, not first-order margin. The server uses the complete existing ladder formula, owner fee and live contract facts, quantizes quantity down and rechecks before allocation. Minimum infeasible budget is rejected. | 
**PriceDeviation** | **string** |  | 
**MaxOrders** | **int** | Maximum additional entries, excluding the first; preserve this legacy meaning. | 
**TakeProfitRatio** | **string** |  | 
**Direction** | **ContractMartingaleDirection** |  | 
**Leverage** | **string** |  | 
**StopLossPrice** | **string** | Positive fixed stop price; requires explicit stop_loss_price_type. Missing both leaves the old no-fixed-stop request unchanged. | [optional] 
**ProfitSharingRatio** | **string** |  | [optional] 
**StopLossPriceType** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
