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
    public interface IPublicServicesApi
    {
        /// <summary>
        /// Retrieve a document (meta-data only, no content) 
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="id4n">id4n</param>
        /// <param name="fileName">fileName</param>
        /// <returns>Document</returns>
        Document GetPublicDocument (long? organizationId, string id4n, string fileName);
        /// <summary>
        /// Forward Forwarding to the designated route defined in the routing,
        /// </summary>
        /// <param name="guid">guid</param>
        /// <returns>ApiError</returns>
        ApiError Go (string guid);
        /// <summary>
        /// List organization specific documents Listing documents of an id4n owned by a specified organization
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="organizationId">organizationId</param>
        /// <param name="offset">Start with the n-th element</param>
        /// <param name="limit">The maximum count of returned elements</param>
        /// <returns>PaginatedOwnedDocumentResponse</returns>
        PaginatedOwnedDocumentResponse ListAllPublicDocuments (string id4n, long? organizationId, int? offset, int? limit);
        /// <summary>
        /// List organization specific documents Listing documents of an id4n owned by a specified organization
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="id4n">id4n</param>
        /// <param name="offset">Start with the n-th element</param>
        /// <param name="limit">The maximum count of returned elements</param>
        /// <returns>PaginatedDocumentResponse</returns>
        PaginatedDocumentResponse ListPublicDocuments (long? organizationId, string id4n, int? offset, int? limit);
        /// <summary>
        /// Read document contents 
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="id4n">id4n</param>
        /// <param name="fileName">fileName</param>
        /// <returns>byte[]</returns>
        byte[] ReadPublicDocument (long? organizationId, string id4n, string fileName);
        /// <summary>
        /// Resolve image 
        /// </summary>
        /// <param name="imageID">The id of the image to be resolved.</param>
        /// <returns>byte[]</returns>
        byte[] ResolveImageUsingGET (string imageID);
        /// <summary>
        /// Resolve owner of id4n 
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <returns>WhoIsResponse</returns>
        WhoIsResponse ResolveWhoIsEntry (string id4n);
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
        /// Retrieve a document (meta-data only, no content) 
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="id4n">id4n</param> 
        /// <param name="fileName">fileName</param> 
        /// <returns>Document</returns>            
        public Document GetPublicDocument (long? organizationId, string id4n, string fileName)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling GetPublicDocument");
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling GetPublicDocument");
            
            // verify the required parameter 'fileName' is set
            if (fileName == null) throw new ApiException(400, "Missing required parameter 'fileName' when calling GetPublicDocument");
            
    
            var path = "/api/v1/public/documents/{id4n}/{organizationId}/{fileName}/metadata";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
path = path.Replace("{" + "fileName" + "}", ApiClient.ParameterToString(fileName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetPublicDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPublicDocument: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Document) ApiClient.Deserialize(response.Content, typeof(Document), response.Headers);
        }
    
        /// <summary>
        /// Forward Forwarding to the designated route defined in the routing,
        /// </summary>
        /// <param name="guid">guid</param> 
        /// <returns>ApiError</returns>            
        public ApiError Go (string guid)
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
        /// List organization specific documents Listing documents of an id4n owned by a specified organization
        /// </summary>
        /// <param name="id4n">id4n</param> 
        /// <param name="organizationId">organizationId</param> 
        /// <param name="offset">Start with the n-th element</param> 
        /// <param name="limit">The maximum count of returned elements</param> 
        /// <returns>PaginatedOwnedDocumentResponse</returns>            
        public PaginatedOwnedDocumentResponse ListAllPublicDocuments (string id4n, long? organizationId, int? offset, int? limit)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling ListAllPublicDocuments");
            
    
            var path = "/api/v1/public/documents/{id4n}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (organizationId != null) queryParams.Add("organizationId", ApiClient.ParameterToString(organizationId)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "Authorization" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAllPublicDocuments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAllPublicDocuments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaginatedOwnedDocumentResponse) ApiClient.Deserialize(response.Content, typeof(PaginatedOwnedDocumentResponse), response.Headers);
        }
    
        /// <summary>
        /// List organization specific documents Listing documents of an id4n owned by a specified organization
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="id4n">id4n</param> 
        /// <param name="offset">Start with the n-th element</param> 
        /// <param name="limit">The maximum count of returned elements</param> 
        /// <returns>PaginatedDocumentResponse</returns>            
        public PaginatedDocumentResponse ListPublicDocuments (long? organizationId, string id4n, int? offset, int? limit)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling ListPublicDocuments");
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling ListPublicDocuments");
            
    
            var path = "/api/v1/public/documents/{id4n}/{organizationId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "Authorization" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListPublicDocuments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListPublicDocuments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaginatedDocumentResponse) ApiClient.Deserialize(response.Content, typeof(PaginatedDocumentResponse), response.Headers);
        }
    
        /// <summary>
        /// Read document contents 
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="id4n">id4n</param> 
        /// <param name="fileName">fileName</param> 
        /// <returns>byte[]</returns>            
        public byte[] ReadPublicDocument (long? organizationId, string id4n, string fileName)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling ReadPublicDocument");
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling ReadPublicDocument");
            
            // verify the required parameter 'fileName' is set
            if (fileName == null) throw new ApiException(400, "Missing required parameter 'fileName' when calling ReadPublicDocument");
            
    
            var path = "/api/v1/public/documents/{id4n}/{organizationId}/{fileName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
path = path.Replace("{" + "fileName" + "}", ApiClient.ParameterToString(fileName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReadPublicDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadPublicDocument: " + response.ErrorMessage, response.ErrorMessage);
    
            return (byte[]) ApiClient.Deserialize(response.Content, typeof(byte[]), response.Headers);
        }
    
        /// <summary>
        /// Resolve image 
        /// </summary>
        /// <param name="imageID">The id of the image to be resolved.</param> 
        /// <returns>byte[]</returns>            
        public byte[] ResolveImageUsingGET (string imageID)
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
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Authorization" };
    
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
        /// <returns>WhoIsResponse</returns>            
        public WhoIsResponse ResolveWhoIsEntry (string id4n)
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
