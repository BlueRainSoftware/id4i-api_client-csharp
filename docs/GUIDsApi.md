# .GUIDsApi

All URIs are relative to *https://backend.id4i.de*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddGuidAlias**](GUIDsApi.md#addguidalias) | **POST** /api/v1/guids/{id4n}/alias/{aliasType} | Add alias for GUIDs
[**AddGuidAlias1**](GUIDsApi.md#addguidalias1) | **DELETE** /api/v1/guids/{id4n}/alias/{aliasType} | Remove aliases from GUIDs
[**CreateGuid**](GUIDsApi.md#createguid) | **POST** /api/v1/guids | Create GUID(s)
[**GetGuid**](GUIDsApi.md#getguid) | **GET** /api/v1/guids/{id4n} | Retrieve GUID information
[**GetGuidAliases**](GUIDsApi.md#getguidaliases) | **GET** /api/v1/guids/{id4n}/alias | Get all aliases for the given GUID
[**GetGuidsWithoutCollection**](GUIDsApi.md#getguidswithoutcollection) | **GET** /api/v1/guids/withoutCollection | Retrieve GUIDs not in any collection
[**UpdateGuid**](GUIDsApi.md#updateguid) | **PUT** /api/v1/guids/{id4n} | Change GUID information.


<a name="addguidalias"></a>
# **AddGuidAlias**
> ApiError AddGuidAlias (string id4n, string aliasType, GuidAlias alias, string authorization, string acceptLanguage)

Add alias for GUIDs

Adds or replaces aliases for single GUIDs (alias type item and mapp) or groups of GUIDs (alias types gtin, ean and article)

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class AddGuidAliasExample
    {
        public void main()
        {
            
            var apiInstance = new GUIDsApi();
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
                Debug.Print("Exception when calling GUIDsApi.AddGuidAlias: " + e.Message );
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
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class AddGuidAlias1Example
    {
        public void main()
        {
            
            var apiInstance = new GUIDsApi();
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
                Debug.Print("Exception when calling GUIDsApi.AddGuidAlias1: " + e.Message );
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

<a name="createguid"></a>
# **CreateGuid**
> ListOfId4ns CreateGuid (CreateGuidRequest createGUIDInfo, string authorization, string acceptLanguage)

Create GUID(s)

Creating one or more GUIDs with a specified length.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class CreateGuidExample
    {
        public void main()
        {
            
            var apiInstance = new GUIDsApi();
            var createGUIDInfo = new CreateGuidRequest(); // CreateGuidRequest | createGUIDInfo
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Create GUID(s)
                ListOfId4ns result = apiInstance.CreateGuid(createGUIDInfo, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GUIDsApi.CreateGuid: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createGUIDInfo** | [**CreateGuidRequest**](CreateGuidRequest.md)| createGUIDInfo | 
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**ListOfId4ns**](ListOfId4ns.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getguid"></a>
# **GetGuid**
> Guid GetGuid (string id4n, string authorization, string acceptLanguage)

Retrieve GUID information

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class GetGuidExample
    {
        public void main()
        {
            
            var apiInstance = new GUIDsApi();
            var id4n = id4n_example;  // string | The GUID number
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Retrieve GUID information
                Guid result = apiInstance.GetGuid(id4n, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GUIDsApi.GetGuid: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| The GUID number | 
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**Guid**](Guid.md)

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
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class GetGuidAliasesExample
    {
        public void main()
        {
            
            var apiInstance = new GUIDsApi();
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
                Debug.Print("Exception when calling GUIDsApi.GetGuidAliases: " + e.Message );
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

<a name="getguidswithoutcollection"></a>
# **GetGuidsWithoutCollection**
> PaginatedResponseGuid GetGuidsWithoutCollection (long? organizationId, string authorization, string acceptLanguage, int? offset, int? limit)

Retrieve GUIDs not in any collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class GetGuidsWithoutCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new GUIDsApi();
            var organizationId = 789;  // long? | Organization to search GUIDs for (required).
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var offset = 56;  // int? | Start with the n-th element.  (optional) 
            var limit = 56;  // int? | The maximum count of returned elements. (optional) 

            try
            {
                // Retrieve GUIDs not in any collection
                PaginatedResponseGuid result = apiInstance.GetGuidsWithoutCollection(organizationId, authorization, acceptLanguage, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GUIDsApi.GetGuidsWithoutCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| Organization to search GUIDs for (required). | 
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **offset** | **int?**| Start with the n-th element.  | [optional] 
 **limit** | **int?**| The maximum count of returned elements. | [optional] 

### Return type

[**PaginatedResponseGuid**](PaginatedResponseGuid.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateguid"></a>
# **UpdateGuid**
> Object UpdateGuid (string id4n, Guid request, string authorization, string acceptLanguage)

Change GUID information.

Allows ownership transfer.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class UpdateGuidExample
    {
        public void main()
        {
            
            var apiInstance = new GUIDsApi();
            var id4n = id4n_example;  // string | The GUID number
            var request = new Guid(); // Guid | request
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Change GUID information.
                Object result = apiInstance.UpdateGuid(id4n, request, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GUIDsApi.UpdateGuid: " + e.Message );
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

