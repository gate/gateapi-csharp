# Io.Gate.GateApi.Api.OTCApi

All URIs are relative to *https://api.gateio.ws/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOtcQuote**](OTCApi.md#createotcquote) | **POST** /otc/quote | Fiat and stablecoin quote
[**CreateOtcOrder**](OTCApi.md#createotcorder) | **POST** /otc/order/create | Create fiat order
[**CreateStableCoinOrder**](OTCApi.md#createstablecoinorder) | **POST** /otc/stable_coin/order/create | Create stablecoin order
[**GetBankListInnerPath**](OTCApi.md#getbanklistinnerpath) | **GET** /otc/bank/list | Get user bank card list
[**CreateOtcBank**](OTCApi.md#createotcbank) | **POST** /otc/bank/create | Create bank card
[**DeleteOtcBank**](OTCApi.md#deleteotcbank) | **POST** /otc/bank/delete | Delete bank card
[**SetDefaultOtcBank**](OTCApi.md#setdefaultotcbank) | **POST** /otc/bank/set_default | Set default bank card
[**GetOtcBankSupplementChecklist**](OTCApi.md#getotcbanksupplementchecklist) | **GET** /otc/bank/bank_supplement_checklist | Query the checklist of materials to supplement for a bank card
[**SubmitOtcBankPersonalSupplement**](OTCApi.md#submitotcbankpersonalsupplement) | **POST** /otc/bank/personal/bank_supplement | Submit Bank Card Supplement Materials (Personal)
[**SubmitOtcBankEnterpriseSupplement**](OTCApi.md#submitotcbankenterprisesupplement) | **POST** /otc/bank/enterprise/bank_supplement | Submit Bank Card Supplement Materials (Enterprise)
[**CreateOtcUploadPreUpload**](OTCApi.md#createotcuploadpreupload) | **POST** /otc/upload/pre_upload | Pre-upload file (temporary bucket)
[**MarkOtcOrderPaid**](OTCApi.md#markotcorderpaid) | **POST** /otc/order/paid | Mark fiat order as paid (deposit confirmation)
[**CancelOtcOrder**](OTCApi.md#cancelotcorder) | **POST** /otc/order/cancel | Fiat order cancellation
[**ListOtcOrders**](OTCApi.md#listotcorders) | **GET** /otc/order/list | Fiat order list
[**ListStableCoinOrders**](OTCApi.md#liststablecoinorders) | **GET** /otc/stable_coin/order/list | Stablecoin order list
[**GetOtcOrderDetail**](OTCApi.md#getotcorderdetail) | **GET** /otc/order/detail | Fiat order details


<a name="createotcquote"></a>
# **CreateOtcQuote**
> OtcQuoteResponse CreateOtcQuote (OtcQuoteRequest otcQuoteRequest)

Fiat and stablecoin quote

Create fiat and stablecoin quotes, supporting both PAY and GET directions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateOtcQuoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OTCApi(config);
            var otcQuoteRequest = new OtcQuoteRequest(); // OtcQuoteRequest | 

            try
            {
                // Fiat and stablecoin quote
                OtcQuoteResponse result = apiInstance.CreateOtcQuote(otcQuoteRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OTCApi.CreateOtcQuote: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **otcQuoteRequest** | [**OtcQuoteRequest**](OtcQuoteRequest.md)|  | 

### Return type

[**OtcQuoteResponse**](OtcQuoteResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Quote retrieved successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createotcorder"></a>
# **CreateOtcOrder**
> OtcActionResponse CreateOtcOrder (OtcOrderRequest otcOrderRequest)

Create fiat order

Create a fiat order, supporting BUY for on-ramp and SELL for off-ramp

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateOtcOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OTCApi(config);
            var otcOrderRequest = new OtcOrderRequest(); // OtcOrderRequest | 

            try
            {
                // Create fiat order
                OtcActionResponse result = apiInstance.CreateOtcOrder(otcOrderRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OTCApi.CreateOtcOrder: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **otcOrderRequest** | [**OtcOrderRequest**](OtcOrderRequest.md)|  | 

### Return type

[**OtcActionResponse**](OtcActionResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Order created successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createstablecoinorder"></a>
# **CreateStableCoinOrder**
> OtcStableCoinOrderCreateResponse CreateStableCoinOrder (OtcStableCoinOrderRequest otcStableCoinOrderRequest)

Create stablecoin order

Create a stablecoin order. All request body fields except `promotion_code` are required.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateStableCoinOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OTCApi(config);
            var otcStableCoinOrderRequest = new OtcStableCoinOrderRequest(); // OtcStableCoinOrderRequest | 

            try
            {
                // Create stablecoin order
                OtcStableCoinOrderCreateResponse result = apiInstance.CreateStableCoinOrder(otcStableCoinOrderRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OTCApi.CreateStableCoinOrder: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **otcStableCoinOrderRequest** | [**OtcStableCoinOrderRequest**](OtcStableCoinOrderRequest.md)|  | 

### Return type

[**OtcStableCoinOrderCreateResponse**](OtcStableCoinOrderCreateResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Stablecoin order created successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbanklistinnerpath"></a>
# **GetBankListInnerPath**
> OtcBankListResponse GetBankListInnerPath ()

Get user bank card list

List the user's bank cards for selecting a card when placing an order. **Default card**: use the `is_default` field in each list item (`1` indicates the default). The deprecated standalone default-bank-card endpoint is no longer required.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetBankListInnerPathExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OTCApi(config);

            try
            {
                // Get user bank card list
                OtcBankListResponse result = apiInstance.GetBankListInnerPath();
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OTCApi.GetBankListInnerPath: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**OtcBankListResponse**](OtcBankListResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Query successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createotcbank"></a>
# **CreateOtcBank**
> OtcBankCreateResponse CreateOtcBank (string bankAccountName, string bankName, string bankCountry, string bankAddress, string iban, string swift, string remittanceLineNumber = null, string agentBankName = null, string agentBankSwift = null, string documentationFile = null, string documentationFileKey = null, string fileType = null)

Create bank card

Bind a bank card. Under the Global entity, non-same-name accounts may enter manual review (`status` pending) and require supplementary materials later. Corresponds to Inner: `POST /bank/create`. Fields and protocol follow the live form/gateway; `bank_account_name` may be Base64-encoded in some environments—see integration notes.  Account-opening proof supports two methods (choose one):  1. **Pre-upload (recommended)**: call `POST /otc/upload/pre_upload` (`scene=bank`) to obtain a temporary-bucket Policy and upload directly to S3, then pass `documentation_file_key` + `file_type` in this endpoint; 2. **Multipart direct upload**: pass the `documentation_file` file field; the server writes directly to the production bucket.  When using pre-upload, the server validates object existence and that the uid in the `file_key` path matches the caller; after validation, the object is moved to the production bucket and persisted. Cross-user references return `Invalid parameters file_key`; incomplete direct upload returns `Invalid parameters file not uploaded`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateOtcBankExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OTCApi(config);
            var bankAccountName = "bankAccountName_example";  // string | 
            var bankName = "bankName_example";  // string | 
            var bankCountry = "bankCountry_example";  // string | 
            var bankAddress = "bankAddress_example";  // string | 
            var iban = "iban_example";  // string | 
            var swift = "swift_example";  // string | 
            var remittanceLineNumber = "remittanceLineNumber_example";  // string |  (optional) 
            var agentBankName = "agentBankName_example";  // string |  (optional) 
            var agentBankSwift = "agentBankSwift_example";  // string |  (optional) 
            var documentationFile = "documentationFile_example";  // string | Multipart direct upload; mutually exclusive with documentation_file_key (optional) 
            var documentationFileKey = "documentationFileKey_example";  // string | Pre-upload mode; file_key returned by pre_upload (plaintext or base64 accepted) (optional) 
            var fileType = "fileType_example";  // string | Required when using documentation_file_key; plaintext MIME or its base64 (optional) 

            try
            {
                // Create bank card
                OtcBankCreateResponse result = apiInstance.CreateOtcBank(bankAccountName, bankName, bankCountry, bankAddress, iban, swift, remittanceLineNumber, agentBankName, agentBankSwift, documentationFile, documentationFileKey, fileType);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OTCApi.CreateOtcBank: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bankAccountName** | **string**|  | 
 **bankName** | **string**|  | 
 **bankCountry** | **string**|  | 
 **bankAddress** | **string**|  | 
 **iban** | **string**|  | 
 **swift** | **string**|  | 
 **remittanceLineNumber** | **string**|  | [optional] 
 **agentBankName** | **string**|  | [optional] 
 **agentBankSwift** | **string**|  | [optional] 
 **documentationFile** | **string**| Multipart direct upload; mutually exclusive with documentation_file_key | [optional] 
 **documentationFileKey** | **string**| Pre-upload mode; file_key returned by pre_upload (plaintext or base64 accepted) | [optional] 
 **fileType** | **string**| Required when using documentation_file_key; plaintext MIME or its base64 | [optional] 

### Return type

[**OtcBankCreateResponse**](OtcBankCreateResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Accepted successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteotcbank"></a>
# **DeleteOtcBank**
> OtcActionResponse DeleteOtcBank (OtcBankIdRequest otcBankIdRequest)

Delete bank card

Delete the specified bank card. Corresponds to Inner: `POST /bank/delete`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class DeleteOtcBankExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OTCApi(config);
            var otcBankIdRequest = new OtcBankIdRequest(); // OtcBankIdRequest | 

            try
            {
                // Delete bank card
                OtcActionResponse result = apiInstance.DeleteOtcBank(otcBankIdRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OTCApi.DeleteOtcBank: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **otcBankIdRequest** | [**OtcBankIdRequest**](OtcBankIdRequest.md)|  | 

### Return type

[**OtcActionResponse**](OtcActionResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Deleted successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setdefaultotcbank"></a>
# **SetDefaultOtcBank**
> OtcActionResponse SetDefaultOtcBank (OtcBankIdRequest otcBankIdRequest)

Set default bank card

Set the specified bank card as default. Corresponds to Inner: `POST /bank/set_default`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class SetDefaultOtcBankExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OTCApi(config);
            var otcBankIdRequest = new OtcBankIdRequest(); // OtcBankIdRequest | 

            try
            {
                // Set default bank card
                OtcActionResponse result = apiInstance.SetDefaultOtcBank(otcBankIdRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OTCApi.SetDefaultOtcBank: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **otcBankIdRequest** | [**OtcBankIdRequest**](OtcBankIdRequest.md)|  | 

### Return type

[**OtcActionResponse**](OtcActionResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Set successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getotcbanksupplementchecklist"></a>
# **GetOtcBankSupplementChecklist**
> OtcBankSupplementChecklistResponse GetOtcBankSupplementChecklist (string bankId)

Query the checklist of materials to supplement for a bank card

**①** `bank_id` must be specified. After verifying that the card belongs to the current user and its status allows supplementary documents, the endpoint returns the required items based on the user's **approved advanced verification type** (personal/enterprise); each item's `description` states the submission requirements. Corresponding Inner endpoint: `GET /bank/bank_supplement_checklist`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetOtcBankSupplementChecklistExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OTCApi(config);
            var bankId = "bankId_example";  // string | Bank card ID (otc_rds / the id returned by the list endpoint).

            try
            {
                // Query the checklist of materials to supplement for a bank card
                OtcBankSupplementChecklistResponse result = apiInstance.GetOtcBankSupplementChecklist(bankId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OTCApi.GetOtcBankSupplementChecklist: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bankId** | **string**| Bank card ID (otc_rds / the id returned by the list endpoint). | 

### Return type

[**OtcBankSupplementChecklistResponse**](OtcBankSupplementChecklistResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Query successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitotcbankpersonalsupplement"></a>
# **SubmitOtcBankPersonalSupplement**
> OtcActionResponse SubmitOtcBankPersonalSupplement (string bankId, string idDocumentFront = null, string idDocumentBack = null, string addressProof = null, string relationshipProof = null)

Submit Bank Card Supplement Materials (Personal)

**Personal professional verification (type=1)** users submit non-same-person/supplementary materials. Must match `user_type=personal` from `GET /otc/bank/bank_supplement_checklist?bank_id=`; otherwise rejected.  Two submission methods (can be mixed):  1. **Pre-upload (recommended)**: call `POST /otc/upload/pre_upload` (`scene=bank`) to upload to the temporary bucket, then fill file items by category in the `relationship_proof` JSON; pass **`key` as plaintext** object path (`base64_decode(pre_upload.file_key)`, e.g. `otc_temp/{uid}/bank/xxx.png`), and `file_type` as plaintext MIME; the server base64-encodes before persistence—do not pass base64 `file_key` directly; 2. **Multipart direct upload**: one file field per material item; field names match checklist `code` (`id_document_front`, `id_document_back`, `address_proof`).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class SubmitOtcBankPersonalSupplementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OTCApi(config);
            var bankId = "bankId_example";  // string | 
            var idDocumentFront = "idDocumentFront_example";  // string | ID document front-side file content (multipart file field, binary/Base64) (optional) 
            var idDocumentBack = "idDocumentBack_example";  // string | ID document back-side file content (multipart file field, binary/Base64) (optional) 
            var addressProof = "addressProof_example";  // string | Proof-of-address file content (multipart file field, binary/Base64) (optional) 
            var relationshipProof = "relationshipProof_example";  // string | Optional. JSON string of relationship_proof. (optional) 

            try
            {
                // Submit Bank Card Supplement Materials (Personal)
                OtcActionResponse result = apiInstance.SubmitOtcBankPersonalSupplement(bankId, idDocumentFront, idDocumentBack, addressProof, relationshipProof);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OTCApi.SubmitOtcBankPersonalSupplement: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bankId** | **string**|  | 
 **idDocumentFront** | **string**| ID document front-side file content (multipart file field, binary/Base64) | [optional] 
 **idDocumentBack** | **string**| ID document back-side file content (multipart file field, binary/Base64) | [optional] 
 **addressProof** | **string**| Proof-of-address file content (multipart file field, binary/Base64) | [optional] 
 **relationshipProof** | **string**| Optional. JSON string of relationship_proof. | [optional] 

### Return type

[**OtcActionResponse**](OtcActionResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Accepted successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitotcbankenterprisesupplement"></a>
# **SubmitOtcBankEnterpriseSupplement**
> OtcActionResponse SubmitOtcBankEnterpriseSupplement (string bankId, string uid = null, string certificate = null, string shareHolders = null, string passport = null, string shareHoldingStructure = null, string fundsStatement = null, string additional = null, string relationshipProof = null)

Submit Bank Card Supplement Materials (Enterprise)

**Enterprise professional verification (type=2)** users submit supplementary materials. Must match `user_type=enterprise` from the checklist.  Two submission methods (can be mixed):  1. **Pre-upload (recommended)**: call `POST /otc/upload/pre_upload` (`scene=bank`), fill file items by category in `relationship_proof`; pass **`key` as plaintext** object path (`base64_decode(pre_upload.file_key)`), and `file_type` as plaintext MIME; 2. **Multipart direct upload**: file field names `certificate`, `share_holders`, `passport`, `share_holding_structure`; optional `funds_statement`, `additional`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class SubmitOtcBankEnterpriseSupplementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OTCApi(config);
            var bankId = "bankId_example";  // string | 
            var uid = "uid_example";  // string |  (optional) 
            var certificate = "certificate_example";  // string | Business license / registration certificate file content (multipart file field, binary/Base64) (optional) 
            var shareHolders = "shareHolders_example";  // string | Register of shareholders file content (multipart file field, binary/Base64) (optional) 
            var passport = "passport_example";  // string | Legal representative / shareholder passport file content (multipart file field, binary/Base64) (optional) 
            var shareHoldingStructure = "shareHoldingStructure_example";  // string | Ownership structure chart file content (multipart file field, binary/Base64) (optional) 
            var fundsStatement = "fundsStatement_example";  // string | Proof-of-funds file content (multipart file field, binary/Base64, optional) (optional) 
            var additional = "additional_example";  // string | Other supplementary material file content (multipart file field, binary/Base64, optional) (optional) 
            var relationshipProof = "relationshipProof_example";  // string | Optional. JSON string of relationship_proof. (optional) 

            try
            {
                // Submit Bank Card Supplement Materials (Enterprise)
                OtcActionResponse result = apiInstance.SubmitOtcBankEnterpriseSupplement(bankId, uid, certificate, shareHolders, passport, shareHoldingStructure, fundsStatement, additional, relationshipProof);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OTCApi.SubmitOtcBankEnterpriseSupplement: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bankId** | **string**|  | 
 **uid** | **string**|  | [optional] 
 **certificate** | **string**| Business license / registration certificate file content (multipart file field, binary/Base64) | [optional] 
 **shareHolders** | **string**| Register of shareholders file content (multipart file field, binary/Base64) | [optional] 
 **passport** | **string**| Legal representative / shareholder passport file content (multipart file field, binary/Base64) | [optional] 
 **shareHoldingStructure** | **string**| Ownership structure chart file content (multipart file field, binary/Base64) | [optional] 
 **fundsStatement** | **string**| Proof-of-funds file content (multipart file field, binary/Base64, optional) | [optional] 
 **additional** | **string**| Other supplementary material file content (multipart file field, binary/Base64, optional) | [optional] 
 **relationshipProof** | **string**| Optional. JSON string of relationship_proof. | [optional] 

### Return type

[**OtcActionResponse**](OtcActionResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Accepted successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createotcuploadpreupload"></a>
# **CreateOtcUploadPreUpload**
> OtcUploadPreUploadResponse CreateOtcUploadPreUpload (OtcUploadPreUploadRequest otcUploadPreUploadRequest)

Pre-upload file (temporary bucket)

After selecting a file, the client calls this endpoint first to obtain a temporary-bucket POST Policy and `file_key`; then upload directly to S3 using the returned `url` and `fields` (success HTTP 204); finally, in business submit endpoints (e.g. `POST /otc/order/paid`, `POST /otc/bank/create`), pass the **same base64 `file_key` unchanged** (do not decode). The server validates ownership and object existence, then moves to the production bucket and persists. Unsubmitted files remain in the temporary bucket and are reclaimed by lifecycle rules.  Corresponds to Inner: `POST /upload/pre_upload`.  **`content_type` must be sent as base64** (plaintext containing `/` may be blocked by the gateway). Only the following MIME types are supported:  | MIME | base64 | Extension | | - -- | - -- | - -- | | image/png | aW1hZ2UvcG5n | .png | | image/jpeg | aW1hZ2UvanBlZw== | .jpeg | | image/jpg | aW1hZ2UvanBn | .jpg | | application/pdf | YXBwbGljYXRpb24vcGRm | .pdf |  **`scene` mapping to downstream endpoints**:  | scene | Typical use | | - -- | - -- | | general | Fiat buy payment receipt (`payment_receipt_file_key` in `POST /otc/order/paid`) | | bank | Add card, bank card supplementary materials | | assessment | Professional verification materials | | credit | Credit limit increase materials |  **Credential validity**: response `expires_in` is **5400 seconds (90 minutes)**; `fields.Policy` `expiration` matches it. Complete the S3 direct upload within this window; after expiry, call this endpoint again for a new credential.  **File size**: the S3 POST Policy enforces `content-length-range` **1 byte ~ 10MB** (10485760 bytes). Uploads exceeding the limit are rejected by S3; all `scene` values share this limit.  **Direct S3 upload**: `url` is the upload address; send each key-value pair in `fields` unchanged as form-data; the `file` field must be last. Object path is generated as `otc_temp/{uid}/{scene}/{unique filename}`; uid is taken from the login session.  This endpoint returns `content type is required.` when `content_type` is missing. Ownership and object-existence checks for `file_key` are performed by the subsequent business submission endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CreateOtcUploadPreUploadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OTCApi(config);
            var otcUploadPreUploadRequest = new OtcUploadPreUploadRequest(); // OtcUploadPreUploadRequest | 

            try
            {
                // Pre-upload file (temporary bucket)
                OtcUploadPreUploadResponse result = apiInstance.CreateOtcUploadPreUpload(otcUploadPreUploadRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OTCApi.CreateOtcUploadPreUpload: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **otcUploadPreUploadRequest** | [**OtcUploadPreUploadRequest**](OtcUploadPreUploadRequest.md)|  | 

### Return type

[**OtcUploadPreUploadResponse**](OtcUploadPreUploadResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Pre-upload credentials issued successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="markotcorderpaid"></a>
# **MarkOtcOrderPaid**
> OtcActionResponse MarkOtcOrderPaid (OtcMarkOrderPaidRequest otcMarkOrderPaidRequest)

Mark fiat order as paid (deposit confirmation)

Mark a fiat buy order as paid (deposit confirmation). **A user payment receipt must be uploaded**: `payment_receipt_file_key` is required; supported formats are jpg / jpeg / png / pdf, with a maximum size of 10 MB per file (validated jointly by the service and gateway). The compatible field name `payment_receipt` depends on the gateway and production contract. The persisted field is `otc_trade_record.payment_receipt_file_key`. The Pay Inner path is `POST .../pay/order_set_paid` (which commonly identifies orders by `client_order_id`); the Inner path corresponding to this OpenAPI operation, `POST /order/paid`, still primarily uses `order_id`. If the gateway standardizes on the merchant order ID, follow the gateway documentation.  **Recommended pre-upload flow**: first call `POST /otc/upload/pre_upload` (`scene=general`) and upload directly to the temporary bucket, then pass the returned **base64 `file_key` unchanged** (do not decode) to this endpoint. The service validates the uid and object existence before moving the object to the production bucket. A cross-user key returns `Invalid parameters file_key`; an object that has not been uploaded returns `Invalid parameters file not uploaded`. The legacy flow using a base64 key for an object uploaded directly to the production bucket remains supported.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class MarkOtcOrderPaidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OTCApi(config);
            var otcMarkOrderPaidRequest = new OtcMarkOrderPaidRequest(); // OtcMarkOrderPaidRequest | 

            try
            {
                // Mark fiat order as paid (deposit confirmation)
                OtcActionResponse result = apiInstance.MarkOtcOrderPaid(otcMarkOrderPaidRequest);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OTCApi.MarkOtcOrderPaid: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **otcMarkOrderPaidRequest** | [**OtcMarkOrderPaidRequest**](OtcMarkOrderPaidRequest.md)|  | 

### Return type

[**OtcActionResponse**](OtcActionResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The order has been marked as paid |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelotcorder"></a>
# **CancelOtcOrder**
> OtcActionResponse CancelOtcOrder (string orderId)

Fiat order cancellation

Cancel fiat order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class CancelOtcOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OTCApi(config);
            var orderId = "orderId_example";  // string | Order ID

            try
            {
                // Fiat order cancellation
                OtcActionResponse result = apiInstance.CancelOtcOrder(orderId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OTCApi.CancelOtcOrder: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| Order ID | 

### Return type

[**OtcActionResponse**](OtcActionResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Order cancelled successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listotcorders"></a>
# **ListOtcOrders**
> OtcOrderListResponse ListOtcOrders (string type = null, string fiatCurrency = null, string cryptoCurrency = null, string startTime = null, string endTime = null, string status = null, string pn = null, string ps = null)

Fiat order list

Query the fiat order list with filters such as type, currency, time range, and status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListOtcOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OTCApi(config);
            var type = "type_example";  // string | BUY for on-ramp, SELL for off-ramp (optional) 
            var fiatCurrency = "fiatCurrency_example";  // string | Fiat currency (optional) 
            var cryptoCurrency = "cryptoCurrency_example";  // string | Digital currency (optional) 
            var startTime = "startTime_example";  // string | starttime   for example : 2025-09-09 (optional) 
            var endTime = "endTime_example";  // string | endtime  for example :2025-09-09 (optional) 
            var status = "status_example";  // string | DONE: completed CANCEL: canceled PROCESSING: in progress DISBURSED: disbursed (optional) 
            var pn = "pn_example";  // string | Page number (optional) 
            var ps = "ps_example";  // string | Number of items per page (optional) 

            try
            {
                // Fiat order list
                OtcOrderListResponse result = apiInstance.ListOtcOrders(type, fiatCurrency, cryptoCurrency, startTime, endTime, status, pn, ps);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OTCApi.ListOtcOrders: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| BUY for on-ramp, SELL for off-ramp | [optional] 
 **fiatCurrency** | **string**| Fiat currency | [optional] 
 **cryptoCurrency** | **string**| Digital currency | [optional] 
 **startTime** | **string**| starttime   for example : 2025-09-09 | [optional] 
 **endTime** | **string**| endtime  for example :2025-09-09 | [optional] 
 **status** | **string**| DONE: completed CANCEL: canceled PROCESSING: in progress DISBURSED: disbursed | [optional] 
 **pn** | **string**| Page number | [optional] 
 **ps** | **string**| Number of items per page | [optional] 

### Return type

[**OtcOrderListResponse**](OtcOrderListResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Query successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="liststablecoinorders"></a>
# **ListStableCoinOrders**
> OtcStableCoinOrderListResponse ListStableCoinOrders (string pageSize = null, string pageNumber = null, string coinName = null, string startTime = null, string endTime = null, string status = null)

Stablecoin order list

Query stablecoin order list with filtering by currency, time range, status, etc.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class ListStableCoinOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OTCApi(config);
            var pageSize = "10";  // string | Number of records per page (optional) 
            var pageNumber = "1";  // string | Page number (optional) 
            var coinName = "USDT";  // string | ordercurrency (optional) 
            var startTime = "startTime_example";  // string | Start Time (optional) 
            var endTime = "endTime_example";  // string | End time (optional) 
            var status = "status_example";  // string | Status: PROCESSING: in progress / DONE：completed / FAILED: failed (optional) 

            try
            {
                // Stablecoin order list
                OtcStableCoinOrderListResponse result = apiInstance.ListStableCoinOrders(pageSize, pageNumber, coinName, startTime, endTime, status);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OTCApi.ListStableCoinOrders: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pageSize** | **string**| Number of records per page | [optional] 
 **pageNumber** | **string**| Page number | [optional] 
 **coinName** | **string**| ordercurrency | [optional] 
 **startTime** | **string**| Start Time | [optional] 
 **endTime** | **string**| End time | [optional] 
 **status** | **string**| Status: PROCESSING: in progress / DONE：completed / FAILED: failed | [optional] 

### Return type

[**OtcStableCoinOrderListResponse**](OtcStableCoinOrderListResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Query successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getotcorderdetail"></a>
# **GetOtcOrderDetail**
> OtcOrderDetailResponse GetOtcOrderDetail (string orderId)

Fiat order details

Query fiat order details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class GetOtcOrderDetailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            config.SetGateApiV4KeyPair("YOUR_API_KEY", "YOUR_API_SECRET");

            var apiInstance = new OTCApi(config);
            var orderId = "orderId_example";  // string | Order ID

            try
            {
                // Fiat order details
                OtcOrderDetailResponse result = apiInstance.GetOtcOrderDetail(orderId);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling OTCApi.GetOtcOrderDetail: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**| Order ID | 

### Return type

[**OtcOrderDetailResponse**](OtcOrderDetailResponse.md)

### Authorization

[apiv4](../README.md#apiv4)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Query successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

