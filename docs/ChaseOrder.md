
# Io.Gate.GateApi.Model.ChaseOrder

Chase order detail or list item

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**User** | **string** |  | [optional] 
**Contract** | **string** |  | [optional] 
**Settle** | **string** |  | [optional] 
**Amount** | **string** | Total size in contracts; positive for buy, negative for sell | [optional] 
**PriceLimit** | **string** |  | [optional] 
**ReduceOnly** | **bool** |  | [optional] 
**Text** | **string** |  | [optional] 
**CreateTime** | **long** |  | [optional] 
**FinishTime** | **long** |  | [optional] 
**OriginalStatus** | **int** | Raw status enum | [optional] 
**Status** | **string** | Simplified status, e.g. open / finished | [optional] 
**Reason** | **string** |  | [optional] 
**FillAmount** | **string** |  | [optional] 
**AverageFillPrice** | **string** |  | [optional] 
**SuborderId** | **string** |  | [optional] 
**IsDualMode** | **bool** |  | [optional] 
**SideLabel** | **string** |  | [optional] 
**PositionSideOutput** | **string** |  | [optional] 
**ChasePrice** | **string** |  | [optional] 
**IntervalSec** | **int** |  | [optional] 
**UpdatedAt** | **long** |  | [optional] 
**SuborderPrice** | **string** |  | [optional] 
**SuborderOngoing** | **bool** |  | [optional] 
**SuborderFinishAs** | **string** |  | [optional] 
**PriceType** | **int** | PriceType enum: 1 latest, 2 index, 3 mark | [optional] 
**PriceGapType** | **string** |  | [optional] 
**PriceGapValue** | **string** |  | [optional] 
**StatusCode** | **string** |  | [optional] 
**CreateTimePrecise** | **string** | Creation time (seconds.microseconds) | [optional] 
**FinishTimePrecise** | **string** |  | [optional] 
**PosMarginMode** | **string** |  | [optional] 
**PositionMode** | **string** |  | [optional] 
**Leverage** | **string** |  | [optional] 
**ErrorLabel** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
