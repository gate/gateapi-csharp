
# Io.Gate.GateApi.Model.OtcBankCreateMultipartRequest

Inner create-bank-card &#x60;multipart/form-data&#x60;. Use the form field &#x60;documentation_file&#x60; to upload the account-opening proof.

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
**DocumentationFile** | **System.IO.Stream** | Account-opening proof file (jpg/jpeg/png/pdf, etc.; single file ≤4MB — subject to production environment). | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
