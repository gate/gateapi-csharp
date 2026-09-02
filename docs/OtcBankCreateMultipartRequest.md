
# Io.Gate.GateApi.Model.OtcBankCreateMultipartRequest

Inner create-bank-card &#x60;multipart/form-data&#x60;. Account-opening proof file (choose one):  - **Pre-upload**: &#x60;documentation_file_key&#x60; + &#x60;file_type&#x60; (call &#x60;POST /otc/upload/pre_upload&#x60; first, &#x60;scene&#x3D;bank&#x60;); - **Multipart direct upload**: &#x60;documentation_file&#x60; file field.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BankAccountName** | **string** |  | 
**BankName** | **string** |  | 
**BankCountry** | **string** |  | 
**BankAddress** | **string** |  | 
**Iban** | **string** |  | 
**Swift** | **string** |  | 
**RemittanceLineNumber** | **string** |  | [optional] 
**AgentBankName** | **string** |  | [optional] 
**AgentBankSwift** | **string** |  | [optional] 
**DocumentationFile** | **string** | Multipart direct upload; mutually exclusive with documentation_file_key | [optional] 
**DocumentationFileKey** | **string** | Pre-upload mode; file_key returned by pre_upload (plaintext or base64 accepted) | [optional] 
**FileType** | **string** | Required when using documentation_file_key; plaintext MIME or its base64 | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
