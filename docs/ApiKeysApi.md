# BlueRain.ID4i.Api.ApiKeysApi

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
> void AddApiKeyPrivilege (string key, AddApiKeyPrivilegeRequest addApiKeyPrivilegeRequest)

Add privilege

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class AddApiKeyPrivilegeExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApiKeysApi();
            var key = key_example;  // string | key
            var addApiKeyPrivilegeRequest = new AddApiKeyPrivilegeRequest(); // AddApiKeyPrivilegeRequest | addApiKeyPrivilegeRequest

            try
            {
                // Add privilege
                apiInstance.AddApiKeyPrivilege(key, addApiKeyPrivilegeRequest);
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

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addapikeyprivilegeforid4ns"></a>
# **AddApiKeyPrivilegeForId4ns**
> void AddApiKeyPrivilegeForId4ns (string key, string privilege, ListOfId4ns id4ns)

Add ID4ns of a privilege

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class AddApiKeyPrivilegeForId4nsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApiKeysApi();
            var key = key_example;  // string | key
            var privilege = privilege_example;  // string | privilege
            var id4ns = new ListOfId4ns(); // ListOfId4ns | id4ns

            try
            {
                // Add ID4ns of a privilege
                apiInstance.AddApiKeyPrivilegeForId4ns(key, privilege, id4ns);
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

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createnewapikey"></a>
# **CreateNewApiKey**
> ApiKeyPresentation CreateNewApiKey (ApiKeyCreationRequest creationRequest)

Create API key

Creation of a new API key.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class CreateNewApiKeyExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApiKeysApi();
            var creationRequest = new ApiKeyCreationRequest(); // ApiKeyCreationRequest | API key to be created.

            try
            {
                // Create API key
                ApiKeyPresentation result = apiInstance.CreateNewApiKey(creationRequest);
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

### Return type

[**ApiKeyPresentation**](ApiKeyPresentation.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteapikey"></a>
# **DeleteApiKey**
> void DeleteApiKey (string key)

Delete API key

Deletion of an API key.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class DeleteApiKeyExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApiKeysApi();
            var key = key_example;  // string | The API key to delete.

            try
            {
                // Delete API key
                apiInstance.DeleteApiKey(key);
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

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapikey"></a>
# **GetApiKey**
> ApiKeyPresentation GetApiKey (string key)

Show API key

Showing the details of an API key.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class GetApiKeyExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApiKeysApi();
            var key = key_example;  // string | The API key to show.

            try
            {
                // Show API key
                ApiKeyPresentation result = apiInstance.GetApiKey(key);
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

### Return type

[**ApiKeyPresentation**](ApiKeyPresentation.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listallapikeyprivileges"></a>
# **ListAllApiKeyPrivileges**
> PaginatedResponseOfApiKeyPrivilegeInfo ListAllApiKeyPrivileges (bool? id4nConcerning = null, int? offset = null, int? limit = null)

List all privileges

Listing all possible API key privileges.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class ListAllApiKeyPrivilegesExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApiKeysApi();
            var id4nConcerning = true;  // bool? | id4nConcerning (optional) 
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // List all privileges
                PaginatedResponseOfApiKeyPrivilegeInfo result = apiInstance.ListAllApiKeyPrivileges(id4nConcerning, offset, limit);
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
 **id4nConcerning** | **bool?**| id4nConcerning | [optional] 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedResponseOfApiKeyPrivilegeInfo**](PaginatedResponseOfApiKeyPrivilegeInfo.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listallapikeysoforganization"></a>
# **ListAllApiKeysOfOrganization**
> PaginatedResponseOfApiKeyPresentation ListAllApiKeysOfOrganization (string organizationId = null, int? offset = null, int? limit = null)

Find API key by organization

Finding all API key assigned to the specified organization in a paginated manner.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class ListAllApiKeysOfOrganizationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApiKeysApi();
            var organizationId = organizationId_example;  // string | The namespace of the organization to search in. (optional) 
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // Find API key by organization
                PaginatedResponseOfApiKeyPresentation result = apiInstance.ListAllApiKeysOfOrganization(organizationId, offset, limit);
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
 **organizationId** | **string**| The namespace of the organization to search in. | [optional] 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedResponseOfApiKeyPresentation**](PaginatedResponseOfApiKeyPresentation.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listapikeyprivileges"></a>
# **ListApiKeyPrivileges**
> PaginatedResponseOfApiKeyPrivilege ListApiKeyPrivileges (string key, int? offset = null, int? limit = null)

List privileges

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class ListApiKeyPrivilegesExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApiKeysApi();
            var key = key_example;  // string | key
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // List privileges
                PaginatedResponseOfApiKeyPrivilege result = apiInstance.ListApiKeyPrivileges(key, offset, limit);
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
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedResponseOfApiKeyPrivilege**](PaginatedResponseOfApiKeyPrivilege.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listid4ns"></a>
# **ListId4ns**
> PaginatedResponseOfId4nPresentation ListId4ns (string key, string privilege, int? offset = null, int? limit = null)

ID4ns of a privilege

Listing ID4ns of a id4n concerning privilege

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class ListId4nsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApiKeysApi();
            var key = key_example;  // string | key
            var privilege = privilege_example;  // string | privilege
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // ID4ns of a privilege
                PaginatedResponseOfId4nPresentation result = apiInstance.ListId4ns(key, privilege, offset, limit);
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
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedResponseOfId4nPresentation**](PaginatedResponseOfId4nPresentation.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeapikeyprivilege"></a>
# **RemoveApiKeyPrivilege**
> void RemoveApiKeyPrivilege (string key, RemoveApiKeyPrivilegeRequest removeApiKeyPrivilegeRequest)

Remove privilege

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class RemoveApiKeyPrivilegeExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApiKeysApi();
            var key = key_example;  // string | key
            var removeApiKeyPrivilegeRequest = new RemoveApiKeyPrivilegeRequest(); // RemoveApiKeyPrivilegeRequest | removeApiKeyPrivilegeRequest

            try
            {
                // Remove privilege
                apiInstance.RemoveApiKeyPrivilege(key, removeApiKeyPrivilegeRequest);
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

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeapikeyprivilegeforid4ns"></a>
# **RemoveApiKeyPrivilegeForId4ns**
> void RemoveApiKeyPrivilegeForId4ns (string key, string privilege, ListOfId4ns id4ns)

Remove id4ns of a privilege

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class RemoveApiKeyPrivilegeForId4nsExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApiKeysApi();
            var key = key_example;  // string | key
            var privilege = privilege_example;  // string | privilege
            var id4ns = new ListOfId4ns(); // ListOfId4ns | id4ns

            try
            {
                // Remove id4ns of a privilege
                apiInstance.RemoveApiKeyPrivilegeForId4ns(key, privilege, id4ns);
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

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateapikey"></a>
# **UpdateApiKey**
> void UpdateApiKey (string key, ApiKeyChangeRequest apiKeyChange)

Update API keys

API keys can be updated with new labels, and be activated and deactivated. The secret or UUID cannot be changed.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class UpdateApiKeyExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApiKeysApi();
            var key = key_example;  // string | The API key to be updated.
            var apiKeyChange = new ApiKeyChangeRequest(); // ApiKeyChangeRequest | The new values to apply.

            try
            {
                // Update API keys
                apiInstance.UpdateApiKey(key, apiKeyChange);
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

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

