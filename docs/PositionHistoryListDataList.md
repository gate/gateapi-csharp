
# Io.Gate.GateApi.Model.PositionHistoryListDataList

Position close history

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PositionId** | **long** | Position ID | 
**Symbol** | **string** | Market / Trading symbol | 
**RealizedPnl** | **string** | Realized PnL | 
**RealizedPnlRate** | **string** | Realized return rate | [optional] 
**Volume** | **string** | Position size / Maximum position size | 
**VolumeClosed** | **string** | Close volume | 
**PriceOpen** | **string** | Average Opening Price | 
**PositionDir** | **string** | Position Direction - Long: Long Position - Short: Short Position | 
**PriceTp** | **string** | Take profit price | [optional] 
**PriceSl** | **string** | Stop loss price | [optional] 
**CounterpartyPrice** | **string** | Counterparty price | [optional] 
**ClosePrice** | **string** | Close price | 
**TimeCreate** | **string** | Open time (timestamp in seconds) | 
**TimeClose** | **string** | Close time (timestamp in seconds) | 
**PositionStatus** | **string** | Position Status - 1: Fully Closed - 2: Forced Liquidation | 
**CloseDetail** | [**PositionHistoryListDataCloseDetail**](PositionHistoryListDataCloseDetail.md) |  | [optional] 
**RealizedPnlDetail** | [**PositionHistoryListDataRealizedPnlDetail**](PositionHistoryListDataRealizedPnlDetail.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
