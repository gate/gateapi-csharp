
# Io.Gate.GateApi.Model.AIHubRecommendation

A single piece of strategy recommendation information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RecommendationId** | **string** |  | 
**Market** | **string** |  | 
**StrategyType** | **StrategyType** |  | 
**StrategyName** | **string** |  | 
**BacktestApr** | **string** |  | [optional] 
**MaxDrawdown** | **string** |  | [optional] 
**Summary** | **string** |  | 
**StrategyParamsPreview** | **string** | Recommended-parameter preview as JSON text (string-encoded so clients deserialize it consistently). The value is a serialized JSON object whose structure varies by strategy type; callers or upper-layer models must parse it. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
