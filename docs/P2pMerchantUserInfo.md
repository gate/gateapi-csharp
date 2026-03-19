
# Io.Gate.GateApi.Model.P2pMerchantUserInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsSelf** | **bool** | Whether self | [optional] 
**UserTimest** | **string** | User registration time (formatted string) | [optional] 
**CounterpartiesNum** | **int** | Number of counterparties | [optional] 
**EmailVerified** | **string** | Whether email is verified | [optional] 
**Verified** | **string** | Whether KYC verification is completed | [optional] 
**HasPhone** | **string** | Whether phone is bound | [optional] 
**UserName** | **string** | Username | [optional] 
**UserNote** | **string** | User note information | [optional] 
**CompleteTransactions** | **string** | Total completed orders | [optional] 
**PaidTransactions** | **string** | Number of completed buy orders | [optional] 
**AcceptedTransactions** | **string** | Number of completed sell orders | [optional] 
**TransactionsUsedTime** | **string** | Average time to confirm receipt | [optional] 
**CancelledUsedTimeMonth** | **string** | Cancellation time in last 30 days | [optional] 
**CompleteTransactionsMonth** | **string** | Number of completed orders in last 30 days | [optional] 
**CompleteRateMonth** | **decimal** | Completion rate in last 30 days | [optional] 
**OrdersBuyRateMonth** | **decimal** | Buy order ratio in last 30 days | [optional] 
**IsBlack** | **int** | Whether blocked | [optional] 
**IsFollow** | **int** | Whether following | [optional] 
**HaveTraded** | **int** | Whether traded with self | [optional] 
**BizUid** | **string** | Encrypted UID | [optional] 
**BlueVip** | **int** | Blue V Crown Shield | [optional] 
**WorkStatus** | **int** | Merchant work status | [optional] 
**RegistrationDays** | **int** | Registration days | [optional] 
**FirstTradeDays** | **int** | Days since first trade | [optional] 
**NeedReplenish** | **int** | Whether margin replenishment is needed | [optional] 
**MerchantInfo** | [**P2pMerchantMarketInfo**](P2pMerchantMarketInfo.md) |  | [optional] 
**OnlineStatus** | **int** | Merchant online status | [optional] 
**WorkHours** | [**Object**](.md) | Merchant online status details | [optional] 
**TransactionsMonth** | **decimal** | 30-day transaction volume | [optional] 
**TransactionsAll** | **decimal** | Total transaction volume | [optional] 
**TradeVersatile** | **bool** | Single user or composite user | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
