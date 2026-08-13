
# Io.Gate.GateApi.Model.SymbolDetailItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Symbol** | **string** |  | [optional] 
**Exchange** | **string** | Exchange, supports us, hk, and kr | [optional] 
**ExchangeDesc** | **string** |  | [optional] 
**QuoteCurrency** | **string** |  | [optional] 
**QuoteCurrencyPrecision** | **int** |  | [optional] 
**FxRate** | **string** | Quote currency to USD exchange rate | [optional] 
**SymbolDesc** | **string** |  | [optional] 
**Category** | **string** |  | [optional] 
**SettlementCurrency** | **string** |  | [optional] 
**MaxOrderVolume** | **string** |  | [optional] 
**StepOrderVolume** | **string** |  | [optional] 
**MinOrderVolume** | **string** |  | [optional] 
**PricePrecision** | **int** | Price precision | [optional] 
**VolumePrecision** | **int** |  | [optional] 
**IsIpo** | **bool** |  | [optional] 
**IpoPrice** | **string** |  | [optional] 
**PriceProtection** | **string** |  | [optional] 
**SellPriceProtection** | **string** |  | [optional] 
**BuyPriceProtection** | **string** |  | [optional] 
**SlippageRate** | **string** |  | [optional] 
**CommissionRate** | **string** | Fee Rate | [optional] 
**TradeStatus** | **string** | Trading status. - pre_market: Pre-market. - open: Regular trading session. - post_market: Post-market. - closed: Market closed. - gt_lp: GT LP session. | [optional] 
**TradeMode** | **int** | Current session trading mode. - 0: Trading disabled. - 1: Buy only. - 2: Sell only. - 4: Buy and sell supported. | [optional] 
**OrderFillTiming** | **int** | Order fill timing (1&#x3D;immediate, 2&#x3D;after pre-market opens, 3&#x3D;after regular session opens) | [optional] 
**SymbolDescs** | [**List&lt;SymbolDetailItemSymbolDescs&gt;**](SymbolDetailItemSymbolDescs.md) |  | [optional] 
**IconLink** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
