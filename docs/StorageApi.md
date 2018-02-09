# BlueRain.ID4i.Api.StorageApi

All URIs are relative to *https://backend.id4i.de*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateDocument**](StorageApi.md#createdocument) | **PUT** /api/v1/collections/{id4n}/documents/{organizationId} | Create an empty document for an id4n
[**CreateDocument1**](StorageApi.md#createdocument1) | **PUT** /api/v1/guids/{id4n}/documents/{organizationId} | Create an empty document for an id4n
[**DeleteDocument**](StorageApi.md#deletedocument) | **DELETE** /api/v1/collections/{id4n}/documents/{organizationId}/{fileName} | Delete a document
[**DeleteDocument1**](StorageApi.md#deletedocument1) | **DELETE** /api/v1/guids/{id4n}/documents/{organizationId}/{fileName} | Delete a document
[**GetDocument**](StorageApi.md#getdocument) | **GET** /api/v1/collections/{id4n}/documents/{organizationId}/{fileName} | Retrieve a document (meta-data only, no content)
[**GetDocument1**](StorageApi.md#getdocument1) | **GET** /api/v1/guids/{id4n}/documents/{organizationId}/{fileName} | Retrieve a document (meta-data only, no content)
[**GetPublicDocument**](StorageApi.md#getpublicdocument) | **GET** /api/v1/public/collections/{id4n}/documents/{organizationId}/{fileName} | Retrieve a document (meta-data only, no content)
[**GetPublicDocument1**](StorageApi.md#getpublicdocument1) | **GET** /api/v1/public/guids/{id4n}/documents/{organizationId}/{fileName} | Retrieve a document (meta-data only, no content)
[**ListAllDocuments**](StorageApi.md#listalldocuments) | **GET** /api/v1/collections/{id4n}/documents | List documents
[**ListAllDocuments1**](StorageApi.md#listalldocuments1) | **GET** /api/v1/guids/{id4n}/documents | List documents
[**ListAllPublicDocuments**](StorageApi.md#listallpublicdocuments) | **GET** /api/v1/public/collections/{id4n}/documents | List organization specific documents
[**ListAllPublicDocuments1**](StorageApi.md#listallpublicdocuments1) | **GET** /api/v1/public/guids/{id4n}/documents | List organization specific documents
[**ListDocuments**](StorageApi.md#listdocuments) | **GET** /api/v1/collections/{id4n}/documents/{organizationId} | List organization specific documents
[**ListDocuments1**](StorageApi.md#listdocuments1) | **GET** /api/v1/guids/{id4n}/documents/{organizationId} | List organization specific documents
[**ListPublicDocuments**](StorageApi.md#listpublicdocuments) | **GET** /api/v1/public/collections/{id4n}/documents/{organizationId} | List organization specific documents
[**ListPublicDocuments1**](StorageApi.md#listpublicdocuments1) | **GET** /api/v1/public/guids/{id4n}/documents/{organizationId} | List organization specific documents
[**Read**](StorageApi.md#read) | **GET** /api/v1/collections/{id4n}/micro/{organization} | Read data from microstorage
[**Read1**](StorageApi.md#read1) | **GET** /api/v1/guids/{id4n}/micro/{organization} | Read data from microstorage
[**ReadDocument**](StorageApi.md#readdocument) | **GET** /api/v1/collections/{id4n}/documents/{organizationId}/{fileName}/content | Read document contents
[**ReadDocument1**](StorageApi.md#readdocument1) | **GET** /api/v1/guids/{id4n}/documents/{organizationId}/{fileName}/content | Read document contents
[**ReadPublicDocument**](StorageApi.md#readpublicdocument) | **GET** /api/v1/public/collections/{id4n}/documents/{organizationId}/{fileName}/content | Read document contents
[**ReadPublicDocument1**](StorageApi.md#readpublicdocument1) | **GET** /api/v1/public/guids/{id4n}/documents/{organizationId}/{fileName}/content | Read document contents
[**UpdateDocument**](StorageApi.md#updatedocument) | **PATCH** /api/v1/collections/{id4n}/documents/{organizationId}/{fileName} | Update a document
[**UpdateDocument1**](StorageApi.md#updatedocument1) | **PATCH** /api/v1/guids/{id4n}/documents/{organizationId}/{fileName} | Update a document
[**Write**](StorageApi.md#write) | **PUT** /api/v1/collections/{id4n}/micro/{organization} | Write data to microstorage
[**Write1**](StorageApi.md#write1) | **PUT** /api/v1/guids/{id4n}/micro/{organization} | Write data to microstorage
[**WriteDocument**](StorageApi.md#writedocument) | **PUT** /api/v1/collections/{id4n}/documents/{organizationId}/{fileName}/content | Write document contents
[**WriteDocument1**](StorageApi.md#writedocument1) | **PUT** /api/v1/guids/{id4n}/documents/{organizationId}/{fileName}/content | Write document contents


<a name="createdocument"></a>
# **CreateDocument**
> Object CreateDocument (string id4n, long? organizationId, Document document, string authorization, string acceptLanguage, string mimeType)

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
            
            var apiInstance = new StorageApi();
            var id4n = id4n_example;  // string | id4n
            var organizationId = 789;  // long? | organizationId
            var document = new Document(); // Document | document
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var mimeType = mimeType_example;  // string | mimeType (optional) 

            try
            {
                // Create an empty document for an id4n
                Object result = apiInstance.CreateDocument(id4n, organizationId, document, authorization, acceptLanguage, mimeType);
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
 **id4n** | **string**| id4n | 
 **organizationId** | **long?**| organizationId | 
 **document** | [**Document**](Document.md)| document | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **mimeType** | **string**| mimeType | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createdocument1"></a>
# **CreateDocument1**
> Object CreateDocument1 (string id4n, long? organizationId, Document document, string authorization, string acceptLanguage, string mimeType)

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
    public class CreateDocument1Example
    {
        public void main()
        {
            
            var apiInstance = new StorageApi();
            var id4n = id4n_example;  // string | id4n
            var organizationId = 789;  // long? | organizationId
            var document = new Document(); // Document | document
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var mimeType = mimeType_example;  // string | mimeType (optional) 

            try
            {
                // Create an empty document for an id4n
                Object result = apiInstance.CreateDocument1(id4n, organizationId, document, authorization, acceptLanguage, mimeType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.CreateDocument1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 
 **organizationId** | **long?**| organizationId | 
 **document** | [**Document**](Document.md)| document | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **mimeType** | **string**| mimeType | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedocument"></a>
# **DeleteDocument**
> Object DeleteDocument (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage)

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
            
            var apiInstance = new StorageApi();
            var organizationId = 789;  // long? | organizationId
            var id4n = id4n_example;  // string | id4n
            var fileName = fileName_example;  // string | fileName
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Delete a document
                Object result = apiInstance.DeleteDocument(organizationId, id4n, fileName, authorization, acceptLanguage);
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
 **organizationId** | **long?**| organizationId | 
 **id4n** | **string**| id4n | 
 **fileName** | **string**| fileName | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedocument1"></a>
# **DeleteDocument1**
> Object DeleteDocument1 (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage)

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
    public class DeleteDocument1Example
    {
        public void main()
        {
            
            var apiInstance = new StorageApi();
            var organizationId = 789;  // long? | organizationId
            var id4n = id4n_example;  // string | id4n
            var fileName = fileName_example;  // string | fileName
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Delete a document
                Object result = apiInstance.DeleteDocument1(organizationId, id4n, fileName, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.DeleteDocument1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **id4n** | **string**| id4n | 
 **fileName** | **string**| fileName | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocument"></a>
# **GetDocument**
> Document GetDocument (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage)

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
            
            var apiInstance = new StorageApi();
            var organizationId = 789;  // long? | organizationId
            var id4n = id4n_example;  // string | id4n
            var fileName = fileName_example;  // string | fileName
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Retrieve a document (meta-data only, no content)
                Document result = apiInstance.GetDocument(organizationId, id4n, fileName, authorization, acceptLanguage);
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
 **organizationId** | **long?**| organizationId | 
 **id4n** | **string**| id4n | 
 **fileName** | **string**| fileName | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**Document**](Document.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocument1"></a>
# **GetDocument1**
> Document GetDocument1 (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage)

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
    public class GetDocument1Example
    {
        public void main()
        {
            
            var apiInstance = new StorageApi();
            var organizationId = 789;  // long? | organizationId
            var id4n = id4n_example;  // string | id4n
            var fileName = fileName_example;  // string | fileName
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Retrieve a document (meta-data only, no content)
                Document result = apiInstance.GetDocument1(organizationId, id4n, fileName, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.GetDocument1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **id4n** | **string**| id4n | 
 **fileName** | **string**| fileName | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**Document**](Document.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpublicdocument"></a>
# **GetPublicDocument**
> Document GetPublicDocument (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage)

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
            
            var apiInstance = new StorageApi();
            var organizationId = 789;  // long? | organizationId
            var id4n = id4n_example;  // string | id4n
            var fileName = fileName_example;  // string | fileName
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Retrieve a document (meta-data only, no content)
                Document result = apiInstance.GetPublicDocument(organizationId, id4n, fileName, authorization, acceptLanguage);
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
 **organizationId** | **long?**| organizationId | 
 **id4n** | **string**| id4n | 
 **fileName** | **string**| fileName | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**Document**](Document.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpublicdocument1"></a>
# **GetPublicDocument1**
> Document GetPublicDocument1 (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage)

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
    public class GetPublicDocument1Example
    {
        public void main()
        {
            
            var apiInstance = new StorageApi();
            var organizationId = 789;  // long? | organizationId
            var id4n = id4n_example;  // string | id4n
            var fileName = fileName_example;  // string | fileName
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Retrieve a document (meta-data only, no content)
                Document result = apiInstance.GetPublicDocument1(organizationId, id4n, fileName, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.GetPublicDocument1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **id4n** | **string**| id4n | 
 **fileName** | **string**| fileName | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**Document**](Document.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listalldocuments"></a>
# **ListAllDocuments**
> PaginatedOwnedDocumentResponse ListAllDocuments (string id4n, string authorization, string acceptLanguage, int? offset, int? limit)

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
            
            var apiInstance = new StorageApi();
            var id4n = id4n_example;  // string | id4n
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // List documents
                PaginatedOwnedDocumentResponse result = apiInstance.ListAllDocuments(id4n, authorization, acceptLanguage, offset, limit);
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
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedOwnedDocumentResponse**](PaginatedOwnedDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listalldocuments1"></a>
# **ListAllDocuments1**
> PaginatedOwnedDocumentResponse ListAllDocuments1 (string id4n, string authorization, string acceptLanguage, int? offset, int? limit)

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
    public class ListAllDocuments1Example
    {
        public void main()
        {
            
            var apiInstance = new StorageApi();
            var id4n = id4n_example;  // string | id4n
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // List documents
                PaginatedOwnedDocumentResponse result = apiInstance.ListAllDocuments1(id4n, authorization, acceptLanguage, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.ListAllDocuments1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedOwnedDocumentResponse**](PaginatedOwnedDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listallpublicdocuments"></a>
# **ListAllPublicDocuments**
> PaginatedOwnedDocumentResponse ListAllPublicDocuments (string id4n, string authorization, string acceptLanguage, long? organizationId, int? offset, int? limit)

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
            
            var apiInstance = new StorageApi();
            var id4n = id4n_example;  // string | id4n
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var organizationId = 789;  // long? | organizationId (optional) 
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // List organization specific documents
                PaginatedOwnedDocumentResponse result = apiInstance.ListAllPublicDocuments(id4n, authorization, acceptLanguage, organizationId, offset, limit);
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
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **organizationId** | **long?**| organizationId | [optional] 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedOwnedDocumentResponse**](PaginatedOwnedDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listallpublicdocuments1"></a>
# **ListAllPublicDocuments1**
> PaginatedOwnedDocumentResponse ListAllPublicDocuments1 (string id4n, string authorization, string acceptLanguage, long? organizationId, int? offset, int? limit)

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
    public class ListAllPublicDocuments1Example
    {
        public void main()
        {
            
            var apiInstance = new StorageApi();
            var id4n = id4n_example;  // string | id4n
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var organizationId = 789;  // long? | organizationId (optional) 
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // List organization specific documents
                PaginatedOwnedDocumentResponse result = apiInstance.ListAllPublicDocuments1(id4n, authorization, acceptLanguage, organizationId, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.ListAllPublicDocuments1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **organizationId** | **long?**| organizationId | [optional] 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedOwnedDocumentResponse**](PaginatedOwnedDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listdocuments"></a>
# **ListDocuments**
> PaginatedDocumentResponse ListDocuments (long? organizationId, string id4n, string authorization, string acceptLanguage, int? offset, int? limit)

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
            
            var apiInstance = new StorageApi();
            var organizationId = 789;  // long? | organizationId
            var id4n = id4n_example;  // string | id4n
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // List organization specific documents
                PaginatedDocumentResponse result = apiInstance.ListDocuments(organizationId, id4n, authorization, acceptLanguage, offset, limit);
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
 **organizationId** | **long?**| organizationId | 
 **id4n** | **string**| id4n | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedDocumentResponse**](PaginatedDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listdocuments1"></a>
# **ListDocuments1**
> PaginatedDocumentResponse ListDocuments1 (long? organizationId, string id4n, string authorization, string acceptLanguage, int? offset, int? limit)

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
    public class ListDocuments1Example
    {
        public void main()
        {
            
            var apiInstance = new StorageApi();
            var organizationId = 789;  // long? | organizationId
            var id4n = id4n_example;  // string | id4n
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // List organization specific documents
                PaginatedDocumentResponse result = apiInstance.ListDocuments1(organizationId, id4n, authorization, acceptLanguage, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.ListDocuments1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **id4n** | **string**| id4n | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedDocumentResponse**](PaginatedDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpublicdocuments"></a>
# **ListPublicDocuments**
> PaginatedDocumentResponse ListPublicDocuments (long? organizationId, string id4n, string authorization, string acceptLanguage, int? offset, int? limit)

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
            
            var apiInstance = new StorageApi();
            var organizationId = 789;  // long? | organizationId
            var id4n = id4n_example;  // string | id4n
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // List organization specific documents
                PaginatedDocumentResponse result = apiInstance.ListPublicDocuments(organizationId, id4n, authorization, acceptLanguage, offset, limit);
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
 **organizationId** | **long?**| organizationId | 
 **id4n** | **string**| id4n | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedDocumentResponse**](PaginatedDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpublicdocuments1"></a>
# **ListPublicDocuments1**
> PaginatedDocumentResponse ListPublicDocuments1 (long? organizationId, string id4n, string authorization, string acceptLanguage, int? offset, int? limit)

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
    public class ListPublicDocuments1Example
    {
        public void main()
        {
            
            var apiInstance = new StorageApi();
            var organizationId = 789;  // long? | organizationId
            var id4n = id4n_example;  // string | id4n
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // List organization specific documents
                PaginatedDocumentResponse result = apiInstance.ListPublicDocuments1(organizationId, id4n, authorization, acceptLanguage, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.ListPublicDocuments1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **id4n** | **string**| id4n | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedDocumentResponse**](PaginatedDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="read"></a>
# **Read**
> InputStreamResource Read (long? organization, string id4n, string authorization, string acceptLanguage)

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
    public class ReadExample
    {
        public void main()
        {
            
            var apiInstance = new StorageApi();
            var organization = 789;  // long? | organization
            var id4n = id4n_example;  // string | id4n
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Read data from microstorage
                InputStreamResource result = apiInstance.Read(organization, id4n, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.Read: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organization** | **long?**| organization | 
 **id4n** | **string**| id4n | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**InputStreamResource**](InputStreamResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="read1"></a>
# **Read1**
> InputStreamResource Read1 (long? organization, string id4n, string authorization, string acceptLanguage)

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
    public class Read1Example
    {
        public void main()
        {
            
            var apiInstance = new StorageApi();
            var organization = 789;  // long? | organization
            var id4n = id4n_example;  // string | id4n
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Read data from microstorage
                InputStreamResource result = apiInstance.Read1(organization, id4n, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.Read1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organization** | **long?**| organization | 
 **id4n** | **string**| id4n | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**InputStreamResource**](InputStreamResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readdocument"></a>
# **ReadDocument**
> InputStreamResource ReadDocument (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage)

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
            
            var apiInstance = new StorageApi();
            var organizationId = 789;  // long? | organizationId
            var id4n = id4n_example;  // string | id4n
            var fileName = fileName_example;  // string | fileName
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Read document contents
                InputStreamResource result = apiInstance.ReadDocument(organizationId, id4n, fileName, authorization, acceptLanguage);
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
 **organizationId** | **long?**| organizationId | 
 **id4n** | **string**| id4n | 
 **fileName** | **string**| fileName | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**InputStreamResource**](InputStreamResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readdocument1"></a>
# **ReadDocument1**
> InputStreamResource ReadDocument1 (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage)

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
    public class ReadDocument1Example
    {
        public void main()
        {
            
            var apiInstance = new StorageApi();
            var organizationId = 789;  // long? | organizationId
            var id4n = id4n_example;  // string | id4n
            var fileName = fileName_example;  // string | fileName
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Read document contents
                InputStreamResource result = apiInstance.ReadDocument1(organizationId, id4n, fileName, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.ReadDocument1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **id4n** | **string**| id4n | 
 **fileName** | **string**| fileName | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**InputStreamResource**](InputStreamResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpublicdocument"></a>
# **ReadPublicDocument**
> InputStreamResource ReadPublicDocument (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage)

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
            
            var apiInstance = new StorageApi();
            var organizationId = 789;  // long? | organizationId
            var id4n = id4n_example;  // string | id4n
            var fileName = fileName_example;  // string | fileName
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Read document contents
                InputStreamResource result = apiInstance.ReadPublicDocument(organizationId, id4n, fileName, authorization, acceptLanguage);
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
 **organizationId** | **long?**| organizationId | 
 **id4n** | **string**| id4n | 
 **fileName** | **string**| fileName | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**InputStreamResource**](InputStreamResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpublicdocument1"></a>
# **ReadPublicDocument1**
> InputStreamResource ReadPublicDocument1 (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage)

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
    public class ReadPublicDocument1Example
    {
        public void main()
        {
            
            var apiInstance = new StorageApi();
            var organizationId = 789;  // long? | organizationId
            var id4n = id4n_example;  // string | id4n
            var fileName = fileName_example;  // string | fileName
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Read document contents
                InputStreamResource result = apiInstance.ReadPublicDocument1(organizationId, id4n, fileName, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.ReadPublicDocument1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **id4n** | **string**| id4n | 
 **fileName** | **string**| fileName | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**InputStreamResource**](InputStreamResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedocument"></a>
# **UpdateDocument**
> Document UpdateDocument (long? organizationId, string id4n, string fileName, DocumentUpdate document, string authorization, string acceptLanguage)

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
    public class UpdateDocumentExample
    {
        public void main()
        {
            
            var apiInstance = new StorageApi();
            var organizationId = 789;  // long? | organizationId
            var id4n = id4n_example;  // string | id4n
            var fileName = fileName_example;  // string | fileName
            var document = new DocumentUpdate(); // DocumentUpdate | document
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Update a document
                Document result = apiInstance.UpdateDocument(organizationId, id4n, fileName, document, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.UpdateDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **id4n** | **string**| id4n | 
 **fileName** | **string**| fileName | 
 **document** | [**DocumentUpdate**](DocumentUpdate.md)| document | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**Document**](Document.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedocument1"></a>
# **UpdateDocument1**
> Document UpdateDocument1 (long? organizationId, string id4n, string fileName, DocumentUpdate document, string authorization, string acceptLanguage)

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
    public class UpdateDocument1Example
    {
        public void main()
        {
            
            var apiInstance = new StorageApi();
            var organizationId = 789;  // long? | organizationId
            var id4n = id4n_example;  // string | id4n
            var fileName = fileName_example;  // string | fileName
            var document = new DocumentUpdate(); // DocumentUpdate | document
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Update a document
                Document result = apiInstance.UpdateDocument1(organizationId, id4n, fileName, document, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.UpdateDocument1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **id4n** | **string**| id4n | 
 **fileName** | **string**| fileName | 
 **document** | [**DocumentUpdate**](DocumentUpdate.md)| document | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**Document**](Document.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="write"></a>
# **Write**
> Object Write (long? organization, string id4n, string authorization, string acceptLanguage, string contentType, long? contentLength)

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
    public class WriteExample
    {
        public void main()
        {
            
            var apiInstance = new StorageApi();
            var organization = 789;  // long? | organization
            var id4n = id4n_example;  // string | id4n
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var contentType = contentType_example;  // string | Content-Type (optional) 
            var contentLength = 789;  // long? | Content-Length (optional) 

            try
            {
                // Write data to microstorage
                Object result = apiInstance.Write(organization, id4n, authorization, acceptLanguage, contentType, contentLength);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.Write: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organization** | **long?**| organization | 
 **id4n** | **string**| id4n | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **contentType** | **string**| Content-Type | [optional] 
 **contentLength** | **long?**| Content-Length | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="write1"></a>
# **Write1**
> Object Write1 (long? organization, string id4n, string authorization, string acceptLanguage, string contentType, long? contentLength)

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
    public class Write1Example
    {
        public void main()
        {
            
            var apiInstance = new StorageApi();
            var organization = 789;  // long? | organization
            var id4n = id4n_example;  // string | id4n
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var contentType = contentType_example;  // string | Content-Type (optional) 
            var contentLength = 789;  // long? | Content-Length (optional) 

            try
            {
                // Write data to microstorage
                Object result = apiInstance.Write1(organization, id4n, authorization, acceptLanguage, contentType, contentLength);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.Write1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organization** | **long?**| organization | 
 **id4n** | **string**| id4n | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **contentType** | **string**| Content-Type | [optional] 
 **contentLength** | **long?**| Content-Length | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writedocument"></a>
# **WriteDocument**
> Object WriteDocument (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage, string contentType, long? contentLength)

Write document contents

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class WriteDocumentExample
    {
        public void main()
        {
            
            var apiInstance = new StorageApi();
            var organizationId = 789;  // long? | organizationId
            var id4n = id4n_example;  // string | id4n
            var fileName = fileName_example;  // string | fileName
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var contentType = contentType_example;  // string | Content-Type (optional) 
            var contentLength = 789;  // long? | Content-Length (optional) 

            try
            {
                // Write document contents
                Object result = apiInstance.WriteDocument(organizationId, id4n, fileName, authorization, acceptLanguage, contentType, contentLength);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.WriteDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **id4n** | **string**| id4n | 
 **fileName** | **string**| fileName | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **contentType** | **string**| Content-Type | [optional] 
 **contentLength** | **long?**| Content-Length | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writedocument1"></a>
# **WriteDocument1**
> Object WriteDocument1 (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage, string contentType, long? contentLength)

Write document contents

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class WriteDocument1Example
    {
        public void main()
        {
            
            var apiInstance = new StorageApi();
            var organizationId = 789;  // long? | organizationId
            var id4n = id4n_example;  // string | id4n
            var fileName = fileName_example;  // string | fileName
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var contentType = contentType_example;  // string | Content-Type (optional) 
            var contentLength = 789;  // long? | Content-Length (optional) 

            try
            {
                // Write document contents
                Object result = apiInstance.WriteDocument1(organizationId, id4n, fileName, authorization, acceptLanguage, contentType, contentLength);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.WriteDocument1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **id4n** | **string**| id4n | 
 **fileName** | **string**| fileName | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **contentType** | **string**| Content-Type | [optional] 
 **contentLength** | **long?**| Content-Length | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

