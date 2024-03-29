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
    public interface IMessagingApi : IApiAccessor
    {
    #region Synchronous Operations
        /// <summary>
            /// Enqueue a custom message
            /// </summary>
        /// <remarks>
            /// Enqueue a custom organisation message with custom data.
            /// </remarks>
        /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">The organisation namespace</param>
        /// <param name="request">request</param>
        /// <returns></returns>
        void EnqueueCustomMessage (string organizationId, SendCustomMessage request);

        /// <summary>
            /// Enqueue a custom message
            /// </summary>
        /// <remarks>
            /// Enqueue a custom organisation message with custom data.
            /// </remarks>
        /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">The organisation namespace</param>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> EnqueueCustomMessageWithHttpInfo (string organizationId, SendCustomMessage request);
        /// <summary>
            /// 
            /// </summary>
        /// <remarks>
            /// 
            /// </remarks>
        /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">organizationId</param>
        /// <returns>QueuePresentation</returns>
        QueuePresentation GetDefaultQueue (string organizationId);

        /// <summary>
            /// 
            /// </summary>
        /// <remarks>
            /// 
            /// </remarks>
        /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">organizationId</param>
        /// <returns>ApiResponse of QueuePresentation</returns>
        ApiResponse<QueuePresentation> GetDefaultQueueWithHttpInfo (string organizationId);
        /// <summary>
            /// 
            /// </summary>
        /// <remarks>
            /// 
            /// </remarks>
        /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">organizationId</param>
        /// <param name="request">request</param>
        /// <returns></returns>
        void PatchDefaultQueue (string organizationId, QueueUpdateRequest request);

        /// <summary>
            /// 
            /// </summary>
        /// <remarks>
            /// 
            /// </remarks>
        /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">organizationId</param>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchDefaultQueueWithHttpInfo (string organizationId, QueueUpdateRequest request);
        #endregion Synchronous Operations
            #region Asynchronous Operations
                /// <summary>
                /// Enqueue a custom message
                /// </summary>
                /// <remarks>
                /// Enqueue a custom organisation message with custom data.
                /// </remarks>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <param name="organizationId">The organisation namespace</param>
            /// <param name="request">request</param>
            /// <returns>Task of void</returns>
            System.Threading.Tasks.Task EnqueueCustomMessageAsync (string organizationId, SendCustomMessage request);

                /// <summary>
                /// Enqueue a custom message
                /// </summary>
                /// <remarks>
                /// Enqueue a custom organisation message with custom data.
                /// </remarks>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <param name="organizationId">The organisation namespace</param>
            /// <param name="request">request</param>
            /// <returns>Task of ApiResponse</returns>
                System.Threading.Tasks.Task<ApiResponse<Object>> EnqueueCustomMessageAsyncWithHttpInfo (string organizationId, SendCustomMessage request);
                /// <summary>
                /// 
                /// </summary>
                /// <remarks>
                /// 
                /// </remarks>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <param name="organizationId">organizationId</param>
            /// <returns>Task of QueuePresentation</returns>
            System.Threading.Tasks.Task<QueuePresentation> GetDefaultQueueAsync (string organizationId);

                /// <summary>
                /// 
                /// </summary>
                /// <remarks>
                /// 
                /// </remarks>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <param name="organizationId">organizationId</param>
            /// <returns>Task of ApiResponse (QueuePresentation)</returns>
                System.Threading.Tasks.Task<ApiResponse<QueuePresentation>> GetDefaultQueueAsyncWithHttpInfo (string organizationId);
                /// <summary>
                /// 
                /// </summary>
                /// <remarks>
                /// 
                /// </remarks>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <param name="organizationId">organizationId</param>
            /// <param name="request">request</param>
            /// <returns>Task of void</returns>
            System.Threading.Tasks.Task PatchDefaultQueueAsync (string organizationId, QueueUpdateRequest request);

                /// <summary>
                /// 
                /// </summary>
                /// <remarks>
                /// 
                /// </remarks>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <param name="organizationId">organizationId</param>
            /// <param name="request">request</param>
            /// <returns>Task of ApiResponse</returns>
                System.Threading.Tasks.Task<ApiResponse<Object>> PatchDefaultQueueAsyncWithHttpInfo (string organizationId, QueueUpdateRequest request);
            #endregion Asynchronous Operations
        }

        /// <summary>
        /// Represents a collection of functions to interact with the API endpoints
        /// </summary>
    public partial class MessagingApi : IMessagingApi
        {
        private BlueRain.ID4i.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MessagingApi(String basePath)
        {
        this.Configuration = new Configuration { BasePath = basePath };

        ExceptionFactory = BlueRain.ID4i.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MessagingApi(Configuration configuration = null)
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
            /// Enqueue a custom message Enqueue a custom organisation message with custom data.
            /// </summary>
            /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">The organisation namespace</param>
        /// <param name="request">request</param>
        /// <returns></returns>
            public void EnqueueCustomMessage (string organizationId, SendCustomMessage request)
            {
        EnqueueCustomMessageWithHttpInfo(organizationId, request);
            }

            /// <summary>
            /// Enqueue a custom message Enqueue a custom organisation message with custom data.
            /// </summary>
            /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">The organisation namespace</param>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of Object(void)</returns>
            public ApiResponse<Object> EnqueueCustomMessageWithHttpInfo (string organizationId, SendCustomMessage request)
            {
                    // verify the required parameter 'organizationId' is set
                    if (organizationId == null)
                    throw new ApiException(400, "Missing required parameter 'organizationId' when calling MessagingApi->EnqueueCustomMessage");
                    // verify the required parameter 'request' is set
                    if (request == null)
                    throw new ApiException(400, "Missing required parameter 'request' when calling MessagingApi->EnqueueCustomMessage");

            var localVarPath = "./api/v1/organizations/{organizationId}/messaging/enqueueCustomMessage";
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
                if (request != null && request.GetType() != typeof(byte[]))
                {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
                }
                else
                {
                localVarPostBody = request; // byte array
                }

                // authentication (Authorization) required
                        if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
                        {
                        localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
                        }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
            Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
            Exception exception = ExceptionFactory("EnqueueCustomMessage", localVarResponse);
            if (exception != null) throw exception;
            }

                return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
            }

                /// <summary>
                /// Enqueue a custom message Enqueue a custom organisation message with custom data.
                /// </summary>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <param name="organizationId">The organisation namespace</param>
            /// <param name="request">request</param>
            /// <returns>Task of void</returns>
            public async System.Threading.Tasks.Task EnqueueCustomMessageAsync (string organizationId, SendCustomMessage request)
                {
            await EnqueueCustomMessageAsyncWithHttpInfo(organizationId, request);

                }

                /// <summary>
                /// Enqueue a custom message Enqueue a custom organisation message with custom data.
                /// </summary>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <param name="organizationId">The organisation namespace</param>
            /// <param name="request">request</param>
            /// <returns>Task of ApiResponse</returns>
                public async System.Threading.Tasks.Task<ApiResponse<Object>> EnqueueCustomMessageAsyncWithHttpInfo (string organizationId, SendCustomMessage request)
                {
                        // verify the required parameter 'organizationId' is set
                        if (organizationId == null)
                        throw new ApiException(400, "Missing required parameter 'organizationId' when calling MessagingApi->EnqueueCustomMessage");
                        // verify the required parameter 'request' is set
                        if (request == null)
                        throw new ApiException(400, "Missing required parameter 'request' when calling MessagingApi->EnqueueCustomMessage");

                var localVarPath = "./api/v1/organizations/{organizationId}/messaging/enqueueCustomMessage";
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
                    if (request != null && request.GetType() != typeof(byte[]))
                    {
                    localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
                    }
                    else
                    {
                    localVarPostBody = request; // byte array
                    }

                    // authentication (Authorization) required
                            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
                            {
                            localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
                            }

                // make the HTTP request
                IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

                int localVarStatusCode = (int) localVarResponse.StatusCode;

                if (ExceptionFactory != null)
                {
                Exception exception = ExceptionFactory("EnqueueCustomMessage", localVarResponse);
                if (exception != null) throw exception;
                }

                    return new ApiResponse<Object>(localVarStatusCode,
                    localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                    null);
                }

            /// <summary>
            ///  
            /// </summary>
            /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">organizationId</param>
        /// <returns>QueuePresentation</returns>
            public QueuePresentation GetDefaultQueue (string organizationId)
            {
        ApiResponse<QueuePresentation> localVarResponse = GetDefaultQueueWithHttpInfo(organizationId);
            return localVarResponse.Data;
            }

            /// <summary>
            ///  
            /// </summary>
            /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">organizationId</param>
        /// <returns>ApiResponse of QueuePresentation</returns>
            public ApiResponse< QueuePresentation > GetDefaultQueueWithHttpInfo (string organizationId)
            {
                    // verify the required parameter 'organizationId' is set
                    if (organizationId == null)
                    throw new ApiException(400, "Missing required parameter 'organizationId' when calling MessagingApi->GetDefaultQueue");

            var localVarPath = "./api/v1/organizations/{organizationId}/messaging";
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
            Exception exception = ExceptionFactory("GetDefaultQueue", localVarResponse);
            if (exception != null) throw exception;
            }

                return new ApiResponse<QueuePresentation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (QueuePresentation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueuePresentation)));
            }

                /// <summary>
                ///  
                /// </summary>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <param name="organizationId">organizationId</param>
            /// <returns>Task of QueuePresentation</returns>
            public async System.Threading.Tasks.Task<QueuePresentation> GetDefaultQueueAsync (string organizationId)
                {
            ApiResponse<QueuePresentation> localVarResponse = await GetDefaultQueueAsyncWithHttpInfo(organizationId);
                return localVarResponse.Data;

                }

                /// <summary>
                ///  
                /// </summary>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <param name="organizationId">organizationId</param>
            /// <returns>Task of ApiResponse (QueuePresentation)</returns>
                public async System.Threading.Tasks.Task<ApiResponse<QueuePresentation>> GetDefaultQueueAsyncWithHttpInfo (string organizationId)
                {
                        // verify the required parameter 'organizationId' is set
                        if (organizationId == null)
                        throw new ApiException(400, "Missing required parameter 'organizationId' when calling MessagingApi->GetDefaultQueue");

                var localVarPath = "./api/v1/organizations/{organizationId}/messaging";
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
                Exception exception = ExceptionFactory("GetDefaultQueue", localVarResponse);
                if (exception != null) throw exception;
                }

                    return new ApiResponse<QueuePresentation>(localVarStatusCode,
                    localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                    (QueuePresentation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QueuePresentation)));
                }

            /// <summary>
            ///  
            /// </summary>
            /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">organizationId</param>
        /// <param name="request">request</param>
        /// <returns></returns>
            public void PatchDefaultQueue (string organizationId, QueueUpdateRequest request)
            {
        PatchDefaultQueueWithHttpInfo(organizationId, request);
            }

            /// <summary>
            ///  
            /// </summary>
            /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">organizationId</param>
        /// <param name="request">request</param>
        /// <returns>ApiResponse of Object(void)</returns>
            public ApiResponse<Object> PatchDefaultQueueWithHttpInfo (string organizationId, QueueUpdateRequest request)
            {
                    // verify the required parameter 'organizationId' is set
                    if (organizationId == null)
                    throw new ApiException(400, "Missing required parameter 'organizationId' when calling MessagingApi->PatchDefaultQueue");
                    // verify the required parameter 'request' is set
                    if (request == null)
                    throw new ApiException(400, "Missing required parameter 'request' when calling MessagingApi->PatchDefaultQueue");

            var localVarPath = "./api/v1/organizations/{organizationId}/messaging";
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
                if (request != null && request.GetType() != typeof(byte[]))
                {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
                }
                else
                {
                localVarPostBody = request; // byte array
                }

                // authentication (Authorization) required
                        if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
                        {
                        localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
                        }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
            Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
            Exception exception = ExceptionFactory("PatchDefaultQueue", localVarResponse);
            if (exception != null) throw exception;
            }

                return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
            }

                /// <summary>
                ///  
                /// </summary>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <param name="organizationId">organizationId</param>
            /// <param name="request">request</param>
            /// <returns>Task of void</returns>
            public async System.Threading.Tasks.Task PatchDefaultQueueAsync (string organizationId, QueueUpdateRequest request)
                {
            await PatchDefaultQueueAsyncWithHttpInfo(organizationId, request);

                }

                /// <summary>
                ///  
                /// </summary>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <param name="organizationId">organizationId</param>
            /// <param name="request">request</param>
            /// <returns>Task of ApiResponse</returns>
                public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchDefaultQueueAsyncWithHttpInfo (string organizationId, QueueUpdateRequest request)
                {
                        // verify the required parameter 'organizationId' is set
                        if (organizationId == null)
                        throw new ApiException(400, "Missing required parameter 'organizationId' when calling MessagingApi->PatchDefaultQueue");
                        // verify the required parameter 'request' is set
                        if (request == null)
                        throw new ApiException(400, "Missing required parameter 'request' when calling MessagingApi->PatchDefaultQueue");

                var localVarPath = "./api/v1/organizations/{organizationId}/messaging";
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
                    if (request != null && request.GetType() != typeof(byte[]))
                    {
                    localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
                    }
                    else
                    {
                    localVarPostBody = request; // byte array
                    }

                    // authentication (Authorization) required
                            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
                            {
                            localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
                            }

                // make the HTTP request
                IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

                int localVarStatusCode = (int) localVarResponse.StatusCode;

                if (ExceptionFactory != null)
                {
                Exception exception = ExceptionFactory("PatchDefaultQueue", localVarResponse);
                if (exception != null) throw exception;
                }

                    return new ApiResponse<Object>(localVarStatusCode,
                    localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                    null);
                }

        }
    }