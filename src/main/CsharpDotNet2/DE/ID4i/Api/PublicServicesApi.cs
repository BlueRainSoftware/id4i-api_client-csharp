using System;
using System.Collections.Generic;
using RestSharp;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace DE.ID4i.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPublicServicesApi
    {
        /// <summary>
        /// Forward Forwarding to the designated route defined in the routing,
        /// </summary>
        /// <param name="guid">guid</param>
        /// <param name="authorization">Authorization JWT Bearer Token as returned from /login</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiError</returns>
        ApiError Go (string guid, string authorization, string acceptLanguage);
        /// <summary>
        /// Resolve image 
        /// </summary>
        /// <param name="imageID">The id of the image to be resolved.</param>
        /// <param name="authorization">Authorization JWT Bearer Token as returned from /login</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>byte[]</returns>
        byte[] ResolveImageUsingGET (string imageID, string authorization, string acceptLanguage);
        /// <summary>
        /// Resolve owner of id4n 
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="authorization">Authorization JWT Bearer Token as returned from /login</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>WhoIsResponse</returns>
        WhoIsResponse ResolveWhoIsEntry (string id4n, string authorization, string acceptLanguage);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PublicServicesApi : IPublicServicesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicServicesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PublicServicesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicServicesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PublicServicesApi(String basePath)
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
        /// Forward Forwarding to the designated route defined in the routing,
        /// </summary>
        /// <param name="guid">guid</param> 
        /// <param name="authorization">Authorization JWT Bearer Token as returned from /login</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiError</returns>            
        public ApiError Go (string guid, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'guid' is set
            if (guid == null) throw new ApiException(400, "Missing required parameter 'guid' when calling Go");
            
    
            var path = "/go/{guid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "guid" + "}", ApiClient.ParameterToString(guid));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling Go: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Go: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiError) ApiClient.Deserialize(response.Content, typeof(ApiError), response.Headers);
        }
    
        /// <summary>
        /// Resolve image 
        /// </summary>
        /// <param name="imageID">The id of the image to be resolved.</param> 
        /// <param name="authorization">Authorization JWT Bearer Token as returned from /login</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>byte[]</returns>            
        public byte[] ResolveImageUsingGET (string imageID, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'imageID' is set
            if (imageID == null) throw new ApiException(400, "Missing required parameter 'imageID' when calling ResolveImageUsingGET");
            
    
            var path = "/api/v1/public/image/{imageID}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "imageID" + "}", ApiClient.ParameterToString(imageID));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ResolveImageUsingGET: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ResolveImageUsingGET: " + response.ErrorMessage, response.ErrorMessage);
    
            return (byte[]) ApiClient.Deserialize(response.Content, typeof(byte[]), response.Headers);
        }
    
        /// <summary>
        /// Resolve owner of id4n 
        /// </summary>
        /// <param name="id4n">id4n</param> 
        /// <param name="authorization">Authorization JWT Bearer Token as returned from /login</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>WhoIsResponse</returns>            
        public WhoIsResponse ResolveWhoIsEntry (string id4n, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling ResolveWhoIsEntry");
            
    
            var path = "/whois/{id4n}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ResolveWhoIsEntry: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ResolveWhoIsEntry: " + response.ErrorMessage, response.ErrorMessage);
    
            return (WhoIsResponse) ApiClient.Deserialize(response.Content, typeof(WhoIsResponse), response.Headers);
        }
    
    }
}
