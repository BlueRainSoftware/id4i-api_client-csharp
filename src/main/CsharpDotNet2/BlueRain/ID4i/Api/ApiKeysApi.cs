using System;
using System.Collections.Generic;
using RestSharp;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;
using Guid = BlueRain.ID4i.Model.Guid;

namespace BlueRain.ID4i.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IApiKeysApi
    {
        /// <summary>
        /// Add privilege 
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="addApiKeyPrivilegeRequest">addApiKeyPrivilegeRequest</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiError</returns>
        ApiError AddApiKeyPrivilege (string key, AddApiKeyPrivilegeRequest addApiKeyPrivilegeRequest, string authorization, string acceptLanguage);
        /// <summary>
        /// Add ID4ns of a privilege 
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="privilege">privilege</param>
        /// <param name="id4ns">id4ns</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiError</returns>
        ApiError AddApiKeyPrivilegeForId4ns (string key, string privilege, ListOfId4ns id4ns, string authorization, string acceptLanguage);
        /// <summary>
        /// Create API key Creation of a new API key.
        /// </summary>
        /// <param name="creationRequest">API key to be created.</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiKeyPresentation</returns>
        ApiKeyPresentation CreateNewApiKey (ApiKeyCreationRequest creationRequest, string authorization, string acceptLanguage);
        /// <summary>
        /// Delete API key Deletion of an API key.
        /// </summary>
        /// <param name="key">The API key to delete.</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiError</returns>
        ApiError DeleteApiKey (string key, string authorization, string acceptLanguage);
        /// <summary>
        /// Show API key Showing the details of an API key.
        /// </summary>
        /// <param name="key">The API key to show.</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiKeyPresentation</returns>
        ApiKeyPresentation GetApiKey (string key, string authorization, string acceptLanguage);
        /// <summary>
        /// List all privileges Listing all possible API key privileges.
        /// </summary>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="id4nConcerning">id4nConcerning</param>
        /// <param name="offset">Start with the n-th element</param>
        /// <param name="limit">The maximum count of returned elements</param>
        /// <returns>ApiKeyPrivilegeInfoResponse</returns>
        ApiKeyPrivilegeInfoResponse ListAllApiKeyPrivileges (string authorization, string acceptLanguage, bool? id4nConcerning, int? offset, int? limit);
        /// <summary>
        /// Find API key by organization Finding all API key assigned to the specified organization in a paginated manner.
        /// </summary>
        /// <param name="organizationId">The id of the organization to search in.</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="offset">Start with the n-th element</param>
        /// <param name="limit">The maximum count of returned elements</param>
        /// <returns>PaginatedApiKeyResponse</returns>
        PaginatedApiKeyResponse ListAllApiKeysOfOrganization (long? organizationId, string authorization, string acceptLanguage, int? offset, int? limit);
        /// <summary>
        /// List privileges 
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="offset">Start with the n-th element</param>
        /// <param name="limit">The maximum count of returned elements</param>
        /// <returns>ApiKeyPrivilegePaginatedResponse</returns>
        ApiKeyPrivilegePaginatedResponse ListApiKeyPrivileges (string key, string authorization, string acceptLanguage, int? offset, int? limit);
        /// <summary>
        /// ID4ns of a privilege Listing ID4ns of a id4n concerning privilege
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="privilege">privilege</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="offset">Start with the n-th element</param>
        /// <param name="limit">The maximum count of returned elements</param>
        /// <returns>Id4nPresentationPaginatedResponse</returns>
        Id4nPresentationPaginatedResponse ListId4ns (string key, string privilege, string authorization, string acceptLanguage, int? offset, int? limit);
        /// <summary>
        /// Remove privilege 
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="removeApiKeyPrivilegeRequest">removeApiKeyPrivilegeRequest</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiError</returns>
        ApiError RemoveApiKeyPrivilege (string key, RemoveApiKeyPrivilegeRequest removeApiKeyPrivilegeRequest, string authorization, string acceptLanguage);
        /// <summary>
        /// Remove id4ns of a privilege 
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="privilege">privilege</param>
        /// <param name="id4ns">id4ns</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiError</returns>
        ApiError RemoveApiKeyPrivilegeForId4ns (string key, string privilege, ListOfId4ns id4ns, string authorization, string acceptLanguage);
        /// <summary>
        /// Update API keys API keys can be updated with new labels, and be activated and deactivated. The secret or UUID cannot be changed.
        /// </summary>
        /// <param name="key">The API key to be updated.</param>
        /// <param name="apiKeyChange">The new values to apply.</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiError</returns>
        ApiError UpdateApiKey (string key, ApiKeyChangeRequest apiKeyChange, string authorization, string acceptLanguage);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ApiKeysApi : IApiKeysApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeysApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ApiKeysApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeysApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ApiKeysApi(String basePath)
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
        /// Add privilege 
        /// </summary>
        /// <param name="key">key</param> 
        /// <param name="addApiKeyPrivilegeRequest">addApiKeyPrivilegeRequest</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiError</returns>            
        public ApiError AddApiKeyPrivilege (string key, AddApiKeyPrivilegeRequest addApiKeyPrivilegeRequest, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddApiKeyPrivilege");
            
            // verify the required parameter 'addApiKeyPrivilegeRequest' is set
            if (addApiKeyPrivilegeRequest == null) throw new ApiException(400, "Missing required parameter 'addApiKeyPrivilegeRequest' when calling AddApiKeyPrivilege");
            
    
            var path = "/api/v1/apikeys/{key}/privileges";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "key" + "}", ApiClient.ParameterToString(key));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(addApiKeyPrivilegeRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddApiKeyPrivilege: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddApiKeyPrivilege: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiError) ApiClient.Deserialize(response.Content, typeof(ApiError), response.Headers);
        }
    
        /// <summary>
        /// Add ID4ns of a privilege 
        /// </summary>
        /// <param name="key">key</param> 
        /// <param name="privilege">privilege</param> 
        /// <param name="id4ns">id4ns</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiError</returns>            
        public ApiError AddApiKeyPrivilegeForId4ns (string key, string privilege, ListOfId4ns id4ns, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddApiKeyPrivilegeForId4ns");
            
            // verify the required parameter 'privilege' is set
            if (privilege == null) throw new ApiException(400, "Missing required parameter 'privilege' when calling AddApiKeyPrivilegeForId4ns");
            
            // verify the required parameter 'id4ns' is set
            if (id4ns == null) throw new ApiException(400, "Missing required parameter 'id4ns' when calling AddApiKeyPrivilegeForId4ns");
            
    
            var path = "/api/v1/apikeys/{key}/privileges/{privilege}/id4ns";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "key" + "}", ApiClient.ParameterToString(key));
