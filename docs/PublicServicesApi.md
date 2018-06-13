# BlueRain.ID4i.Api.PublicServicesApi

All URIs are relative to *https://backend.id4i.de*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPublicDocument**](PublicServicesApi.md#getpublicdocument) | **GET** /api/v1/public/documents/{id4n}/{organizationId}/{fileName}/metadata | Retrieve a document (meta-data only, no content)
[**GetRoutes**](PublicServicesApi.md#getroutes) | **GET** /api/v1/public/routes/{id4n} | Retrieve all public routes for a GUID
[**Go**](PublicServicesApi.md#go) | **GET** /go/{guid} | Forward
[**ListAllPublicDocuments**](PublicServicesApi.md#listallpublicdocuments) | **GET** /api/v1/public/documents/{id4n} | List organization specific documents
[**ListPublicDocuments**](PublicServicesApi.md#listpublicdocuments) | **GET** /api/v1/public/documents/{id4n}/{organizationId} | List organization specific documents
[**ListPublicHistory**](PublicServicesApi.md#listpublichistory) | **GET** /api/v1/public/history/{id4n} | Shows the public history of the given GUID
[**ReadOrganizationInfo**](PublicServicesApi.md#readorganizationinfo) | **GET** /api/v1/public/organizations/{organizationId} | Read public organization information
[**ReadPublicDocument**](PublicServicesApi.md#readpublicdocument) | **GET** /api/v1/public/documents/{id4n}/{organizationId}/{fileName} | Read document contents
[**ResolveImageUsingGET**](PublicServicesApi.md#resolveimageusingget) | **GET** /api/v1/public/image/{imageID} | Resolve image
[**ResolveWhoIsEntry**](PublicServicesApi.md#resolvewhoisentry) | **GET** /whois/{id4n} | Resolve owner of id4n


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

            var apiInstance = new PublicServicesApi();
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
                Debug.Print("Exception when calling PublicServicesApi.GetPublicDocument: " + e.Message );
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

<a name="getroutes"></a>
# **GetRoutes**
> List<Route> GetRoutes (string id4n, string type, bool? interpolate = null)

Retrieve all public routes for a GUID

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class GetRoutesExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PublicServicesApi();
            var id4n = id4n_example;  // string | id4n
            var type = type_example;  // string | type (default to web)
            var interpolate = true;  // bool? | interpolate (optional)  (default to true)

            try
            {
                // Retrieve all public routes for a GUID
                List&lt;Route&gt; result = apiInstance.GetRoutes(id4n, type, interpolate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicServicesApi.GetRoutes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 
 **type** | **string**| type | [default to web]
 **interpolate** | **bool?**| interpolate | [optional] [default to true]

### Return type

[**List<Route>**](Route.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="go"></a>
# **Go**
> void Go (string guid)

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

            try
            {
                // Forward
                apiInstance.Go(guid);
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

### Return type

void (empty response body)

### Authorization

No authorization required

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

            var apiInstance = new PublicServicesApi();
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

            var apiInstance = new PublicServicesApi();
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
                Debug.Print("Exception when calling PublicServicesApi.ListPublicDocuments: " + e.Message );
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

<a name="listpublichistory"></a>
# **ListPublicHistory**
> PaginatedHistoryItemResponse ListPublicHistory (string id4n, int? offset = null, int? limit = null)

Shows the public history of the given GUID

Only contains public history items

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class ListPublicHistoryExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PublicServicesApi();
            var id4n = id4n_example;  // string | GUID to retrieve the history for
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // Shows the public history of the given GUID
                PaginatedHistoryItemResponse result = apiInstance.ListPublicHistory(id4n, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicServicesApi.ListPublicHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| GUID to retrieve the history for | 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedHistoryItemResponse**](PaginatedHistoryItemResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readorganizationinfo"></a>
# **ReadOrganizationInfo**
> Organization ReadOrganizationInfo (string organizationId)

Read public organization information

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class ReadOrganizationInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PublicServicesApi();
            var organizationId = organizationId_example;  // string | Organization ID

            try
            {
                // Read public organization information
                Organization result = apiInstance.ReadOrganizationInfo(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicServicesApi.ReadOrganizationInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| Organization ID | 

### Return type

[**Organization**](Organization.md)

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

            var apiInstance = new PublicServicesApi();
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
                Debug.Print("Exception when calling PublicServicesApi.ReadPublicDocument: " + e.Message );
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

<a name="resolveimageusingget"></a>
# **ResolveImageUsingGET**
> byte[] ResolveImageUsingGET (string imageID)

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
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PublicServicesApi();
            var imageID = imageID_example;  // string | The id of the image to be resolved.

            try
            {
                // Resolve image
                byte[] result = apiInstance.ResolveImageUsingGET(imageID);
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

### Return type

**byte[]**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resolvewhoisentry"></a>
# **ResolveWhoIsEntry**
> WhoIsResponse ResolveWhoIsEntry (string id4n)

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

            try
            {
                // Resolve owner of id4n
                WhoIsResponse result = apiInstance.ResolveWhoIsEntry(id4n);
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

### Return type

[**WhoIsResponse**](WhoIsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

