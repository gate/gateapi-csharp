
# Io.Gate.GateApi.Model.OtcBankEnterpriseSupplementMultipartRequest

Enterprise supplement &#x60;multipart/form-data&#x60;. File field names: &#x60;certificate&#x60;, &#x60;share_holders&#x60;, &#x60;passport&#x60;, &#x60;share_holding_structure&#x60;; optional &#x60;funds_statement&#x60;, &#x60;additional&#x60;. Optional string field &#x60;relationship_proof&#x60; (JSON) is merged into the request.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uid** | **string** |  | [optional] 
**BankId** | **string** |  | 
**Certificate** | **string** | Business license / registration certificate file content (multipart file field, binary/Base64) | 
**ShareHolders** | **string** | Register of shareholders file content (multipart file field, binary/Base64) | 
**Passport** | **string** | Legal representative / shareholder passport file content (multipart file field, binary/Base64) | 
**ShareHoldingStructure** | **string** | Ownership structure chart file content (multipart file field, binary/Base64) | 
**FundsStatement** | **string** | Proof-of-funds file content (multipart file field, binary/Base64, optional) | [optional] 
**Additional** | **string** | Other supplementary material file content (multipart file field, binary/Base64, optional) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