path = path.Replace("{" + "privilege" + "}", ApiClient.ParameterToString(privilege));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(id4ns); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddApiKeyPrivilegeForId4ns: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddApiKeyPrivilegeForId4ns: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiError) ApiClient.Deserialize(response.Content, typeof(ApiError), response.Headers);
        }
    
        /// <summary>
        /// Create API key Creation of a new API key.
        /// </summary>
        /// <param name="creationRequest">API key to be created.</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiKeyPresentation</returns>            
        public ApiKeyPresentation CreateNewApiKey (ApiKeyCreationRequest creationRequest, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'creationRequest' is set
            if (creationRequest == null) throw new ApiException(400, "Missing required parameter 'creationRequest' when calling CreateNewApiKey");
            
    
            var path = "/api/v1/apikeys";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(creationRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNewApiKey: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateNewApiKey: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiKeyPresentation) ApiClient.Deserialize(response.Content, typeof(ApiKeyPresentation), response.Headers);
        }
    
        /// <summary>
        /// Delete API key Deletion of an API key.
        /// </summary>
        /// <param name="key">The API key to delete.</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiError</returns>            
        public ApiError DeleteApiKey (string key, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling DeleteApiKey");
            
    
            var path = "/api/v1/apikeys/{key}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "key" + "}", ApiClient.ParameterToString(key));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteApiKey: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteApiKey: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiError) ApiClient.Deserialize(response.Content, typeof(ApiError), response.Headers);
        }
    
        /// <summary>
        /// Show API key Showing the details of an API key.
        /// </summary>
        /// <param name="key">The API key to show.</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiKeyPresentation</returns>            
        public ApiKeyPresentation GetApiKey (string key, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetApiKey");
            
    
            var path = "/api/v1/apikeys/{key}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "key" + "}", ApiClient.ParameterToString(key));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetApiKey: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetApiKey: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiKeyPresentation) ApiClient.Deserialize(response.Content, typeof(ApiKeyPresentation), response.Headers);
        }
    
        /// <summary>
        /// List all privileges Listing all possible API key privileges.
        /// </summary>
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="id4nConcerning">id4nConcerning</param> 
        /// <param name="offset">Start with the n-th element</param> 
        /// <param name="limit">The maximum count of returned elements</param> 
        /// <returns>ApiKeyPrivilegeInfoResponse</returns>            
        public ApiKeyPrivilegeInfoResponse ListAllApiKeyPrivileges (string authorization, string acceptLanguage, bool? id4nConcerning, int? offset, int? limit)
        {
            
    
            var path = "/api/v1/apikeys/privileges";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (id4nConcerning != null) queryParams.Add("id4nConcerning", ApiClient.ParameterToString(id4nConcerning)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
             if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAllApiKeyPrivileges: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAllApiKeyPrivileges: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiKeyPrivilegeInfoResponse) ApiClient.Deserialize(response.Content, typeof(ApiKeyPrivilegeInfoResponse), response.Headers);
        }
    
        /// <summary>
        /// Find API key by organization Finding all API key assigned to the specified organization in a paginated manner.
        /// </summary>
        /// <param name="organizationId">The id of the organization to search in.</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="offset">Start with the n-th element</param> 
        /// <param name="limit">The maximum count of returned elements</param> 
        /// <returns>PaginatedApiKeyResponse</returns>            
        public PaginatedApiKeyResponse ListAllApiKeysOfOrganization (long? organizationId, string authorization, string acceptLanguage, int? offset, int? limit)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling ListAllApiKeysOfOrganization");
            
    
            var path = "/api/v1/apikeys";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (organizationId != null) queryParams.Add("organizationId", ApiClient.ParameterToString(organizationId)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
             if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAllApiKeysOfOrganization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAllApiKeysOfOrganization: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaginatedApiKeyResponse) ApiClient.Deserialize(response.Content, typeof(PaginatedApiKeyResponse), response.Headers);
        }
    
        /// <summary>
        /// List privileges 
        /// </summary>
        /// <param name="key">key</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="offset">Start with the n-th element</param> 
        /// <param name="limit">The maximum count of returned elements</param> 
        /// <returns>ApiKeyPrivilegePaginatedResponse</returns>            
        public ApiKeyPrivilegePaginatedResponse ListApiKeyPrivileges (string key, string authorization, string acceptLanguage, int? offset, int? limit)
        {
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling ListApiKeyPrivileges");
            
    
            var path = "/api/v1/apikeys/{key}/privileges";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "key" + "}", ApiClient.ParameterToString(key));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListApiKeyPrivileges: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListApiKeyPrivileges: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiKeyPrivilegePaginatedResponse) ApiClient.Deserialize(response.Content, typeof(ApiKeyPrivilegePaginatedResponse), response.Headers);
        }
    
        /// <summary>
        /// ID4ns of a privilege Listing ID4ns of a id4n concerning privilege
        /// </summary>
        /// <param name="key">key</param> 
        /// <param name="privilege">privilege</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="offset">Start with the n-th element</param> 
        /// <param name="limit">The maximum count of returned elements</param> 
        /// <returns>Id4nPresentationPaginatedResponse</returns>            
        public Id4nPresentationPaginatedResponse ListId4ns (string key, string privilege, string authorization, string acceptLanguage, int? offset, int? limit)
        {
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling ListId4ns");
            
            // verify the required parameter 'privilege' is set
            if (privilege == null) throw new ApiException(400, "Missing required parameter 'privilege' when calling ListId4ns");
            
    
            var path = "/api/v1/apikeys/{key}/privileges/{privilege}/id4ns";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "key" + "}", ApiClient.ParameterToString(key));
