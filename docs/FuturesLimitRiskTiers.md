
# Io.Gate.GateApi.Model.FuturesLimitRiskTiers

Retrieve risk limit configurations for different tiers under a specified contract

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tier** | **int** | Tier | [optional] 
**RiskLimit** | **string** | Position risk limit | [optional] 
**InitialRate** | **string** | Initial margin rate | [optional] 
**MaintenanceRate** | **string** | The maintenance margin rate of the first tier of risk limit sheet | [optional] 
**LeverageMax** | **string** | Maximum leverage | [optional] 
**Contract** | **string** | Market, only visible when market pagination is requested | [optional] 
**Deduction** | **string** | Maintenance margin quick calculation deduction amount | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
