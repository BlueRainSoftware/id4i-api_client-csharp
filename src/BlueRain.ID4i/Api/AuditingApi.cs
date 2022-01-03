/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 1.0.0
 * Contact: info@bluerain.de
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
    using RestSharp.Portable;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;
using Guid = BlueRain.ID4i.Model.Guid;

namespace BlueRain.ID4i.Api
{
    /// <summary>
        /// Represents a collection of functions to interact with the API endpoints
        /// </summary>
    public interface IAuditingApi : IApiAccessor
    {
    #region Synchronous Operations
        /// <summary>
            /// List change log entries of an organization
            /// </summary>
        /// <remarks>
            /// Listing change log entries of the specified organization id.
            /// </remarks>
        /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">The namespace identifying the organization whose change log entries are to be listed</param>
        /// <param name="messageMimeType">The Mime-type for the message format that should be returned. e.g. &#39;text/plain&#39; or &#39;text/mustache&#39;  (optional, default to text/mustache)</param>
        /// <param name="fromDate">From date time as UTC Date-Time format (optional)</param>
        /// <param name="toDate">To date time as UTC Date-Time format (optional)</param>
        /// <param name="offset">Start with the n-th element (optional)</param>
        /// <param name="limit">The maximum count of returned elements (optional)</param>
        /// <returns>PaginatedResponseOfChangeLogEntry</returns>
        PaginatedResponseOfChangeLogEntry ListOrganizationChangeLog (string organizationId, string messageMimeType = null, DateTime? fromDate = null, DateTime? toDate = null, int? offset = null, int? limit = null);

        /// <summary>
            /// List change log entries of an organization
            /// </summary>
        /// <remarks>
            /// Listing change log entries of the specified organization id.
            /// </remarks>
        /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">The namespace identifying the organization whose change log entries are to be listed</param>
        /// <param name="messageMimeType">The Mime-type for the message format that should be returned. e.g. &#39;text/plain&#39; or &#39;text/mustache&#39;  (optional, default to text/mustache)</param>
        /// <param name="fromDate">From date time as UTC Date-Time format (optional)</param>
        /// <param name="toDate">To date time as UTC Date-Time format (optional)</param>
        /// <param name="offset">Start with the n-th element (optional)</param>
        /// <param name="limit">The maximum count of returned elements (optional)</param>
        /// <returns>ApiResponse of PaginatedResponseOfChangeLogEntry</returns>
        ApiResponse<PaginatedResponseOfChangeLogEntry> ListOrganizationChangeLogWithHttpInfo (string organizationId, string messageMimeType = null, DateTime? fromDate = null, DateTime? toDate = null, int? offset = null, int? limit = null);
        #endregion Synchronous Operations
            #region Asynchronous Operations
                /// <summary>
                /// List change log entries of an organization
                /// </summary>
                /// <remarks>
                /// Listing change log entries of the specified organization id.
                /// </remarks>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <param name="organizationId">The namespace identifying the organization whose change log entries are to be listed</param>
            /// <param name="messageMimeType">The Mime-type for the message format that should be returned. e.g. &#39;text/plain&#39; or &#39;text/mustache&#39;  (optional, default to text/mustache)</param>
            /// <param name="fromDate">From date time as UTC Date-Time format (optional)</param>
            /// <param name="toDate">To date time as UTC Date-Time format (optional)</param>
            /// <param name="offset">Start with the n-th element (optional)</param>
            /// <param name="limit">The maximum count of returned elements (optional)</param>
            /// <returns>Task of PaginatedResponseOfChangeLogEntry</returns>
            System.Threading.Tasks.Task<PaginatedResponseOfChangeLogEntry> ListOrganizationChangeLogAsync (string organizationId, string messageMimeType = null, DateTime? fromDate = null, DateTime? toDate = null, int? offset = null, int? limit = null);

                /// <summary>
                /// List change log entries of an organization
                /// </summary>
                /// <remarks>
                /// Listing change log entries of the specified organization id.
                /// </remarks>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <param name="organizationId">The namespace identifying the organization whose change log entries are to be listed</param>
            /// <param name="messageMimeType">The Mime-type for the message format that should be returned. e.g. &#39;text/plain&#39; or &#39;text/mustache&#39;  (optional, default to text/mustache)</param>
            /// <param name="fromDate">From date time as UTC Date-Time format (optional)</param>
            /// <param name="toDate">To date time as UTC Date-Time format (optional)</param>
            /// <param name="offset">Start with the n-th element (optional)</param>
            /// <param name="limit">The maximum count of returned elements (optional)</param>
            /// <returns>Task of ApiResponse (PaginatedResponseOfChangeLogEntry)</returns>
                System.Threading.Tasks.Task<ApiResponse<PaginatedResponseOfChangeLogEntry>> ListOrganizationChangeLogAsyncWithHttpInfo (string organizationId, string messageMimeType = null, DateTime? fromDate = null, DateTime? toDate = null, int? offset = null, int? limit = null);
            #endregion Asynchronous Operations
        }

