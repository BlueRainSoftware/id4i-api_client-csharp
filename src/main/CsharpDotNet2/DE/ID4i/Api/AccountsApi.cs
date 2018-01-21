using System;
using System.Collections.Generic;
using RestSharp;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace 
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccountsApi
    {
        /// <summary>
        /// Add role(s) to user 
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="username">username</param>
        /// <param name="changeRoleRequest">changeRoleRequest</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiError</returns>
        ApiError AddUserRoles (long? organizationId, string username, ChangeRoleRequest changeRoleRequest, string authorization, string acceptLanguage);
        /// <summary>
        /// Complete registration Completing a registration e.g. for invited users. Finish registration with a username and a password.
        /// </summary>
        /// <param name="completeRegistration">Contains the verification token, the username and the initial password.</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiError</returns>
        ApiError CompleteRegistration (CompleteUserRegistrationRequest completeRegistration, string authorization, string acceptLanguage);
        /// <summary>
        /// Find by username 
        /// </summary>
        /// <param name="username">username</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>UserPresentation</returns>
        UserPresentation FindUserByUsername (string username, string authorization, string acceptLanguage);
        /// <summary>
        /// Find users 
        /// </summary>
        /// <param name="usernamePrefix">Find users starting with this prefix.</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="offset">Start with the n-th element. </param>
        /// <param name="limit">The maximum count of returned elements.</param>
        /// <returns>PaginatedUserPresentationResponse</returns>
        PaginatedUserPresentationResponse FindUsers (string usernamePrefix, string authorization, string acceptLanguage, int? offset, int? limit);
        /// <summary>
        /// List users and their roles Listing users and their roles in a paginated manner.
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="offset">Start with the n-th element. </param>
        /// <param name="limit">The maximum count of returned elements.</param>
        /// <returns>PaginatedUserRolesResponse</returns>
        PaginatedUserRolesResponse GetAllOrganizationRoles (long? organizationId, string authorization, string acceptLanguage, int? offset, int? limit);
        /// <summary>
        /// Retrieve organizations of user 
        /// </summary>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="role">role</param>
        /// <param name="offset">Start with the n-th element. </param>
        /// <param name="limit">The maximum count of returned elements.</param>
        /// <returns>PaginatedOrganizationResponse</returns>
        PaginatedOrganizationResponse GetOrganizationsOfUser (string authorization, string acceptLanguage, string role, int? offset, int? limit);
        /// <summary>
        /// Get user roles by username 
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="username">username</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="offset">Start with the n-th element. </param>
        /// <param name="limit">The maximum count of returned elements.</param>
        /// <returns>PaginatedStringResponse</returns>
        PaginatedStringResponse GetUserRoles (long? organizationId, string username, string authorization, string acceptLanguage, int? offset, int? limit);
        /// <summary>
        /// Find users in organization Finding users in the specified organization in a paginated manner.
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="offset">Start with the n-th element. </param>
        /// <param name="limit">The maximum count of returned elements.</param>
        /// <returns>PaginatedUserPresentationResponse</returns>
        PaginatedUserPresentationResponse GetUsersOfOrganization (long? organizationId, string authorization, string acceptLanguage, int? offset, int? limit);
        /// <summary>
        /// Invite Users 
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="invitationList">invitationList</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiError</returns>
        ApiError InviteUsers (long? organizationId, OrganizationUserInvitationListRequest invitationList, string authorization, string acceptLanguage);
        /// <summary>
        /// List roles Listing of roles.
        /// </summary>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="privilege">If specified the roles will be filtered containing that privilege.</param>
        /// <param name="offset">Start with the n-th element. </param>
        /// <param name="limit">The maximum count of returned elements.</param>
        /// <returns>RoleResponse</returns>
        RoleResponse ListAllRoles (string authorization, string acceptLanguage, string privilege, int? offset, int? limit);
        /// <summary>
        ///  ID4i API Login
        /// </summary>
        /// <param name="accountCredentials"></param>
        /// <returns></returns>
        void Login (AccountCredentials accountCredentials);
        /// <summary>
        /// Register user Registering a new user.
        /// </summary>
        /// <param name="userRegistration">The user information about the new created user.</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>UserRegistrationResponse</returns>
        UserRegistrationResponse RegisterUser (UserRegistrationRequest userRegistration, string authorization, string acceptLanguage);
        /// <summary>
        /// Remove role(s) from user 
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="username">username</param>
        /// <param name="changeRoleRequest">changeRoleRequest</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiError</returns>
        ApiError RemoveUserRoles (long? organizationId, string username, ChangeRoleRequest changeRoleRequest, string authorization, string acceptLanguage);
        /// <summary>
        /// Request password reset Requesting a reset for a new password. 
        /// </summary>
        /// <param name="resetRequest">Contains the required information to request a new password.</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>SimpleMessageResponse</returns>
        SimpleMessageResponse RequestPasswordReset (PasswordResetRequest resetRequest, string authorization, string acceptLanguage);
        /// <summary>
        /// Verify password reset Setting a new password and verifying the request to set the password.
        /// </summary>
        /// <param name="verificationRequest">Contains the new password and the verification token to set the new password.</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>SimpleMessageResponse</returns>
        SimpleMessageResponse VerifyPasswordReset (PasswordResetVerificationRequest verificationRequest, string authorization, string acceptLanguage);
        /// <summary>
        /// Verify registration Verifies a new user registration.
        /// </summary>
        /// <param name="token">The token for user verification.</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiError</returns>
        ApiError VerifyUserRegistration (RegistrationVerificationTokenPresentation token, string authorization, string acceptLanguage);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AccountsApi : IAccountsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AccountsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountsApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Add role(s) to user 
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="username">username</param> 
        /// <param name="changeRoleRequest">changeRoleRequest</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiError</returns>            
        public ApiError AddUserRoles (long? organizationId, string username, ChangeRoleRequest changeRoleRequest, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling AddUserRoles");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling AddUserRoles");
            
            // verify the required parameter 'changeRoleRequest' is set
            if (changeRoleRequest == null) throw new ApiException(400, "Missing required parameter 'changeRoleRequest' when calling AddUserRoles");
            
    
            var path = "/api/v1/organizations/{organizationId}/users/{username}/roles";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(changeRoleRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddUserRoles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddUserRoles: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiError) ApiClient.Deserialize(response.Content, typeof(ApiError), response.Headers);
        }
    
        /// <summary>
        /// Complete registration Completing a registration e.g. for invited users. Finish registration with a username and a password.
        /// </summary>
        /// <param name="completeRegistration">Contains the verification token, the username and the initial password.</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiError</returns>            
        public ApiError CompleteRegistration (CompleteUserRegistrationRequest completeRegistration, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'completeRegistration' is set
            if (completeRegistration == null) throw new ApiException(400, "Missing required parameter 'completeRegistration' when calling CompleteRegistration");
            
    
            var path = "/account/registration";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(completeRegistration); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CompleteRegistration: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CompleteRegistration: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiError) ApiClient.Deserialize(response.Content, typeof(ApiError), response.Headers);
        }
    
        /// <summary>
        /// Find by username 
        /// </summary>
        /// <param name="username">username</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>UserPresentation</returns>            
        public UserPresentation FindUserByUsername (string username, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling FindUserByUsername");
            
    
            var path = "/api/v1/users/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FindUserByUsername: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FindUserByUsername: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserPresentation) ApiClient.Deserialize(response.Content, typeof(UserPresentation), response.Headers);
        }
    
        /// <summary>
        /// Find users 
        /// </summary>
        /// <param name="usernamePrefix">Find users starting with this prefix.</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="offset">Start with the n-th element. </param> 
        /// <param name="limit">The maximum count of returned elements.</param> 
        /// <returns>PaginatedUserPresentationResponse</returns>            
        public PaginatedUserPresentationResponse FindUsers (string usernamePrefix, string authorization, string acceptLanguage, int? offset, int? limit)
        {
            
            // verify the required parameter 'usernamePrefix' is set
            if (usernamePrefix == null) throw new ApiException(400, "Missing required parameter 'usernamePrefix' when calling FindUsers");
            
    
            var path = "/api/v1/users";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (usernamePrefix != null) queryParams.Add("usernamePrefix", ApiClient.ParameterToString(usernamePrefix)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
             if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FindUsers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FindUsers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaginatedUserPresentationResponse) ApiClient.Deserialize(response.Content, typeof(PaginatedUserPresentationResponse), response.Headers);
        }
    
        /// <summary>
        /// List users and their roles Listing users and their roles in a paginated manner.
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="offset">Start with the n-th element. </param> 
        /// <param name="limit">The maximum count of returned elements.</param> 
        /// <returns>PaginatedUserRolesResponse</returns>            
        public PaginatedUserRolesResponse GetAllOrganizationRoles (long? organizationId, string authorization, string acceptLanguage, int? offset, int? limit)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling GetAllOrganizationRoles");
            
    
            var path = "/api/v1/organizations/{organizationId}/roles";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
             if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAllOrganizationRoles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAllOrganizationRoles: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaginatedUserRolesResponse) ApiClient.Deserialize(response.Content, typeof(PaginatedUserRolesResponse), response.Headers);
        }
    
        /// <summary>
        /// Retrieve organizations of user 
        /// </summary>
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="role">role</param> 
        /// <param name="offset">Start with the n-th element. </param> 
        /// <param name="limit">The maximum count of returned elements.</param> 
        /// <returns>PaginatedOrganizationResponse</returns>            
        public PaginatedOrganizationResponse GetOrganizationsOfUser (string authorization, string acceptLanguage, string role, int? offset, int? limit)
        {
            
    
            var path = "/api/v1/user/organizations";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (role != null) queryParams.Add("role", ApiClient.ParameterToString(role)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
             if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrganizationsOfUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrganizationsOfUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaginatedOrganizationResponse) ApiClient.Deserialize(response.Content, typeof(PaginatedOrganizationResponse), response.Headers);
        }
    
        /// <summary>
        /// Get user roles by username 
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="username">username</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="offset">Start with the n-th element. </param> 
        /// <param name="limit">The maximum count of returned elements.</param> 
        /// <returns>PaginatedStringResponse</returns>            
        public PaginatedStringResponse GetUserRoles (long? organizationId, string username, string authorization, string acceptLanguage, int? offset, int? limit)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling GetUserRoles");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling GetUserRoles");
            
    
            var path = "/api/v1/organizations/{organizationId}/users/{username}/roles";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
             if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserRoles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserRoles: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaginatedStringResponse) ApiClient.Deserialize(response.Content, typeof(PaginatedStringResponse), response.Headers);
        }
    
        /// <summary>
        /// Find users in organization Finding users in the specified organization in a paginated manner.
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="offset">Start with the n-th element. </param> 
        /// <param name="limit">The maximum count of returned elements.</param> 
        /// <returns>PaginatedUserPresentationResponse</returns>            
        public PaginatedUserPresentationResponse GetUsersOfOrganization (long? organizationId, string authorization, string acceptLanguage, int? offset, int? limit)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling GetUsersOfOrganization");
            
    
            var path = "/api/v1/organizations/{organizationId}/users";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
             if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsersOfOrganization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsersOfOrganization: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaginatedUserPresentationResponse) ApiClient.Deserialize(response.Content, typeof(PaginatedUserPresentationResponse), response.Headers);
        }
    
        /// <summary>
        /// Invite Users 
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="invitationList">invitationList</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiError</returns>            
        public ApiError InviteUsers (long? organizationId, OrganizationUserInvitationListRequest invitationList, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling InviteUsers");
            
            // verify the required parameter 'invitationList' is set
            if (invitationList == null) throw new ApiException(400, "Missing required parameter 'invitationList' when calling InviteUsers");
            
    
            var path = "/api/v1/organizations/{organizationId}/users/invite";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(invitationList); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling InviteUsers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InviteUsers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiError) ApiClient.Deserialize(response.Content, typeof(ApiError), response.Headers);
        }
    
        /// <summary>
        /// List roles Listing of roles.
        /// </summary>
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="privilege">If specified the roles will be filtered containing that privilege.</param> 
        /// <param name="offset">Start with the n-th element. </param> 
        /// <param name="limit">The maximum count of returned elements.</param> 
        /// <returns>RoleResponse</returns>            
        public RoleResponse ListAllRoles (string authorization, string acceptLanguage, string privilege, int? offset, int? limit)
        {
            
    
            var path = "/api/v1/roles";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (privilege != null) queryParams.Add("privilege", ApiClient.ParameterToString(privilege)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
             if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAllRoles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAllRoles: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RoleResponse) ApiClient.Deserialize(response.Content, typeof(RoleResponse), response.Headers);
        }
    
        /// <summary>
        ///  ID4i API Login
        /// </summary>
        /// <param name="accountCredentials"></param> 
        /// <returns></returns>            
        public void Login (AccountCredentials accountCredentials)
        {
            
            // verify the required parameter 'accountCredentials' is set
            if (accountCredentials == null) throw new ApiException(400, "Missing required parameter 'accountCredentials' when calling Login");
            
    
            var path = "/login";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(accountCredentials); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Login: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Login: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Register user Registering a new user.
        /// </summary>
        /// <param name="userRegistration">The user information about the new created user.</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>UserRegistrationResponse</returns>            
        public UserRegistrationResponse RegisterUser (UserRegistrationRequest userRegistration, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'userRegistration' is set
            if (userRegistration == null) throw new ApiException(400, "Missing required parameter 'userRegistration' when calling RegisterUser");
            
    
            var path = "/account/registration";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(userRegistration); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RegisterUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RegisterUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserRegistrationResponse) ApiClient.Deserialize(response.Content, typeof(UserRegistrationResponse), response.Headers);
        }
    
        /// <summary>
        /// Remove role(s) from user 
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="username">username</param> 
        /// <param name="changeRoleRequest">changeRoleRequest</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiError</returns>            
        public ApiError RemoveUserRoles (long? organizationId, string username, ChangeRoleRequest changeRoleRequest, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling RemoveUserRoles");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling RemoveUserRoles");
            
            // verify the required parameter 'changeRoleRequest' is set
            if (changeRoleRequest == null) throw new ApiException(400, "Missing required parameter 'changeRoleRequest' when calling RemoveUserRoles");
            
    
            var path = "/api/v1/organizations/{organizationId}/users/{username}/roles";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(changeRoleRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveUserRoles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveUserRoles: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiError) ApiClient.Deserialize(response.Content, typeof(ApiError), response.Headers);
        }
    
        /// <summary>
        /// Request password reset Requesting a reset for a new password. 
        /// </summary>
        /// <param name="resetRequest">Contains the required information to request a new password.</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>SimpleMessageResponse</returns>            
        public SimpleMessageResponse RequestPasswordReset (PasswordResetRequest resetRequest, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'resetRequest' is set
            if (resetRequest == null) throw new ApiException(400, "Missing required parameter 'resetRequest' when calling RequestPasswordReset");
            
    
            var path = "/account/password";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(resetRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RequestPasswordReset: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RequestPasswordReset: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SimpleMessageResponse) ApiClient.Deserialize(response.Content, typeof(SimpleMessageResponse), response.Headers);
        }
    
        /// <summary>
        /// Verify password reset Setting a new password and verifying the request to set the password.
        /// </summary>
        /// <param name="verificationRequest">Contains the new password and the verification token to set the new password.</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>SimpleMessageResponse</returns>            
        public SimpleMessageResponse VerifyPasswordReset (PasswordResetVerificationRequest verificationRequest, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'verificationRequest' is set
            if (verificationRequest == null) throw new ApiException(400, "Missing required parameter 'verificationRequest' when calling VerifyPasswordReset");
            
    
            var path = "/account/password";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(verificationRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VerifyPasswordReset: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VerifyPasswordReset: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SimpleMessageResponse) ApiClient.Deserialize(response.Content, typeof(SimpleMessageResponse), response.Headers);
        }
    
        /// <summary>
        /// Verify registration Verifies a new user registration.
        /// </summary>
        /// <param name="token">The token for user verification.</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiError</returns>            
        public ApiError VerifyUserRegistration (RegistrationVerificationTokenPresentation token, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling VerifyUserRegistration");
            
    
            var path = "/account/verification";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(token); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VerifyUserRegistration: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VerifyUserRegistration: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiError) ApiClient.Deserialize(response.Content, typeof(ApiError), response.Headers);
        }
    
    }
}
