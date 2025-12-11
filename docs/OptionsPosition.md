
# Io.Gate.GateApi.Model.OptionsPosition

Options contract position details

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**User** | **int** | User ID | [optional] [readonly] 
**Underlying** | **string** | Underlying | [optional] [readonly] 
**UnderlyingPrice** | **string** | The forward futures price corresponding to the delivery date | [optional] [readonly] 
**Contract** | **string** | Options contract name | [optional] [readonly] 
**Size** | **long** | Position size (contract quantity) | [optional] [readonly] 
**EntryPrice** | **string** | Entry size (quote currency) | [optional] [readonly] 
**MarkPrice** | **string** | Current mark price (quote currency) | [optional] [readonly] 
**MarkIv** | **string** | Implied volatility | [optional] [readonly] 
**RealisedPnl** | **string** | Realized PnL | [optional] [readonly] 
**UnrealisedPnl** | **string** | Unrealised PnL &#x3D; (mark price - entry price) * position size. For long postion, size is positive; for short positon, size is negative.This value is for reference only. | [optional] [readonly] 
**PendingOrders** | **int** | Current pending order quantity | [optional] [readonly] 
**CloseOrder** | [**OptionsPositionCloseOrder**](OptionsPositionCloseOrder.md) |  | [optional] 
**Delta** | **string** | Greek letter delta | [optional] [readonly] 
**Gamma** | **string** | Greek letter gamma | [optional] [readonly] 
**Vega** | **string** | Greek letter vega | [optional] [readonly] 
**Theta** | **string** | Greek letter theta | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
