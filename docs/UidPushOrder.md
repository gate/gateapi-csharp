
# Io.Gate.GateApi.Model.UidPushOrder

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | Order ID | [optional] 
**PushUid** | **long** | Initiator User ID | [optional] 
**ReceiveUid** | **long** | Recipient User ID | [optional] 
**Currency** | **string** | Currency name | [optional] 
**Amount** | **string** | Transfer amount | [optional] 
**CreateTime** | **long** | Created time | [optional] 
**Status** | **string** | Withdrawal status:  - CREATING: Creating - PENDING: Waiting for recipient (Please contact the recipient to accept the transfer on Gate official website) - CANCELLING: Cancelling - CANCELLED: Cancelled - REFUSING: Refusing - REFUSED: Refused - RECEIVING: Receiving - RECEIVED: Success | [optional] 
**Message** | **string** | PENDING reason tips | [optional] 
**TransactionType** | **string** | Order Type | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
