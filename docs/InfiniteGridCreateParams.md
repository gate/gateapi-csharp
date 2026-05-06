
# Io.Gate.GateApi.Model.InfiniteGridCreateParams

无限网格策略的创建参数。  与 App 口径对齐：**仅** &#x60;money&#x60;、&#x60;price_floor&#x60;、&#x60;profit_per_grid&#x60; 为必填； &#x60;grid_num&#x60;、&#x60;price_type&#x60; 可选（不传时由服务端按默认处理）。

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
