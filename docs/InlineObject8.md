
# Io.Gate.GateApi.Model.InlineObject8

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CryptoCurrency** | **string** | Cryptocurrency | 
**FiatCurrency** | **string** | Fiat currency | 
**SelectType** | **string** | Buy/Sell (sell&#x3D;Sell, buy&#x3D;Buy, others&#x3D;All) | [optional] 
**Status** | **string** | Order Status (dispute: Disputed Order; closed: ACCEPT, BCLOSED; cancel: CANCEL, BECANCEL, SCLOSED, SCANCEL; locked: LOCKED; open: OPEN; paid: PAID; completed: CANCEL, BECANCEL, SCLOSED, SCANCEL, ACCEPT, BCLOSED) | [optional] 
**Txid** | **int** | Order ID | [optional] 
**StartTime** | **int** | Start timestamp, default is 00:00 89 days ago | [optional] 
**EndTime** | **int** | End timestamp, default is 23:59:59 today | [optional] 
**QueryDispute** | **int** | 1: Include appeal status, 0: None | [optional] 
**Page** | **int** | page number | [optional] 
**PerPage** | **int** | Number of orders per page | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
