
# Io.Gate.GateApi.Model.SubAccountKey

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserId** | **long** | User ID | [optional] [readonly] 
**Mode** | **int** | Mode: 1 - classic 2 - portfolio account | [optional] 
**Name** | **string** | API Key Name | [optional] 
**Perms** | [**List&lt;SubAccountKeyPerms&gt;**](SubAccountKeyPerms.md) |  | [optional] 
**IpWhitelist** | **List&lt;string&gt;** | IP whitelist (list will be cleared if no value is passed) | [optional] 
**Key** | **string** | API Key | [optional] [readonly] 
**State** | **int** | Status: 1-Normal 2-Frozen 3-Locked | [optional] [readonly] 
**CreatedAt** | **long** | Created time | [optional] [readonly] 
**UpdatedAt** | **long** | Last Update Time | [optional] [readonly] 
**LastAccess** | **long** | Last Access Time | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
