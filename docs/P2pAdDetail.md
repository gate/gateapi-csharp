
# Io.Gate.GateApi.Model.P2pAdDetail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Rate** | **string** | Price | [optional] 
**Type** | **string** | Buy/Sell order | [optional] 
**Amount** | **string** | Cryptocurrency amount | [optional] 
**MinAmount** | **string** | Minimum limit | [optional] 
**MaxAmount** | **string** | Maximum limit | [optional] 
**Total** | **string** | Fiat amount | [optional] 
**PayAli** | **int** | Whether Alipay payment is supported | [optional] 
**PayBank** | **int** | Whether bank payment is supported | [optional] 
**PayPaypal** | **int** | Whether PayPal payment is supported | [optional] 
**PayWechat** | **int** | Whether WeChat payment is supported | [optional] 
**PayTypeNum** | **string** | Payment method ID list | [optional] 
**PayTypeJson** | **string** | Payment method list | [optional] 
**LockedAmount** | **string** | Locked amount | [optional] 
**Orderid** | **int** | Order ID | [optional] 
**Timestamp** | **int** | Created time | [optional] 
**CurrencyType** | **string** | Cryptocurrency type | [optional] 
**WantType** | **string** | Fiat type | [optional] 
**HideRate** | **string** | Hidden price | [optional] 
**TradeTips** | **string** | Trading terms | [optional] 
**AutoReply** | **string** | Auto reply | [optional] 
**NewHand** | **string** | Merchant-friendly order | [optional] 
**RateRefId** | **int** | Floating price reference ID: 1&#x3D;Platform reference price, 3&#x3D;Spot reference price (≤0 means fixed price, &gt;0 means floating price) | [optional] 
**RateOffset** | **decimal** | Floating ratio (absolute value) | [optional] 
**Status** | **string** | Status | [optional] 
**RateFixed** | **int** | 0&#x3D;Floating, 1&#x3D;Fixed | [optional] 
**FloatTrend** | **int** | 0&#x3D;Upward float, 1&#x3D;Downward float | [optional] 
**ExpireMin** | **int** | Timeout (minutes) | [optional] 
**TierLimit** | **int** | Tier limit | [optional] 
**RegTimeLimit** | **int** | Registration time limit | [optional] 
**AdvertisersLimit** | **int** | Do not trade with advertisers, advertiser limit: 0&#x3D;No limit, 1&#x3D;Limit | [optional] 
**VerifiedLimit** | **int** | kyclimit | [optional] 
**MinCompletedLimit** | **int** | Minimum limit of completed orders | [optional] 
**MaxCompletedLimit** | **int** | Maximum limit of completed orders | [optional] 
**UserOrdersLimit** | **int** | Order count limit | [optional] 
**CompletedRateLimit** | **decimal** | 30-day completion rate limit | [optional] 
**UserCountryLimit** | **int** | KYC nationality restriction | [optional] 
**LimitCountryCn** | **string** | Restricted nationality (Chinese) | [optional] 
**LimitCountryEn** | **string** | Restricted nationality (English) | [optional] 
**IsHedge** | **int** | Whether auto delegation | [optional] 
**HidePayment** | **int** | Whether to hide payment method | [optional] 
**Fee** | **int** | fee | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
