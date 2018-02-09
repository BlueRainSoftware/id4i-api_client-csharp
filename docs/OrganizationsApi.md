# BlueRain.ID4i.Api.OrganizationsApi

All URIs are relative to *https://backend.id4i.de*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddUserRoles**](OrganizationsApi.md#adduserroles) | **POST** /api/v1/organizations/{organizationId}/users/{username}/roles | Add role(s) to user
[**CreateOrganization**](OrganizationsApi.md#createorganization) | **POST** /api/v1/organizations | Create organization
[**DeleteOrganization**](OrganizationsApi.md#deleteorganization) | **DELETE** /api/v1/organizations/{organizationId} | Delete organization
[**DeleteOrganizationBillingAddress**](OrganizationsApi.md#deleteorganizationbillingaddress) | **DELETE** /api/v1/organizations/{organizationId}/addresses/billing | Remove billing address
[**DeleteOrganizationLogo**](OrganizationsApi.md#deleteorganizationlogo) | **DELETE** /api/v1/organizations/{organizationId}/logo | Delete organization logo
[**FindOrganization**](OrganizationsApi.md#findorganization) | **GET** /api/v1/organizations/{organizationId} | Find organization by id
[**FindOrganizationAddress**](OrganizationsApi.md#findorganizationaddress) | **GET** /api/v1/organizations/{organizationId}/addresses/default | Retrieve address
[**FindOrganizationBillingAddress**](OrganizationsApi.md#findorganizationbillingaddress) | **GET** /api/v1/organizations/{organizationId}/addresses/billing | Retrieve billing address
[**GetAllCollectionsOfOrganization**](OrganizationsApi.md#getallcollectionsoforganization) | **GET** /api/v1/organizations/{organizationId}/collections | Get collections of organization
[**GetAllOrganizationRoles**](OrganizationsApi.md#getallorganizationroles) | **GET** /api/v1/organizations/{organizationId}/roles | List users and their roles
[**GetOrganizationsOfUser**](OrganizationsApi.md#getorganizationsofuser) | **GET** /api/v1/user/organizations | Retrieve organizations of user
[**GetUserRoles**](OrganizationsApi.md#getuserroles) | **GET** /api/v1/organizations/{organizationId}/users/{username}/roles | Get user roles by username
[**GetUsersOfOrganization**](OrganizationsApi.md#getusersoforganization) | **GET** /api/v1/organizations/{organizationId}/users | Find users in organization
[**InviteUsers**](OrganizationsApi.md#inviteusers) | **POST** /api/v1/organizations/{organizationId}/users/invite | Invite Users
[**ListCountries**](OrganizationsApi.md#listcountries) | **GET** /api/v1/countries | List countries
[**RemoveUserRoles**](OrganizationsApi.md#removeuserroles) | **DELETE** /api/v1/organizations/{organizationId}/users/{username}/roles | Remove role(s) from user
[**SetOrganizationLogo**](OrganizationsApi.md#setorganizationlogo) | **POST** /api/v1/organizations/{organizationId}/logo | Update organization logo
[**UpdateOrganization**](OrganizationsApi.md#updateorganization) | **PUT** /api/v1/organizations/{organizationId} | Update organization
[**UpdateOrganizationAddress**](OrganizationsApi.md#updateorganizationaddress) | **PUT** /api/v1/organizations/{organizationId}/addresses/default | Store address
[**UpdateOrganizationBillingAddress**](OrganizationsApi.md#updateorganizationbillingaddress) | **PUT** /api/v1/organizations/{organizationId}/addresses/billing | Store billing address


<a name="adduserroles"></a>
# **AddUserRoles**
> ApiError AddUserRoles (long? organizationId, string username, ChangeRoleRequest changeRoleRequest, string authorization, string acceptLanguage)

Add role(s) to user

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class AddUserRolesExample
    {
        public void main()
        {
            
            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | organizationId
            var username = username_example;  // string | username
            var changeRoleRequest = new ChangeRoleRequest(); // ChangeRoleRequest | changeRoleRequest
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Add role(s) to user
                ApiError result = apiInstance.AddUserRoles(organizationId, username, changeRoleRequest, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.AddUserRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **username** | **string**| username | 
 **changeRoleRequest** | [**ChangeRoleRequest**](ChangeRoleRequest.md)| changeRoleRequest | 
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

<a name="createorganization"></a>
# **CreateOrganization**
> Organization CreateOrganization (Organization organization, string authorization, string acceptLanguage)

Create organization

Creating a new organization.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class CreateOrganizationExample
    {
        public void main()
        {
            
            var apiInstance = new OrganizationsApi();
            var organization = new Organization(); // Organization | Organization to be created
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Create organization
                Organization result = apiInstance.CreateOrganization(organization, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.CreateOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organization** | [**Organization**](Organization.md)| Organization to be created | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**Organization**](Organization.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteorganization"></a>
# **DeleteOrganization**
> ApiError DeleteOrganization (long? organizationId, string authorization, string acceptLanguage)

Delete organization

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class DeleteOrganizationExample
    {
        public void main()
        {
            
            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | The id of the organization to be deleted.
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Delete organization
                ApiError result = apiInstance.DeleteOrganization(organizationId, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.DeleteOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| The id of the organization to be deleted. | 
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

<a name="deleteorganizationbillingaddress"></a>
# **DeleteOrganizationBillingAddress**
> ApiError DeleteOrganizationBillingAddress (long? organizationId, string authorization, string acceptLanguage)

Remove billing address

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class DeleteOrganizationBillingAddressExample
    {
        public void main()
        {
            
            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | organizationId
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Remove billing address
                ApiError result = apiInstance.DeleteOrganizationBillingAddress(organizationId, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.DeleteOrganizationBillingAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
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

<a name="deleteorganizationlogo"></a>
# **DeleteOrganizationLogo**
> ApiError DeleteOrganizationLogo (long? organizationId, string authorization, string acceptLanguage)

Delete organization logo

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class DeleteOrganizationLogoExample
    {
        public void main()
        {
            
            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | The id of the organization where the logo should be deleted.
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Delete organization logo
                ApiError result = apiInstance.DeleteOrganizationLogo(organizationId, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.DeleteOrganizationLogo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| The id of the organization where the logo should be deleted. | 
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

<a name="findorganization"></a>
# **FindOrganization**
> Organization FindOrganization (long? organizationId, string authorization, string acceptLanguage)

Find organization by id

Returns a single organization.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class FindOrganizationExample
    {
        public void main()
        {
            
            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | The id of the organization to be retrieved.
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Find organization by id
                Organization result = apiInstance.FindOrganization(organizationId, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.FindOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| The id of the organization to be retrieved. | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**Organization**](Organization.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findorganizationaddress"></a>
# **FindOrganizationAddress**
> OrganizationAddress FindOrganizationAddress (long? organizationId, string authorization, string acceptLanguage)

Retrieve address

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class FindOrganizationAddressExample
    {
        public void main()
        {
            
            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | organizationId
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Retrieve address
                OrganizationAddress result = apiInstance.FindOrganizationAddress(organizationId, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.FindOrganizationAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**OrganizationAddress**](OrganizationAddress.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findorganizationbillingaddress"></a>
# **FindOrganizationBillingAddress**
> OrganizationAddress FindOrganizationBillingAddress (long? organizationId, string authorization, string acceptLanguage)

Retrieve billing address

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class FindOrganizationBillingAddressExample
    {
        public void main()
        {
            
            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | organizationId
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Retrieve billing address
                OrganizationAddress result = apiInstance.FindOrganizationBillingAddress(organizationId, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.FindOrganizationBillingAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**OrganizationAddress**](OrganizationAddress.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallcollectionsoforganization"></a>
# **GetAllCollectionsOfOrganization**
> PaginatedGuidCollection GetAllCollectionsOfOrganization (long? organizationId, string authorization, string acceptLanguage, int? offset, int? limit, string type, string label, string labelPrefix)

Get collections of organization

Retrieving all collections of an organization in a paginated manner.

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
            
            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | organizationId
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 
            var type = type_example;  // string | Filter by this type (optional) 
            var label = label_example;  // string | Filter by this label (optional) 
            var labelPrefix = labelPrefix_example;  // string | Filter by this label prefix (optional) 

            try
            {
                // Get collections of organization
                PaginatedGuidCollection result = apiInstance.GetAllCollectionsOfOrganization(organizationId, authorization, acceptLanguage, offset, limit, type, label, labelPrefix);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetAllCollectionsOfOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 
 **type** | **string**| Filter by this type | [optional] 
 **label** | **string**| Filter by this label | [optional] 
 **labelPrefix** | **string**| Filter by this label prefix | [optional] 

### Return type

[**PaginatedGuidCollection**](PaginatedGuidCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallorganizationroles"></a>
# **GetAllOrganizationRoles**
> PaginatedUserRolesResponse GetAllOrganizationRoles (long? organizationId, string authorization, string acceptLanguage, int? offset, int? limit)

List users and their roles

Listing users and their roles in a paginated manner.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class GetAllOrganizationRolesExample
    {
        public void main()
        {
            
            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | organizationId
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // List users and their roles
                PaginatedUserRolesResponse result = apiInstance.GetAllOrganizationRoles(organizationId, authorization, acceptLanguage, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetAllOrganizationRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedUserRolesResponse**](PaginatedUserRolesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorganizationsofuser"></a>
# **GetOrganizationsOfUser**
> PaginatedOrganizationResponse GetOrganizationsOfUser (string authorization, string acceptLanguage, string role, int? offset, int? limit)

Retrieve organizations of user

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class GetOrganizationsOfUserExample
    {
        public void main()
        {
            
            var apiInstance = new OrganizationsApi();
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var role = role_example;  // string | role (optional) 
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // Retrieve organizations of user
                PaginatedOrganizationResponse result = apiInstance.GetOrganizationsOfUser(authorization, acceptLanguage, role, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetOrganizationsOfUser: " + e.Message );
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
 **role** | **string**| role | [optional] 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedOrganizationResponse**](PaginatedOrganizationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserroles"></a>
# **GetUserRoles**
> PaginatedStringResponse GetUserRoles (long? organizationId, string username, string authorization, string acceptLanguage, int? offset, int? limit)

Get user roles by username

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class GetUserRolesExample
    {
        public void main()
        {
            
            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | organizationId
            var username = username_example;  // string | username
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // Get user roles by username
                PaginatedStringResponse result = apiInstance.GetUserRoles(organizationId, username, authorization, acceptLanguage, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetUserRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **username** | **string**| username | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedStringResponse**](PaginatedStringResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusersoforganization"></a>
# **GetUsersOfOrganization**
> PaginatedUserPresentationResponse GetUsersOfOrganization (long? organizationId, string authorization, string acceptLanguage, int? offset, int? limit)

Find users in organization

Finding users in the specified organization in a paginated manner.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class GetUsersOfOrganizationExample
    {
        public void main()
        {
            
            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | organizationId
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // Find users in organization
                PaginatedUserPresentationResponse result = apiInstance.GetUsersOfOrganization(organizationId, authorization, acceptLanguage, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetUsersOfOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedUserPresentationResponse**](PaginatedUserPresentationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inviteusers"></a>
# **InviteUsers**
> ApiError InviteUsers (long? organizationId, OrganizationUserInvitationListRequest invitationList, string authorization, string acceptLanguage)

Invite Users

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class InviteUsersExample
    {
        public void main()
        {
            
            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | organizationId
            var invitationList = new OrganizationUserInvitationListRequest(); // OrganizationUserInvitationListRequest | invitationList
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Invite Users
                ApiError result = apiInstance.InviteUsers(organizationId, invitationList, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.InviteUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **invitationList** | [**OrganizationUserInvitationListRequest**](OrganizationUserInvitationListRequest.md)| invitationList | 
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

<a name="listcountries"></a>
# **ListCountries**
> PaginatedCountryResponse ListCountries (string authorization, string acceptLanguage, int? offset, int? limit)

List countries

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class ListCountriesExample
    {
        public void main()
        {
            
            var apiInstance = new OrganizationsApi();
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // List countries
                PaginatedCountryResponse result = apiInstance.ListCountries(authorization, acceptLanguage, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.ListCountries: " + e.Message );
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
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedCountryResponse**](PaginatedCountryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeuserroles"></a>
# **RemoveUserRoles**
> ApiError RemoveUserRoles (long? organizationId, string username, ChangeRoleRequest changeRoleRequest, string authorization, string acceptLanguage)

Remove role(s) from user

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class RemoveUserRolesExample
    {
        public void main()
        {
            
            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | organizationId
            var username = username_example;  // string | username
            var changeRoleRequest = new ChangeRoleRequest(); // ChangeRoleRequest | changeRoleRequest
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Remove role(s) from user
                ApiError result = apiInstance.RemoveUserRoles(organizationId, username, changeRoleRequest, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.RemoveUserRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **username** | **string**| username | 
 **changeRoleRequest** | [**ChangeRoleRequest**](ChangeRoleRequest.md)| changeRoleRequest | 
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

<a name="setorganizationlogo"></a>
# **SetOrganizationLogo**
> PublicImagePresentation SetOrganizationLogo (long? organizationId, System.IO.Stream file, string authorization, string acceptLanguage)

Update organization logo

Updating an organization logo using a multipart file upload.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class SetOrganizationLogoExample
    {
        public void main()
        {
            
            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | The id of the organization where the logo should be updated.
            var file = new System.IO.Stream(); // System.IO.Stream | An image containing the new logo.
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Update organization logo
                PublicImagePresentation result = apiInstance.SetOrganizationLogo(organizationId, file, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.SetOrganizationLogo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| The id of the organization where the logo should be updated. | 
 **file** | **System.IO.Stream**| An image containing the new logo. | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**PublicImagePresentation**](PublicImagePresentation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateorganization"></a>
# **UpdateOrganization**
> Organization UpdateOrganization (long? organizationId, Organization organization, string authorization, string acceptLanguage)

Update organization

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class UpdateOrganizationExample
    {
        public void main()
        {
            
            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | The id of the organization to be updated.
            var organization = new Organization(); // Organization | Updated organization object
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Update organization
                Organization result = apiInstance.UpdateOrganization(organizationId, organization, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.UpdateOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| The id of the organization to be updated. | 
 **organization** | [**Organization**](Organization.md)| Updated organization object | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**Organization**](Organization.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateorganizationaddress"></a>
# **UpdateOrganizationAddress**
> OrganizationAddress UpdateOrganizationAddress (long? organizationId, OrganizationAddress addressResource, string authorization, string acceptLanguage)

Store address

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class UpdateOrganizationAddressExample
    {
        public void main()
        {
            
            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | organizationId
            var addressResource = new OrganizationAddress(); // OrganizationAddress | addressResource
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Store address
                OrganizationAddress result = apiInstance.UpdateOrganizationAddress(organizationId, addressResource, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.UpdateOrganizationAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **addressResource** | [**OrganizationAddress**](OrganizationAddress.md)| addressResource | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**OrganizationAddress**](OrganizationAddress.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateorganizationbillingaddress"></a>
# **UpdateOrganizationBillingAddress**
> OrganizationAddress UpdateOrganizationBillingAddress (long? organizationId, OrganizationAddress addressResource, string authorization, string acceptLanguage)

Store billing address

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class UpdateOrganizationBillingAddressExample
    {
        public void main()
        {
            
            var apiInstance = new OrganizationsApi();
            var organizationId = 789;  // long? | organizationId
            var addressResource = new OrganizationAddress(); // OrganizationAddress | addressResource
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Store billing address
                OrganizationAddress result = apiInstance.UpdateOrganizationBillingAddress(organizationId, addressResource, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationsApi.UpdateOrganizationBillingAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **addressResource** | [**OrganizationAddress**](OrganizationAddress.md)| addressResource | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**OrganizationAddress**](OrganizationAddress.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

