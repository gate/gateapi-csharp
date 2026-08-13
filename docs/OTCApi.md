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
> OtcBankCreateResponse CreateOtcBank (string bankAccountName, string bankName, string bankCountry, string bankAddress, string iban, string swift, string documentationFile, string remittanceLineNumber = null, string agentBankName = null, string agentBankSwift = null)

Create bank card

Bind a bank card. Under the Global entity, an account with a non-matching name may enter manual review (`status` pending) and require subsequent supplementary materials. Corresponding Inner: `POST /bank/create`. Fields and protocol are subject to the production form/gateway; in some environments `bank_account_name` is passed Base64-encoded, see the integration notes for details.

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
            var documentationFile = "documentationFile_example";  // string | Account opening proof file content (multipart file field, binary/Base64; jpg/jpeg/png/pdf, etc.; maximum 10 MB per file, subject to the live environment)
            var remittanceLineNumber = "remittanceLineNumber_example";  // string |  (optional) 
            var agentBankName = "agentBankName_example";  // string |  (optional) 
            var agentBankSwift = "agentBankSwift_example";  // string |  (optional) 

            try
            {
                // Create bank card
                OtcBankCreateResponse result = apiInstance.CreateOtcBank(bankAccountName, bankName, bankCountry, bankAddress, iban, swift, documentationFile, remittanceLineNumber, agentBankName, agentBankSwift);
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
 **documentationFile** | **string**| Account opening proof file content (multipart file field, binary/Base64; jpg/jpeg/png/pdf, etc.; maximum 10 MB per file, subject to the live environment) | 
 **remittanceLineNumber** | **string**|  | [optional] 
 **agentBankName** | **string**|  | [optional] 
 **agentBankSwift** | **string**|  | [optional] 

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
> OtcActionResponse SubmitOtcBankPersonalSupplement (string bankId, string idDocumentFront, string idDocumentBack, string addressProof)

Submit Bank Card Supplement Materials (Personal)

**Personal professional verification (type=1)** users submit non-same-person/supplementary materials. Must match `user_type=personal` returned by `GET /otc/bank/bank_supplement_checklist?bank_id=`, otherwise the request is rejected. **multipart/form-data** is recommended: each material item is a separate file field, with field names matching the checklist `code` (`id_document_front`, `id_document_back`, `address_proof`).

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
            var idDocumentFront = "idDocumentFront_example";  // string | ID document front-side file content (multipart file field, binary/Base64)
            var idDocumentBack = "idDocumentBack_example";  // string | ID document back-side file content (multipart file field, binary/Base64)
            var addressProof = "addressProof_example";  // string | Proof-of-address file content (multipart file field, binary/Base64)

            try
            {
                // Submit Bank Card Supplement Materials (Personal)
                OtcActionResponse result = apiInstance.SubmitOtcBankPersonalSupplement(bankId, idDocumentFront, idDocumentBack, addressProof);
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
 **idDocumentFront** | **string**| ID document front-side file content (multipart file field, binary/Base64) | 
 **idDocumentBack** | **string**| ID document back-side file content (multipart file field, binary/Base64) | 
 **addressProof** | **string**| Proof-of-address file content (multipart file field, binary/Base64) | 

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
> OtcActionResponse SubmitOtcBankEnterpriseSupplement (string bankId, string certificate, string shareHolders, string passport, string shareHoldingStructure, string uid = null, string fundsStatement = null, string additional = null)

Submit Bank Card Supplement Materials (Enterprise)

**Enterprise professional verification (type=2)** users submit supplementary materials. Must match `user_type=enterprise` returned by the checklist. **multipart** file field names: `certificate`, `share_holders`, `passport`, `share_holding_structure`.

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
            var certificate = "certificate_example";  // string | Business license / registration certificate file content (multipart file field, binary/Base64)
            var shareHolders = "shareHolders_example";  // string | Register of shareholders file content (multipart file field, binary/Base64)
            var passport = "passport_example";  // string | Legal representative / shareholder passport file content (multipart file field, binary/Base64)
            var shareHoldingStructure = "shareHoldingStructure_example";  // string | Ownership structure chart file content (multipart file field, binary/Base64)
            var uid = "uid_example";  // string |  (optional) 
            var fundsStatement = "fundsStatement_example";  // string | Proof-of-funds file content (multipart file field, binary/Base64, optional) (optional) 
            var additional = "additional_example";  // string | Other supplementary material file content (multipart file field, binary/Base64, optional) (optional) 

            try
            {
                // Submit Bank Card Supplement Materials (Enterprise)
                OtcActionResponse result = apiInstance.SubmitOtcBankEnterpriseSupplement(bankId, certificate, shareHolders, passport, shareHoldingStructure, uid, fundsStatement, additional);
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
 **certificate** | **string**| Business license / registration certificate file content (multipart file field, binary/Base64) | 
 **shareHolders** | **string**| Register of shareholders file content (multipart file field, binary/Base64) | 
 **passport** | **string**| Legal representative / shareholder passport file content (multipart file field, binary/Base64) | 
 **shareHoldingStructure** | **string**| Ownership structure chart file content (multipart file field, binary/Base64) | 
 **uid** | **string**|  | [optional] 
 **fundsStatement** | **string**| Proof-of-funds file content (multipart file field, binary/Base64, optional) | [optional] 
 **additional** | **string**| Other supplementary material file content (multipart file field, binary/Base64, optional) | [optional] 

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

<a name="markotcorderpaid"></a>
# **MarkOtcOrderPaid**
> OtcActionResponse MarkOtcOrderPaid (OtcMarkOrderPaidRequest otcMarkOrderPaidRequest)

Mark fiat order as paid (deposit confirmation)

Mark a fiat BUY order as paid (deposit confirmation). **A user payment receipt must be uploaded**: `payment_receipt_file_key` is required; supported formats are jpg/jpeg/png/pdf, with a maximum size of 10 MB per file (validated jointly by the service and gateway). The compatibility field name `payment_receipt` is subject to the gateway/live environment. The persisted field is `otc_trade_record.payment_receipt_file_key`. The Pay Inner path is `POST .../pay/order_set_paid` (commonly associated by `client_order_id`); the Inner path corresponding to this OpenAPI endpoint, `POST /order/paid`, still primarily uses `order_id`. If the gateway standardizes on the merchant order ID, follow the gateway documentation.

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

