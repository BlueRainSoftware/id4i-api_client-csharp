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
    public interface IStorageApi
    {
        /// <summary>
        /// Create an empty document for an id4n The document is created empty, mime-type defaults to text/plain
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="organizationId">organizationId</param>
        /// <param name="document">document</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="mimeType">mimeType</param>
        /// <returns>Object</returns>
        Object CreateDocument (string id4n, long? organizationId, Document document, string authorization, string acceptLanguage, string mimeType);
        /// <summary>
        /// Create an empty document for an id4n The document is created empty, mime-type defaults to text/plain
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="organizationId">organizationId</param>
        /// <param name="document">document</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="mimeType">mimeType</param>
        /// <returns>Object</returns>
        Object CreateDocument1 (string id4n, long? organizationId, Document document, string authorization, string acceptLanguage, string mimeType);
        /// <summary>
        /// Delete a document 
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="id4n">id4n</param>
        /// <param name="fileName">fileName</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>Object</returns>
        Object DeleteDocument (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage);
        /// <summary>
        /// Delete a document 
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="id4n">id4n</param>
        /// <param name="fileName">fileName</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>Object</returns>
        Object DeleteDocument1 (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage);
        /// <summary>
        /// Retrieve a document (meta-data only, no content) 
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="id4n">id4n</param>
        /// <param name="fileName">fileName</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>Document</returns>
        Document GetDocument (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage);
        /// <summary>
        /// Retrieve a document (meta-data only, no content) 
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="id4n">id4n</param>
        /// <param name="fileName">fileName</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>Document</returns>
        Document GetDocument1 (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage);
        /// <summary>
        /// Retrieve a document (meta-data only, no content) 
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="id4n">id4n</param>
        /// <param name="fileName">fileName</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>Document</returns>
        Document GetPublicDocument (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage);
        /// <summary>
        /// Retrieve a document (meta-data only, no content) 
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="id4n">id4n</param>
        /// <param name="fileName">fileName</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>Document</returns>
        Document GetPublicDocument1 (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage);
        /// <summary>
        /// List documents Listing all documents of an id4n
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="offset">Start with the n-th element</param>
        /// <param name="limit">The maximum count of returned elements</param>
        /// <returns>PaginatedOwnedDocumentResponse</returns>
        PaginatedOwnedDocumentResponse ListAllDocuments (string id4n, string authorization, string acceptLanguage, int? offset, int? limit);
        /// <summary>
        /// List documents Listing all documents of an id4n
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="offset">Start with the n-th element</param>
        /// <param name="limit">The maximum count of returned elements</param>
        /// <returns>PaginatedOwnedDocumentResponse</returns>
        PaginatedOwnedDocumentResponse ListAllDocuments1 (string id4n, string authorization, string acceptLanguage, int? offset, int? limit);
        /// <summary>
        /// List organization specific documents Listing documents of an id4n owned by a specified organization
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="organizationId">organizationId</param>
        /// <param name="offset">Start with the n-th element</param>
        /// <param name="limit">The maximum count of returned elements</param>
        /// <returns>PaginatedOwnedDocumentResponse</returns>
        PaginatedOwnedDocumentResponse ListAllPublicDocuments (string id4n, string authorization, string acceptLanguage, long? organizationId, int? offset, int? limit);
        /// <summary>
        /// List organization specific documents Listing documents of an id4n owned by a specified organization
        /// </summary>
        /// <param name="id4n">id4n</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="organizationId">organizationId</param>
        /// <param name="offset">Start with the n-th element</param>
        /// <param name="limit">The maximum count of returned elements</param>
        /// <returns>PaginatedOwnedDocumentResponse</returns>
        PaginatedOwnedDocumentResponse ListAllPublicDocuments1 (string id4n, string authorization, string acceptLanguage, long? organizationId, int? offset, int? limit);
        /// <summary>
        /// List organization specific documents Listing documents of an id4n owned by a specified organization
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="id4n">id4n</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="offset">Start with the n-th element</param>
        /// <param name="limit">The maximum count of returned elements</param>
        /// <returns>PaginatedDocumentResponse</returns>
        PaginatedDocumentResponse ListDocuments (long? organizationId, string id4n, string authorization, string acceptLanguage, int? offset, int? limit);
        /// <summary>
        /// List organization specific documents Listing documents of an id4n owned by a specified organization
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="id4n">id4n</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="offset">Start with the n-th element</param>
        /// <param name="limit">The maximum count of returned elements</param>
        /// <returns>PaginatedDocumentResponse</returns>
        PaginatedDocumentResponse ListDocuments1 (long? organizationId, string id4n, string authorization, string acceptLanguage, int? offset, int? limit);
        /// <summary>
        /// List organization specific documents Listing documents of an id4n owned by a specified organization
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="id4n">id4n</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="offset">Start with the n-th element</param>
        /// <param name="limit">The maximum count of returned elements</param>
        /// <returns>PaginatedDocumentResponse</returns>
        PaginatedDocumentResponse ListPublicDocuments (long? organizationId, string id4n, string authorization, string acceptLanguage, int? offset, int? limit);
        /// <summary>
        /// List organization specific documents Listing documents of an id4n owned by a specified organization
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="id4n">id4n</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="offset">Start with the n-th element</param>
        /// <param name="limit">The maximum count of returned elements</param>
        /// <returns>PaginatedDocumentResponse</returns>
        PaginatedDocumentResponse ListPublicDocuments1 (long? organizationId, string id4n, string authorization, string acceptLanguage, int? offset, int? limit);
        /// <summary>
        /// Read data from microstorage 
        /// </summary>
        /// <param name="organization">organization</param>
        /// <param name="id4n">id4n</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>InputStreamResource</returns>
        InputStreamResource Read (long? organization, string id4n, string authorization, string acceptLanguage);
        /// <summary>
        /// Read data from microstorage 
        /// </summary>
        /// <param name="organization">organization</param>
        /// <param name="id4n">id4n</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>InputStreamResource</returns>
        InputStreamResource Read1 (long? organization, string id4n, string authorization, string acceptLanguage);
        /// <summary>
        /// Read document contents 
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="id4n">id4n</param>
        /// <param name="fileName">fileName</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>InputStreamResource</returns>
        InputStreamResource ReadDocument (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage);
        /// <summary>
        /// Read document contents 
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="id4n">id4n</param>
        /// <param name="fileName">fileName</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>InputStreamResource</returns>
        InputStreamResource ReadDocument1 (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage);
        /// <summary>
        /// Read document contents 
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="id4n">id4n</param>
        /// <param name="fileName">fileName</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>InputStreamResource</returns>
        InputStreamResource ReadPublicDocument (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage);
        /// <summary>
        /// Read document contents 
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="id4n">id4n</param>
        /// <param name="fileName">fileName</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>InputStreamResource</returns>
        InputStreamResource ReadPublicDocument1 (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage);
        /// <summary>
        /// Update a document 
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="id4n">id4n</param>
        /// <param name="fileName">fileName</param>
        /// <param name="document">document</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>Document</returns>
        Document UpdateDocument (long? organizationId, string id4n, string fileName, DocumentUpdate document, string authorization, string acceptLanguage);
        /// <summary>
        /// Update a document 
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="id4n">id4n</param>
        /// <param name="fileName">fileName</param>
        /// <param name="document">document</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <returns>Document</returns>
        Document UpdateDocument1 (long? organizationId, string id4n, string fileName, DocumentUpdate document, string authorization, string acceptLanguage);
        /// <summary>
        /// Write data to microstorage 
        /// </summary>
        /// <param name="organization">organization</param>
        /// <param name="id4n">id4n</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="contentType">Content-Type</param>
        /// <param name="contentLength">Content-Length</param>
        /// <returns>Object</returns>
        Object Write (long? organization, string id4n, string authorization, string acceptLanguage, string contentType, long? contentLength);
        /// <summary>
        /// Write data to microstorage 
        /// </summary>
        /// <param name="organization">organization</param>
        /// <param name="id4n">id4n</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="contentType">Content-Type</param>
        /// <param name="contentLength">Content-Length</param>
        /// <returns>Object</returns>
        Object Write1 (long? organization, string id4n, string authorization, string acceptLanguage, string contentType, long? contentLength);
        /// <summary>
        /// Write document contents 
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="id4n">id4n</param>
        /// <param name="fileName">fileName</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="contentType">Content-Type</param>
        /// <param name="contentLength">Content-Length</param>
        /// <returns>Object</returns>
        Object WriteDocument (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage, string contentType, long? contentLength);
        /// <summary>
        /// Write document contents 
        /// </summary>
        /// <param name="organizationId">organizationId</param>
        /// <param name="id4n">id4n</param>
        /// <param name="fileName">fileName</param>
        /// <param name="authorization">Authorization JWT Bearer Token</param>
        /// <param name="acceptLanguage">Requested language</param>
        /// <param name="contentType">Content-Type</param>
        /// <param name="contentLength">Content-Length</param>
        /// <returns>Object</returns>
        Object WriteDocument1 (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage, string contentType, long? contentLength);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class StorageApi : IStorageApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public StorageApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StorageApi(String basePath)
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
        /// Create an empty document for an id4n The document is created empty, mime-type defaults to text/plain
        /// </summary>
        /// <param name="id4n">id4n</param> 
        /// <param name="organizationId">organizationId</param> 
        /// <param name="document">document</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="mimeType">mimeType</param> 
        /// <returns>Object</returns>            
        public Object CreateDocument (string id4n, long? organizationId, Document document, string authorization, string acceptLanguage, string mimeType)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling CreateDocument");
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling CreateDocument");
            
            // verify the required parameter 'document' is set
            if (document == null) throw new ApiException(400, "Missing required parameter 'document' when calling CreateDocument");
            
    
            var path = "/api/v1/collections/{id4n}/documents/{organizationId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (mimeType != null) queryParams.Add("mimeType", ApiClient.ParameterToString(mimeType)); // query parameter
             if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(document); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateDocument: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Create an empty document for an id4n The document is created empty, mime-type defaults to text/plain
        /// </summary>
        /// <param name="id4n">id4n</param> 
        /// <param name="organizationId">organizationId</param> 
        /// <param name="document">document</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="mimeType">mimeType</param> 
        /// <returns>Object</returns>            
        public Object CreateDocument1 (string id4n, long? organizationId, Document document, string authorization, string acceptLanguage, string mimeType)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling CreateDocument1");
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling CreateDocument1");
            
            // verify the required parameter 'document' is set
            if (document == null) throw new ApiException(400, "Missing required parameter 'document' when calling CreateDocument1");
            
    
            var path = "/api/v1/guids/{id4n}/documents/{organizationId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (mimeType != null) queryParams.Add("mimeType", ApiClient.ParameterToString(mimeType)); // query parameter
             if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(document); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateDocument1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateDocument1: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Delete a document 
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="id4n">id4n</param> 
        /// <param name="fileName">fileName</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>Object</returns>            
        public Object DeleteDocument (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling DeleteDocument");
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling DeleteDocument");
            
            // verify the required parameter 'fileName' is set
            if (fileName == null) throw new ApiException(400, "Missing required parameter 'fileName' when calling DeleteDocument");
            
    
            var path = "/api/v1/collections/{id4n}/documents/{organizationId}/{fileName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
path = path.Replace("{" + "fileName" + "}", ApiClient.ParameterToString(fileName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDocument: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Delete a document 
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="id4n">id4n</param> 
        /// <param name="fileName">fileName</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>Object</returns>            
        public Object DeleteDocument1 (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling DeleteDocument1");
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling DeleteDocument1");
            
            // verify the required parameter 'fileName' is set
            if (fileName == null) throw new ApiException(400, "Missing required parameter 'fileName' when calling DeleteDocument1");
            
    
            var path = "/api/v1/guids/{id4n}/documents/{organizationId}/{fileName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
path = path.Replace("{" + "fileName" + "}", ApiClient.ParameterToString(fileName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDocument1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDocument1: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Retrieve a document (meta-data only, no content) 
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="id4n">id4n</param> 
        /// <param name="fileName">fileName</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>Document</returns>            
        public Document GetDocument (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling GetDocument");
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling GetDocument");
            
            // verify the required parameter 'fileName' is set
            if (fileName == null) throw new ApiException(400, "Missing required parameter 'fileName' when calling GetDocument");
            
    
            var path = "/api/v1/collections/{id4n}/documents/{organizationId}/{fileName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
path = path.Replace("{" + "fileName" + "}", ApiClient.ParameterToString(fileName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDocument: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Document) ApiClient.Deserialize(response.Content, typeof(Document), response.Headers);
        }
    
        /// <summary>
        /// Retrieve a document (meta-data only, no content) 
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="id4n">id4n</param> 
        /// <param name="fileName">fileName</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>Document</returns>            
        public Document GetDocument1 (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling GetDocument1");
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling GetDocument1");
            
            // verify the required parameter 'fileName' is set
            if (fileName == null) throw new ApiException(400, "Missing required parameter 'fileName' when calling GetDocument1");
            
    
            var path = "/api/v1/guids/{id4n}/documents/{organizationId}/{fileName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
path = path.Replace("{" + "fileName" + "}", ApiClient.ParameterToString(fileName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetDocument1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDocument1: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Document) ApiClient.Deserialize(response.Content, typeof(Document), response.Headers);
        }
    
        /// <summary>
        /// Retrieve a document (meta-data only, no content) 
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="id4n">id4n</param> 
        /// <param name="fileName">fileName</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>Document</returns>            
        public Document GetPublicDocument (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling GetPublicDocument");
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling GetPublicDocument");
            
            // verify the required parameter 'fileName' is set
            if (fileName == null) throw new ApiException(400, "Missing required parameter 'fileName' when calling GetPublicDocument");
            
    
            var path = "/api/v1/public/collections/{id4n}/documents/{organizationId}/{fileName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
path = path.Replace("{" + "fileName" + "}", ApiClient.ParameterToString(fileName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetPublicDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPublicDocument: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Document) ApiClient.Deserialize(response.Content, typeof(Document), response.Headers);
        }
    
        /// <summary>
        /// Retrieve a document (meta-data only, no content) 
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="id4n">id4n</param> 
        /// <param name="fileName">fileName</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>Document</returns>            
        public Document GetPublicDocument1 (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling GetPublicDocument1");
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling GetPublicDocument1");
            
            // verify the required parameter 'fileName' is set
            if (fileName == null) throw new ApiException(400, "Missing required parameter 'fileName' when calling GetPublicDocument1");
            
    
            var path = "/api/v1/public/guids/{id4n}/documents/{organizationId}/{fileName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
path = path.Replace("{" + "fileName" + "}", ApiClient.ParameterToString(fileName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetPublicDocument1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPublicDocument1: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Document) ApiClient.Deserialize(response.Content, typeof(Document), response.Headers);
        }
    
        /// <summary>
        /// List documents Listing all documents of an id4n
        /// </summary>
        /// <param name="id4n">id4n</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="offset">Start with the n-th element</param> 
        /// <param name="limit">The maximum count of returned elements</param> 
        /// <returns>PaginatedOwnedDocumentResponse</returns>            
        public PaginatedOwnedDocumentResponse ListAllDocuments (string id4n, string authorization, string acceptLanguage, int? offset, int? limit)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling ListAllDocuments");
            
    
            var path = "/api/v1/collections/{id4n}/documents";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListAllDocuments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAllDocuments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaginatedOwnedDocumentResponse) ApiClient.Deserialize(response.Content, typeof(PaginatedOwnedDocumentResponse), response.Headers);
        }
    
        /// <summary>
        /// List documents Listing all documents of an id4n
        /// </summary>
        /// <param name="id4n">id4n</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="offset">Start with the n-th element</param> 
        /// <param name="limit">The maximum count of returned elements</param> 
        /// <returns>PaginatedOwnedDocumentResponse</returns>            
        public PaginatedOwnedDocumentResponse ListAllDocuments1 (string id4n, string authorization, string acceptLanguage, int? offset, int? limit)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling ListAllDocuments1");
            
    
            var path = "/api/v1/guids/{id4n}/documents";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListAllDocuments1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAllDocuments1: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaginatedOwnedDocumentResponse) ApiClient.Deserialize(response.Content, typeof(PaginatedOwnedDocumentResponse), response.Headers);
        }
    
        /// <summary>
        /// List organization specific documents Listing documents of an id4n owned by a specified organization
        /// </summary>
        /// <param name="id4n">id4n</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="organizationId">organizationId</param> 
        /// <param name="offset">Start with the n-th element</param> 
        /// <param name="limit">The maximum count of returned elements</param> 
        /// <returns>PaginatedOwnedDocumentResponse</returns>            
        public PaginatedOwnedDocumentResponse ListAllPublicDocuments (string id4n, string authorization, string acceptLanguage, long? organizationId, int? offset, int? limit)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling ListAllPublicDocuments");
            
    
            var path = "/api/v1/public/collections/{id4n}/documents";
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
             if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
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
        /// <param name="id4n">id4n</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="organizationId">organizationId</param> 
        /// <param name="offset">Start with the n-th element</param> 
        /// <param name="limit">The maximum count of returned elements</param> 
        /// <returns>PaginatedOwnedDocumentResponse</returns>            
        public PaginatedOwnedDocumentResponse ListAllPublicDocuments1 (string id4n, string authorization, string acceptLanguage, long? organizationId, int? offset, int? limit)
        {
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling ListAllPublicDocuments1");
            
    
            var path = "/api/v1/public/guids/{id4n}/documents";
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
             if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAllPublicDocuments1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAllPublicDocuments1: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaginatedOwnedDocumentResponse) ApiClient.Deserialize(response.Content, typeof(PaginatedOwnedDocumentResponse), response.Headers);
        }
    
        /// <summary>
        /// List organization specific documents Listing documents of an id4n owned by a specified organization
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="id4n">id4n</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="offset">Start with the n-th element</param> 
        /// <param name="limit">The maximum count of returned elements</param> 
        /// <returns>PaginatedDocumentResponse</returns>            
        public PaginatedDocumentResponse ListDocuments (long? organizationId, string id4n, string authorization, string acceptLanguage, int? offset, int? limit)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling ListDocuments");
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling ListDocuments");
            
    
            var path = "/api/v1/collections/{id4n}/documents/{organizationId}";
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
             if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListDocuments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListDocuments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaginatedDocumentResponse) ApiClient.Deserialize(response.Content, typeof(PaginatedDocumentResponse), response.Headers);
        }
    
        /// <summary>
        /// List organization specific documents Listing documents of an id4n owned by a specified organization
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="id4n">id4n</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="offset">Start with the n-th element</param> 
        /// <param name="limit">The maximum count of returned elements</param> 
        /// <returns>PaginatedDocumentResponse</returns>            
        public PaginatedDocumentResponse ListDocuments1 (long? organizationId, string id4n, string authorization, string acceptLanguage, int? offset, int? limit)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling ListDocuments1");
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling ListDocuments1");
            
    
            var path = "/api/v1/guids/{id4n}/documents/{organizationId}";
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
             if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListDocuments1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListDocuments1: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaginatedDocumentResponse) ApiClient.Deserialize(response.Content, typeof(PaginatedDocumentResponse), response.Headers);
        }
    
        /// <summary>
        /// List organization specific documents Listing documents of an id4n owned by a specified organization
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="id4n">id4n</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="offset">Start with the n-th element</param> 
        /// <param name="limit">The maximum count of returned elements</param> 
        /// <returns>PaginatedDocumentResponse</returns>            
        public PaginatedDocumentResponse ListPublicDocuments (long? organizationId, string id4n, string authorization, string acceptLanguage, int? offset, int? limit)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling ListPublicDocuments");
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling ListPublicDocuments");
            
    
            var path = "/api/v1/public/collections/{id4n}/documents/{organizationId}";
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
             if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListPublicDocuments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListPublicDocuments: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaginatedDocumentResponse) ApiClient.Deserialize(response.Content, typeof(PaginatedDocumentResponse), response.Headers);
        }
    
        /// <summary>
        /// List organization specific documents Listing documents of an id4n owned by a specified organization
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="id4n">id4n</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="offset">Start with the n-th element</param> 
        /// <param name="limit">The maximum count of returned elements</param> 
        /// <returns>PaginatedDocumentResponse</returns>            
        public PaginatedDocumentResponse ListPublicDocuments1 (long? organizationId, string id4n, string authorization, string acceptLanguage, int? offset, int? limit)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling ListPublicDocuments1");
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling ListPublicDocuments1");
            
    
            var path = "/api/v1/public/guids/{id4n}/documents/{organizationId}";
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
             if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListPublicDocuments1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListPublicDocuments1: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaginatedDocumentResponse) ApiClient.Deserialize(response.Content, typeof(PaginatedDocumentResponse), response.Headers);
        }
    
        /// <summary>
        /// Read data from microstorage 
        /// </summary>
        /// <param name="organization">organization</param> 
        /// <param name="id4n">id4n</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>InputStreamResource</returns>            
        public InputStreamResource Read (long? organization, string id4n, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'organization' is set
            if (organization == null) throw new ApiException(400, "Missing required parameter 'organization' when calling Read");
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling Read");
            
    
            var path = "/api/v1/collections/{id4n}/micro/{organization}";
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
        /// Read data from microstorage 
        /// </summary>
        /// <param name="organization">organization</param> 
        /// <param name="id4n">id4n</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>InputStreamResource</returns>            
        public InputStreamResource Read1 (long? organization, string id4n, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'organization' is set
            if (organization == null) throw new ApiException(400, "Missing required parameter 'organization' when calling Read1");
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling Read1");
            
    
            var path = "/api/v1/guids/{id4n}/micro/{organization}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Read1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Read1: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InputStreamResource) ApiClient.Deserialize(response.Content, typeof(InputStreamResource), response.Headers);
        }
    
        /// <summary>
        /// Read document contents 
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="id4n">id4n</param> 
        /// <param name="fileName">fileName</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>InputStreamResource</returns>            
        public InputStreamResource ReadDocument (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling ReadDocument");
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling ReadDocument");
            
            // verify the required parameter 'fileName' is set
            if (fileName == null) throw new ApiException(400, "Missing required parameter 'fileName' when calling ReadDocument");
            
    
            var path = "/api/v1/collections/{id4n}/documents/{organizationId}/{fileName}/content";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
path = path.Replace("{" + "fileName" + "}", ApiClient.ParameterToString(fileName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReadDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadDocument: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InputStreamResource) ApiClient.Deserialize(response.Content, typeof(InputStreamResource), response.Headers);
        }
    
        /// <summary>
        /// Read document contents 
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="id4n">id4n</param> 
        /// <param name="fileName">fileName</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>InputStreamResource</returns>            
        public InputStreamResource ReadDocument1 (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling ReadDocument1");
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling ReadDocument1");
            
            // verify the required parameter 'fileName' is set
            if (fileName == null) throw new ApiException(400, "Missing required parameter 'fileName' when calling ReadDocument1");
            
    
            var path = "/api/v1/guids/{id4n}/documents/{organizationId}/{fileName}/content";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
path = path.Replace("{" + "fileName" + "}", ApiClient.ParameterToString(fileName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReadDocument1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadDocument1: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InputStreamResource) ApiClient.Deserialize(response.Content, typeof(InputStreamResource), response.Headers);
        }
    
        /// <summary>
        /// Read document contents 
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="id4n">id4n</param> 
        /// <param name="fileName">fileName</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>InputStreamResource</returns>            
        public InputStreamResource ReadPublicDocument (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling ReadPublicDocument");
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling ReadPublicDocument");
            
            // verify the required parameter 'fileName' is set
            if (fileName == null) throw new ApiException(400, "Missing required parameter 'fileName' when calling ReadPublicDocument");
            
    
            var path = "/api/v1/public/collections/{id4n}/documents/{organizationId}/{fileName}/content";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
path = path.Replace("{" + "fileName" + "}", ApiClient.ParameterToString(fileName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReadPublicDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadPublicDocument: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InputStreamResource) ApiClient.Deserialize(response.Content, typeof(InputStreamResource), response.Headers);
        }
    
        /// <summary>
        /// Read document contents 
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="id4n">id4n</param> 
        /// <param name="fileName">fileName</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>InputStreamResource</returns>            
        public InputStreamResource ReadPublicDocument1 (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling ReadPublicDocument1");
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling ReadPublicDocument1");
            
            // verify the required parameter 'fileName' is set
            if (fileName == null) throw new ApiException(400, "Missing required parameter 'fileName' when calling ReadPublicDocument1");
            
    
            var path = "/api/v1/public/guids/{id4n}/documents/{organizationId}/{fileName}/content";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
path = path.Replace("{" + "fileName" + "}", ApiClient.ParameterToString(fileName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReadPublicDocument1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadPublicDocument1: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InputStreamResource) ApiClient.Deserialize(response.Content, typeof(InputStreamResource), response.Headers);
        }
    
        /// <summary>
        /// Update a document 
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="id4n">id4n</param> 
        /// <param name="fileName">fileName</param> 
        /// <param name="document">document</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>Document</returns>            
        public Document UpdateDocument (long? organizationId, string id4n, string fileName, DocumentUpdate document, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling UpdateDocument");
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling UpdateDocument");
            
            // verify the required parameter 'fileName' is set
            if (fileName == null) throw new ApiException(400, "Missing required parameter 'fileName' when calling UpdateDocument");
            
            // verify the required parameter 'document' is set
            if (document == null) throw new ApiException(400, "Missing required parameter 'document' when calling UpdateDocument");
            
    
            var path = "/api/v1/collections/{id4n}/documents/{organizationId}/{fileName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
path = path.Replace("{" + "fileName" + "}", ApiClient.ParameterToString(fileName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(document); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateDocument: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Document) ApiClient.Deserialize(response.Content, typeof(Document), response.Headers);
        }
    
        /// <summary>
        /// Update a document 
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="id4n">id4n</param> 
        /// <param name="fileName">fileName</param> 
        /// <param name="document">document</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <returns>Document</returns>            
        public Document UpdateDocument1 (long? organizationId, string id4n, string fileName, DocumentUpdate document, string authorization, string acceptLanguage)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling UpdateDocument1");
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling UpdateDocument1");
            
            // verify the required parameter 'fileName' is set
            if (fileName == null) throw new ApiException(400, "Missing required parameter 'fileName' when calling UpdateDocument1");
            
            // verify the required parameter 'document' is set
            if (document == null) throw new ApiException(400, "Missing required parameter 'document' when calling UpdateDocument1");
            
    
            var path = "/api/v1/guids/{id4n}/documents/{organizationId}/{fileName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
path = path.Replace("{" + "fileName" + "}", ApiClient.ParameterToString(fileName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (acceptLanguage != null) headerParams.Add("Accept-Language", ApiClient.ParameterToString(acceptLanguage)); // header parameter
                        postBody = ApiClient.Serialize(document); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateDocument1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateDocument1: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Document) ApiClient.Deserialize(response.Content, typeof(Document), response.Headers);
        }
    
        /// <summary>
        /// Write data to microstorage 
        /// </summary>
        /// <param name="organization">organization</param> 
        /// <param name="id4n">id4n</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
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
            
    
            var path = "/api/v1/collections/{id4n}/micro/{organization}";
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
    
        /// <summary>
        /// Write data to microstorage 
        /// </summary>
        /// <param name="organization">organization</param> 
        /// <param name="id4n">id4n</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="contentType">Content-Type</param> 
        /// <param name="contentLength">Content-Length</param> 
        /// <returns>Object</returns>            
        public Object Write1 (long? organization, string id4n, string authorization, string acceptLanguage, string contentType, long? contentLength)
        {
            
            // verify the required parameter 'organization' is set
            if (organization == null) throw new ApiException(400, "Missing required parameter 'organization' when calling Write1");
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling Write1");
            
    
            var path = "/api/v1/guids/{id4n}/micro/{organization}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Write1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Write1: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Write document contents 
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="id4n">id4n</param> 
        /// <param name="fileName">fileName</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="contentType">Content-Type</param> 
        /// <param name="contentLength">Content-Length</param> 
        /// <returns>Object</returns>            
        public Object WriteDocument (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage, string contentType, long? contentLength)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling WriteDocument");
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling WriteDocument");
            
            // verify the required parameter 'fileName' is set
            if (fileName == null) throw new ApiException(400, "Missing required parameter 'fileName' when calling WriteDocument");
            
    
            var path = "/api/v1/collections/{id4n}/documents/{organizationId}/{fileName}/content";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
path = path.Replace("{" + "fileName" + "}", ApiClient.ParameterToString(fileName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WriteDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WriteDocument: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Write document contents 
        /// </summary>
        /// <param name="organizationId">organizationId</param> 
        /// <param name="id4n">id4n</param> 
        /// <param name="fileName">fileName</param> 
        /// <param name="authorization">Authorization JWT Bearer Token</param> 
        /// <param name="acceptLanguage">Requested language</param> 
        /// <param name="contentType">Content-Type</param> 
        /// <param name="contentLength">Content-Length</param> 
        /// <returns>Object</returns>            
        public Object WriteDocument1 (long? organizationId, string id4n, string fileName, string authorization, string acceptLanguage, string contentType, long? contentLength)
        {
            
            // verify the required parameter 'organizationId' is set
            if (organizationId == null) throw new ApiException(400, "Missing required parameter 'organizationId' when calling WriteDocument1");
            
            // verify the required parameter 'id4n' is set
            if (id4n == null) throw new ApiException(400, "Missing required parameter 'id4n' when calling WriteDocument1");
            
            // verify the required parameter 'fileName' is set
            if (fileName == null) throw new ApiException(400, "Missing required parameter 'fileName' when calling WriteDocument1");
            
    
            var path = "/api/v1/guids/{id4n}/documents/{organizationId}/{fileName}/content";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "organizationId" + "}", ApiClient.ParameterToString(organizationId));
path = path.Replace("{" + "id4n" + "}", ApiClient.ParameterToString(id4n));
path = path.Replace("{" + "fileName" + "}", ApiClient.ParameterToString(fileName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling WriteDocument1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling WriteDocument1: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
    }
}
