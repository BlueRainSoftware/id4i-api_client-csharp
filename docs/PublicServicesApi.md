# BlueRain.ID4i.Api.PublicServicesApi

All URIs are relative to *https://backend.id4i.de*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPublicDocument**](PublicServicesApi.md#getpublicdocument) | **GET** /api/v1/public/collections/{id4n}/documents/{organizationId}/{fileName} | Retrieve a document (meta-data only, no content)
[**GetPublicDocument1**](PublicServicesApi.md#getpublicdocument1) | **GET** /api/v1/public/guids/{id4n}/documents/{organizationId}/{fileName} | Retrieve a document (meta-data only, no content)
[**Go**](PublicServicesApi.md#go) | **GET** /go/{guid} | Forward
[**ListAllPublicDocuments**](PublicServicesApi.md#listallpublicdocuments) | **GET** /api/v1/public/collections/{id4n}/documents | List organization specific documents
[**ListAllPublicDocuments1**](PublicServicesApi.md#listallpublicdocuments1) | **GET** /api/v1/public/guids/{id4n}/documents | List organization specific documents
[**ListPublicDocuments**](PublicServicesApi.md#listpublicdocuments) | **GET** /api/v1/public/collections/{id4n}/documents/{organizationId} | List organization specific documents
[**ListPublicDocuments1**](PublicServicesApi.md#listpublicdocuments1) | **GET** /api/v1/public/guids/{id4n}/documents/{organizationId} | List organization specific documents
[**ReadPublicDocument**](PublicServicesApi.md#readpublicdocument) | **GET** /api/v1/public/collections/{id4n}/documents/{organizationId}/{fileName}/content | Read document contents
[**ReadPublicDocument1**](PublicServicesApi.md#readpublicdocument1) | **GET** /api/v1/public/guids/{id4n}/documents/{organizationId}/{fileName}/content | Read document contents
[**ResolveImageUsingGET**](PublicServicesApi.md#resolveimageusingget) | **GET** /api/v1/public/image/{imageID} | Resolve image
[**ResolveWhoIsEntry**](PublicServicesApi.md#resolvewhoisentry) | **GET** /whois/{id4n} | Resolve owner of id4n


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
            
            var apiInstance = new PublicServicesApi();
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
                Debug.Print("Exception when calling PublicServicesApi.GetPublicDocument: " + e.Message );
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
            
            var apiInstance = new PublicServicesApi();
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
                Debug.Print("Exception when calling PublicServicesApi.GetPublicDocument1: " + e.Message );
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

<a name="go"></a>
# **Go**
> ApiError Go (string guid, string authorization, string acceptLanguage)

Forward

Forwarding to the designated route defined in the routing,

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class GoExample
    {
        public void main()
        {
            
            var apiInstance = new PublicServicesApi();
            var guid = guid_example;  // string | guid
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Forward
                ApiError result = apiInstance.Go(guid, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicServicesApi.Go: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **guid** | **string**| guid | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**ApiError**](ApiError.md)

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
            
            var apiInstance = new PublicServicesApi();
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
                Debug.Print("Exception when calling PublicServicesApi.ListAllPublicDocuments: " + e.Message );
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
            
            var apiInstance = new PublicServicesApi();
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
                Debug.Print("Exception when calling PublicServicesApi.ListAllPublicDocuments1: " + e.Message );
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
            
            var apiInstance = new PublicServicesApi();
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
                Debug.Print("Exception when calling PublicServicesApi.ListPublicDocuments: " + e.Message );
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
            
            var apiInstance = new PublicServicesApi();
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
                Debug.Print("Exception when calling PublicServicesApi.ListPublicDocuments1: " + e.Message );
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
            
            var apiInstance = new PublicServicesApi();
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
                Debug.Print("Exception when calling PublicServicesApi.ReadPublicDocument: " + e.Message );
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
            
            var apiInstance = new PublicServicesApi();
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
                Debug.Print("Exception when calling PublicServicesApi.ReadPublicDocument1: " + e.Message );
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

<a name="resolveimageusingget"></a>
# **ResolveImageUsingGET**
> byte[] ResolveImageUsingGET (string imageID, string authorization, string acceptLanguage)

Resolve image

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class ResolveImageUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new PublicServicesApi();
            var imageID = imageID_example;  // string | The id of the image to be resolved.
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Resolve image
                byte[] result = apiInstance.ResolveImageUsingGET(imageID, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicServicesApi.ResolveImageUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageID** | **string**| The id of the image to be resolved. | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

**byte[]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resolvewhoisentry"></a>
# **ResolveWhoIsEntry**
> WhoIsResponse ResolveWhoIsEntry (string id4n, string authorization, string acceptLanguage)

Resolve owner of id4n

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class ResolveWhoIsEntryExample
    {
        public void main()
        {
            
            var apiInstance = new PublicServicesApi();
            var id4n = id4n_example;  // string | id4n
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Resolve owner of id4n
                WhoIsResponse result = apiInstance.ResolveWhoIsEntry(id4n, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicServicesApi.ResolveWhoIsEntry: " + e.Message );
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

### Return type

[**WhoIsResponse**](WhoIsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

