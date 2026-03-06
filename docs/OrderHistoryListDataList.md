
# Io.Gate.GateApi.Model.OrderHistoryListDataList

Order detail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | **int** | Order ID | [optional] 
**Symbol** | **string** | Currency pair | [optional] 
**SymbolDesc** | **string** | Trading symbol description | [optional] 
**PriceType** | **string** | Trade type (market&#x3D;market price, trigger&#x3D;trigger price) | [optional] 
**OrderOptType** | **int** | Order operation type (1&#x3D;sell, 2&#x3D;buy, 3&#x3D;close long, 4&#x3D;close short, 5&#x3D;force close long, 6&#x3D;force close short) | [optional] 
**State** | **int** | Order status code | [optional] 
**StateDesc** | **string** | Order status description | [optional] 
**Side** | **int** | Order side (1&#x3D;sell, 2&#x3D;buy) | [optional] 
**Volume** | **string** | Order volume | [optional] 
**FillVolume** | **string** | Trading size | [optional] 
**ClosePnl** | **string** | Close Position P&amp;L | [optional] 
**Price** | **string** | Average fill price | [optional] 
**TriggerPrice** | **string** | Trigger price | [optional] 
**PriceTp** | **string** | Take profit price | [optional] 
**PriceSl** | **string** | Stop loss price | [optional] 
**TimeSetup** | **long** | Order time (Unix timestamp in seconds) | [optional] 
**TimeDone** | **long** | End time (Unix timestamp in seconds) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
