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
    public interface IImagesApi : IApiAccessor
    {
    #region Synchronous Operations
        /// <summary>
            /// Resolve image
            /// </summary>
        /// <remarks>
            /// 
            /// </remarks>
        /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageID">The id of the image to be resolved.</param>
        /// <returns>byte[]</returns>
        byte[] ResolveImageUsingGET (string imageID);

        /// <summary>
            /// Resolve image
            /// </summary>
        /// <remarks>
            /// 
            /// </remarks>
        /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageID">The id of the image to be resolved.</param>
        /// <returns>ApiResponse of byte[]</returns>
        ApiResponse<byte[]> ResolveImageUsingGETWithHttpInfo (string imageID);
        #endregion Synchronous Operations
            #region Asynchronous Operations
                /// <summary>
                /// Resolve image
                /// </summary>
                /// <remarks>
                /// 
                /// </remarks>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <param name="imageID">The id of the image to be resolved.</param>
            /// <returns>Task of byte[]</returns>
            System.Threading.Tasks.Task<byte[]> ResolveImageUsingGETAsync (string imageID);

                /// <summary>
                /// Resolve image
                /// </summary>
                /// <remarks>
                /// 
                /// </remarks>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <param name="imageID">The id of the image to be resolved.</param>
            /// <returns>Task of ApiResponse (byte[])</returns>
                System.Threading.Tasks.Task<ApiResponse<byte[]>> ResolveImageUsingGETAsyncWithHttpInfo (string imageID);
            #endregion Asynchronous Operations
        }

        /// <summary>
        /// Represents a collection of functions to interact with the API endpoints
        /// </summary>
    public partial class ImagesApi : IImagesApi
        {
        private BlueRain.ID4i.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ImagesApi(String basePath)
        {
        this.Configuration = new Configuration { BasePath = basePath };

        ExceptionFactory = BlueRain.ID4i.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ImagesApi(Configuration configuration = null)
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
            /// Resolve image 
            /// </summary>
            /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageID">The id of the image to be resolved.</param>
        /// <returns>byte[]</returns>
            public byte[] ResolveImageUsingGET (string imageID)
            {
        ApiResponse<byte[]> localVarResponse = ResolveImageUsingGETWithHttpInfo(imageID);
            return localVarResponse.Data;
            }

            /// <summary>
            /// Resolve image 
            /// </summary>
            /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="imageID">The id of the image to be resolved.</param>
        /// <returns>ApiResponse of byte[]</returns>
            public ApiResponse< byte[] > ResolveImageUsingGETWithHttpInfo (string imageID)
            {
                    // verify the required parameter 'imageID' is set
                    if (imageID == null)
                    throw new ApiException(400, "Missing required parameter 'imageID' when calling ImagesApi->ResolveImageUsingGET");

            var localVarPath = "./api/v1/public/image/{imageID}";
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

                if (imageID != null) localVarPathParams.Add("imageID", Configuration.ApiClient.ParameterToString(imageID)); // path parameter

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
            Exception exception = ExceptionFactory("ResolveImageUsingGET", localVarResponse);
            if (exception != null) throw exception;
            }

                return new ApiResponse<byte[]>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (byte[]) Configuration.ApiClient.Deserialize(localVarResponse, typeof(byte[])));
            }

                /// <summary>
                /// Resolve image 
                /// </summary>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <param name="imageID">The id of the image to be resolved.</param>
            /// <returns>Task of byte[]</returns>
            public async System.Threading.Tasks.Task<byte[]> ResolveImageUsingGETAsync (string imageID)
                {
            ApiResponse<byte[]> localVarResponse = await ResolveImageUsingGETAsyncWithHttpInfo(imageID);
                return localVarResponse.Data;

                }

                /// <summary>
                /// Resolve image 
                /// </summary>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <param name="imageID">The id of the image to be resolved.</param>
            /// <returns>Task of ApiResponse (byte[])</returns>
                public async System.Threading.Tasks.Task<ApiResponse<byte[]>> ResolveImageUsingGETAsyncWithHttpInfo (string imageID)
                {
                        // verify the required parameter 'imageID' is set
                        if (imageID == null)
                        throw new ApiException(400, "Missing required parameter 'imageID' when calling ImagesApi->ResolveImageUsingGET");

                var localVarPath = "./api/v1/public/image/{imageID}";
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

                    if (imageID != null) localVarPathParams.Add("imageID", Configuration.ApiClient.ParameterToString(imageID)); // path parameter

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
                Exception exception = ExceptionFactory("ResolveImageUsingGET", localVarResponse);
                if (exception != null) throw exception;
                }

                    return new ApiResponse<byte[]>(localVarStatusCode,
                    localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                    (byte[]) Configuration.ApiClient.Deserialize(localVarResponse, typeof(byte[])));
                }

        }
    }