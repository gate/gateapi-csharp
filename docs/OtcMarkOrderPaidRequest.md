
# Io.Gate.GateApi.Model.OtcMarkOrderPaidRequest

Request body for marking a fiat order as paid (deposit confirmation). Must include the user&#39;s payment receipt (consistent with §3.2).  **&#x60;payment_receipt_file_key&#x60; is required**; the order primary key for this path is &#x60;order_id&#x60;. When accessed via the Pay gateway using &#x60;client_order_id&#x60;, the gateway&#39;s rewritten field prevails.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | **string** | Order ID | 
**ClientOrderId** | **string** | Client order ID (used by some gateway/Inner Pay paths, optional) | [optional] 
**PaymentReceiptFileKey** | **string** | User payment receipt: **required**. Stored as a file_key. Single file; jpg/jpeg/png/pdf; ≤4MB. | 
**PaymentReceipt** | **string** | Alias compatible with &#x60;payment_receipt_file_key&#x60; (depends on the gateway&#39;s external field name) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
