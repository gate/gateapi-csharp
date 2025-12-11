
# Io.Gate.GateApi.Model.OptionsContract

Options contract details

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Options contract name | [optional] 
**Tag** | **string** | Expiry periods include day, week, and month. | [optional] 
**CreateTime** | **double** | Created time | [optional] 
**ExpirationTime** | **double** | Expiration time | [optional] 
**IsCall** | **bool** | &#x60;true&#x60; means call options, &#x60;false&#x60; means put options | [optional] 
**Multiplier** | **string** | The option contract multiplier indicates how many units of the underlying asset the face value of one contract represents. | [optional] 
**Underlying** | **string** | Underlying | [optional] 
**UnderlyingPrice** | **string** | The forward futures price corresponding to the delivery date | [optional] 
**LastPrice** | **string** | Last trading price | [optional] 
**MarkPrice** | **string** | Current mark price (quote currency) | [optional] 
**IndexPrice** | **string** | Current index price (quote currency) | [optional] 
**MakerFeeRate** | **string** | Maker fee rate, negative values indicate rebates | [optional] 
**TakerFeeRate** | **string** | Taker fee rate | [optional] 
**OrderPriceRound** | **string** | Minimum order price increment | [optional] 
**MarkPriceRound** | **string** | Minimum mark price increment | [optional] 
**OrderSizeMin** | **long** | Minimum order size allowed by the contract | [optional] 
**OrderSizeMax** | **long** | Maximum order size allowed by the contract | [optional] 
**OrderPriceDeviate** | **string** | Deprecated | [optional] 
**RefDiscountRate** | **string** | Trading fee discount for referred users | [optional] 
**RefRebateRate** | **string** | Commission rate for referrers | [optional] 
**OrderbookId** | **long** | Orderbook update ID | [optional] 
**TradeId** | **long** | Deprecated | [optional] 
**TradeSize** | **long** | Historical cumulative trading volume | [optional] 
**PositionSize** | **long** | Current total long position size | [optional] 
**OrdersLimit** | **int** | The maximum number of open orders each user can place in this order book. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
