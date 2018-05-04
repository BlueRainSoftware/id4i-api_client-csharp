# BlueRain.ID4i.Api.StorageApi

All URIs are relative to *https://backend.id4i.de*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateDocument**](StorageApi.md#createdocument) | **PUT** /api/v1/documents/{id4n}/{organizationId} | Create an empty document for an id4n
[**DeleteDocument**](StorageApi.md#deletedocument) | **DELETE** /api/v1/documents/{id4n}/{organizationId}/{fileName} | Delete a document
[**GetDocument**](StorageApi.md#getdocument) | **GET** /api/v1/documents/{id4n}/{organizationId}/{fileName}/metadata | Retrieve a document (meta-data only, no content)
[**GetPublicDocument**](StorageApi.md#getpublicdocument) | **GET** /api/v1/public/documents/{id4n}/{organizationId}/{fileName}/metadata | Retrieve a document (meta-data only, no content)
[**ListAllDocuments**](StorageApi.md#listalldocuments) | **GET** /api/v1/documents/{id4n} | List documents
[**ListAllPublicDocuments**](StorageApi.md#listallpublicdocuments) | **GET** /api/v1/public/documents/{id4n} | List organization specific documents
[**ListDocuments**](StorageApi.md#listdocuments) | **GET** /api/v1/documents/{id4n}/{organizationId} | List organization specific documents
[**ListPublicDocuments**](StorageApi.md#listpublicdocuments) | **GET** /api/v1/public/documents/{id4n}/{organizationId} | List organization specific documents
[**ReadDocument**](StorageApi.md#readdocument) | **GET** /api/v1/documents/{id4n}/{organizationId}/{fileName} | Read document contents
[**ReadFromMicrostorage**](StorageApi.md#readfrommicrostorage) | **GET** /api/v1/microstorage/{id4n}/{organization} | Read data from microstorage
[**ReadPublicDocument**](StorageApi.md#readpublicdocument) | **GET** /api/v1/public/documents/{id4n}/{organizationId}/{fileName} | Read document contents
[**UpdateDocumentMetadata**](StorageApi.md#updatedocumentmetadata) | **PATCH** /api/v1/documents/{id4n}/{organizationId}/{fileName}/metadata | Update a document
[**WriteToMicrostorage**](StorageApi.md#writetomicrostorage) | **PUT** /api/v1/microstorage/{id4n}/{organization} | Write data to microstorage


<a name="createdocument"></a>
# **CreateDocument**
> Document CreateDocument (string organizationId, string id4n, System.IO.Stream content)

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
            var organizationId = organizationId_example;  // string | organizationId
            var id4n = id4n_example;  // string | id4n
            var content = new System.IO.Stream(); // System.IO.Stream | content

            try
            {
                // Create an empty document for an id4n
                Document result = apiInstance.CreateDocument(organizationId, id4n, content);
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
 **organizationId** | **string**| organizationId | 
 **id4n** | **string**| id4n | 
 **content** | **System.IO.Stream**| content | 

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
> ResponseEntity DeleteDocument (string organizationId, string id4n, string fileName)

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
            var organizationId = organizationId_example;  // string | organizationId
            var id4n = id4n_example;  // string | id4n
            var fileName = fileName_example;  // string | fileName

            try
            {
                // Delete a document
                ResponseEntity result = apiInstance.DeleteDocument(organizationId, id4n, fileName);
                Debug.WriteLine(result);
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
 **organizationId** | **string**| organizationId | 
 **id4n** | **string**| id4n | 
 **fileName** | **string**| fileName | 

### Return type

[**ResponseEntity**](ResponseEntity.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocument"></a>
# **GetDocument**
> Document GetDocument (string organizationId, string id4n, string fileName)

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
            var organizationId = organizationId_example;  // string | organizationId
            var id4n = id4n_example;  // string | id4n
            var fileName = fileName_example;  // string | fileName

            try
            {
                // Retrieve a document (meta-data only, no content)
                Document result = apiInstance.GetDocument(organizationId, id4n, fileName);
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
 **organizationId** | **string**| organizationId | 
 **id4n** | **string**| id4n | 
 **fileName** | **string**| fileName | 

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
> Document GetPublicDocument (string organizationId, string id4n, string fileName)

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
    public class GetPublicDocumentExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi();
            var organizationId = organizationId_example;  // string | organizationId
            var id4n = id4n_example;  // string | id4n
            var fileName = fileName_example;  // string | fileName

            try
            {
                // Retrieve a document (meta-data only, no content)
                Document result = apiInstance.GetPublicDocument(organizationId, id4n, fileName);
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
 **organizationId** | **string**| organizationId | 
 **id4n** | **string**| id4n | 
 **fileName** | **string**| fileName | 

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
> PaginatedOwnedDocumentResponse ListAllDocuments (string id4n, int? offset = null, int? limit = null)

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
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // List documents
                PaginatedOwnedDocumentResponse result = apiInstance.ListAllDocuments(id4n, offset, limit);
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
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedOwnedDocumentResponse**](PaginatedOwnedDocumentResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listallpublicdocuments"></a>
# **ListAllPublicDocuments**
> PaginatedOwnedDocumentResponse ListAllPublicDocuments (string id4n, string organizationId = null, int? offset = null, int? limit = null)

List organization specific documents

Listing documents of an id4n owned by a specified organization

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
            var organizationId = organizationId_example;  // string | organizationId (optional) 
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // List organization specific documents
                PaginatedOwnedDocumentResponse result = apiInstance.ListAllPublicDocuments(id4n, organizationId, offset, limit);
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
 **organizationId** | **string**| organizationId | [optional] 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedOwnedDocumentResponse**](PaginatedOwnedDocumentResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listdocuments"></a>
# **ListDocuments**
> PaginatedDocumentResponse ListDocuments (string organizationId, string id4n, int? offset = null, int? limit = null)

List organization specific documents

Listing documents of an id4n owned by a specified organization

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
            var organizationId = organizationId_example;  // string | organizationId
            var id4n = id4n_example;  // string | id4n
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // List organization specific documents
                PaginatedDocumentResponse result = apiInstance.ListDocuments(organizationId, id4n, offset, limit);
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
 **organizationId** | **string**| organizationId | 
 **id4n** | **string**| id4n | 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedDocumentResponse**](PaginatedDocumentResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpublicdocuments"></a>
# **ListPublicDocuments**
> PaginatedDocumentResponse ListPublicDocuments (string organizationId, string id4n, int? offset = null, int? limit = null)

List organization specific documents

Listing documents of an id4n owned by a specified organization

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class ListPublicDocumentsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi();
            var organizationId = organizationId_example;  // string | organizationId
            var id4n = id4n_example;  // string | id4n
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // List organization specific documents
                PaginatedDocumentResponse result = apiInstance.ListPublicDocuments(organizationId, id4n, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.ListPublicDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| organizationId | 
 **id4n** | **string**| id4n | 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

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
> byte[] ReadDocument (string organizationId, string id4n, string fileName)

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
            var organizationId = organizationId_example;  // string | organizationId
            var id4n = id4n_example;  // string | id4n
            var fileName = fileName_example;  // string | fileName

            try
            {
                // Read document contents
                byte[] result = apiInstance.ReadDocument(organizationId, id4n, fileName);
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
 **organizationId** | **string**| organizationId | 
 **id4n** | **string**| id4n | 
 **fileName** | **string**| fileName | 

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
> byte[] ReadFromMicrostorage (string organization, string id4n)

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
            var organization = organization_example;  // string | organization
            var id4n = id4n_example;  // string | id4n

            try
            {
                // Read data from microstorage
                byte[] result = apiInstance.ReadFromMicrostorage(organization, id4n);
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
 **organization** | **string**| organization | 
 **id4n** | **string**| id4n | 

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
> byte[] ReadPublicDocument (string organizationId, string id4n, string fileName)

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
    public class ReadPublicDocumentExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StorageApi();
            var organizationId = organizationId_example;  // string | organizationId
            var id4n = id4n_example;  // string | id4n
            var fileName = fileName_example;  // string | fileName

            try
            {
                // Read document contents
                byte[] result = apiInstance.ReadPublicDocument(organizationId, id4n, fileName);
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
 **organizationId** | **string**| organizationId | 
 **id4n** | **string**| id4n | 
 **fileName** | **string**| fileName | 

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
> Document UpdateDocumentMetadata (string organizationId, string id4n, string fileName, DocumentUpdate document)

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
            var organizationId = organizationId_example;  // string | organizationId
            var id4n = id4n_example;  // string | id4n
            var fileName = fileName_example;  // string | fileName
            var document = new DocumentUpdate(); // DocumentUpdate | document

            try
            {
                // Update a document
                Document result = apiInstance.UpdateDocumentMetadata(organizationId, id4n, fileName, document);
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
 **organizationId** | **string**| organizationId | 
 **id4n** | **string**| id4n | 
 **fileName** | **string**| fileName | 
 **document** | [**DocumentUpdate**](DocumentUpdate.md)| document | 

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
> Object WriteToMicrostorage (string organization, string id4n, string contentType = null, long? contentLength = null, byte[] body = null)

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
            var organization = organization_example;  // string | organization
            var id4n = id4n_example;  // string | id4n
            var contentType = contentType_example;  // string | Content-Type (optional) 
            var contentLength = 789;  // long? | Content-Length (optional) 
            var body = BINARY_DATA_HERE;  // byte[] | body (optional) 

            try
            {
                // Write data to microstorage
                Object result = apiInstance.WriteToMicrostorage(organization, id4n, contentType, contentLength, body);
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
 **organization** | **string**| organization | 
 **id4n** | **string**| id4n | 
 **contentType** | **string**| Content-Type | [optional] 
 **contentLength** | **long?**| Content-Length | [optional] 
 **body** | **byte[]**| body | [optional] 

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

