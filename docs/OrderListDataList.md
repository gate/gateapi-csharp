
# Io.Gate.GateApi.Model.OrderListDataList

Order detail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | **int** | Order ID | [optional] 
**Symbol** | **string** | Currency pair | [optional] 
**SymbolDesc** | **string** | Trading symbol description | [optional] 
**PriceType** | **string** | Trade type (market&#x3D;market price, trigger&#x3D;trigger price) | [optional] 
**State** | **int** | Order status code | [optional] 
**StateDesc** | **string** | Order status description | [optional] 
**Finished** | **int** | Is completed (0&#x3D;shown in active order list, 1&#x3D;not shown in active list) | [optional] 
**Side** | **int** | Order side (1&#x3D;sell, 2&#x3D;buy) | [optional] 
**Volume** | **string** | Order volume | [optional] 
**Price** | **string** | Trigger price | [optional] 
**PriceTp** | **string** | Take profit price | [optional] 
**PriceSl** | **string** | Stop loss price | [optional] 
**TimeSetup** | **long** | Order time (Unix timestamp in seconds) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
