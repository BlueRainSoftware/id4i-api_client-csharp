# BlueRain.ID4i.Api.GuidsApi

All URIs are relative to *https://backend.id4i.de*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddGuidAlias**](GuidsApi.md#addguidalias) | **POST** /api/v1/id4ns/{id4n}/alias/{aliasType} | Add alias for GUID or Collection
[**CreateGuid**](GuidsApi.md#createguid) | **POST** /api/v1/guids | Create GUID(s)
[**GetCollections**](GuidsApi.md#getcollections) | **GET** /api/v1/id4ns/{id4n}/collections | Retrieve collections of an ID
[**GetGuid**](GuidsApi.md#getguid) | **GET** /api/v1/guids/{id4n} | Retrieve GUID information
[**GetGuidAliases**](GuidsApi.md#getguidaliases) | **GET** /api/v1/id4ns/{id4n}/alias | Get all aliases for the given GUID or Collection.
[**GetGuidsWithoutCollection**](GuidsApi.md#getguidswithoutcollection) | **GET** /api/v1/guids/withoutCollection | Retrieve GUIDs not in any collection
[**GetId4n**](GuidsApi.md#getid4n) | **GET** /api/v1/id4ns/{id4n} | Retrieve ID4n information
[**RemoveGuidAlias**](GuidsApi.md#removeguidalias) | **DELETE** /api/v1/id4ns/{id4n}/alias/{aliasType} | Remove aliases from GUID or Collection
[**UpdateGuid**](GuidsApi.md#updateguid) | **PATCH** /api/v1/guids/{id4n} | Change GUID information.


<a name="addguidalias"></a>
# **AddGuidAlias**
> void AddGuidAlias (string id4n, string aliasType, GuidAlias alias)

Add alias for GUID or Collection

Adds or replaces aliases for single ID4ns (alias type item and mapp) or groups of ID4ns (alias types gtin, ean and article)

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class AddGuidAliasExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GuidsApi();
            var id4n = id4n_example;  // string | The GUID or Collection to operate on
            var aliasType = aliasType_example;  // string | Alias type, see the corresponding API model
            var alias = new GuidAlias(); // GuidAlias | The alias to add or update

            try
            {
                // Add alias for GUID or Collection
                apiInstance.AddGuidAlias(id4n, aliasType, alias);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GuidsApi.AddGuidAlias: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| The GUID or Collection to operate on | 
 **aliasType** | **string**| Alias type, see the corresponding API model | 
 **alias** | [**GuidAlias**](GuidAlias.md)| The alias to add or update | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createguid"></a>
# **CreateGuid**
> ListOfId4ns CreateGuid (CreateGuidRequest createGUIDInfo)

Create GUID(s)

Creating one or more GUIDs with a specified length.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class CreateGuidExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GuidsApi();
            var createGUIDInfo = new CreateGuidRequest(); // CreateGuidRequest | GUID creation model

            try
            {
                // Create GUID(s)
                ListOfId4ns result = apiInstance.CreateGuid(createGUIDInfo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GuidsApi.CreateGuid: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createGUIDInfo** | [**CreateGuidRequest**](CreateGuidRequest.md)| GUID creation model | 

### Return type

[**ListOfId4ns**](ListOfId4ns.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcollections"></a>
# **GetCollections**
> PaginatedResponseOfGuidCollection GetCollections (string id4n, string organizationId = null, int? offset = null, int? limit = null)

Retrieve collections of an ID

Retrieving all owned or holding collections the specified id4n is assigned to.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class GetCollectionsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GuidsApi();
            var id4n = id4n_example;  // string | The ID which the collections should contain
            var organizationId = organizationId_example;  // string | The organization holding the collections. (optional) 
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // Retrieve collections of an ID
                PaginatedResponseOfGuidCollection result = apiInstance.GetCollections(id4n, organizationId, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GuidsApi.GetCollections: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| The ID which the collections should contain | 
 **organizationId** | **string**| The organization holding the collections. | [optional] 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedResponseOfGuidCollection**](PaginatedResponseOfGuidCollection.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getguid"></a>
# **GetGuid**
> Guid GetGuid (string id4n)

Retrieve GUID information

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class GetGuidExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GuidsApi();
            var id4n = id4n_example;  // string | The GUID number

            try
            {
                // Retrieve GUID information
                Guid result = apiInstance.GetGuid(id4n);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GuidsApi.GetGuid: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| The GUID number | 

### Return type

[**Guid**](Guid.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getguidaliases"></a>
# **GetGuidAliases**
> Dictionary<string, string> GetGuidAliases (string id4n)

Get all aliases for the given GUID or Collection.

Looks up the alias for each alias type (group and single) and returns a map of all aliases found.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class GetGuidAliasesExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GuidsApi();
            var id4n = id4n_example;  // string | The GUID or Collection to operate on

            try
            {
                // Get all aliases for the given GUID or Collection.
                Dictionary&lt;string, string&gt; result = apiInstance.GetGuidAliases(id4n);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GuidsApi.GetGuidAliases: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| The GUID or Collection to operate on | 

### Return type

**Dictionary<string, string>**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getguidswithoutcollection"></a>
# **GetGuidsWithoutCollection**
> PaginatedResponseOfGuid GetGuidsWithoutCollection (string organizationId, int? offset = null, int? limit = null)

Retrieve GUIDs not in any collection

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class GetGuidsWithoutCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GuidsApi();
            var organizationId = organizationId_example;  // string | The namespace of the organization to search GUIDs for
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // Retrieve GUIDs not in any collection
                PaginatedResponseOfGuid result = apiInstance.GetGuidsWithoutCollection(organizationId, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GuidsApi.GetGuidsWithoutCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| The namespace of the organization to search GUIDs for | 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedResponseOfGuid**](PaginatedResponseOfGuid.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getid4n"></a>
# **GetId4n**
> Id4nPresentation GetId4n (string id4n)

Retrieve ID4n information

Retrieving basic information about an ID like the type and the creation time.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class GetId4nExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GuidsApi();
            var id4n = id4n_example;  // string | The ID to resolve to

            try
            {
                // Retrieve ID4n information
                Id4nPresentation result = apiInstance.GetId4n(id4n);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GuidsApi.GetId4n: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| The ID to resolve to | 

### Return type

[**Id4nPresentation**](Id4nPresentation.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeguidalias"></a>
# **RemoveGuidAlias**
> void RemoveGuidAlias (string id4n, string aliasType)

Remove aliases from GUID or Collection

Remove the alias of the given type

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class RemoveGuidAliasExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GuidsApi();
            var id4n = id4n_example;  // string | The GUID or Collection to operate on
            var aliasType = aliasType_example;  // string | Alias type, see the corresponding API model

            try
            {
                // Remove aliases from GUID or Collection
                apiInstance.RemoveGuidAlias(id4n, aliasType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GuidsApi.RemoveGuidAlias: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| The GUID or Collection to operate on | 
 **aliasType** | **string**| Alias type, see the corresponding API model | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateguid"></a>
# **UpdateGuid**
> Object UpdateGuid (string id4n, Guid request)

Change GUID information.

Allows ownership transfer.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class UpdateGuidExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GuidsApi();
            var id4n = id4n_example;  // string | The GUID number
            var request = new Guid(); // Guid | request

            try
            {
                // Change GUID information.
                Object result = apiInstance.UpdateGuid(id4n, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GuidsApi.UpdateGuid: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| The GUID number | 
 **request** | [**Guid**](Guid.md)| request | 

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

