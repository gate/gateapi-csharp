
# Io.Gate.GateApi.Model.AutoInvestPlanDetail

Auto invest planDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | Plan ID | 
**Version** | **long** | PlanVersion | [optional] 
**Name** | **string** | Plan name | 
**CreateTime** | **long** | Creation time (Unix timestamp) | 
**UpdateTime** | **long** | Update time (Unix timestamp) | 
**UserId** | **long** | User ID | 
**Money** | **string** | Quote Currency | 
**Amount** | **string** | Per PeriodInvestment amount | 
**PeriodType** | **string** | Cycle type（e.g., monthly） | 
**PeriodDay** | **long** | Cycle day | 
**PeriodHour** | **long** | CycleHours | 
**Portfolio** | [**List&lt;AutoInvestPortfolioItem&gt;**](AutoInvestPortfolioItem.md) | InvestmentPortfolio | 
**NextTime** | **long** | Next execution time (Unix timestamp) | 
**Period** | **long** | Executed periods | 
**FundSource** | **string** | Fund source（spot/earn） | 
**FundFlow** | **string** | Fund flow direction (auto_invest/earn) | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