        /// <summary>
        /// Represents a collection of functions to interact with the API endpoints
        /// </summary>
    public partial class AuditingApi : IAuditingApi
        {
        private BlueRain.ID4i.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuditingApi(String basePath)
        {
        this.Configuration = new Configuration { BasePath = basePath };

        ExceptionFactory = BlueRain.ID4i.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuditingApi(Configuration configuration = null)
        {
        if (configuration == null) // use the default one in Configuration
        this.Configuration = Configuration.Default;
        else
        this.Configuration = configuration;

        ExceptionFactory = BlueRain.ID4i.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
        return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
        // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public BlueRain.ID4i.Client.ExceptionFactory ExceptionFactory
        {
        get
        {
        if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
        {
        throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
        }
        return _exceptionFactory;
        }
        set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
        return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
        this.Configuration.AddDefaultHeader(key, value);
        }

            /// <summary>
            /// List change log entries of an organization Listing change log entries of the specified organization id.
            /// </summary>
            /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">The namespace identifying the organization whose change log entries are to be listed</param>
        /// <param name="messageMimeType">The Mime-type for the message format that should be returned. e.g. &#39;text/plain&#39; or &#39;text/mustache&#39;  (optional, default to text/mustache)</param>
        /// <param name="fromDate">From date time as UTC Date-Time format (optional)</param>
        /// <param name="toDate">To date time as UTC Date-Time format (optional)</param>
        /// <param name="offset">Start with the n-th element (optional)</param>
        /// <param name="limit">The maximum count of returned elements (optional)</param>
        /// <returns>PaginatedResponseOfChangeLogEntry</returns>
            public PaginatedResponseOfChangeLogEntry ListOrganizationChangeLog (string organizationId, string messageMimeType = null, DateTime? fromDate = null, DateTime? toDate = null, int? offset = null, int? limit = null)
            {
        ApiResponse<PaginatedResponseOfChangeLogEntry> localVarResponse = ListOrganizationChangeLogWithHttpInfo(organizationId, messageMimeType, fromDate, toDate, offset, limit);
            return localVarResponse.Data;
            }

            /// <summary>
            /// List change log entries of an organization Listing change log entries of the specified organization id.
            /// </summary>
            /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">The namespace identifying the organization whose change log entries are to be listed</param>
        /// <param name="messageMimeType">The Mime-type for the message format that should be returned. e.g. &#39;text/plain&#39; or &#39;text/mustache&#39;  (optional, default to text/mustache)</param>
        /// <param name="fromDate">From date time as UTC Date-Time format (optional)</param>
        /// <param name="toDate">To date time as UTC Date-Time format (optional)</param>
        /// <param name="offset">Start with the n-th element (optional)</param>
        /// <param name="limit">The maximum count of returned elements (optional)</param>
        /// <returns>ApiResponse of PaginatedResponseOfChangeLogEntry</returns>
            public ApiResponse< PaginatedResponseOfChangeLogEntry > ListOrganizationChangeLogWithHttpInfo (string organizationId, string messageMimeType = null, DateTime? fromDate = null, DateTime? toDate = null, int? offset = null, int? limit = null)
            {
                    // verify the required parameter 'organizationId' is set
                    if (organizationId == null)
                    throw new ApiException(400, "Missing required parameter 'organizationId' when calling AuditingApi->ListOrganizationChangeLog");

            var localVarPath = "./api/v1/changelog/organization/{organizationId}/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/xml", 
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml",
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

                if (organizationId != null) localVarPathParams.Add("organizationId", Configuration.ApiClient.ParameterToString(organizationId)); // path parameter
                if (messageMimeType != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "messageMimeType", messageMimeType)); // query parameter
                if (fromDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fromDate", fromDate)); // query parameter
                if (toDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "toDate", toDate)); // query parameter
                if (offset != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
                if (limit != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter

                // authentication (Authorization) required
                        if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
                        {
                        localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
                        }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
            Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
            Exception exception = ExceptionFactory("ListOrganizationChangeLog", localVarResponse);
            if (exception != null) throw exception;
            }

                return new ApiResponse<PaginatedResponseOfChangeLogEntry>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (PaginatedResponseOfChangeLogEntry) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaginatedResponseOfChangeLogEntry)));
            }

