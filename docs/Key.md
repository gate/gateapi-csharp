
# Io.Gate.GateApi.Model.Key

Main Account API Key Information

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**State** | **int** | API Key Status: 1 - Normal, 2 - Locked, 3 - Frozen (can only be modified; default is 1 upon creation) | [optional] 
**Mode** | **int** | User Mode: 1 - Classic, 2 - Legacy Unified (can only be specified during creation, non-modifiable afterwards) | [optional] 
**Name** | **List&lt;string&gt;** | API Key Remark | [optional] 
**CurrencyPairs** | **List&lt;string&gt;** | Trading Pair Whitelist, Maximum 30 Pairs | [optional] 
**UserId** | **long** | User ID | [optional] 
**IpWhitelist** | **List&lt;string&gt;** | IP Whitelist | [optional] 
**Perms** | [**List&lt;KeyPerms&gt;**](KeyPerms.md) |  | [optional] 
**Key** | [**AccountDetailKey**](AccountDetailKey.md) |  | [optional] 
**CreatedAt** | **string** | Created time | [optional] [readonly] 
**UpdatedAt** | **string** | Last Update Time | [optional] [readonly] 
**LastAccess** | **string** | Last Access Time | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
