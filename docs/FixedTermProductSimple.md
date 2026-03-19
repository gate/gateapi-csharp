
# Io.Gate.GateApi.Model.FixedTermProductSimple

Fixed-term earn product (compact)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Product ID | [optional] 
**Asset** | **string** | Currency | [optional] 
**LockUpPeriod** | **int** | Lock-up period (in days) | [optional] 
**YearRate** | **string** | Annual interest rate | [optional] 
**Type** | **int** | Product type: 1 for regular, 2 for VIP | [optional] 
**PreRedeem** | **int** | Whether early redemption is supported: 0 for not supported, 1 for supported | [optional] 
**Reinvest** | **int** | Whether auto-renewal is supported: 0 for not supported, 1 for supported | [optional] 
**SimpleEarn** | **int** | Whether fixed-to-flexible conversion is supported: 0 for not supported, 1 for supported | [optional] 
**MinVip** | **int** | Minimum VIP level requirement, 0 means no restriction | [optional] 
**MaxVip** | **int** | Maximum VIP level requirement, 0 means no restriction | [optional] 
**SaleStatus** | **int** | Sale status: 1 for on sale, 2 for sold out | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
