# DE.ID4i..AliasApi

All URIs are relative to *https://backend.id4i.de*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddGuidAlias**](AliasApi.md#addguidalias) | **POST** /api/v1/guids/{id4n}/alias/{aliasType} | Add alias for GUIDs
[**AddGuidAlias1**](AliasApi.md#addguidalias1) | **DELETE** /api/v1/guids/{id4n}/alias/{aliasType} | Remove aliases from GUIDs
[**GetGuidAliasTypes**](AliasApi.md#getguidaliastypes) | **GET** /api/v1/search/guids/aliases/types | List all supported alias types
[**GetGuidAliases**](AliasApi.md#getguidaliases) | **GET** /api/v1/guids/{id4n}/alias | Get all aliases for the given GUID
[**SearchByAlias**](AliasApi.md#searchbyalias) | **GET** /api/v1/search/guids | Search for GUIDs by alias


<a name="addguidalias"></a>
# **AddGuidAlias**
> ApiError AddGuidAlias (string id4n, string aliasType, GuidAlias alias, string authorization, string acceptLanguage)

Add alias for GUIDs

Adds or replaces aliases for single GUIDs (alias type item and mapp) or groups of GUIDs (alias types gtin, ean and article)

### Example
```csharp
using System;
using System.Diagnostics;
using DE.ID4i.Api;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class AddGuidAliasExample
    {
        public void main()
        {
            
            var apiInstance = new AliasApi();
            var id4n = id4n_example;  // string | The GUID to operate on
            var aliasType = aliasType_example;  // string | Alias type, see the corresponding API model
            var alias = new GuidAlias(); // GuidAlias | The alias to add or update
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Add alias for GUIDs
                ApiError result = apiInstance.AddGuidAlias(id4n, aliasType, alias, authorization, acceptLanguage);
                Debug.WriteLine(result);
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
 **id4n** | **string**| The GUID to operate on | 
 **aliasType** | **string**| Alias type, see the corresponding API model | 
 **alias** | [**GuidAlias**](GuidAlias.md)| The alias to add or update | 
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**ApiError**](ApiError.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addguidalias1"></a>
# **AddGuidAlias1**
> ApiError AddGuidAlias1 (string id4n, string aliasType, string authorization, string acceptLanguage)

Remove aliases from GUIDs

Remove the alias of the given type

### Example
```csharp
using System;
using System.Diagnostics;
using DE.ID4i.Api;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class AddGuidAlias1Example
    {
        public void main()
        {
            
            var apiInstance = new AliasApi();
            var id4n = id4n_example;  // string | The GUID to operate on
            var aliasType = aliasType_example;  // string | Alias type, see the corresponding API model
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Remove aliases from GUIDs
                ApiError result = apiInstance.AddGuidAlias1(id4n, aliasType, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AliasApi.AddGuidAlias1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| The GUID to operate on | 
 **aliasType** | **string**| Alias type, see the corresponding API model | 
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**ApiError**](ApiError.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getguidaliastypes"></a>
# **GetGuidAliasTypes**
> List<string> GetGuidAliasTypes (string authorization, string acceptLanguage)

List all supported alias types

Retrieve this list to find out all alias types to use with alias search and change operations

### Example
```csharp
using System;
using System.Diagnostics;
using DE.ID4i.Api;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class GetGuidAliasTypesExample
    {
        public void main()
        {
            
            var apiInstance = new AliasApi();
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // List all supported alias types
                List&lt;string&gt; result = apiInstance.GetGuidAliasTypes(authorization, acceptLanguage);
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

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getguidaliases"></a>
# **GetGuidAliases**
> Dictionary<string, string> GetGuidAliases (string id4n, string authorization, string acceptLanguage)

Get all aliases for the given GUID

Looks up the alias for each alias type (group and single GUID) and returns all found ones

### Example
```csharp
using System;
using System.Diagnostics;
using DE.ID4i.Api;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class GetGuidAliasesExample
    {
        public void main()
        {
            
            var apiInstance = new AliasApi();
            var id4n = id4n_example;  // string | The GUID to operate on
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Get all aliases for the given GUID
                Dictionary&lt;string, string&gt; result = apiInstance.GetGuidAliases(id4n, authorization, acceptLanguage);
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
 **id4n** | **string**| The GUID to operate on | 
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

**Dictionary<string, string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchbyalias"></a>
# **SearchByAlias**
> PaginatedGuidResponse SearchByAlias (string alias, string aliasType, string authorization, string acceptLanguage, int? offset, int? limit)

Search for GUIDs by alias

### Example
```csharp
using System;
using System.Diagnostics;
using DE.ID4i.Api;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class SearchByAliasExample
    {
        public void main()
        {
            
            var apiInstance = new AliasApi();
            var alias = alias_example;  // string | The alias to search for
            var aliasType = aliasType_example;  // string | Alias type type to search for
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var offset = 56;  // int? | Start with the n-th element.  (optional) 
            var limit = 56;  // int? | The maximum count of returned elements. (optional) 

            try
            {
                // Search for GUIDs by alias
                PaginatedGuidResponse result = apiInstance.SearchByAlias(alias, aliasType, authorization, acceptLanguage, offset, limit);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **offset** | **int?**| Start with the n-th element.  | [optional] 
 **limit** | **int?**| The maximum count of returned elements. | [optional] 

### Return type

[**PaginatedGuidResponse**](PaginatedGuidResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

