
# Io.Gate.GateApi.Model.SpotMartingaleCreateParams

Spot martingale creation parameters (serialized fields aligned with &#x60;MartingaleBot&#x60;). - **Stop-loss**: use &#x60;stop_loss_per_cycle&#x60; (ratio per round), same as the app; **do not** use &#x60;stop_loss_price&#x60;. - Optional **&#x60;trigger_price&#x60;**: trigger price. - If &#x60;stop_loss_per_cycle&#x60; is passed and &gt; 0, the server validates roughly between &#x60;0.001&#x60; and &#x60;0.9999&#x60; (same as &#x60;check_martingale&#x60;).

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
