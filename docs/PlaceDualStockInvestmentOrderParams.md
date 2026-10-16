
# Io.Gate.GateApi.Model.PlaceDualStockInvestmentOrderParams

Stock dual investment order request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PlanId** | **string** | Product ID | 
**Amount** | **string** | Subscription amount | 
**Text** | **string** | Order custom information. Users can set custom ID with this field. Custom fields must meet the following conditions:  1. Must start with &#x60;t-&#x60; 2. Excluding &#x60;t-&#x60;, length cannot exceed 28 bytes 3. Can only contain numbers, letters, underscore(_), hyphen(-) or dot(.)  | [optional] 
**HitSpot** | **int** | Whether to use the spot account to fund a buy-low (put) subscription. &#x60;1&#x60; selects the account; omitted or other values leave it unselected. | [optional] 
**HitStock** | **int** | Whether to use the stock account to fund a buy-low (put) subscription. &#x60;1&#x60; selects the account; omitted or other values leave it unselected. | [optional] 
**HitSimple** | **int** | Whether to use the Simple Earn account to fund a buy-low (put) subscription. &#x60;1&#x60; selects the account; omitted or other values leave it unselected. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
