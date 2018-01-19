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
    public interface IRoutingApi
    {
        /// <summary>
        /// Retrieve current route of a GUID (or ID4N) 
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="type">The type of route you want to have</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="privateRoutes">privateRoutes</param>
        /// <param name="publicRoutes">publicRoutes</param>
        /// <returns>Route</returns>
        Route GetRoute (string id4n, string type, string authorization, string acceptLanguage, bool? privateRoutes, bool? publicRoutes);
        /// <summary>
        /// Retrieve routing file 
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="organizationId">organizationId</param>
        /// <returns>RoutingFile</returns>
        RoutingFile GetRoutingFile (string id4n, string authorization, string acceptLanguage, long? organizationId);
        /// <summary>
        /// Store routing file 
        /// </summary>
        /// <param name="rfr">rfr</param>
        /// <param name="id4n">id4n</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiError</returns>
        ApiError UpdateRoutingFile (RoutingFileRequest rfr, string id4n, string authorization, string acceptLanguage);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RoutingApi : IRoutingApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RoutingApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RoutingApi(String basePath)
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
        /// Retrieve current route of a GUID (or ID4N) 
        /// </summary>
        /// <param name="id4n">id4n</param> 
        /// <param name="type">The type of route you want to have</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="privateRoutes">privateRoutes</param> 
        /// <param name="publicRoutes">publicRoutes</param> 
        /// <returns>Route</returns>            
        public Route GetRoute (string id4n, string type, string authorization, string acceptLanguage, bool? privateRoutes, bool? publicRoutes)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling GetRoute");
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling GetRoute");
            
    
            var path = "/api/v1/routingfiles/{id4n}/route/{type}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (privateRoutes != null) queryParams.Add("privateRoutes", ApiClient.ParameterToString(privateRoutes)); // query parameter
 if (publicRoutes != null) queryParams.Add("publicRoutes", ApiClient.ParameterToString(publicRoutes)); // query parameter
             if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRoute: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRoute: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Route) ApiClient.Deserialize(response.Content, typeof(Route), response.Headers);
        }
    
        /// <summary>
        /// Retrieve routing file 
        /// </summary>
        /// <param name="id4n">id4n</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="organizationId">organizationId</param> 
        /// <returns>RoutingFile</returns>            
        public RoutingFile GetRoutingFile (string id4n, string authorization, string acceptLanguage, long? organizationId)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling GetRoutingFile");
            
    
            var path = "/api/v1/routingfiles/{id4n}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(organizationId); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRoutingFile: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRoutingFile: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RoutingFile) ApiClient.Deserialize(response.Content, typeof(RoutingFile), response.Headers);
        }
    
        /// <summary>
        /// Store routing file 
        /// </summary>
        /// <param name="rfr">rfr</param> 
        /// <param name="id4n">id4n</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiError</returns>            
        public ApiError UpdateRoutingFile (RoutingFileRequest rfr, string id4n, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'rfr' is set
            if (rfr == null) throw new ApiException(400, "Missing required parameter 'rfr' when calling UpdateRoutingFile");
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling UpdateRoutingFile");
            
    
            var path = "/api/v1/routingfiles/{id4n}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(rfr); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateRoutingFile: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateRoutingFile: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiError) ApiClient.Deserialize(response.Content, typeof(ApiError), response.Headers);
        }
    
    }
}
