
# Io.Gate.GateApi.Model.TradFiSpotTransactionRequest

Fund transfer request parameters. Transfer in means moving funds from the spot account to the stock account; transfer out means moving funds from the stock account to the spot account.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Asset** | **string** | Asset, USDT only | 
**Change** | **string** | Change amount, must be greater than 0 | 
**Type** | **string** | Transaction type. deposit transfers funds from the spot account to the stock account; withdraw transfers funds from the stock account to the spot account. | 
**RefId** | **string** | Business idempotent ID | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
