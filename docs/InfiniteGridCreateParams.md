
# Io.Gate.GateApi.Model.InfiniteGridCreateParams

Infinite grid creation parameters. Aligned with the app: **&#x60;money&#x60;**, **&#x60;price_floor&#x60;**, and **&#x60;profit_per_grid&#x60;** are required; &#x60;grid_num&#x60; and &#x60;price_type&#x60; are optional (defaults applied server-side when omitted).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Money** | **string** |  | 
**PriceFloor** | **string** | price floor | 
**ProfitPerGrid** | **string** | Profit per square | 
**GridNum** | **int** | Optional; may be omitted like in the app. | [optional] 
**PriceType** | **int** | Optional. &#x60;0&#x60; arithmetic grid; &#x60;1&#x60; geometric; omit for server defaults. | [optional] 
**TriggerPrice** | **string** |  | [optional] 
**StopProfit** | **string** |  | [optional] 
**StopLoss** | **string** |  | [optional] 
**ProfitSharingRatio** | **string** |  | [optional] 
**IsUseBase** | **bool** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
