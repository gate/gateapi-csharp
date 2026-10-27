
# Io.Gate.GateApi.Model.AIHubPortfolioRunningItem

A single record in the list of running policies.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StrategyId** | **string** |  | 
**StrategyType** | **StrategyType** |  | 
**StrategyName** | **string** |  | 
**Market** | **string** | Single market, or empty string for a portfolio; use assets/markets for the latter. | 
**Status** | **string** |  | 
**Pnl** | **string** |  | [optional] 
**PnlRate** | **string** |  | [optional] 
**InvestAmount** | **string** |  | [optional] 
**CreatedAt** | **string** | Created time | [optional] 
**Assets** | **List&lt;string&gt;** |  | [optional] 
**Markets** | **List&lt;string&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
