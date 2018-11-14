# BlueRain.ID4i.Api.AliasApi

All URIs are relative to *https://backend.id4i.de*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddGuidAlias**](AliasApi.md#addguidalias) | **POST** /api/v1/id4ns/{id4n}/alias/{aliasType} | Add alias for GUID or Collection
[**GetGuidAliasTypes**](AliasApi.md#getguidaliastypes) | **GET** /api/v1/search/guids/aliases/types | List all supported alias types
[**GetGuidAliases**](AliasApi.md#getguidaliases) | **GET** /api/v1/id4ns/{id4n}/alias | Get all aliases for the given GUID or Collection.
[**RemoveGuidAlias**](AliasApi.md#removeguidalias) | **DELETE** /api/v1/id4ns/{id4n}/alias/{aliasType} | Remove aliases from GUID or Collection
[**SearchByAlias**](AliasApi.md#searchbyalias) | **GET** /api/v1/search/guids | Search for GUIDs by alias


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

            var apiInstance = new AliasApi();
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
                Debug.Print("Exception when calling AliasApi.AddGuidAlias: " + e.Message );
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

<a name="getguidaliastypes"></a>
# **GetGuidAliasTypes**
> List<string> GetGuidAliasTypes ()

List all supported alias types

Retrieve this list to find out all alias types to use with alias search and change operations

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class GetGuidAliasTypesExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AliasApi();

            try
            {
                // List all supported alias types
                List&lt;string&gt; result = apiInstance.GetGuidAliasTypes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AliasApi.GetGuidAliasTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**List<string>**

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

            var apiInstance = new AliasApi();
            var id4n = id4n_example;  // string | The GUID or Collection to operate on

            try
            {
                // Get all aliases for the given GUID or Collection.
                Dictionary&lt;string, string&gt; result = apiInstance.GetGuidAliases(id4n);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AliasApi.GetGuidAliases: " + e.Message );
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

            var apiInstance = new AliasApi();
            var id4n = id4n_example;  // string | The GUID or Collection to operate on
            var aliasType = aliasType_example;  // string | Alias type, see the corresponding API model

            try
            {
                // Remove aliases from GUID or Collection
                apiInstance.RemoveGuidAlias(id4n, aliasType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AliasApi.RemoveGuidAlias: " + e.Message );
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

<a name="searchbyalias"></a>
# **SearchByAlias**
> PaginatedGuidResponse SearchByAlias (string alias, string aliasType, int? offset = null, int? limit = null)

Search for GUIDs by alias

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class SearchByAliasExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AliasApi();
            var alias = alias_example;  // string | The alias to search for
            var aliasType = aliasType_example;  // string | Alias type type to search for
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // Search for GUIDs by alias
                PaginatedGuidResponse result = apiInstance.SearchByAlias(alias, aliasType, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AliasApi.SearchByAlias: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **alias** | **string**| The alias to search for | 
 **aliasType** | **string**| Alias type type to search for | 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedGuidResponse**](PaginatedGuidResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

