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
    public interface IOrganizationsApi
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
        /// Create organization Creating a new organization.
        /// </summary>
        /// <param name="organization">Organization to be created</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>Organization</returns>
        Organization CreateOrganization (Organization organization, string authorization, string acceptLanguage);
        /// <summary>
        /// Delete organization 
        /// </summary>
        /// <param name="organizationId">The id of the organization to be deleted.</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiError</returns>
        ApiError DeleteOrganization (long? organizationId, string authorization, string acceptLanguage);
        /// <summary>
        /// Remove billing address 
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiError</returns>
        ApiError DeleteOrganizationBillingAddress (long? organizationId, string authorization, string acceptLanguage);
        /// <summary>
        /// Delete organization logo 
        /// </summary>
        /// <param name="organizationId">The id of the organization where the logo should be deleted.</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiError</returns>
        ApiError DeleteOrganizationLogo (long? organizationId, string authorization, string acceptLanguage);
        /// <summary>
        /// Find organization by id Returns a single organization.
        /// </summary>
        /// <param name="organizationId">The id of the organization to be retrieved.</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>Organization</returns>
        Organization FindOrganization (long? organizationId, string authorization, string acceptLanguage);
        /// <summary>
        /// Retrieve address 
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>OrganizationAddress</returns>
        OrganizationAddress FindOrganizationAddress (long? organizationId, string authorization, string acceptLanguage);
        /// <summary>
        /// Retrieve billing address 
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>OrganizationAddress</returns>
        OrganizationAddress FindOrganizationBillingAddress (long? organizationId, string authorization, string acceptLanguage);
        /// <summary>
        /// Get collections of organization Retrieving all collections of an organization in a paginated manner.
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="offset">Start with the n-th element</param>
        /// <param name="limit">The maximum count of returned elements</param>
        /// <param name="type">Filter by this type</param>
        /// <param name="label">Filter by this label</param>
        /// <param name="labelPrefix">Filter by this label prefix</param>
        /// <returns>PaginatedGuidCollection</returns>
        PaginatedGuidCollection GetAllCollectionsOfOrganization (long? organizationId, string authorization, string acceptLanguage, int? offset, int? limit, string type, string label, string labelPrefix);
        /// <summary>
        /// List users and their roles Listing users and their roles in a paginated manner.
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="offset">Start with the n-th element</param>
        /// <param name="limit">The maximum count of returned elements</param>
        /// <returns>PaginatedUserRolesResponse</returns>
        PaginatedUserRolesResponse GetAllOrganizationRoles (long? organizationId, string authorization, string acceptLanguage, int? offset, int? limit);
        /// <summary>
        /// Retrieve organizations of user 
        /// </summary>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="role">role</param>
        /// <param name="offset">Start with the n-th element</param>
        /// <param name="limit">The maximum count of returned elements</param>
        /// <returns>PaginatedOrganizationResponse</returns>
        PaginatedOrganizationResponse GetOrganizationsOfUser (string authorization, string acceptLanguage, string role, int? offset, int? limit);
        /// <summary>
        /// Get user roles by username 
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="username">username</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="offset">Start with the n-th element</param>
        /// <param name="limit">The maximum count of returned elements</param>
        /// <returns>PaginatedStringResponse</returns>
        PaginatedStringResponse GetUserRoles (long? organizationId, string username, string authorization, string acceptLanguage, int? offset, int? limit);
        /// <summary>
        /// Find users in organization Finding users in the specified organization in a paginated manner.
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="offset">Start with the n-th element</param>
        /// <param name="limit">The maximum count of returned elements</param>
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
        /// List countries 
        /// </summary>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="offset">Start with the n-th element</param>
        /// <param name="limit">The maximum count of returned elements</param>
        /// <returns>PaginatedCountryResponse</returns>
        PaginatedCountryResponse ListCountries (string authorization, string acceptLanguage, int? offset, int? limit);
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
        /// Update organization 
        /// </summary>
        /// <param name="organizationId">The id of the organization to be updated.</param>
        /// <param name="organization">Updated organization object</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>Organization</returns>
        Organization UpdateOrganization (long? organizationId, Organization organization, string authorization, string acceptLanguage);
        /// <summary>
        /// Store address 
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="addressResource">addressResource</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>OrganizationAddress</returns>
        OrganizationAddress UpdateOrganizationAddress (long? organizationId, OrganizationAddress addressResource, string authorization, string acceptLanguage);
        /// <summary>
        /// Store billing address 
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="addressResource">addressResource</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>OrganizationAddress</returns>
        OrganizationAddress UpdateOrganizationBillingAddress (long? organizationId, OrganizationAddress addressResource, string authorization, string acceptLanguage);
        /// <summary>
        /// Update organization logo Updating an organization logo using a multipart file upload.
        /// </summary>
        /// <param name="organizationId">The id of the organization where the logo should be updated.</param>
        /// <param name="file">An image containing the new logo.</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiError</returns>
        ApiError UpdateOrganizationLogo (long? organizationId, System.IO.Stream file, string authorization, string acceptLanguage);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OrganizationsApi : IOrganizationsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public OrganizationsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrganizationsApi(String basePath)
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
        /// Create organization Creating a new organization.
        /// </summary>
        /// <param name="organization">Organization to be created</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>Organization</returns>            
        public Organization CreateOrganization (Organization organization, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'organization' is set
            if (organization == null) throw new ApiException(400, "Missing required parameter 'organization' when calling CreateOrganization");
            
    
            var path = "/api/v1/organizations";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(organization); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateOrganization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateOrganization: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Organization) ApiClient.Deserialize(response.Content, typeof(Organization), response.Headers);
        }
    
        /// <summary>
        /// Delete organization 
        /// </summary>
        /// <param name="organizationId">The id of the organization to be deleted.</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiError</returns>            
        public ApiError DeleteOrganization (long? organizationId, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling DeleteOrganization");
            
    
            var path = "/api/v1/organizations/{organizationId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
    
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteOrganization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteOrganization: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiError) ApiClient.Deserialize(response.Content, typeof(ApiError), response.Headers);
        }
    
        /// <summary>
        /// Remove billing address 
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiError</returns>            
        public ApiError DeleteOrganizationBillingAddress (long? organizationId, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling DeleteOrganizationBillingAddress");
            
    
            var path = "/api/v1/organizations/{organizationId}/addresses/billing";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
    
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteOrganizationBillingAddress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteOrganizationBillingAddress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiError) ApiClient.Deserialize(response.Content, typeof(ApiError), response.Headers);
        }
    
        /// <summary>
        /// Delete organization logo 
        /// </summary>
        /// <param name="organizationId">The id of the organization where the logo should be deleted.</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiError</returns>            
        public ApiError DeleteOrganizationLogo (long? organizationId, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling DeleteOrganizationLogo");
            
    
            var path = "/api/v1/organizations/{organizationId}/logo";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
    
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteOrganizationLogo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteOrganizationLogo: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiError) ApiClient.Deserialize(response.Content, typeof(ApiError), response.Headers);
        }
    
        /// <summary>
        /// Find organization by id Returns a single organization.
        /// </summary>
        /// <param name="organizationId">The id of the organization to be retrieved.</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>Organization</returns>            
        public Organization FindOrganization (long? organizationId, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling FindOrganization");
            
    
            var path = "/api/v1/organizations/{organizationId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling FindOrganization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FindOrganization: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Organization) ApiClient.Deserialize(response.Content, typeof(Organization), response.Headers);
        }
    
        /// <summary>
        /// Retrieve address 
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>OrganizationAddress</returns>            
        public OrganizationAddress FindOrganizationAddress (long? organizationId, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling FindOrganizationAddress");
            
    
            var path = "/api/v1/organizations/{organizationId}/addresses/default";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling FindOrganizationAddress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FindOrganizationAddress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (OrganizationAddress) ApiClient.Deserialize(response.Content, typeof(OrganizationAddress), response.Headers);
        }
    
        /// <summary>
        /// Retrieve billing address 
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>OrganizationAddress</returns>            
        public OrganizationAddress FindOrganizationBillingAddress (long? organizationId, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling FindOrganizationBillingAddress");
            
    
            var path = "/api/v1/organizations/{organizationId}/addresses/billing";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling FindOrganizationBillingAddress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FindOrganizationBillingAddress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (OrganizationAddress) ApiClient.Deserialize(response.Content, typeof(OrganizationAddress), response.Headers);
        }
    
        /// <summary>
        /// Get collections of organization Retrieving all collections of an organization in a paginated manner.
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="offset">Start with the n-th element</param> 
        /// <param name="limit">The maximum count of returned elements</param> 
        /// <param name="type">Filter by this type</param> 
        /// <param name="label">Filter by this label</param> 
        /// <param name="labelPrefix">Filter by this label prefix</param> 
        /// <returns>PaginatedGuidCollection</returns>            
        public PaginatedGuidCollection GetAllCollectionsOfOrganization (long? organizationId, string authorization, string acceptLanguage, int? offset, int? limit, string type, string label, string labelPrefix)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling GetAllCollectionsOfOrganization");
            
    
            var path = "/api/v1/organizations/{organizationId}/collections";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
 if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
 if (labelPrefix != null) queryParams.Add("labelPrefix", ApiClient.ParameterToString(labelPrefix)); // query parameter
             if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAllCollectionsOfOrganization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAllCollectionsOfOrganization: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaginatedGuidCollection) ApiClient.Deserialize(response.Content, typeof(PaginatedGuidCollection), response.Headers);
        }
    
        /// <summary>
        /// List users and their roles Listing users and their roles in a paginated manner.
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="offset">Start with the n-th element</param> 
        /// <param name="limit">The maximum count of returned elements</param> 
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
        /// <param name="offset">Start with the n-th element</param> 
        /// <param name="limit">The maximum count of returned elements</param> 
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
        /// <param name="offset">Start with the n-th element</param> 
        /// <param name="limit">The maximum count of returned elements</param> 
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
        /// <param name="offset">Start with the n-th element</param> 
        /// <param name="limit">The maximum count of returned elements</param> 
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
        /// List countries 
        /// </summary>
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="offset">Start with the n-th element</param> 
        /// <param name="limit">The maximum count of returned elements</param> 
        /// <returns>PaginatedCountryResponse</returns>            
        public PaginatedCountryResponse ListCountries (string authorization, string acceptLanguage, int? offset, int? limit)
        {
            
    
            var path = "/api/v1/countries";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListCountries: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListCountries: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaginatedCountryResponse) ApiClient.Deserialize(response.Content, typeof(PaginatedCountryResponse), response.Headers);
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
        /// Update organization 
        /// </summary>
        /// <param name="organizationId">The id of the organization to be updated.</param> 
        /// <param name="organization">Updated organization object</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>Organization</returns>            
        public Organization UpdateOrganization (long? organizationId, Organization organization, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling UpdateOrganization");
            
            // verify the required parameter 'organization' is set
            if (organization == null) throw new ApiException(400, "Missing required parameter 'organization' when calling UpdateOrganization");
            
    
            var path = "/api/v1/organizations/{organizationId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(organization); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganization: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Organization) ApiClient.Deserialize(response.Content, typeof(Organization), response.Headers);
        }
    
        /// <summary>
        /// Store address 
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="addressResource">addressResource</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>OrganizationAddress</returns>            
        public OrganizationAddress UpdateOrganizationAddress (long? organizationId, OrganizationAddress addressResource, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling UpdateOrganizationAddress");
            
            // verify the required parameter 'addressResource' is set
            if (addressResource == null) throw new ApiException(400, "Missing required parameter 'addressResource' when calling UpdateOrganizationAddress");
            
    
            var path = "/api/v1/organizations/{organizationId}/addresses/default";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(addressResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationAddress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationAddress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (OrganizationAddress) ApiClient.Deserialize(response.Content, typeof(OrganizationAddress), response.Headers);
        }
    
        /// <summary>
        /// Store billing address 
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="addressResource">addressResource</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>OrganizationAddress</returns>            
        public OrganizationAddress UpdateOrganizationBillingAddress (long? organizationId, OrganizationAddress addressResource, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling UpdateOrganizationBillingAddress");
            
            // verify the required parameter 'addressResource' is set
            if (addressResource == null) throw new ApiException(400, "Missing required parameter 'addressResource' when calling UpdateOrganizationBillingAddress");
            
    
            var path = "/api/v1/organizations/{organizationId}/addresses/billing";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(addressResource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationBillingAddress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationBillingAddress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (OrganizationAddress) ApiClient.Deserialize(response.Content, typeof(OrganizationAddress), response.Headers);
        }
    
        /// <summary>
        /// Update organization logo Updating an organization logo using a multipart file upload.
        /// </summary>
        /// <param name="organizationId">The id of the organization where the logo should be updated.</param> 
        /// <param name="file">An image containing the new logo.</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiError</returns>            
        public ApiError UpdateOrganizationLogo (long? organizationId, System.IO.Stream file, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling UpdateOrganizationLogo");
            
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling UpdateOrganizationLogo");
            
    
            var path = "/api/v1/organizations/{organizationId}/logo";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
            if (file != null) fileParams.Add("file", ApiClient.ParameterToFile("file", file));
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationLogo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationLogo: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiError) ApiClient.Deserialize(response.Content, typeof(ApiError), response.Headers);
        }
    
    }
}
