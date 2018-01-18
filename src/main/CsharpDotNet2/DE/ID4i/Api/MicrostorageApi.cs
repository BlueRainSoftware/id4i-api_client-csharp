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
    public interface IMicrostorageApi
    {
        /// <summary>
        /// Read data from microstorage 
        /// </summary>
        /// <param name="organization">organization</param>
        /// <param name="id4n">id4n</param>
        /// <param name="authorization">Authorization JWT Bearer Token as returned from /login</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>InputStreamResource</returns>
        InputStreamResource Read (long? organization, string id4n, string authorization, string acceptLanguage);
        /// <summary>
        /// Write data to microstorage 
        /// </summary>
        /// <param name="organization">organization</param>
        /// <param name="id4n">id4n</param>
        /// <param name="authorization">Authorization JWT Bearer Token as returned from /login</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="contentType">Content-Type</param>
        /// <param name="contentLength">Content-Length</param>
        /// <returns>Object</returns>
        Object Write (long? organization, string id4n, string authorization, string acceptLanguage, string contentType, long? contentLength);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MicrostorageApi : IMicrostorageApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MicrostorageApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MicrostorageApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MicrostorageApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MicrostorageApi(String basePath)
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
        /// Read data from microstorage 
        /// </summary>
        /// <param name="organization">organization</param> 
        /// <param name="id4n">id4n</param> 
        /// <param name="authorization">Authorization JWT Bearer Token as returned from /login</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>InputStreamResource</returns>            
        public InputStreamResource Read (long? organization, string id4n, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'organization' is set
            if (organization == null) throw new ApiException(400, "Missing required parameter 'organization' when calling Read");
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling Read");
            
    
            var path = "/api/v1/microstorage/{id4n}/{organization}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organization" + "}", ApiClient.ParameterToString(organization));
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
                throw new ApiException ((int)response.StatusCode, "Error calling Read: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Read: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InputStreamResource) ApiClient.Deserialize(response.Content, typeof(InputStreamResource), response.Headers);
        }
    
        /// <summary>
        /// Write data to microstorage 
        /// </summary>
        /// <param name="organization">organization</param> 
        /// <param name="id4n">id4n</param> 
        /// <param name="authorization">Authorization JWT Bearer Token as returned from /login</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="contentType">Content-Type</param> 
        /// <param name="contentLength">Content-Length</param> 
        /// <returns>Object</returns>            
        public Object Write (long? organization, string id4n, string authorization, string acceptLanguage, string contentType, long? contentLength)
        {
            
            // verify the required parameter 'organization' is set
            if (organization == null) throw new ApiException(400, "Missing required parameter 'organization' when calling Write");
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling Write");
            
    
            var path = "/api/v1/microstorage/{id4n}/{organization}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organization" + "}", ApiClient.ParameterToString(organization));
path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
 if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
 if (contentLength != null) headerParams.Add("Content-Length", ApiClient.ParameterToString(contentLength)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Write: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Write: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
    }
}