                /// <summary>
                /// List change log entries of an organization Listing change log entries of the specified organization id.
                /// </summary>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <param name="organizationId">The namespace identifying the organization whose change log entries are to be listed</param>
            /// <param name="messageMimeType">The Mime-type for the message format that should be returned. e.g. &#39;text/plain&#39; or &#39;text/mustache&#39;  (optional, default to text/mustache)</param>
            /// <param name="fromDate">From date time as UTC Date-Time format (optional)</param>
            /// <param name="toDate">To date time as UTC Date-Time format (optional)</param>
            /// <param name="offset">Start with the n-th element (optional)</param>
            /// <param name="limit">The maximum count of returned elements (optional)</param>
            /// <returns>Task of PaginatedResponseOfChangeLogEntry</returns>
            public async System.Threading.Tasks.Task<PaginatedResponseOfChangeLogEntry> ListOrganizationChangeLogAsync (string organizationId, string messageMimeType = null, DateTime? fromDate = null, DateTime? toDate = null, int? offset = null, int? limit = null)
                {
            ApiResponse<PaginatedResponseOfChangeLogEntry> localVarResponse = await ListOrganizationChangeLogAsyncWithHttpInfo(organizationId, messageMimeType, fromDate, toDate, offset, limit);
                return localVarResponse.Data;

                }

                /// <summary>
                /// List change log entries of an organization Listing change log entries of the specified organization id.
                /// </summary>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <param name="organizationId">The namespace identifying the organization whose change log entries are to be listed</param>
            /// <param name="messageMimeType">The Mime-type for the message format that should be returned. e.g. &#39;text/plain&#39; or &#39;text/mustache&#39;  (optional, default to text/mustache)</param>
            /// <param name="fromDate">From date time as UTC Date-Time format (optional)</param>
            /// <param name="toDate">To date time as UTC Date-Time format (optional)</param>
            /// <param name="offset">Start with the n-th element (optional)</param>
            /// <param name="limit">The maximum count of returned elements (optional)</param>
            /// <returns>Task of ApiResponse (PaginatedResponseOfChangeLogEntry)</returns>
                public async System.Threading.Tasks.Task<ApiResponse<PaginatedResponseOfChangeLogEntry>> ListOrganizationChangeLogAsyncWithHttpInfo (string organizationId, string messageMimeType = null, DateTime? fromDate = null, DateTime? toDate = null, int? offset = null, int? limit = null)
                {
                        // verify the required parameter 'organizationId' is set
                        if (organizationId == null)
                        throw new ApiException(400, "Missing required parameter 'organizationId' when calling AuditingApi->ListOrganizationChangeLog");

                var localVarPath = "./api/v1/changelog/organization/{organizationId}/";
                var localVarPathParams = new Dictionary<String, String>();
                var localVarQueryParams = new List<KeyValuePair<String, String>>();
                var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
                var localVarFormParams = new Dictionary<String, String>();
                var localVarFileParams = new Dictionary<String, FileParameter>();
                Object localVarPostBody = null;

                // to determine the Content-Type header
                String[] localVarHttpContentTypes = new String[] {
                    "application/xml", 
                    "application/json"
                };
                String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

                // to determine the Accept header
                String[] localVarHttpHeaderAccepts = new String[] {
                    "application/xml",
                    "application/json"
                };
                String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
                if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

                    if (organizationId != null) localVarPathParams.Add("organizationId", Configuration.ApiClient.ParameterToString(organizationId)); // path parameter
                    if (messageMimeType != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "messageMimeType", messageMimeType)); // query parameter
                    if (fromDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fromDate", fromDate)); // query parameter
                    if (toDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "toDate", toDate)); // query parameter
                    if (offset != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
                    if (limit != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter

                    // authentication (Authorization) required
                            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
                            {
                            localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
                            }

                // make the HTTP request
                IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

                int localVarStatusCode = (int) localVarResponse.StatusCode;

                if (ExceptionFactory != null)
                {
                Exception exception = ExceptionFactory("ListOrganizationChangeLog", localVarResponse);
                if (exception != null) throw exception;
                }

                    return new ApiResponse<PaginatedResponseOfChangeLogEntry>(localVarStatusCode,
                    localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                    (PaginatedResponseOfChangeLogEntry) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PaginatedResponseOfChangeLogEntry)));
                }

        }
    }