path = path.Replace("{" + "privilege" + "}", ApiClient.ParameterToString(privilege));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListId4ns: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListId4ns: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Id4nPresentationPaginatedResponse) ApiClient.Deserialize(response.Content, typeof(Id4nPresentationPaginatedResponse), response.Headers);
        }
    
        /// <summary>
        /// Remove privilege 
        /// </summary>
        /// <param name="key">key</param> 
        /// <param name="removeApiKeyPrivilegeRequest">removeApiKeyPrivilegeRequest</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiError</returns>            
        public ApiError RemoveApiKeyPrivilege (string key, RemoveApiKeyPrivilegeRequest removeApiKeyPrivilegeRequest, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling RemoveApiKeyPrivilege");
            
            // verify the required parameter 'removeApiKeyPrivilegeRequest' is set
            if (removeApiKeyPrivilegeRequest == null) throw new ApiException(400, "Missing required parameter 'removeApiKeyPrivilegeRequest' when calling RemoveApiKeyPrivilege");
            
    
            var path = "/api/v1/apikeys/{key}/privileges";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "key" + "}", ApiClient.ParameterToString(key));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(removeApiKeyPrivilegeRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveApiKeyPrivilege: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveApiKeyPrivilege: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiError) ApiClient.Deserialize(response.Content, typeof(ApiError), response.Headers);
        }
    
        /// <summary>
        /// Remove id4ns of a privilege 
        /// </summary>
        /// <param name="key">key</param> 
        /// <param name="privilege">privilege</param> 
        /// <param name="id4ns">id4ns</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiError</returns>            
        public ApiError RemoveApiKeyPrivilegeForId4ns (string key, string privilege, ListOfId4ns id4ns, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling RemoveApiKeyPrivilegeForId4ns");
            
            // verify the required parameter 'privilege' is set
            if (privilege == null) throw new ApiException(400, "Missing required parameter 'privilege' when calling RemoveApiKeyPrivilegeForId4ns");
            
            // verify the required parameter 'id4ns' is set
            if (id4ns == null) throw new ApiException(400, "Missing required parameter 'id4ns' when calling RemoveApiKeyPrivilegeForId4ns");
            
    
            var path = "/api/v1/apikeys/{key}/privileges/{privilege}/id4ns";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "key" + "}", ApiClient.ParameterToString(key));
path = path.Replace("{" + "privilege" + "}", ApiClient.ParameterToString(privilege));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(id4ns); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveApiKeyPrivilegeForId4ns: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveApiKeyPrivilegeForId4ns: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiError) ApiClient.Deserialize(response.Content, typeof(ApiError), response.Headers);
        }
    
        /// <summary>
        /// Update API keys API keys can be updated with new labels, and be activated and deactivated. The secret or UUID cannot be changed.
        /// </summary>
        /// <param name="key">The API key to be updated.</param> 
        /// <param name="apiKeyChange">The new values to apply.</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiError</returns>            
        public ApiError UpdateApiKey (string key, ApiKeyChangeRequest apiKeyChange, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateApiKey");
            
            // verify the required parameter 'apiKeyChange' is set
            if (apiKeyChange == null) throw new ApiException(400, "Missing required parameter 'apiKeyChange' when calling UpdateApiKey");
            
    
            var path = "/api/v1/apikeys/{key}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "key" + "}", ApiClient.ParameterToString(key));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(apiKeyChange); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateApiKey: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateApiKey: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiError) ApiClient.Deserialize(response.Content, typeof(ApiError), response.Headers);
        }
    
    }
}
