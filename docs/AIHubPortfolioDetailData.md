
# Io.Gate.GateApi.Model.AIHubPortfolioDetailData

Policy details data.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StrategyId** | **string** |  | 
**StrategyType** | **StrategyType** |  | 
**Market** | **string** | Single market, or empty string for a portfolio; use assets/markets for the latter. | 
**Status** | **string** |  | 
**BaseInfo** | [**AIHubPortfolioBaseInfo**](AIHubPortfolioBaseInfo.md) |  | 
**Metrics** | [**AIHubPortfolioMetrics**](AIHubPortfolioMetrics.md) |  | 
**Position** | [**AIHubPortfolioPosition**](AIHubPortfolioPosition.md) |  | [optional] 
**StopSupported** | **bool** |  | 
**Assets** | **List&lt;string&gt;** |  | [optional] 
**Markets** | **List&lt;string&gt;** |  | [optional] 
**Positions** | [**List&lt;AIHubPortfolioAssetPosition&gt;**](AIHubPortfolioAssetPosition.md) |  | [optional] 
**PositionsStatus** | **string** |  | [optional] 
**Configuration** | [**Object**](.md) | Product-specific saved configuration. spot_martingale exposes AIHubSpotMartingaleConfiguration; absence is unverified. Runtime recovery internals are excluded. | [optional] 
**StopProgress** | [**AIHubStopProgress**](AIHubStopProgress.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
