/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.7.2
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
    public interface IMetaInformationApi : IApiAccessor
    {
    #region Synchronous Operations
        /// <summary>
            /// Retrieve version information about ID4i
            /// </summary>
        /// <remarks>
            /// Retrieving version information about ID4i.
            /// </remarks>
        /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>AppInfoPresentation</returns>
        AppInfoPresentation ApplicationInfo ();

        /// <summary>
            /// Retrieve version information about ID4i
            /// </summary>
        /// <remarks>
            /// Retrieving version information about ID4i.
            /// </remarks>
        /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of AppInfoPresentation</returns>
        ApiResponse<AppInfoPresentation> ApplicationInfoWithHttpInfo ();
        #endregion Synchronous Operations
            #region Asynchronous Operations
                /// <summary>
                /// Retrieve version information about ID4i
                /// </summary>
                /// <remarks>
                /// Retrieving version information about ID4i.
                /// </remarks>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <returns>Task of AppInfoPresentation</returns>
            System.Threading.Tasks.Task<AppInfoPresentation> ApplicationInfoAsync ();

                /// <summary>
                /// Retrieve version information about ID4i
                /// </summary>
                /// <remarks>
                /// Retrieving version information about ID4i.
                /// </remarks>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <returns>Task of ApiResponse (AppInfoPresentation)</returns>
                System.Threading.Tasks.Task<ApiResponse<AppInfoPresentation>> ApplicationInfoAsyncWithHttpInfo ();
            #endregion Asynchronous Operations
        }

        /// <summary>
        /// Represents a collection of functions to interact with the API endpoints
        /// </summary>
    public partial class MetaInformationApi : IMetaInformationApi
        {
        private BlueRain.ID4i.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MetaInformationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MetaInformationApi(String basePath)
        {
        this.Configuration = new Configuration { BasePath = basePath };

        ExceptionFactory = BlueRain.ID4i.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetaInformationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MetaInformationApi(Configuration configuration = null)
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
            /// Retrieve version information about ID4i Retrieving version information about ID4i.
            /// </summary>
            /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>AppInfoPresentation</returns>
            public AppInfoPresentation ApplicationInfo ()
            {
        ApiResponse<AppInfoPresentation> localVarResponse = ApplicationInfoWithHttpInfo();
            return localVarResponse.Data;
            }

            /// <summary>
            /// Retrieve version information about ID4i Retrieving version information about ID4i.
            /// </summary>
            /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of AppInfoPresentation</returns>
            public ApiResponse< AppInfoPresentation > ApplicationInfoWithHttpInfo ()
            {

            var localVarPath = "./api/v1/info";
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
            Exception exception = ExceptionFactory("ApplicationInfo", localVarResponse);
            if (exception != null) throw exception;
            }

                return new ApiResponse<AppInfoPresentation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (AppInfoPresentation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AppInfoPresentation)));
            }

                /// <summary>
                /// Retrieve version information about ID4i Retrieving version information about ID4i.
                /// </summary>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <returns>Task of AppInfoPresentation</returns>
            public async System.Threading.Tasks.Task<AppInfoPresentation> ApplicationInfoAsync ()
                {
            ApiResponse<AppInfoPresentation> localVarResponse = await ApplicationInfoAsyncWithHttpInfo();
                return localVarResponse.Data;

                }

                /// <summary>
                /// Retrieve version information about ID4i Retrieving version information about ID4i.
                /// </summary>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <returns>Task of ApiResponse (AppInfoPresentation)</returns>
                public async System.Threading.Tasks.Task<ApiResponse<AppInfoPresentation>> ApplicationInfoAsyncWithHttpInfo ()
                {

                var localVarPath = "./api/v1/info";
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
                Exception exception = ExceptionFactory("ApplicationInfo", localVarResponse);
                if (exception != null) throw exception;
                }

                    return new ApiResponse<AppInfoPresentation>(localVarStatusCode,
                    localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                    (AppInfoPresentation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AppInfoPresentation)));
                }

        }
    }