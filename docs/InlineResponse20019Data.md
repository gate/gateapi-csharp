
# Io.Gate.GateApi.Model.InlineResponse20019Data

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Rate** | **string** | Price | 
**Type** | **string** | Buy/Sell order | 
**Amount** | **string** | Cryptocurrency amount | 
**MinAmount** | **string** | Minimum limit | 
**MaxAmount** | **string** | Maximum limit | 
**Total** | **string** | Fiat amount | 
**PayAli** | **int** | Whether Alipay payment is supported | 
**PayBank** | **int** | Whether bank payment is supported | 
**PayPaypal** | **int** | Whether PayPal payment is supported | 
**PayWechat** | **int** | Whether WeChat payment is supported | 
**PayTypeNum** | **string** | Payment method ID list | 
**PayTypeJson** | **string** | Payment method list | 
**LockedAmount** | **string** | Locked amount | 
**Orderid** | **int** | Order ID | 
**Timestamp** | **int** | Created time | 
**CurrencyType** | **string** | Cryptocurrency type | 
**WantType** | **string** | Fiat type | 
**HideRate** | **string** | Hidden price | 
**TradeTips** | **string** | Trading terms | 
**AutoReply** | **string** | Auto reply | 
**NewHand** | **string** | Merchant-friendly order | 
**RateRefId** | **int** | Floating price reference ID: 1&#x3D;Platform reference price, 3&#x3D;Spot reference price (≤0 means fixed price, &gt;0 means floating price) | 
**RateOffset** | **decimal** | Floating ratio (absolute value) | 
**Status** | **string** | Status | 
**RateFixed** | **int** | 0&#x3D;Floating, 1&#x3D;Fixed | 
**FloatTrend** | **int** | 0&#x3D;Upward float, 1&#x3D;Downward float | 
**ExpireMin** | **int** | Timeout (minutes) | 
**TierLimit** | **int** | Tier limit | 
**RegTimeLimit** | **int** | Registration time limit | 
**AdvertisersLimit** | **int** | Do not trade with advertisers, advertiser limit: 0&#x3D;No limit, 1&#x3D;Limit | 
**VerifiedLimit** | **int** | kyclimit | 
**MinCompletedLimit** | **int** | Minimum limit of completed orders | 
**MaxCompletedLimit** | **int** | Maximum limit of completed orders | 
**UserOrdersLimit** | **int** | Order count limit | 
**CompletedRateLimit** | **int** | 30-day completion rate limit | 
**UserCountryLimit** | **int** | KYC nationality restriction | 
**LimitCountryCn** | **string** | Restricted nationality (Chinese) | 
**LimitCountryEn** | **string** | Restricted nationality (English) | 
**IsHedge** | **int** | Whether auto delegation | 
**HidePayment** | **int** | Whether to hide payment method | 
**Fee** | **int** | fee | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
