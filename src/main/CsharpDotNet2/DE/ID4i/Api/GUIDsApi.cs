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
    public interface IGUIDsApi
    {
        /// <summary>
        /// Add alias for GUIDs Adds or replaces aliases for single GUIDs (alias type item and mapp) or groups of GUIDs (alias types gtin, ean and article)
        /// </summary>
        /// <param name="id4n">The GUID to operate on</param>
        /// <param name="aliasType">Alias type, see the corresponding API model</param>
        /// <param name="alias">The alias to add or update</param>
        /// <param name="authorization">Authorization JWT Bearer Token as returned from /login</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiError</returns>
        ApiError AddGuidAlias (string id4n, string aliasType, GuidAlias alias, string authorization, string acceptLanguage);
        /// <summary>
        /// Remove aliases from GUIDs Remove the alias of the given type
        /// </summary>
        /// <param name="id4n">The GUID to operate on</param>
        /// <param name="aliasType">Alias type, see the corresponding API model</param>
        /// <param name="authorization">Authorization JWT Bearer Token as returned from /login</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiError</returns>
        ApiError AddGuidAlias1 (string id4n, string aliasType, string authorization, string acceptLanguage);
        /// <summary>
        /// Create GUID(s) Creating one or more GUIDs with a specified length.
        /// </summary>
        /// <param name="createGUIDInfo">createGUIDInfo</param>
        /// <param name="authorization">Authorization JWT Bearer Token as returned from /login</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ListOfId4ns</returns>
        ListOfId4ns CreateGuid (CreateGuidRequest createGUIDInfo, string authorization, string acceptLanguage);
        /// <summary>
        /// Retrieve GUID information 
        /// </summary>
        /// <param name="id4n">The GUID number</param>
        /// <param name="authorization">Authorization JWT Bearer Token as returned from /login</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>Guid</returns>
        Guid GetGuid (string id4n, string authorization, string acceptLanguage);
        /// <summary>
        /// Get all aliases for the given GUID Looks up the alias for each alias type (group and single GUID) and returns all found ones
        /// </summary>
        /// <param name="id4n">The GUID to operate on</param>
        /// <param name="authorization">Authorization JWT Bearer Token as returned from /login</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>Dictionary&lt;string, string&gt;</returns>
        Dictionary<string, string> GetGuidAliases (string id4n, string authorization, string acceptLanguage);
        /// <summary>
        /// Retrieve GUIDs not in any collection 
        /// </summary>
        /// <param name="organizationId">Organization to search GUIDs for (required).</param>
        /// <param name="authorization">Authorization JWT Bearer Token as returned from /login</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="offset">Start with the n-th element. </param>
        /// <param name="limit">The maximum count of returned elements.</param>
        /// <returns>PaginatedResponseGuid</returns>
        PaginatedResponseGuid GetGuidsWithoutCollection (long? organizationId, string authorization, string acceptLanguage, int? offset, int? limit);
        /// <summary>
        /// Change GUID information. Allows ownership transfer.
        /// </summary>
        /// <param name="id4n">The GUID number</param>
        /// <param name="request">request</param>
        /// <param name="authorization">Authorization JWT Bearer Token as returned from /login</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>Object</returns>
        Object UpdateGuid (string id4n, Guid request, string authorization, string acceptLanguage);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GUIDsApi : IGUIDsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GUIDsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public GUIDsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GUIDsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GUIDsApi(String basePath)
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
        /// Add alias for GUIDs Adds or replaces aliases for single GUIDs (alias type item and mapp) or groups of GUIDs (alias types gtin, ean and article)
        /// </summary>
        /// <param name="id4n">The GUID to operate on</param> 
        /// <param name="aliasType">Alias type, see the corresponding API model</param> 
        /// <param name="alias">The alias to add or update</param> 
        /// <param name="authorization">Authorization JWT Bearer Token as returned from /login</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiError</returns>            
        public ApiError AddGuidAlias (string id4n, string aliasType, GuidAlias alias, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling AddGuidAlias");
            
            // verify the required parameter 'aliasType' is set
            if (aliasType == null) throw new ApiException(400, "Missing required parameter 'aliasType' when calling AddGuidAlias");
            
            // verify the required parameter 'alias' is set
            if (alias == null) throw new ApiException(400, "Missing required parameter 'alias' when calling AddGuidAlias");
            
    
            var path = "/api/v1/guids/{id4n}/alias/{aliasType}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
path = path.Replace("{" + "aliasType" + "}", ApiClient.ParameterToString(aliasType));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(alias); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddGuidAlias: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddGuidAlias: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiError) ApiClient.Deserialize(response.Content, typeof(ApiError), response.Headers);
        }
    
        /// <summary>
        /// Remove aliases from GUIDs Remove the alias of the given type
        /// </summary>
        /// <param name="id4n">The GUID to operate on</param> 
        /// <param name="aliasType">Alias type, see the corresponding API model</param> 
        /// <param name="authorization">Authorization JWT Bearer Token as returned from /login</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiError</returns>            
        public ApiError AddGuidAlias1 (string id4n, string aliasType, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling AddGuidAlias1");
            
            // verify the required parameter 'aliasType' is set
            if (aliasType == null) throw new ApiException(400, "Missing required parameter 'aliasType' when calling AddGuidAlias1");
            
    
            var path = "/api/v1/guids/{id4n}/alias/{aliasType}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
path = path.Replace("{" + "aliasType" + "}", ApiClient.ParameterToString(aliasType));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddGuidAlias1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddGuidAlias1: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiError) ApiClient.Deserialize(response.Content, typeof(ApiError), response.Headers);
        }
    
        /// <summary>
        /// Create GUID(s) Creating one or more GUIDs with a specified length.
        /// </summary>
        /// <param name="createGUIDInfo">createGUIDInfo</param> 
        /// <param name="authorization">Authorization JWT Bearer Token as returned from /login</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ListOfId4ns</returns>            
        public ListOfId4ns CreateGuid (CreateGuidRequest createGUIDInfo, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'createGUIDInfo' is set
            if (createGUIDInfo == null) throw new ApiException(400, "Missing required parameter 'createGUIDInfo' when calling CreateGuid");
            
    
            var path = "/api/v1/guids";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(createGUIDInfo); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateGuid: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateGuid: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ListOfId4ns) ApiClient.Deserialize(response.Content, typeof(ListOfId4ns), response.Headers);
        }
    
        /// <summary>
        /// Retrieve GUID information 
        /// </summary>
        /// <param name="id4n">The GUID number</param> 
        /// <param name="authorization">Authorization JWT Bearer Token as returned from /login</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>Guid</returns>            
        public Guid GetGuid (string id4n, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling GetGuid");
            
    
            var path = "/api/v1/guids/{id4n}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetGuid: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGuid: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Guid) ApiClient.Deserialize(response.Content, typeof(Guid), response.Headers);
        }
    
        /// <summary>
        /// Get all aliases for the given GUID Looks up the alias for each alias type (group and single GUID) and returns all found ones
        /// </summary>
        /// <param name="id4n">The GUID to operate on</param> 
        /// <param name="authorization">Authorization JWT Bearer Token as returned from /login</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>Dictionary&lt;string, string&gt;</returns>            
        public Dictionary<string, string> GetGuidAliases (string id4n, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling GetGuidAliases");
            
    
            var path = "/api/v1/guids/{id4n}/alias";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetGuidAliases: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGuidAliases: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Dictionary<string, string>) ApiClient.Deserialize(response.Content, typeof(Dictionary<string, string>), response.Headers);
        }
    
        /// <summary>
        /// Retrieve GUIDs not in any collection 
        /// </summary>
        /// <param name="organizationId">Organization to search GUIDs for (required).</param> 
        /// <param name="authorization">Authorization JWT Bearer Token as returned from /login</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="offset">Start with the n-th element. </param> 
        /// <param name="limit">The maximum count of returned elements.</param> 
        /// <returns>PaginatedResponseGuid</returns>            
        public PaginatedResponseGuid GetGuidsWithoutCollection (long? organizationId, string authorization, string acceptLanguage, int? offset, int? limit)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling GetGuidsWithoutCollection");
            
    
            var path = "/api/v1/guids/withoutCollection";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetGuidsWithoutCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGuidsWithoutCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaginatedResponseGuid) ApiClient.Deserialize(response.Content, typeof(PaginatedResponseGuid), response.Headers);
        }
    
        /// <summary>
        /// Change GUID information. Allows ownership transfer.
        /// </summary>
        /// <param name="id4n">The GUID number</param> 
        /// <param name="request">request</param> 
        /// <param name="authorization">Authorization JWT Bearer Token as returned from /login</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>Object</returns>            
        public Object UpdateGuid (string id4n, Guid request, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling UpdateGuid");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling UpdateGuid");
            
    
            var path = "/api/v1/guids/{id4n}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(request); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateGuid: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateGuid: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
    }
}
