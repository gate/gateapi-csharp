
# Io.Gate.GateApi.Model.ContractStat

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Time** | **long** | Stat timestamp | [optional] 
**LsrTaker** | **double** | Long/short taker ratio | [optional] 
**LsrAccount** | **double** | Long/short position user ratio | [optional] 
**LongLiqSize** | **string** | Long liquidation size (contracts) | [optional] 
**LongLiqAmount** | **double** | Long liquidation amount (base currency) | [optional] 
**LongLiqUsd** | **double** | Long liquidation volume (quote currency) | [optional] 
**LongLiqUsdNew** | **double** | Long liquidations in quote currency; USDT settlement: long_liq_size × multiplier × mark price | [optional] 
**ShortLiqSize** | **string** | Short liquidation size (contracts) | [optional] 
**ShortLiqAmount** | **double** | Short liquidation amount (base currency) | [optional] 
**ShortLiqUsd** | **double** | Short liquidation volume (quote currency) | [optional] 
**ShortLiqUsdNew** | **double** | Short liquidations in quote currency; USDT settlement: short_liq_size × multiplier × mark price | [optional] 
**OpenInterest** | **string** | Total open interest size (contracts) | [optional] 
**OpenInterestUsd** | **double** | Total open interest volume (quote currency) | [optional] 
**TopLsrAccount** | **double** | Top trader long/short account ratio | [optional] 
**TopLsrSize** | **string** | Top trader long/short position ratio | [optional] 
**MarkPrice** | **double** | Mark price | [optional] 
**TopLongSize** | **string** | Top long open interest (contracts) | [optional] 
**TopShortSize** | **string** | Top short open interest (contracts) | [optional] 
**LongTakerSize** | **string** | Long taker trade volume (contracts) | [optional] 
**ShortTakerSize** | **string** | Short taker trade volume (contracts) | [optional] 
**TopLongAccount** | **long** | Number of top long accounts (large holders) | [optional] 
**TopShortAccount** | **long** | Number of top short accounts (large holders) | [optional] 
**LongUsers** | **string** | Number of users holding long positions | [optional] 
**ShortUsers** | **string** | Number of users holding short positions | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
