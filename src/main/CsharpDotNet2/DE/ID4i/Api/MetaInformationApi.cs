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
    public interface IMetaInformationApi
    {
        /// <summary>
        /// Retrieve version information about ID4i Retrieving version information about ID4i.
        /// </summary>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>AppInfoPresentation</returns>
        AppInfoPresentation ApplicationInfo (string authorization, string acceptLanguage);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MetaInformationApi : IMetaInformationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetaInformationApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MetaInformationApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MetaInformationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MetaInformationApi(String basePath)
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
        /// Retrieve version information about ID4i Retrieving version information about ID4i.
        /// </summary>
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>AppInfoPresentation</returns>            
        public AppInfoPresentation ApplicationInfo (string authorization, string acceptLanguage)
        {
            
    
            var path = "/api/v1/info";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling ApplicationInfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApplicationInfo: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AppInfoPresentation) ApiClient.Deserialize(response.Content, typeof(AppInfoPresentation), response.Headers);
        }
    
    }
}
