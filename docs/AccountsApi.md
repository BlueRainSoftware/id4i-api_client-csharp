# BlueRain.ID4i.Api.AccountsApi

All URIs are relative to *https://backend.id4i.de*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddUserRoles**](AccountsApi.md#adduserroles) | **POST** /api/v1/organizations/{organizationId}/users/{username}/roles | Add role(s) to user
[**CompleteRegistration**](AccountsApi.md#completeregistration) | **PUT** /account/registration | Complete registration
[**FindUserByUsername**](AccountsApi.md#finduserbyusername) | **GET** /api/v1/users/{username} | Find by username
[**FindUsers**](AccountsApi.md#findusers) | **GET** /api/v1/users | Find users
[**GetAllOrganizationRoles**](AccountsApi.md#getallorganizationroles) | **GET** /api/v1/organizations/{organizationId}/roles | List users and their roles
[**GetOrganizationsOfUser**](AccountsApi.md#getorganizationsofuser) | **GET** /api/v1/user/organizations | Retrieve organizations of user
[**GetUserRoles**](AccountsApi.md#getuserroles) | **GET** /api/v1/organizations/{organizationId}/users/{username}/roles | Get user roles by username
[**GetUsersOfOrganization**](AccountsApi.md#getusersoforganization) | **GET** /api/v1/organizations/{organizationId}/users | Find users in organization
[**InviteUsers**](AccountsApi.md#inviteusers) | **POST** /api/v1/organizations/{organizationId}/users/invite | Invite Users
[**ListAllRoles**](AccountsApi.md#listallroles) | **GET** /api/v1/roles | List roles
[**Login**](AccountsApi.md#login) | **POST** /login | 
[**RegisterUser**](AccountsApi.md#registeruser) | **POST** /account/registration | Register user
[**RemoveUserRoles**](AccountsApi.md#removeuserroles) | **DELETE** /api/v1/organizations/{organizationId}/users/{username}/roles | Remove role(s) from user
[**RequestPasswordReset**](AccountsApi.md#requestpasswordreset) | **POST** /account/password | Request password reset
[**VerifyPasswordReset**](AccountsApi.md#verifypasswordreset) | **PUT** /account/password | Verify password reset
[**VerifyUserRegistration**](AccountsApi.md#verifyuserregistration) | **POST** /account/verification | Verify registration


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
            
            var apiInstance = new AccountsApi();
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
                Debug.Print("Exception when calling AccountsApi.AddUserRoles: " + e.Message );
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

<a name="completeregistration"></a>
# **CompleteRegistration**
> ApiError CompleteRegistration (CompleteUserRegistrationRequest completeRegistration, string authorization, string acceptLanguage)

Complete registration

Completing a registration e.g. for invited users. Finish registration with a username and a password.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class CompleteRegistrationExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var completeRegistration = new CompleteUserRegistrationRequest(); // CompleteUserRegistrationRequest | Contains the verification token, the username and the initial password.
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Complete registration
                ApiError result = apiInstance.CompleteRegistration(completeRegistration, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.CompleteRegistration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **completeRegistration** | [**CompleteUserRegistrationRequest**](CompleteUserRegistrationRequest.md)| Contains the verification token, the username and the initial password. | 
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

<a name="finduserbyusername"></a>
# **FindUserByUsername**
> UserPresentation FindUserByUsername (string username, string authorization, string acceptLanguage)

Find by username

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class FindUserByUsernameExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var username = username_example;  // string | username
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Find by username
                UserPresentation result = apiInstance.FindUserByUsername(username, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.FindUserByUsername: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| username | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**UserPresentation**](UserPresentation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findusers"></a>
# **FindUsers**
> PaginatedUserPresentationResponse FindUsers (string usernamePrefix, string authorization, string acceptLanguage, int? offset, int? limit)

Find users

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class FindUsersExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var usernamePrefix = usernamePrefix_example;  // string | Find users starting with this prefix.
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // Find users
                PaginatedUserPresentationResponse result = apiInstance.FindUsers(usernamePrefix, authorization, acceptLanguage, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.FindUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **usernamePrefix** | **string**| Find users starting with this prefix. | 
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
            
            var apiInstance = new AccountsApi();
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
                Debug.Print("Exception when calling AccountsApi.GetAllOrganizationRoles: " + e.Message );
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
            
            var apiInstance = new AccountsApi();
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
                Debug.Print("Exception when calling AccountsApi.GetOrganizationsOfUser: " + e.Message );
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
            
            var apiInstance = new AccountsApi();
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
                Debug.Print("Exception when calling AccountsApi.GetUserRoles: " + e.Message );
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
            
            var apiInstance = new AccountsApi();
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
                Debug.Print("Exception when calling AccountsApi.GetUsersOfOrganization: " + e.Message );
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
            
            var apiInstance = new AccountsApi();
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
                Debug.Print("Exception when calling AccountsApi.InviteUsers: " + e.Message );
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

<a name="listallroles"></a>
# **ListAllRoles**
> RoleResponse ListAllRoles (string authorization, string acceptLanguage, string privilege, int? offset, int? limit)

List roles

Listing of roles.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class ListAllRolesExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var privilege = privilege_example;  // string | If specified the roles will be filtered containing that privilege. (optional) 
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // List roles
                RoleResponse result = apiInstance.ListAllRoles(authorization, acceptLanguage, privilege, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.ListAllRoles: " + e.Message );
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
 **privilege** | **string**| If specified the roles will be filtered containing that privilege. | [optional] 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**RoleResponse**](RoleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="login"></a>
# **Login**
> void Login (AccountCredentials accountCredentials)



ID4i API Login

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class LoginExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var accountCredentials = new AccountCredentials(); // AccountCredentials | 

            try
            {
                apiInstance.Login(accountCredentials);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.Login: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountCredentials** | [**AccountCredentials**](AccountCredentials.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registeruser"></a>
# **RegisterUser**
> UserRegistrationResponse RegisterUser (UserRegistrationRequest userRegistration, string authorization, string acceptLanguage)

Register user

Registering a new user.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class RegisterUserExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var userRegistration = new UserRegistrationRequest(); // UserRegistrationRequest | The user information about the new created user.
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Register user
                UserRegistrationResponse result = apiInstance.RegisterUser(userRegistration, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.RegisterUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userRegistration** | [**UserRegistrationRequest**](UserRegistrationRequest.md)| The user information about the new created user. | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**UserRegistrationResponse**](UserRegistrationResponse.md)

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
            
            var apiInstance = new AccountsApi();
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
                Debug.Print("Exception when calling AccountsApi.RemoveUserRoles: " + e.Message );
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

<a name="requestpasswordreset"></a>
# **RequestPasswordReset**
> SimpleMessageResponse RequestPasswordReset (PasswordResetRequest resetRequest, string authorization, string acceptLanguage)

Request password reset

Requesting a reset for a new password. 

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class RequestPasswordResetExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var resetRequest = new PasswordResetRequest(); // PasswordResetRequest | Contains the required information to request a new password.
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Request password reset
                SimpleMessageResponse result = apiInstance.RequestPasswordReset(resetRequest, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.RequestPasswordReset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **resetRequest** | [**PasswordResetRequest**](PasswordResetRequest.md)| Contains the required information to request a new password. | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**SimpleMessageResponse**](SimpleMessageResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="verifypasswordreset"></a>
# **VerifyPasswordReset**
> SimpleMessageResponse VerifyPasswordReset (PasswordResetVerificationRequest verificationRequest, string authorization, string acceptLanguage)

Verify password reset

Setting a new password and verifying the request to set the password.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class VerifyPasswordResetExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var verificationRequest = new PasswordResetVerificationRequest(); // PasswordResetVerificationRequest | Contains the new password and the verification token to set the new password.
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Verify password reset
                SimpleMessageResponse result = apiInstance.VerifyPasswordReset(verificationRequest, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.VerifyPasswordReset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **verificationRequest** | [**PasswordResetVerificationRequest**](PasswordResetVerificationRequest.md)| Contains the new password and the verification token to set the new password. | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**SimpleMessageResponse**](SimpleMessageResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="verifyuserregistration"></a>
# **VerifyUserRegistration**
> ApiError VerifyUserRegistration (RegistrationVerificationTokenPresentation token, string authorization, string acceptLanguage)

Verify registration

Verifies a new user registration.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class VerifyUserRegistrationExample
    {
        public void main()
        {
            
            var apiInstance = new AccountsApi();
            var token = new RegistrationVerificationTokenPresentation(); // RegistrationVerificationTokenPresentation | The token for user verification.
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Verify registration
                ApiError result = apiInstance.VerifyUserRegistration(token, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.VerifyUserRegistration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | [**RegistrationVerificationTokenPresentation**](RegistrationVerificationTokenPresentation.md)| The token for user verification. | 
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

