# BlueRain.ID4i.Api.CollectionsApi

All URIs are relative to *https://backend.id4i.de*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddElementsToCollection**](CollectionsApi.md#addelementstocollection) | **POST** /api/v1/collections/{id4n}/elements | Add elements to collection
[**CreateCollection**](CollectionsApi.md#createcollection) | **POST** /api/v1/collections | Create collection
[**DeleteCollection**](CollectionsApi.md#deletecollection) | **DELETE** /api/v1/collections/{id4n} | Delete collection
[**DeleteProperties**](CollectionsApi.md#deleteproperties) | **DELETE** /api/v1/id4ns/{id4n}/properties | Delete ID4n properties
[**FindCollection**](CollectionsApi.md#findcollection) | **GET** /api/v1/collections/{id4n} | Find collection
[**GetAllCollectionsOfOrganization**](CollectionsApi.md#getallcollectionsoforganization) | **GET** /api/v1/organizations/{organizationId}/collections | Get collections of organization
[**GetProperties**](CollectionsApi.md#getproperties) | **GET** /api/v1/id4ns/{id4n}/properties | Retrieve ID4n properties
[**ListElementsOfCollection**](CollectionsApi.md#listelementsofcollection) | **GET** /api/v1/collections/{id4n}/elements | List contents of the collection
[**PatchProperties**](CollectionsApi.md#patchproperties) | **PATCH** /api/v1/id4ns/{id4n}/properties | Patch ID4n properties
[**RemoveElementsFromCollection**](CollectionsApi.md#removeelementsfromcollection) | **DELETE** /api/v1/collections/{id4n}/elements | Remove elements from collection
[**UpdateCollection**](CollectionsApi.md#updatecollection) | **PATCH** /api/v1/collections/{id4n} | Update collection


<a name="addelementstocollection"></a>
# **AddElementsToCollection**
> void AddElementsToCollection (string id4n, ListOfId4ns listOfGuids)

Add elements to collection

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class AddElementsToCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var listOfGuids = new ListOfId4ns(); // ListOfId4ns | listOfGuids

            try
            {
                // Add elements to collection
                apiInstance.AddElementsToCollection(id4n, listOfGuids);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.AddElementsToCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 
 **listOfGuids** | [**ListOfId4ns**](ListOfId4ns.md)| listOfGuids | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcollection"></a>
# **CreateCollection**
> Id4n CreateCollection (CreateCollectionRequest createInfo)

Create collection

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class CreateCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var createInfo = new CreateCollectionRequest(); // CreateCollectionRequest | createInfo

            try
            {
                // Create collection
                Id4n result = apiInstance.CreateCollection(createInfo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.CreateCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createInfo** | [**CreateCollectionRequest**](CreateCollectionRequest.md)| createInfo | 

### Return type

[**Id4n**](Id4n.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecollection"></a>
# **DeleteCollection**
> void DeleteCollection (string id4n)

Delete collection

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class DeleteCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n

            try
            {
                // Delete collection
                apiInstance.DeleteCollection(id4n);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.DeleteCollection: " + e.Message );
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

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteproperties"></a>
# **DeleteProperties**
> void DeleteProperties (string id4n, string organizationId, List<string> properties)

Delete ID4n properties

Partial deletion of id4n properties. If the property does not exist, it will be ignored.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class DeletePropertiesExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | The id4n
            var organizationId = organizationId_example;  // string | The organization namespace to work on while deleting the properties.
            var properties = ;  // List<string> | A set of property keys to delete.

            try
            {
                // Delete ID4n properties
                apiInstance.DeleteProperties(id4n, organizationId, properties);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.DeleteProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| The id4n | 
 **organizationId** | **string**| The organization namespace to work on while deleting the properties. | 
 **properties** | **List&lt;string&gt;**| A set of property keys to delete. | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findcollection"></a>
# **FindCollection**
> GuidCollection FindCollection (string id4n)

Find collection

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class FindCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n

            try
            {
                // Find collection
                GuidCollection result = apiInstance.FindCollection(id4n);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.FindCollection: " + e.Message );
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

[**GuidCollection**](GuidCollection.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallcollectionsoforganization"></a>
# **GetAllCollectionsOfOrganization**
> PaginatedResponseOfGuidCollection GetAllCollectionsOfOrganization (string organizationId, int? offset = null, int? limit = null, string type = null, string label = null, string labelPrefix = null, List<string> property = null)

Get collections of organization

Retrieving all collections of an organization in a paginated manner. You may filter the results by specifying id4n properties with filter operations (eq, in, ne) in the query parameters. e.g. `com.yourcompany.orderId.eq=1234`  

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class GetAllCollectionsOfOrganizationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var organizationId = organizationId_example;  // string | The namespace of the organization
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 
            var type = type_example;  // string | Filter by this type (optional) 
            var label = label_example;  // string | Filter by this label (optional) 
            var labelPrefix = labelPrefix_example;  // string | Filter by this label prefix (optional) 
            var property = new List<string>(); // List<string> | List of i4dn property filter. e.g. \"com.myorga.state:IN:waiting|processing\" or \"com.myorga.orderId:EQ:SAP001\" (optional) 

            try
            {
                // Get collections of organization
                PaginatedResponseOfGuidCollection result = apiInstance.GetAllCollectionsOfOrganization(organizationId, offset, limit, type, label, labelPrefix, property);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.GetAllCollectionsOfOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| The namespace of the organization | 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 
 **type** | **string**| Filter by this type | [optional] 
 **label** | **string**| Filter by this label | [optional] 
 **labelPrefix** | **string**| Filter by this label prefix | [optional] 
 **property** | [**List&lt;string&gt;**](string.md)| List of i4dn property filter. e.g. \&quot;com.myorga.state:IN:waiting|processing\&quot; or \&quot;com.myorga.orderId:EQ:SAP001\&quot; | [optional] 

### Return type

[**PaginatedResponseOfGuidCollection**](PaginatedResponseOfGuidCollection.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproperties"></a>
# **GetProperties**
> Dictionary<string, string> GetProperties (string id4n, string organizationId = null)

Retrieve ID4n properties

List all properties of an id4n.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class GetPropertiesExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | The id4n
            var organizationId = organizationId_example;  // string | The organization namespace. (optional) 

            try
            {
                // Retrieve ID4n properties
                Dictionary&lt;string, string&gt; result = apiInstance.GetProperties(id4n, organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.GetProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| The id4n | 
 **organizationId** | **string**| The organization namespace. | [optional] 

### Return type

**Dictionary<string, string>**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listelementsofcollection"></a>
# **ListElementsOfCollection**
> PaginatedResponseOfGuid ListElementsOfCollection (string id4n, int? offset = null, int? limit = null)

List contents of the collection

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class ListElementsOfCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // List contents of the collection
                PaginatedResponseOfGuid result = apiInstance.ListElementsOfCollection(id4n, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.ListElementsOfCollection: " + e.Message );
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

[**PaginatedResponseOfGuid**](PaginatedResponseOfGuid.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchproperties"></a>
# **PatchProperties**
> void PatchProperties (string id4n, string organizationId, Object properties)

Patch ID4n properties

Partial updating of id4n properties. If a property contains a null value the property will be deleted other values will be saved and overwritten if they already exist.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class PatchPropertiesExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | The id4n
            var organizationId = organizationId_example;  // string | The organization namespace to work on while patching the properties.
            var properties = ;  // Object | The properties to update.

            try
            {
                // Patch ID4n properties
                apiInstance.PatchProperties(id4n, organizationId, properties);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.PatchProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| The id4n | 
 **organizationId** | **string**| The organization namespace to work on while patching the properties. | 
 **properties** | **Object**| The properties to update. | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeelementsfromcollection"></a>
# **RemoveElementsFromCollection**
> void RemoveElementsFromCollection (string id4n, ListOfId4ns listOfGuids)

Remove elements from collection

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class RemoveElementsFromCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var listOfGuids = new ListOfId4ns(); // ListOfId4ns | listOfGuids

            try
            {
                // Remove elements from collection
                apiInstance.RemoveElementsFromCollection(id4n, listOfGuids);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.RemoveElementsFromCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 
 **listOfGuids** | [**ListOfId4ns**](ListOfId4ns.md)| listOfGuids | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecollection"></a>
# **UpdateCollection**
> Object UpdateCollection (string id4n, GuidCollection request)

Update collection

Update collection changing only the given values

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class UpdateCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var request = new GuidCollection(); // GuidCollection | request

            try
            {
                // Update collection
                Object result = apiInstance.UpdateCollection(id4n, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.UpdateCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 
 **request** | [**GuidCollection**](GuidCollection.md)| request | 

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

