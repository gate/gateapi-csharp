
# Io.Gate.GateApi.Model.FixedTermLendRequest

Subscription request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductId** | **int** | Product ID | 
**Amount** | **string** | Subscription amount | 
**YearRate** | **string** | Annual interest rate | [optional] 
**ReinvestStatus** | **int** | Auto-renewal status: 0 for disabled, 1 for enabled | [optional] 
**RedeemAccountType** | **int** | Redemption payout account type: 1 for spot account | [optional] 
**FinancialRateId** | **int** | Interest rate boost coupon ID, 0 means not used | [optional] 
**SubBusiness** | **int** | Sub-business type | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
