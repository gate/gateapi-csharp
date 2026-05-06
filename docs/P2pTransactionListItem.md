
# Io.Gate.GateApi.Model.P2pTransactionListItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TypeBuy** | **int** | Order side from current user&#39;s view. &#x60;1&#x60;: buy; &#x60;0&#x60;: sell. | [optional] 
**Timest** | **string** | Creation time of order | [optional] 
**TimestExpire** | **string** | Order expiration time | [optional] 
**Timestamp** | **int** | Order creation timestamp | [optional] 
**Rate** | **string** | Order price in fiat currency. | [optional] 
**Amount** | **string** | Order size in cryptocurrency. | [optional] 
**Total** | **string** | Total fiat amount of the order. | [optional] 
**Txid** | **int** | Order ID | [optional] 
**Status** | **string** | Display status: &#x60;unpay&#x60; awaiting payment; &#x60;paid&#x60; buyer paid; &#x60;unconfirmed&#x60; awaiting seller confirmation; &#x60;locked&#x60; locked; &#x60;finished&#x60; completed; &#x60;cancel&#x60; canceled; &#x60;expired&#x60; expired; &#x60;bclosed&#x60; arbitration filled; &#x60;sclosed&#x60; arbitration canceled. | [optional] 
**ItsRealname** | **string** | Counterparty real name or verified display name. | [optional] 
**ItsUid** | **string** | Counterparty crypto UID. | [optional] 
**ItsNick** | **string** | Counterparty nickname | [optional] 
**SellerRealname** | **string** | Seller real name or verified display name. | [optional] 
**BuyerRealname** | **string** | Buyer real name or verified display name. | [optional] 
**Cancelable** | **int** | Whether the order can be canceled. &#x60;1&#x60;: yes; &#x60;0&#x60;: no. | [optional] 
**CurrencyType** | **string** | Cryptocurrency symbol. | [optional] 
**WantType** | **string** | Fiat currency | [optional] 
**HidePayment** | **int** | Whether payment methods are hidden. &#x60;1&#x60;: hidden; &#x60;0&#x60;: visible. | [optional] 
**SelPaytype** | **string** | Selected payment type for this order, e.g. &#x60;bank&#x60;, &#x60;alipay&#x60;, &#x60;wechat&#x60;, &#x60;paypal&#x60;, &#x60;swift&#x60;, &#x60;wu&#x60;. | [optional] 
**PayOthers** | [**List&lt;P2pTransactionListResultPayOthers&gt;**](P2pTransactionListResultPayOthers.md) | Other payment method details; may appear on historical orders. | [optional] 
**CdTime** | **int** | Countdown seconds for the current order. | [optional] 
**OrderType** | **int** | Order type: &#x60;1&#x60; standard; &#x60;2&#x60; partner; &#x60;3&#x60; flash swap; &#x60;4&#x60; Web3. | [optional] 
**OrderTag** | **List&lt;string&gt;** | Order tags | [optional] 
**ConvertInfo** | [**P2pTransactionConvertInfo**](P2pTransactionConvertInfo.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
