# .ApiKeysApi

All URIs are relative to *https://backend.id4i.de*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddApiKeyPrivilege**](ApiKeysApi.md#addapikeyprivilege) | **POST** /api/v1/apikeys/{key}/privileges | Add privilege
[**AddApiKeyPrivilegeForId4ns**](ApiKeysApi.md#addapikeyprivilegeforid4ns) | **POST** /api/v1/apikeys/{key}/privileges/{privilege}/id4ns | Add ID4ns of a privilege
[**CreateNewApiKey**](ApiKeysApi.md#createnewapikey) | **POST** /api/v1/apikeys | Create API key
[**DeleteApiKey**](ApiKeysApi.md#deleteapikey) | **DELETE** /api/v1/apikeys/{key} | Delete API key
[**GetApiKey**](ApiKeysApi.md#getapikey) | **GET** /api/v1/apikeys/{key} | Show API key
[**ListAllApiKeyPrivileges**](ApiKeysApi.md#listallapikeyprivileges) | **GET** /api/v1/apikeys/privileges | List all privileges
[**ListAllApiKeysOfOrganization**](ApiKeysApi.md#listallapikeysoforganization) | **GET** /api/v1/apikeys | Find API key by organization
[**ListApiKeyPrivileges**](ApiKeysApi.md#listapikeyprivileges) | **GET** /api/v1/apikeys/{key}/privileges | List privileges
[**ListId4ns**](ApiKeysApi.md#listid4ns) | **GET** /api/v1/apikeys/{key}/privileges/{privilege}/id4ns | ID4ns of a privilege
[**RemoveApiKeyPrivilege**](ApiKeysApi.md#removeapikeyprivilege) | **DELETE** /api/v1/apikeys/{key}/privileges | Remove privilege
[**RemoveApiKeyPrivilegeForId4ns**](ApiKeysApi.md#removeapikeyprivilegeforid4ns) | **DELETE** /api/v1/apikeys/{key}/privileges/{privilege}/id4ns | Remove id4ns of a privilege
[**UpdateApiKey**](ApiKeysApi.md#updateapikey) | **PUT** /api/v1/apikeys/{key} | Update API keys


<a name="addapikeyprivilege"></a>
# **AddApiKeyPrivilege**
> ApiError AddApiKeyPrivilege (string key, AddApiKeyPrivilegeRequest addApiKeyPrivilegeRequest, string authorization, string acceptLanguage)

Add privilege

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class AddApiKeyPrivilegeExample
    {
        public void main()
        {
            
            var apiInstance = new ApiKeysApi();
            var key = key_example;  // string | key
            var addApiKeyPrivilegeRequest = new AddApiKeyPrivilegeRequest(); // AddApiKeyPrivilegeRequest | addApiKeyPrivilegeRequest
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Add privilege
                ApiError result = apiInstance.AddApiKeyPrivilege(key, addApiKeyPrivilegeRequest, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiKeysApi.AddApiKeyPrivilege: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| key | 
 **addApiKeyPrivilegeRequest** | [**AddApiKeyPrivilegeRequest**](AddApiKeyPrivilegeRequest.md)| addApiKeyPrivilegeRequest | 
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

<a name="addapikeyprivilegeforid4ns"></a>
# **AddApiKeyPrivilegeForId4ns**
> ApiError AddApiKeyPrivilegeForId4ns (string key, string privilege, ListOfId4ns id4ns, string authorization, string acceptLanguage)

Add ID4ns of a privilege

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class AddApiKeyPrivilegeForId4nsExample
    {
        public void main()
        {
            
            var apiInstance = new ApiKeysApi();
            var key = key_example;  // string | key
            var privilege = privilege_example;  // string | privilege
            var id4ns = new ListOfId4ns(); // ListOfId4ns | id4ns
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Add ID4ns of a privilege
                ApiError result = apiInstance.AddApiKeyPrivilegeForId4ns(key, privilege, id4ns, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiKeysApi.AddApiKeyPrivilegeForId4ns: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| key | 
 **privilege** | **string**| privilege | 
 **id4ns** | [**ListOfId4ns**](ListOfId4ns.md)| id4ns | 
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

<a name="createnewapikey"></a>
# **CreateNewApiKey**
> ApiKeyPresentation CreateNewApiKey (ApiKeyCreationRequest creationRequest, string authorization, string acceptLanguage)

Create API key

Creation of a new API key.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class CreateNewApiKeyExample
    {
        public void main()
        {
            
            var apiInstance = new ApiKeysApi();
            var creationRequest = new ApiKeyCreationRequest(); // ApiKeyCreationRequest | API key to be created.
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Create API key
                ApiKeyPresentation result = apiInstance.CreateNewApiKey(creationRequest, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiKeysApi.CreateNewApiKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **creationRequest** | [**ApiKeyCreationRequest**](ApiKeyCreationRequest.md)| API key to be created. | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**ApiKeyPresentation**](ApiKeyPresentation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteapikey"></a>
# **DeleteApiKey**
> ApiError DeleteApiKey (string key, string authorization, string acceptLanguage)

Delete API key

Deletion of an API key.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class DeleteApiKeyExample
    {
        public void main()
        {
            
            var apiInstance = new ApiKeysApi();
            var key = key_example;  // string | The API key to delete.
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Delete API key
                ApiError result = apiInstance.DeleteApiKey(key, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiKeysApi.DeleteApiKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The API key to delete. | 
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

<a name="getapikey"></a>
# **GetApiKey**
> ApiKeyPresentation GetApiKey (string key, string authorization, string acceptLanguage)

Show API key

Showing the details of an API key.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class GetApiKeyExample
    {
        public void main()
        {
            
            var apiInstance = new ApiKeysApi();
            var key = key_example;  // string | The API key to show.
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Show API key
                ApiKeyPresentation result = apiInstance.GetApiKey(key, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiKeysApi.GetApiKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The API key to show. | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**ApiKeyPresentation**](ApiKeyPresentation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listallapikeyprivileges"></a>
# **ListAllApiKeyPrivileges**
> ApiKeyPrivilegeInfoResponse ListAllApiKeyPrivileges (string authorization, string acceptLanguage, bool? id4nConcerning, int? offset, int? limit)

List all privileges

Listing all possible API key privileges.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class ListAllApiKeyPrivilegesExample
    {
        public void main()
        {
            
            var apiInstance = new ApiKeysApi();
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var id4nConcerning = true;  // bool? | id4nConcerning (optional) 
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // List all privileges
                ApiKeyPrivilegeInfoResponse result = apiInstance.ListAllApiKeyPrivileges(authorization, acceptLanguage, id4nConcerning, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiKeysApi.ListAllApiKeyPrivileges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **id4nConcerning** | **bool?**| id4nConcerning | [optional] 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**ApiKeyPrivilegeInfoResponse**](ApiKeyPrivilegeInfoResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listallapikeysoforganization"></a>
# **ListAllApiKeysOfOrganization**
> PaginatedApiKeyResponse ListAllApiKeysOfOrganization (long? organizationId, string authorization, string acceptLanguage, int? offset, int? limit)

Find API key by organization

Finding all API key assigned to the specified organization in a paginated manner.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class ListAllApiKeysOfOrganizationExample
    {
        public void main()
        {
            
            var apiInstance = new ApiKeysApi();
            var organizationId = 789;  // long? | The id of the organization to search in.
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // Find API key by organization
                PaginatedApiKeyResponse result = apiInstance.ListAllApiKeysOfOrganization(organizationId, authorization, acceptLanguage, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiKeysApi.ListAllApiKeysOfOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| The id of the organization to search in. | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedApiKeyResponse**](PaginatedApiKeyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listapikeyprivileges"></a>
# **ListApiKeyPrivileges**
> ApiKeyPrivilegePaginatedResponse ListApiKeyPrivileges (string key, string authorization, string acceptLanguage, int? offset, int? limit)

List privileges

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class ListApiKeyPrivilegesExample
    {
        public void main()
        {
            
            var apiInstance = new ApiKeysApi();
            var key = key_example;  // string | key
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // List privileges
                ApiKeyPrivilegePaginatedResponse result = apiInstance.ListApiKeyPrivileges(key, authorization, acceptLanguage, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiKeysApi.ListApiKeyPrivileges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| key | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**ApiKeyPrivilegePaginatedResponse**](ApiKeyPrivilegePaginatedResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listid4ns"></a>
# **ListId4ns**
> Id4nPresentationPaginatedResponse ListId4ns (string key, string privilege, string authorization, string acceptLanguage, int? offset, int? limit)

ID4ns of a privilege

Listing ID4ns of a id4n concerning privilege

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class ListId4nsExample
    {
        public void main()
        {
            
            var apiInstance = new ApiKeysApi();
            var key = key_example;  // string | key
            var privilege = privilege_example;  // string | privilege
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // ID4ns of a privilege
                Id4nPresentationPaginatedResponse result = apiInstance.ListId4ns(key, privilege, authorization, acceptLanguage, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiKeysApi.ListId4ns: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| key | 
 **privilege** | **string**| privilege | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**Id4nPresentationPaginatedResponse**](Id4nPresentationPaginatedResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeapikeyprivilege"></a>
# **RemoveApiKeyPrivilege**
> ApiError RemoveApiKeyPrivilege (string key, RemoveApiKeyPrivilegeRequest removeApiKeyPrivilegeRequest, string authorization, string acceptLanguage)

Remove privilege

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class RemoveApiKeyPrivilegeExample
    {
        public void main()
        {
            
            var apiInstance = new ApiKeysApi();
            var key = key_example;  // string | key
            var removeApiKeyPrivilegeRequest = new RemoveApiKeyPrivilegeRequest(); // RemoveApiKeyPrivilegeRequest | removeApiKeyPrivilegeRequest
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Remove privilege
                ApiError result = apiInstance.RemoveApiKeyPrivilege(key, removeApiKeyPrivilegeRequest, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiKeysApi.RemoveApiKeyPrivilege: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| key | 
 **removeApiKeyPrivilegeRequest** | [**RemoveApiKeyPrivilegeRequest**](RemoveApiKeyPrivilegeRequest.md)| removeApiKeyPrivilegeRequest | 
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

<a name="removeapikeyprivilegeforid4ns"></a>
# **RemoveApiKeyPrivilegeForId4ns**
> ApiError RemoveApiKeyPrivilegeForId4ns (string key, string privilege, ListOfId4ns id4ns, string authorization, string acceptLanguage)

Remove id4ns of a privilege

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class RemoveApiKeyPrivilegeForId4nsExample
    {
        public void main()
        {
            
            var apiInstance = new ApiKeysApi();
            var key = key_example;  // string | key
            var privilege = privilege_example;  // string | privilege
            var id4ns = new ListOfId4ns(); // ListOfId4ns | id4ns
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Remove id4ns of a privilege
                ApiError result = apiInstance.RemoveApiKeyPrivilegeForId4ns(key, privilege, id4ns, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiKeysApi.RemoveApiKeyPrivilegeForId4ns: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| key | 
 **privilege** | **string**| privilege | 
 **id4ns** | [**ListOfId4ns**](ListOfId4ns.md)| id4ns | 
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

<a name="updateapikey"></a>
# **UpdateApiKey**
> ApiError UpdateApiKey (string key, ApiKeyChangeRequest apiKeyChange, string authorization, string acceptLanguage)

Update API keys

API keys can be updated with new labels, and be activated and deactivated. The secret or UUID cannot be changed.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class UpdateApiKeyExample
    {
        public void main()
        {
            
            var apiInstance = new ApiKeysApi();
            var key = key_example;  // string | The API key to be updated.
            var apiKeyChange = new ApiKeyChangeRequest(); // ApiKeyChangeRequest | The new values to apply.
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Update API keys
                ApiError result = apiInstance.UpdateApiKey(key, apiKeyChange, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiKeysApi.UpdateApiKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The API key to be updated. | 
 **apiKeyChange** | [**ApiKeyChangeRequest**](ApiKeyChangeRequest.md)| The new values to apply. | 
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

