
# Io.Gate.GateApi.Model.OtcBankPersonalSupplementMultipartRequest

Personal supplement &#x60;multipart/form-data&#x60;. File field names are fixed: &#x60;id_document_front&#x60;, &#x60;id_document_back&#x60;, &#x60;address_proof&#x60; (aligned with the checklist &#x60;code&#x60;); the optional string field &#x60;relationship_proof&#x60; (JSON text) is merged with the upload result.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BankId** | **string** |  | 
**IdDocumentFront** | **string** | ID document front-side file content (multipart file field, binary/Base64) | 
**IdDocumentBack** | **string** | ID document back-side file content (multipart file field, binary/Base64) | 
**AddressProof** | **string** | Proof-of-address file content (multipart file field, binary/Base64) | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
