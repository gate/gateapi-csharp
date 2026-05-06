
# Io.Gate.GateApi.Model.SpotMartingaleCreateParams

现货马丁策略的创建参数（对应 &#x60;MartingaleBot&#x60; 序列化字段）。  - **止损**：使用 &#x60;stop_loss_per_cycle&#x60;（每轮止损比例），与 App 一致；**不使用** &#x60;stop_loss_price&#x60;。 - 可选 **&#x60;trigger_price&#x60;**：触发价。 - &#x60;stop_loss_per_cycle&#x60; 若传入且大于 0，服务端校验区间约为 &#x60;0.001&#x60;～&#x60;0.9999&#x60;（与 &#x60;check_martingale&#x60; 一致）。

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvestAmount** | **string** |  | 
**PriceDeviation** | **string** | Add-position deviation ratio as a decimal string (e.g. a 2% drop is &#x60;0.02&#x60;). | 
**MaxOrders** | **int** |  | 
**TakeProfitRatio** | **string** | Take-profit ratio per round as a decimal string. | 
**StopLossPerCycle** | **string** | Stop-loss ratio per round as a decimal string; optional; aligned with app &#x60;stop_loss_per_cycle&#x60;. | [optional] 
**TriggerPrice** | **string** | Trigger price; optional. | [optional] 
**ProfitSharingRatio** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
