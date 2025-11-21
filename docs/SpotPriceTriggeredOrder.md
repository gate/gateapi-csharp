
# Io.Gate.GateApi.Model.SpotPriceTriggeredOrder

Spot price order details

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Trigger** | [**SpotPriceTrigger**](SpotPriceTrigger.md) |  | 
**Put** | [**SpotPricePutOrder**](SpotPricePutOrder.md) |  | 
**Id** | **long** | Auto order ID | [optional] [readonly] 
**User** | **int** | User ID | [optional] [readonly] 
**Market** | **string** | Market | 
**Ctime** | **long** | Created time | [optional] [readonly] 
**Ftime** | **long** | End time | [optional] [readonly] 
**FiredOrderId** | **long** | ID of the order created after trigger | [optional] [readonly] 
**Status** | **string** | Status  - open: Running - cancelled: Manually cancelled - finish: Successfully completed - failed: Failed to execute - expired: Expired | [optional] [readonly] 
**Reason** | **string** | Additional description of how the order was completed | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
