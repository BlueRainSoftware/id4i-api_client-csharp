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
    public interface IAliasApi
    {
        /// <summary>
        /// Add alias for GUIDs Adds or replaces aliases for single GUIDs (alias type item and mapp) or groups of GUIDs (alias types gtin, ean and article)
        /// </summary>
        /// <param name="id4n">The GUID to operate on</param>
        /// <param name="aliasType">Alias type, see the corresponding API model</param>
        /// <param name="alias">The alias to add or update</param>
        /// <returns>ApiError</returns>
        ApiError AddGuidAlias (string id4n, string aliasType, GuidAlias alias);
        /// <summary>
        /// Remove aliases from GUIDs Remove the alias of the given type
        /// </summary>
        /// <param name="id4n">The GUID to operate on</param>
        /// <param name="aliasType">Alias type, see the corresponding API model</param>
        /// <returns>ApiError</returns>
        ApiError AddGuidAlias1 (string id4n, string aliasType);
        /// <summary>
        /// List all supported alias types Retrieve this list to find out all alias types to use with alias search and change operations
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetGuidAliasTypes ();
        /// <summary>
        /// Get all aliases for the given GUID Looks up the alias for each alias type (group and single GUID) and returns all found ones
        /// </summary>
        /// <param name="id4n">The GUID to operate on</param>
        /// <returns>Dictionary&lt;string, string&gt;</returns>
        Dictionary<string, string> GetGuidAliases (string id4n);
        /// <summary>
        /// Search for GUIDs by alias 
        /// </summary>
        /// <param name="alias">The alias to search for</param>
        /// <param name="aliasType">Alias type type to search for</param>
        /// <param name="offset">Start with the n-th element</param>
        /// <param name="limit">The maximum count of returned elements</param>
        /// <returns>PaginatedGuidResponse</returns>
        PaginatedGuidResponse SearchByAlias (string alias, string aliasType, int? offset, int? limit);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AliasApi : IAliasApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AliasApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AliasApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AliasApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AliasApi(String basePath)
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
        /// <returns>ApiError</returns>            
        public ApiError AddGuidAlias (string id4n, string aliasType, GuidAlias alias)
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
    
                                                postBody = ApiClient.Serialize(alias); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "Authorization" };
    
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
        /// <returns>ApiError</returns>            
        public ApiError AddGuidAlias1 (string id4n, string aliasType)
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
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Authorization" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddGuidAlias1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddGuidAlias1: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiError) ApiClient.Deserialize(response.Content, typeof(ApiError), response.Headers);
        }
    
        /// <summary>
        /// List all supported alias types Retrieve this list to find out all alias types to use with alias search and change operations
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>            
        public List<string> GetGuidAliasTypes ()
        {
            
    
            var path = "/api/v1/search/guids/aliases/types";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Authorization" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGuidAliasTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGuidAliasTypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
        /// <summary>
        /// Get all aliases for the given GUID Looks up the alias for each alias type (group and single GUID) and returns all found ones
        /// </summary>
        /// <param name="id4n">The GUID to operate on</param> 
        /// <returns>Dictionary&lt;string, string&gt;</returns>            
        public Dictionary<string, string> GetGuidAliases (string id4n)
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
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Authorization" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGuidAliases: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGuidAliases: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Dictionary<string, string>) ApiClient.Deserialize(response.Content, typeof(Dictionary<string, string>), response.Headers);
        }
    
        /// <summary>
        /// Search for GUIDs by alias 
        /// </summary>
        /// <param name="alias">The alias to search for</param> 
        /// <param name="aliasType">Alias type type to search for</param> 
        /// <param name="offset">Start with the n-th element</param> 
        /// <param name="limit">The maximum count of returned elements</param> 
        /// <returns>PaginatedGuidResponse</returns>            
        public PaginatedGuidResponse SearchByAlias (string alias, string aliasType, int? offset, int? limit)
        {
            
            // verify the required parameter 'alias' is set
            if (alias == null) throw new ApiException(400, "Missing required parameter 'alias' when calling SearchByAlias");
            
            // verify the required parameter 'aliasType' is set
            if (aliasType == null) throw new ApiException(400, "Missing required parameter 'aliasType' when calling SearchByAlias");
            
    
            var path = "/api/v1/search/guids";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (alias != null) queryParams.Add("alias", ApiClient.ParameterToString(alias)); // query parameter
 if (aliasType != null) queryParams.Add("aliasType", ApiClient.ParameterToString(aliasType)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "Authorization" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchByAlias: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchByAlias: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaginatedGuidResponse) ApiClient.Deserialize(response.Content, typeof(PaginatedGuidResponse), response.Headers);
        }
    
    }
}
