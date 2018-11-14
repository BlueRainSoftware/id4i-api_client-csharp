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
> void AddUserRoles (string organizationId, string username, ChangeRoleRequest changeRoleRequest)

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
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi();
            var organizationId = organizationId_example;  // string | The namespace of the organization
            var username = username_example;  // string | username
            var changeRoleRequest = new ChangeRoleRequest(); // ChangeRoleRequest | changeRoleRequest

            try
            {
                // Add role(s) to user
                apiInstance.AddUserRoles(organizationId, username, changeRoleRequest);
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
 **organizationId** | **string**| The namespace of the organization | 
 **username** | **string**| username | 
 **changeRoleRequest** | [**ChangeRoleRequest**](ChangeRoleRequest.md)| changeRoleRequest | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="completeregistration"></a>
# **CompleteRegistration**
> void CompleteRegistration (CompleteUserRegistrationRequest completeRegistration)

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

            try
            {
                // Complete registration
                apiInstance.CompleteRegistration(completeRegistration);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="finduserbyusername"></a>
# **FindUserByUsername**
> UserPresentation FindUserByUsername (string username)

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
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi();
            var username = username_example;  // string | username

            try
            {
                // Find by username
                UserPresentation result = apiInstance.FindUserByUsername(username);
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

### Return type

[**UserPresentation**](UserPresentation.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findusers"></a>
# **FindUsers**
> PaginatedUserPresentationResponse FindUsers (string usernamePrefix = null, int? offset = null, int? limit = null)

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
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi();
            var usernamePrefix = usernamePrefix_example;  // string |  (optional) 
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // Find users
                PaginatedUserPresentationResponse result = apiInstance.FindUsers(usernamePrefix, offset, limit);
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
 **usernamePrefix** | **string**|  | [optional] 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedUserPresentationResponse**](PaginatedUserPresentationResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallorganizationroles"></a>
# **GetAllOrganizationRoles**
> PaginatedUserRolesResponse GetAllOrganizationRoles (string organizationId, int? offset = null, int? limit = null)

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
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi();
            var organizationId = organizationId_example;  // string | organizationId
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // List users and their roles
                PaginatedUserRolesResponse result = apiInstance.GetAllOrganizationRoles(organizationId, offset, limit);
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
 **organizationId** | **string**| organizationId | 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedUserRolesResponse**](PaginatedUserRolesResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorganizationsofuser"></a>
# **GetOrganizationsOfUser**
> PaginatedOrganizationResponse GetOrganizationsOfUser (string role = null, int? offset = null, int? limit = null)

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
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi();
            var role = role_example;  // string | role (optional) 
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // Retrieve organizations of user
                PaginatedOrganizationResponse result = apiInstance.GetOrganizationsOfUser(role, offset, limit);
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
 **role** | **string**| role | [optional] 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedOrganizationResponse**](PaginatedOrganizationResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserroles"></a>
# **GetUserRoles**
> PaginatedStringResponse GetUserRoles (string organizationId, string username, int? offset = null, int? limit = null)

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
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi();
            var organizationId = organizationId_example;  // string | The namespace of the organization
            var username = username_example;  // string | username
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // Get user roles by username
                PaginatedStringResponse result = apiInstance.GetUserRoles(organizationId, username, offset, limit);
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
 **organizationId** | **string**| The namespace of the organization | 
 **username** | **string**| username | 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedStringResponse**](PaginatedStringResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusersoforganization"></a>
# **GetUsersOfOrganization**
> PaginatedUserPresentationResponse GetUsersOfOrganization (string organizationId, int? offset = null, int? limit = null)

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
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi();
            var organizationId = organizationId_example;  // string | organizationId
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // Find users in organization
                PaginatedUserPresentationResponse result = apiInstance.GetUsersOfOrganization(organizationId, offset, limit);
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
 **organizationId** | **string**| organizationId | 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedUserPresentationResponse**](PaginatedUserPresentationResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inviteusers"></a>
# **InviteUsers**
> void InviteUsers (string organizationId, OrganizationUserInvitationListRequest invitationList)

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
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi();
            var organizationId = organizationId_example;  // string | The namespace of the organization where users should be invited
            var invitationList = new OrganizationUserInvitationListRequest(); // OrganizationUserInvitationListRequest | invitationList

            try
            {
                // Invite Users
                apiInstance.InviteUsers(organizationId, invitationList);
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
 **organizationId** | **string**| The namespace of the organization where users should be invited | 
 **invitationList** | [**OrganizationUserInvitationListRequest**](OrganizationUserInvitationListRequest.md)| invitationList | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listallroles"></a>
# **ListAllRoles**
> RoleResponse ListAllRoles (string privilege = null, int? offset = null, int? limit = null)

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
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi();
            var privilege = privilege_example;  // string | If specified the roles will be filtered containing that privilege. (optional) 
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // List roles
                RoleResponse result = apiInstance.ListAllRoles(privilege, offset, limit);
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
 **privilege** | **string**| If specified the roles will be filtered containing that privilege. | [optional] 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**RoleResponse**](RoleResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

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

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registeruser"></a>
# **RegisterUser**
> UserRegistrationResponse RegisterUser (UserRegistrationRequest userRegistration)

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

            try
            {
                // Register user
                UserRegistrationResponse result = apiInstance.RegisterUser(userRegistration);
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

### Return type

[**UserRegistrationResponse**](UserRegistrationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeuserroles"></a>
# **RemoveUserRoles**
> void RemoveUserRoles (string organizationId, string username, ChangeRoleRequest changeRoleRequest)

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
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi();
            var organizationId = organizationId_example;  // string | The namespace of the organization
            var username = username_example;  // string | username
            var changeRoleRequest = new ChangeRoleRequest(); // ChangeRoleRequest | changeRoleRequest

            try
            {
                // Remove role(s) from user
                apiInstance.RemoveUserRoles(organizationId, username, changeRoleRequest);
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
 **organizationId** | **string**| The namespace of the organization | 
 **username** | **string**| username | 
 **changeRoleRequest** | [**ChangeRoleRequest**](ChangeRoleRequest.md)| changeRoleRequest | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="requestpasswordreset"></a>
# **RequestPasswordReset**
> SimpleMessageResponse RequestPasswordReset (PasswordResetRequest resetRequest)

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

            try
            {
                // Request password reset
                SimpleMessageResponse result = apiInstance.RequestPasswordReset(resetRequest);
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

### Return type

[**SimpleMessageResponse**](SimpleMessageResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="verifypasswordreset"></a>
# **VerifyPasswordReset**
> SimpleMessageResponse VerifyPasswordReset (PasswordResetVerificationRequest verificationRequest)

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

            try
            {
                // Verify password reset
                SimpleMessageResponse result = apiInstance.VerifyPasswordReset(verificationRequest);
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

### Return type

[**SimpleMessageResponse**](SimpleMessageResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="verifyuserregistration"></a>
# **VerifyUserRegistration**
> void VerifyUserRegistration (RegistrationVerificationTokenPresentation token)

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

            try
            {
                // Verify registration
                apiInstance.VerifyUserRegistration(token);
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

