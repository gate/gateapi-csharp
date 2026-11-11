
# Io.Gate.GateApi.Model.FuturesOrderBook

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | Order Book ID. Increases by 1 on every order book change. Set &#x60;with_id&#x3D;true&#x60; to include this field in response | [optional] 
**Current** | **double** | Response data generation timestamp | [optional] 
**CurrentUs** | **long** | Response data timestamp in microseconds; omitted when unavailable | [optional] 
**Update** | **double** | Order book changed timestamp | [optional] 
**UpdateUs** | **long** | Order book update timestamp in microseconds; omitted when unavailable | [optional] 
**Asks** | [**List&lt;FuturesOrderBookItem&gt;**](FuturesOrderBookItem.md) | Ask Depth | 
**Bids** | [**List&lt;FuturesOrderBookItem&gt;**](FuturesOrderBookItem.md) | Bid Depth | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
