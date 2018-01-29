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
    public interface ICollectionsApi
    {
        /// <summary>
        /// Add elements to collection 
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="listOfGuids">listOfGuids</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiError</returns>
        ApiError AddElementsToCollection (string id4n, ListOfId4ns listOfGuids, string authorization, string acceptLanguage);
        /// <summary>
        /// Add elements to labelled collection 
        /// </summary>
        /// <param name="collectionId4n">collectionId4n</param>
        /// <param name="listOfGuids">listOfGuids</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiError</returns>
        ApiError AddElementsToLabelledCollection (string collectionId4n, ListOfId4ns listOfGuids, string authorization, string acceptLanguage);
        /// <summary>
        /// Add elements to logistic collection 
        /// </summary>
        /// <param name="collectionId4n">collectionId4n</param>
        /// <param name="listOfGuids">listOfGuids</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiError</returns>
        ApiError AddElementsToLogisticCollection (string collectionId4n, ListOfId4ns listOfGuids, string authorization, string acceptLanguage);
        /// <summary>
        /// Add element to routing collection 
        /// </summary>
        /// <param name="collectionId4n">collectionId4n</param>
        /// <param name="listOfGuids">listOfGuids</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiError</returns>
        ApiError AddElementsToRoutingCollection (string collectionId4n, ListOfId4ns listOfGuids, string authorization, string acceptLanguage);
        /// <summary>
        /// Create labelled collection 
        /// </summary>
        /// <param name="createInfo">createInfo</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>Id4n</returns>
        Id4n CreateLabelledCollection (CreateLabelledCollectionRequest createInfo, string authorization, string acceptLanguage);
        /// <summary>
        /// Create logistic collection 
        /// </summary>
        /// <param name="createInfo">createInfo</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>Id4n</returns>
        Id4n CreateLogisticCollection (CreateLogisticCollectionRequest createInfo, string authorization, string acceptLanguage);
        /// <summary>
        /// Create routing collecton 
        /// </summary>
        /// <param name="createInfo">createInfo</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>Id4n</returns>
        Id4n CreateRoutingCollection (CreateRoutingCollectionRequest createInfo, string authorization, string acceptLanguage);
        /// <summary>
        /// Delete collection 
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiError</returns>
        ApiError DeleteCollection (string id4n, string authorization, string acceptLanguage);
        /// <summary>
        /// Delete labelled collection 
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiError</returns>
        ApiError DeleteLabelledCollection (string id4n, string authorization, string acceptLanguage);
        /// <summary>
        /// Delete logistic collection 
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>Object</returns>
        Object DeleteLogisticCollection (string id4n, string authorization, string acceptLanguage);
        /// <summary>
        /// Delete routing collection 
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiError</returns>
        ApiError DeleteRoutingCollection (string id4n, string authorization, string acceptLanguage);
        /// <summary>
        /// Find collection 
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>GuidCollection</returns>
        GuidCollection FindCollection (string id4n, string authorization, string acceptLanguage);
        /// <summary>
        /// Find labelled collection 
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>GuidCollection</returns>
        GuidCollection FindLabelledCollection (string id4n, string authorization, string acceptLanguage);
        /// <summary>
        /// Find logistic collection 
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>GuidCollection</returns>
        GuidCollection FindLogisticCollection (string id4n, string authorization, string acceptLanguage);
        /// <summary>
        /// Find routing collection 
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>GuidCollection</returns>
        GuidCollection FindRoutingCollection (string id4n, string authorization, string acceptLanguage);
        /// <summary>
        /// Get collections of organization Retrieving all collections of an organization in a paginated manner.
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="offset">Start with the n-th element. </param>
        /// <param name="limit">The maximum count of returned elements.</param>
        /// <param name="type">Filter by this type</param>
        /// <param name="label">Filter by this label</param>
        /// <param name="labelPrefix">Filter by this label prefix</param>
        /// <returns>PaginatedGuidCollection</returns>
        PaginatedGuidCollection GetAllCollectionsOfOrganization (long? organizationId, string authorization, string acceptLanguage, int? offset, int? limit, string type, string label, string labelPrefix);
        /// <summary>
        /// List contents of the collection 
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="offset">Start with the n-th element. </param>
        /// <param name="limit">The maximum count of returned elements.</param>
        /// <returns>PaginatedGuidResponse</returns>
        PaginatedGuidResponse ListElementsOfCollection (string id4n, string authorization, string acceptLanguage, int? offset, int? limit);
        /// <summary>
        /// List contents of the collection 
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="offset">Start with the n-th element. </param>
        /// <param name="limit">The maximum count of returned elements.</param>
        /// <returns>PaginatedGuidResponse</returns>
        PaginatedGuidResponse ListElementsOfLabelledCollection (string id4n, string authorization, string acceptLanguage, int? offset, int? limit);
        /// <summary>
        /// List contents of the collection 
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="offset">Start with the n-th element. </param>
        /// <param name="limit">The maximum count of returned elements.</param>
        /// <returns>PaginatedGuidResponse</returns>
        PaginatedGuidResponse ListElementsOfLogisticCollection (string id4n, string authorization, string acceptLanguage, int? offset, int? limit);
        /// <summary>
        /// List contents of the collection 
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="offset">Start with the n-th element. </param>
        /// <param name="limit">The maximum count of returned elements.</param>
        /// <returns>PaginatedGuidResponse</returns>
        PaginatedGuidResponse ListElementsOfRoutingCollection (string id4n, string authorization, string acceptLanguage, int? offset, int? limit);
        /// <summary>
        /// Remove elements from collection 
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="listOfGuids">listOfGuids</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiError</returns>
        ApiError RemoveElementsFromCollection (string id4n, ListOfId4ns listOfGuids, string authorization, string acceptLanguage);
        /// <summary>
        /// Remove elements from labelled collection 
        /// </summary>
        /// <param name="collectionId4n">collectionId4n</param>
        /// <param name="listOfGuids">listOfGuids</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiError</returns>
        ApiError RemoveElementsFromLabelledCollection (string collectionId4n, ListOfId4ns listOfGuids, string authorization, string acceptLanguage);
        /// <summary>
        /// Remove elements from logistic collection 
        /// </summary>
        /// <param name="collectionId4n">collectionId4n</param>
        /// <param name="listOfGuids">listOfGuids</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiError</returns>
        ApiError RemoveElementsFromLogisticCollection (string collectionId4n, ListOfId4ns listOfGuids, string authorization, string acceptLanguage);
        /// <summary>
        /// Remove elements from routing collection 
        /// </summary>
        /// <param name="collectionId4n">collectionId4n</param>
        /// <param name="listOfGuids">listOfGuids</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>ApiError</returns>
        ApiError RemoveElementsFromRoutingCollection (string collectionId4n, ListOfId4ns listOfGuids, string authorization, string acceptLanguage);
        /// <summary>
        /// Set collection Update collection replacing all values but the ID
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="request">request</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>Object</returns>
        Object SetCollection (string id4n, GuidCollection request, string authorization, string acceptLanguage);
        /// <summary>
        /// Set labelled collection values Update labelled collection replacing all values but the ID
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="request">request</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>Object</returns>
        Object SetLabelledCollection (string id4n, GuidCollection request, string authorization, string acceptLanguage);
        /// <summary>
        /// Replace logistic collection Update logistic collection replacing all values but the ID
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="request">request</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>Object</returns>
        Object SetLogisticCollection (string id4n, GuidCollection request, string authorization, string acceptLanguage);
        /// <summary>
        /// Update routing collection 
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="request">request</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>Object</returns>
        Object SetRoutingCollection (string id4n, GuidCollection request, string authorization, string acceptLanguage);
        /// <summary>
        /// Update collection Update collection changing only the given values
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="request">request</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>Object</returns>
        Object UpdateCollection (string id4n, GuidCollection request, string authorization, string acceptLanguage);
        /// <summary>
        /// Update labelled collection Update labelled collection updating only the given values
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="request">request</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>Object</returns>
        Object UpdateLabelledCollection (string id4n, GuidCollection request, string authorization, string acceptLanguage);
        /// <summary>
        /// Update logistic collection Update logistic collection updating only the given values
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="request">request</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>Object</returns>
        Object UpdateLogisticCollection (string id4n, GuidCollection request, string authorization, string acceptLanguage);
        /// <summary>
        /// Update routing collection Update routing collection updating only the given values
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="request">request</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>Object</returns>
        Object UpdateRoutingCollection (string id4n, GuidCollection request, string authorization, string acceptLanguage);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CollectionsApi : ICollectionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CollectionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CollectionsApi(String basePath)
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
        /// Add elements to collection 
        /// </summary>
        /// <param name="id4n">id4n</param> 
        /// <param name="listOfGuids">listOfGuids</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiError</returns>            
        public ApiError AddElementsToCollection (string id4n, ListOfId4ns listOfGuids, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling AddElementsToCollection");
            
            // verify the required parameter 'listOfGuids' is set
            if (listOfGuids == null) throw new ApiException(400, "Missing required parameter 'listOfGuids' when calling AddElementsToCollection");
            
    
            var path = "/api/v1/collections/{id4n}/elements";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(listOfGuids); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddElementsToCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddElementsToCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiError) ApiClient.Deserialize(response.Content, typeof(ApiError), response.Headers);
        }
    
        /// <summary>
        /// Add elements to labelled collection 
        /// </summary>
        /// <param name="collectionId4n">collectionId4n</param> 
        /// <param name="listOfGuids">listOfGuids</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiError</returns>            
        public ApiError AddElementsToLabelledCollection (string collectionId4n, ListOfId4ns listOfGuids, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'collectionId4n' is set
            if (collectionId4n == null) throw new ApiException(400, "Missing required parameter 'collectionId4n' when calling AddElementsToLabelledCollection");
            
            // verify the required parameter 'listOfGuids' is set
            if (listOfGuids == null) throw new ApiException(400, "Missing required parameter 'listOfGuids' when calling AddElementsToLabelledCollection");
            
    
            var path = "/api/v1/collections/labelled/{collectionId4n}/elements";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "collectionId4n" + "}", ApiClient.ParameterToString(collectionId4n));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(listOfGuids); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddElementsToLabelledCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddElementsToLabelledCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiError) ApiClient.Deserialize(response.Content, typeof(ApiError), response.Headers);
        }
    
        /// <summary>
        /// Add elements to logistic collection 
        /// </summary>
        /// <param name="collectionId4n">collectionId4n</param> 
        /// <param name="listOfGuids">listOfGuids</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiError</returns>            
        public ApiError AddElementsToLogisticCollection (string collectionId4n, ListOfId4ns listOfGuids, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'collectionId4n' is set
            if (collectionId4n == null) throw new ApiException(400, "Missing required parameter 'collectionId4n' when calling AddElementsToLogisticCollection");
            
            // verify the required parameter 'listOfGuids' is set
            if (listOfGuids == null) throw new ApiException(400, "Missing required parameter 'listOfGuids' when calling AddElementsToLogisticCollection");
            
    
            var path = "/api/v1/collections/logistic/{collectionId4n}/elements";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "collectionId4n" + "}", ApiClient.ParameterToString(collectionId4n));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(listOfGuids); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddElementsToLogisticCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddElementsToLogisticCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiError) ApiClient.Deserialize(response.Content, typeof(ApiError), response.Headers);
        }
    
        /// <summary>
        /// Add element to routing collection 
        /// </summary>
        /// <param name="collectionId4n">collectionId4n</param> 
        /// <param name="listOfGuids">listOfGuids</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiError</returns>            
        public ApiError AddElementsToRoutingCollection (string collectionId4n, ListOfId4ns listOfGuids, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'collectionId4n' is set
            if (collectionId4n == null) throw new ApiException(400, "Missing required parameter 'collectionId4n' when calling AddElementsToRoutingCollection");
            
            // verify the required parameter 'listOfGuids' is set
            if (listOfGuids == null) throw new ApiException(400, "Missing required parameter 'listOfGuids' when calling AddElementsToRoutingCollection");
            
    
            var path = "/api/v1/collections/routing/{collectionId4n}/elements";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "collectionId4n" + "}", ApiClient.ParameterToString(collectionId4n));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(listOfGuids); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddElementsToRoutingCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddElementsToRoutingCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiError) ApiClient.Deserialize(response.Content, typeof(ApiError), response.Headers);
        }
    
        /// <summary>
        /// Create labelled collection 
        /// </summary>
        /// <param name="createInfo">createInfo</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>Id4n</returns>            
        public Id4n CreateLabelledCollection (CreateLabelledCollectionRequest createInfo, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'createInfo' is set
            if (createInfo == null) throw new ApiException(400, "Missing required parameter 'createInfo' when calling CreateLabelledCollection");
            
    
            var path = "/api/v1/collections/labelled";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(createInfo); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateLabelledCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateLabelledCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Id4n) ApiClient.Deserialize(response.Content, typeof(Id4n), response.Headers);
        }
    
        /// <summary>
        /// Create logistic collection 
        /// </summary>
        /// <param name="createInfo">createInfo</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>Id4n</returns>            
        public Id4n CreateLogisticCollection (CreateLogisticCollectionRequest createInfo, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'createInfo' is set
            if (createInfo == null) throw new ApiException(400, "Missing required parameter 'createInfo' when calling CreateLogisticCollection");
            
    
            var path = "/api/v1/collections/logistic";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(createInfo); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateLogisticCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateLogisticCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Id4n) ApiClient.Deserialize(response.Content, typeof(Id4n), response.Headers);
        }
    
        /// <summary>
        /// Create routing collecton 
        /// </summary>
        /// <param name="createInfo">createInfo</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>Id4n</returns>            
        public Id4n CreateRoutingCollection (CreateRoutingCollectionRequest createInfo, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'createInfo' is set
            if (createInfo == null) throw new ApiException(400, "Missing required parameter 'createInfo' when calling CreateRoutingCollection");
            
    
            var path = "/api/v1/collections/routing";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(createInfo); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateRoutingCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateRoutingCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Id4n) ApiClient.Deserialize(response.Content, typeof(Id4n), response.Headers);
        }
    
        /// <summary>
        /// Delete collection 
        /// </summary>
        /// <param name="id4n">id4n</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiError</returns>            
        public ApiError DeleteCollection (string id4n, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling DeleteCollection");
            
    
            var path = "/api/v1/collections/{id4n}";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiError) ApiClient.Deserialize(response.Content, typeof(ApiError), response.Headers);
        }
    
        /// <summary>
        /// Delete labelled collection 
        /// </summary>
        /// <param name="id4n">id4n</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiError</returns>            
        public ApiError DeleteLabelledCollection (string id4n, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling DeleteLabelledCollection");
            
    
            var path = "/api/v1/collections/labelled/{id4n}";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteLabelledCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteLabelledCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiError) ApiClient.Deserialize(response.Content, typeof(ApiError), response.Headers);
        }
    
        /// <summary>
        /// Delete logistic collection 
        /// </summary>
        /// <param name="id4n">id4n</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>Object</returns>            
        public Object DeleteLogisticCollection (string id4n, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling DeleteLogisticCollection");
            
    
            var path = "/api/v1/collections/logistic/{id4n}";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteLogisticCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteLogisticCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Delete routing collection 
        /// </summary>
        /// <param name="id4n">id4n</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiError</returns>            
        public ApiError DeleteRoutingCollection (string id4n, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling DeleteRoutingCollection");
            
    
            var path = "/api/v1/collections/routing/{id4n}";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteRoutingCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteRoutingCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiError) ApiClient.Deserialize(response.Content, typeof(ApiError), response.Headers);
        }
    
        /// <summary>
        /// Find collection 
        /// </summary>
        /// <param name="id4n">id4n</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>GuidCollection</returns>            
        public GuidCollection FindCollection (string id4n, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling FindCollection");
            
    
            var path = "/api/v1/collections/{id4n}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling FindCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FindCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GuidCollection) ApiClient.Deserialize(response.Content, typeof(GuidCollection), response.Headers);
        }
    
        /// <summary>
        /// Find labelled collection 
        /// </summary>
        /// <param name="id4n">id4n</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>GuidCollection</returns>            
        public GuidCollection FindLabelledCollection (string id4n, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling FindLabelledCollection");
            
    
            var path = "/api/v1/collections/labelled/{id4n}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling FindLabelledCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FindLabelledCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GuidCollection) ApiClient.Deserialize(response.Content, typeof(GuidCollection), response.Headers);
        }
    
        /// <summary>
        /// Find logistic collection 
        /// </summary>
        /// <param name="id4n">id4n</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>GuidCollection</returns>            
        public GuidCollection FindLogisticCollection (string id4n, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling FindLogisticCollection");
            
    
            var path = "/api/v1/collections/logistic/{id4n}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling FindLogisticCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FindLogisticCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GuidCollection) ApiClient.Deserialize(response.Content, typeof(GuidCollection), response.Headers);
        }
    
        /// <summary>
        /// Find routing collection 
        /// </summary>
        /// <param name="id4n">id4n</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>GuidCollection</returns>            
        public GuidCollection FindRoutingCollection (string id4n, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling FindRoutingCollection");
            
    
            var path = "/api/v1/collections/routing/{id4n}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling FindRoutingCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FindRoutingCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GuidCollection) ApiClient.Deserialize(response.Content, typeof(GuidCollection), response.Headers);
        }
    
        /// <summary>
        /// Get collections of organization Retrieving all collections of an organization in a paginated manner.
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="offset">Start with the n-th element. </param> 
        /// <param name="limit">The maximum count of returned elements.</param> 
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
        /// List contents of the collection 
        /// </summary>
        /// <param name="id4n">id4n</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="offset">Start with the n-th element. </param> 
        /// <param name="limit">The maximum count of returned elements.</param> 
        /// <returns>PaginatedGuidResponse</returns>            
        public PaginatedGuidResponse ListElementsOfCollection (string id4n, string authorization, string acceptLanguage, int? offset, int? limit)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling ListElementsOfCollection");
            
    
            var path = "/api/v1/collections/{id4n}/elements";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListElementsOfCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListElementsOfCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaginatedGuidResponse) ApiClient.Deserialize(response.Content, typeof(PaginatedGuidResponse), response.Headers);
        }
    
        /// <summary>
        /// List contents of the collection 
        /// </summary>
        /// <param name="id4n">id4n</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="offset">Start with the n-th element. </param> 
        /// <param name="limit">The maximum count of returned elements.</param> 
        /// <returns>PaginatedGuidResponse</returns>            
        public PaginatedGuidResponse ListElementsOfLabelledCollection (string id4n, string authorization, string acceptLanguage, int? offset, int? limit)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling ListElementsOfLabelledCollection");
            
    
            var path = "/api/v1/collections/labelled/{id4n}/elements";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListElementsOfLabelledCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListElementsOfLabelledCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaginatedGuidResponse) ApiClient.Deserialize(response.Content, typeof(PaginatedGuidResponse), response.Headers);
        }
    
        /// <summary>
        /// List contents of the collection 
        /// </summary>
        /// <param name="id4n">id4n</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="offset">Start with the n-th element. </param> 
        /// <param name="limit">The maximum count of returned elements.</param> 
        /// <returns>PaginatedGuidResponse</returns>            
        public PaginatedGuidResponse ListElementsOfLogisticCollection (string id4n, string authorization, string acceptLanguage, int? offset, int? limit)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling ListElementsOfLogisticCollection");
            
    
            var path = "/api/v1/collections/logistic/{id4n}/elements";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListElementsOfLogisticCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListElementsOfLogisticCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaginatedGuidResponse) ApiClient.Deserialize(response.Content, typeof(PaginatedGuidResponse), response.Headers);
        }
    
        /// <summary>
        /// List contents of the collection 
        /// </summary>
        /// <param name="id4n">id4n</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="offset">Start with the n-th element. </param> 
        /// <param name="limit">The maximum count of returned elements.</param> 
        /// <returns>PaginatedGuidResponse</returns>            
        public PaginatedGuidResponse ListElementsOfRoutingCollection (string id4n, string authorization, string acceptLanguage, int? offset, int? limit)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling ListElementsOfRoutingCollection");
            
    
            var path = "/api/v1/collections/routing/{id4n}/elements";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListElementsOfRoutingCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListElementsOfRoutingCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaginatedGuidResponse) ApiClient.Deserialize(response.Content, typeof(PaginatedGuidResponse), response.Headers);
        }
    
        /// <summary>
        /// Remove elements from collection 
        /// </summary>
        /// <param name="id4n">id4n</param> 
        /// <param name="listOfGuids">listOfGuids</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiError</returns>            
        public ApiError RemoveElementsFromCollection (string id4n, ListOfId4ns listOfGuids, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling RemoveElementsFromCollection");
            
            // verify the required parameter 'listOfGuids' is set
            if (listOfGuids == null) throw new ApiException(400, "Missing required parameter 'listOfGuids' when calling RemoveElementsFromCollection");
            
    
            var path = "/api/v1/collections/{id4n}/elements";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(listOfGuids); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveElementsFromCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveElementsFromCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiError) ApiClient.Deserialize(response.Content, typeof(ApiError), response.Headers);
        }
    
        /// <summary>
        /// Remove elements from labelled collection 
        /// </summary>
        /// <param name="collectionId4n">collectionId4n</param> 
        /// <param name="listOfGuids">listOfGuids</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiError</returns>            
        public ApiError RemoveElementsFromLabelledCollection (string collectionId4n, ListOfId4ns listOfGuids, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'collectionId4n' is set
            if (collectionId4n == null) throw new ApiException(400, "Missing required parameter 'collectionId4n' when calling RemoveElementsFromLabelledCollection");
            
            // verify the required parameter 'listOfGuids' is set
            if (listOfGuids == null) throw new ApiException(400, "Missing required parameter 'listOfGuids' when calling RemoveElementsFromLabelledCollection");
            
    
            var path = "/api/v1/collections/labelled/{collectionId4n}/elements";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "collectionId4n" + "}", ApiClient.ParameterToString(collectionId4n));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(listOfGuids); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveElementsFromLabelledCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveElementsFromLabelledCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiError) ApiClient.Deserialize(response.Content, typeof(ApiError), response.Headers);
        }
    
        /// <summary>
        /// Remove elements from logistic collection 
        /// </summary>
        /// <param name="collectionId4n">collectionId4n</param> 
        /// <param name="listOfGuids">listOfGuids</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiError</returns>            
        public ApiError RemoveElementsFromLogisticCollection (string collectionId4n, ListOfId4ns listOfGuids, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'collectionId4n' is set
            if (collectionId4n == null) throw new ApiException(400, "Missing required parameter 'collectionId4n' when calling RemoveElementsFromLogisticCollection");
            
            // verify the required parameter 'listOfGuids' is set
            if (listOfGuids == null) throw new ApiException(400, "Missing required parameter 'listOfGuids' when calling RemoveElementsFromLogisticCollection");
            
    
            var path = "/api/v1/collections/logistic/{collectionId4n}/elements";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "collectionId4n" + "}", ApiClient.ParameterToString(collectionId4n));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(listOfGuids); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveElementsFromLogisticCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveElementsFromLogisticCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiError) ApiClient.Deserialize(response.Content, typeof(ApiError), response.Headers);
        }
    
        /// <summary>
        /// Remove elements from routing collection 
        /// </summary>
        /// <param name="collectionId4n">collectionId4n</param> 
        /// <param name="listOfGuids">listOfGuids</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>ApiError</returns>            
        public ApiError RemoveElementsFromRoutingCollection (string collectionId4n, ListOfId4ns listOfGuids, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'collectionId4n' is set
            if (collectionId4n == null) throw new ApiException(400, "Missing required parameter 'collectionId4n' when calling RemoveElementsFromRoutingCollection");
            
            // verify the required parameter 'listOfGuids' is set
            if (listOfGuids == null) throw new ApiException(400, "Missing required parameter 'listOfGuids' when calling RemoveElementsFromRoutingCollection");
            
    
            var path = "/api/v1/collections/routing/{collectionId4n}/elements";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "collectionId4n" + "}", ApiClient.ParameterToString(collectionId4n));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(listOfGuids); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveElementsFromRoutingCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RemoveElementsFromRoutingCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiError) ApiClient.Deserialize(response.Content, typeof(ApiError), response.Headers);
        }
    
        /// <summary>
        /// Set collection Update collection replacing all values but the ID
        /// </summary>
        /// <param name="id4n">id4n</param> 
        /// <param name="request">request</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>Object</returns>            
        public Object SetCollection (string id4n, GuidCollection request, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling SetCollection");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling SetCollection");
            
    
            var path = "/api/v1/collections/{id4n}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SetCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Set labelled collection values Update labelled collection replacing all values but the ID
        /// </summary>
        /// <param name="id4n">id4n</param> 
        /// <param name="request">request</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>Object</returns>            
        public Object SetLabelledCollection (string id4n, GuidCollection request, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling SetLabelledCollection");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling SetLabelledCollection");
            
    
            var path = "/api/v1/collections/labelled/{id4n}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SetLabelledCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetLabelledCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Replace logistic collection Update logistic collection replacing all values but the ID
        /// </summary>
        /// <param name="id4n">id4n</param> 
        /// <param name="request">request</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>Object</returns>            
        public Object SetLogisticCollection (string id4n, GuidCollection request, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling SetLogisticCollection");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling SetLogisticCollection");
            
    
            var path = "/api/v1/collections/logistic/{id4n}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SetLogisticCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetLogisticCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Update routing collection 
        /// </summary>
        /// <param name="id4n">id4n</param> 
        /// <param name="request">request</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>Object</returns>            
        public Object SetRoutingCollection (string id4n, GuidCollection request, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling SetRoutingCollection");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling SetRoutingCollection");
            
    
            var path = "/api/v1/collections/routing/{id4n}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SetRoutingCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetRoutingCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Update collection Update collection changing only the given values
        /// </summary>
        /// <param name="id4n">id4n</param> 
        /// <param name="request">request</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>Object</returns>            
        public Object UpdateCollection (string id4n, GuidCollection request, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling UpdateCollection");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling UpdateCollection");
            
    
            var path = "/api/v1/collections/{id4n}";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Update labelled collection Update labelled collection updating only the given values
        /// </summary>
        /// <param name="id4n">id4n</param> 
        /// <param name="request">request</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>Object</returns>            
        public Object UpdateLabelledCollection (string id4n, GuidCollection request, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling UpdateLabelledCollection");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling UpdateLabelledCollection");
            
    
            var path = "/api/v1/collections/labelled/{id4n}";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateLabelledCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateLabelledCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Update logistic collection Update logistic collection updating only the given values
        /// </summary>
        /// <param name="id4n">id4n</param> 
        /// <param name="request">request</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>Object</returns>            
        public Object UpdateLogisticCollection (string id4n, GuidCollection request, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling UpdateLogisticCollection");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling UpdateLogisticCollection");
            
    
            var path = "/api/v1/collections/logistic/{id4n}";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateLogisticCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateLogisticCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Update routing collection Update routing collection updating only the given values
        /// </summary>
        /// <param name="id4n">id4n</param> 
        /// <param name="request">request</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>Object</returns>            
        public Object UpdateRoutingCollection (string id4n, GuidCollection request, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling UpdateRoutingCollection");
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling UpdateRoutingCollection");
            
    
            var path = "/api/v1/collections/routing/{id4n}";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateRoutingCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateRoutingCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
    }
}
