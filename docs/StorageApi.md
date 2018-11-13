# BlueRain.ID4i.Api.StorageApi

All URIs are relative to *https://backend.id4i.de*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateDocument**](StorageApi.md#createdocument) | **PUT** /api/v1/documents/{id4n}/{organizationId} | Create an empty document for an id4n
[**DeleteDocument**](StorageApi.md#deletedocument) | **DELETE** /api/v1/documents/{id4n}/{organizationId}/{fileName} | Delete a document
[**GetDocument**](StorageApi.md#getdocument) | **GET** /api/v1/documents/{id4n}/{organizationId}/{fileName}/metadata | Retrieve a document (meta-data only, no content)
[**GetPublicDocument**](StorageApi.md#getpublicdocument) | **GET** /api/v1/public/documents/{id4n}/{organizationId}/{fileName}/metadata | Retrieve a public document (meta-data only, no content)
[**ListAllDocuments**](StorageApi.md#listalldocuments) | **GET** /api/v1/documents/{id4n} | List documents
[**ListAllPublicDocuments**](StorageApi.md#listallpublicdocuments) | **GET** /api/v1/public/documents/{id4n} | List public documents
[**ListDocuments**](StorageApi.md#listdocuments) | **GET** /api/v1/documents/{id4n}/{organizationId} | List organization specific documents
[**ReadDocument**](StorageApi.md#readdocument) | **GET** /api/v1/documents/{id4n}/{organizationId}/{fileName} | Read document contents
[**ReadFromMicrostorage**](StorageApi.md#readfrommicrostorage) | **GET** /api/v1/microstorage/{id4n}/{organization} | Read data from microstorage
[**ReadPublicDocument**](StorageApi.md#readpublicdocument) | **GET** /api/v1/public/documents/{id4n}/{organizationId}/{fileName} | Read public document contents
[**UpdateDocumentMetadata**](StorageApi.md#updatedocumentmetadata) | **PATCH** /api/v1/documents/{id4n}/{organizationId}/{fileName}/metadata | Update a document
[**WriteToMicrostorage**](StorageApi.md#writetomicrostorage) | **PUT** /api/v1/microstorage/{id4n}/{organization} | Write data to microstorage


<a name="createdocument"></a>
# **CreateDocument**
> Document CreateDocument (System.IO.Stream content, string id4n, string organizationId)

Create an empty document for an id4n

The document is created empty, mime-type defaults to text/plain

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class CreateDocumentExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi();
            var content = new System.IO.Stream(); // System.IO.Stream | content
            var id4n = id4n_example;  // string | id4n
            var organizationId = organizationId_example;  // string | organizationId

            try
            {
                // Create an empty document for an id4n
                Document result = apiInstance.CreateDocument(content, id4n, organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.CreateDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **content** | **System.IO.Stream**| content | 
 **id4n** | **string**| id4n | 
 **organizationId** | **string**| organizationId | 

### Return type

[**Document**](Document.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedocument"></a>
# **DeleteDocument**
> void DeleteDocument (string fileName, string id4n, string organizationId)

Delete a document

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class DeleteDocumentExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi();
            var fileName = fileName_example;  // string | fileName
            var id4n = id4n_example;  // string | id4n
            var organizationId = organizationId_example;  // string | organizationId

            try
            {
                // Delete a document
                apiInstance.DeleteDocument(fileName, id4n, organizationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.DeleteDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| fileName | 
 **id4n** | **string**| id4n | 
 **organizationId** | **string**| organizationId | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocument"></a>
# **GetDocument**
> Document GetDocument (string fileName, string id4n, string organizationId)

Retrieve a document (meta-data only, no content)

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class GetDocumentExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi();
            var fileName = fileName_example;  // string | fileName
            var id4n = id4n_example;  // string | id4n
            var organizationId = organizationId_example;  // string | organizationId

            try
            {
                // Retrieve a document (meta-data only, no content)
                Document result = apiInstance.GetDocument(fileName, id4n, organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.GetDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| fileName | 
 **id4n** | **string**| id4n | 
 **organizationId** | **string**| organizationId | 

### Return type

[**Document**](Document.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpublicdocument"></a>
# **GetPublicDocument**
> Document GetPublicDocument (string fileName, string id4n, string organizationId)

Retrieve a public document (meta-data only, no content)

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class GetPublicDocumentExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi();
            var fileName = fileName_example;  // string | fileName
            var id4n = id4n_example;  // string | id4n
            var organizationId = organizationId_example;  // string | organizationId

            try
            {
                // Retrieve a public document (meta-data only, no content)
                Document result = apiInstance.GetPublicDocument(fileName, id4n, organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.GetPublicDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| fileName | 
 **id4n** | **string**| id4n | 
 **organizationId** | **string**| organizationId | 

### Return type

[**Document**](Document.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listalldocuments"></a>
# **ListAllDocuments**
> PaginatedDocumentResponse ListAllDocuments (string id4n, int? limit = null, int? offset = null, string owner = null)

List documents

Listing all documents of an id4n

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class ListAllDocumentsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi();
            var id4n = id4n_example;  // string | id4n
            var limit = 100;  // int? | The maximum count of returned elements (optional) 
            var offset = 0;  // int? | Start with the n-th element (optional) 
            var owner = owner_example;  // string | Filter by owner organization (optional) 

            try
            {
                // List documents
                PaginatedDocumentResponse result = apiInstance.ListAllDocuments(id4n, limit, offset, owner);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.ListAllDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 
 **limit** | **int?**| The maximum count of returned elements | [optional] 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **owner** | **string**| Filter by owner organization | [optional] 

### Return type

[**PaginatedDocumentResponse**](PaginatedDocumentResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listallpublicdocuments"></a>
# **ListAllPublicDocuments**
> PaginatedDocumentResponse ListAllPublicDocuments (string id4n, int? limit = null, int? offset = null, string organizationId = null, string owner = null)

List public documents

Listing all public documents of an id4n

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class ListAllPublicDocumentsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi();
            var id4n = id4n_example;  // string | id4n
            var limit = 100;  // int? | The maximum count of returned elements (optional) 
            var offset = 0;  // int? | Start with the n-th element (optional) 
            var organizationId = organizationId_example;  // string | organizationId (optional) 
            var owner = owner_example;  // string | Filter by owner organization (optional) 

            try
            {
                // List public documents
                PaginatedDocumentResponse result = apiInstance.ListAllPublicDocuments(id4n, limit, offset, organizationId, owner);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.ListAllPublicDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 
 **limit** | **int?**| The maximum count of returned elements | [optional] 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **organizationId** | **string**| organizationId | [optional] 
 **owner** | **string**| Filter by owner organization | [optional] 

### Return type

[**PaginatedDocumentResponse**](PaginatedDocumentResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listdocuments"></a>
# **ListDocuments**
> PaginatedDocumentResponse ListDocuments (string id4n, string organizationId, int? limit = null, int? offset = null, string owner = null)

List organization specific documents

Listing documents of an id4n seen by a specified organization

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class ListDocumentsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi();
            var id4n = id4n_example;  // string | id4n
            var organizationId = organizationId_example;  // string | organizationId
            var limit = 100;  // int? | The maximum count of returned elements (optional) 
            var offset = 0;  // int? | Start with the n-th element (optional) 
            var owner = owner_example;  // string | Filter by owner organization (optional) 

            try
            {
                // List organization specific documents
                PaginatedDocumentResponse result = apiInstance.ListDocuments(id4n, organizationId, limit, offset, owner);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.ListDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 
 **organizationId** | **string**| organizationId | 
 **limit** | **int?**| The maximum count of returned elements | [optional] 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **owner** | **string**| Filter by owner organization | [optional] 

### Return type

[**PaginatedDocumentResponse**](PaginatedDocumentResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readdocument"></a>
# **ReadDocument**
> byte[] ReadDocument (string fileName, string id4n, string organizationId)

Read document contents

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class ReadDocumentExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi();
            var fileName = fileName_example;  // string | fileName
            var id4n = id4n_example;  // string | id4n
            var organizationId = organizationId_example;  // string | organizationId

            try
            {
                // Read document contents
                byte[] result = apiInstance.ReadDocument(fileName, id4n, organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.ReadDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| fileName | 
 **id4n** | **string**| id4n | 
 **organizationId** | **string**| organizationId | 

### Return type

**byte[]**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readfrommicrostorage"></a>
# **ReadFromMicrostorage**
> byte[] ReadFromMicrostorage (string id4n, string organization)

Read data from microstorage

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class ReadFromMicrostorageExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi();
            var id4n = id4n_example;  // string | id4n
            var organization = organization_example;  // string | organization

            try
            {
                // Read data from microstorage
                byte[] result = apiInstance.ReadFromMicrostorage(id4n, organization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.ReadFromMicrostorage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 
 **organization** | **string**| organization | 

### Return type

**byte[]**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpublicdocument"></a>
# **ReadPublicDocument**
> byte[] ReadPublicDocument (string fileName, string id4n, string organizationId)

Read public document contents

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class ReadPublicDocumentExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi();
            var fileName = fileName_example;  // string | fileName
            var id4n = id4n_example;  // string | id4n
            var organizationId = organizationId_example;  // string | organizationId

            try
            {
                // Read public document contents
                byte[] result = apiInstance.ReadPublicDocument(fileName, id4n, organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.ReadPublicDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **string**| fileName | 
 **id4n** | **string**| id4n | 
 **organizationId** | **string**| organizationId | 

### Return type

**byte[]**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedocumentmetadata"></a>
# **UpdateDocumentMetadata**
> Document UpdateDocumentMetadata (DocumentUpdate document, string fileName, string id4n, string organizationId)

Update a document

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class UpdateDocumentMetadataExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi();
            var document = new DocumentUpdate(); // DocumentUpdate | document
            var fileName = fileName_example;  // string | fileName
            var id4n = id4n_example;  // string | id4n
            var organizationId = organizationId_example;  // string | organizationId

            try
            {
                // Update a document
                Document result = apiInstance.UpdateDocumentMetadata(document, fileName, id4n, organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.UpdateDocumentMetadata: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **document** | [**DocumentUpdate**](DocumentUpdate.md)| document | 
 **fileName** | **string**| fileName | 
 **id4n** | **string**| id4n | 
 **organizationId** | **string**| organizationId | 

### Return type

[**Document**](Document.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writetomicrostorage"></a>
# **WriteToMicrostorage**
> Object WriteToMicrostorage (string id4n, string organization, long? contentLength = null, string contentType = null, byte[] body = null)

Write data to microstorage

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class WriteToMicrostorageExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi();
            var id4n = id4n_example;  // string | id4n
            var organization = organization_example;  // string | organization
            var contentLength = 789;  // long? | Content-Length (optional) 
            var contentType = contentType_example;  // string | Content-Type (optional) 
            var body = BINARY_DATA_HERE;  // byte[] | body (optional) 

            try
            {
                // Write data to microstorage
                Object result = apiInstance.WriteToMicrostorage(id4n, organization, contentLength, contentType, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.WriteToMicrostorage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 
 **organization** | **string**| organization | 
 **contentLength** | **long?**| Content-Length | [optional] 
 **contentType** | **string**| Content-Type | [optional] 
 **body** | **byte[]**| body | [optional] 

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

