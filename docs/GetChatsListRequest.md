
# Io.Gate.GateApi.Model.GetChatsListRequest

Get chat history request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Txid** | **int** | Order ID; omit or &#x60;0&#x60; to return the latest order with chat for the user. | [optional] 
**Lastreceived** | **int** | Timestamp of the last received message for backward incremental fetch; omit on first load. | [optional] 
**Firstreceived** | **int** | Timestamp of first received message for paging backward; omit on first load. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
