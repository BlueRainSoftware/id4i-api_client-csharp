/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.8.2-SNAPSHOT
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
    public interface IBillingApi : IApiAccessor
    {
    #region Synchronous Operations
        /// <summary>
            /// Get billing positions for a given organization
            /// </summary>
        /// <remarks>
            /// 
            /// </remarks>
        /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">The organization to compute the billing information for</param>
        /// <param name="fromDate">Billing start date (optional)</param>
        /// <param name="toDate">Billing end date (optional)</param>
        /// <returns>List&lt;BillingPosition&gt;</returns>
        List<BillingPosition> GetPositionsForOrganization (string organizationId, DateTime? fromDate = null, DateTime? toDate = null);

        /// <summary>
            /// Get billing positions for a given organization
            /// </summary>
        /// <remarks>
            /// 
            /// </remarks>
        /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">The organization to compute the billing information for</param>
        /// <param name="fromDate">Billing start date (optional)</param>
        /// <param name="toDate">Billing end date (optional)</param>
        /// <returns>ApiResponse of List&lt;BillingPosition&gt;</returns>
        ApiResponse<List<BillingPosition>> GetPositionsForOrganizationWithHttpInfo (string organizationId, DateTime? fromDate = null, DateTime? toDate = null);
        /// <summary>
            /// Get billing amount of services for a given organization
            /// </summary>
        /// <remarks>
            /// 
            /// </remarks>
        /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">The organization to compute the billing information for</param>
        /// <param name="fromDate">Billing start date (optional)</param>
        /// <param name="toDate">Billing end date (optional)</param>
        /// <returns>ServiceCosts</returns>
        ServiceCosts GetSumForOrganization (string organizationId, DateTime? fromDate = null, DateTime? toDate = null);

        /// <summary>
            /// Get billing amount of services for a given organization
            /// </summary>
        /// <remarks>
            /// 
            /// </remarks>
        /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">The organization to compute the billing information for</param>
        /// <param name="fromDate">Billing start date (optional)</param>
        /// <param name="toDate">Billing end date (optional)</param>
        /// <returns>ApiResponse of ServiceCosts</returns>
        ApiResponse<ServiceCosts> GetSumForOrganizationWithHttpInfo (string organizationId, DateTime? fromDate = null, DateTime? toDate = null);
        #endregion Synchronous Operations
            #region Asynchronous Operations
                /// <summary>
                /// Get billing positions for a given organization
                /// </summary>
                /// <remarks>
                /// 
                /// </remarks>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <param name="organizationId">The organization to compute the billing information for</param>
            /// <param name="fromDate">Billing start date (optional)</param>
            /// <param name="toDate">Billing end date (optional)</param>
            /// <returns>Task of List&lt;BillingPosition&gt;</returns>
            System.Threading.Tasks.Task<List<BillingPosition>> GetPositionsForOrganizationAsync (string organizationId, DateTime? fromDate = null, DateTime? toDate = null);

                /// <summary>
                /// Get billing positions for a given organization
                /// </summary>
                /// <remarks>
                /// 
                /// </remarks>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <param name="organizationId">The organization to compute the billing information for</param>
            /// <param name="fromDate">Billing start date (optional)</param>
            /// <param name="toDate">Billing end date (optional)</param>
            /// <returns>Task of ApiResponse (List&lt;BillingPosition&gt;)</returns>
                System.Threading.Tasks.Task<ApiResponse<List<BillingPosition>>> GetPositionsForOrganizationAsyncWithHttpInfo (string organizationId, DateTime? fromDate = null, DateTime? toDate = null);
                /// <summary>
                /// Get billing amount of services for a given organization
                /// </summary>
                /// <remarks>
                /// 
                /// </remarks>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <param name="organizationId">The organization to compute the billing information for</param>
            /// <param name="fromDate">Billing start date (optional)</param>
            /// <param name="toDate">Billing end date (optional)</param>
            /// <returns>Task of ServiceCosts</returns>
            System.Threading.Tasks.Task<ServiceCosts> GetSumForOrganizationAsync (string organizationId, DateTime? fromDate = null, DateTime? toDate = null);

                /// <summary>
                /// Get billing amount of services for a given organization
                /// </summary>
                /// <remarks>
                /// 
                /// </remarks>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <param name="organizationId">The organization to compute the billing information for</param>
            /// <param name="fromDate">Billing start date (optional)</param>
            /// <param name="toDate">Billing end date (optional)</param>
            /// <returns>Task of ApiResponse (ServiceCosts)</returns>
                System.Threading.Tasks.Task<ApiResponse<ServiceCosts>> GetSumForOrganizationAsyncWithHttpInfo (string organizationId, DateTime? fromDate = null, DateTime? toDate = null);
            #endregion Asynchronous Operations
        }

        /// <summary>
        /// Represents a collection of functions to interact with the API endpoints
        /// </summary>
    public partial class BillingApi : IBillingApi
        {
        private BlueRain.ID4i.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BillingApi(String basePath)
        {
        this.Configuration = new Configuration { BasePath = basePath };

        ExceptionFactory = BlueRain.ID4i.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BillingApi(Configuration configuration = null)
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
            /// Get billing positions for a given organization 
            /// </summary>
            /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">The organization to compute the billing information for</param>
        /// <param name="fromDate">Billing start date (optional)</param>
        /// <param name="toDate">Billing end date (optional)</param>
        /// <returns>List&lt;BillingPosition&gt;</returns>
            public List<BillingPosition> GetPositionsForOrganization (string organizationId, DateTime? fromDate = null, DateTime? toDate = null)
            {
        ApiResponse<List<BillingPosition>> localVarResponse = GetPositionsForOrganizationWithHttpInfo(organizationId, fromDate, toDate);
            return localVarResponse.Data;
            }

            /// <summary>
            /// Get billing positions for a given organization 
            /// </summary>
            /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">The organization to compute the billing information for</param>
        /// <param name="fromDate">Billing start date (optional)</param>
        /// <param name="toDate">Billing end date (optional)</param>
        /// <returns>ApiResponse of List&lt;BillingPosition&gt;</returns>
            public ApiResponse< List<BillingPosition> > GetPositionsForOrganizationWithHttpInfo (string organizationId, DateTime? fromDate = null, DateTime? toDate = null)
            {
                    // verify the required parameter 'organizationId' is set
                    if (organizationId == null)
                    throw new ApiException(400, "Missing required parameter 'organizationId' when calling BillingApi->GetPositionsForOrganization");

            var localVarPath = "./api/v1/billing/{organizationId}/positions";
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
                if (fromDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fromDate", fromDate)); // query parameter
                if (toDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "toDate", toDate)); // query parameter

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
            Exception exception = ExceptionFactory("GetPositionsForOrganization", localVarResponse);
            if (exception != null) throw exception;
            }

                return new ApiResponse<List<BillingPosition>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (List<BillingPosition>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BillingPosition>)));
            }

                /// <summary>
                /// Get billing positions for a given organization 
                /// </summary>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <param name="organizationId">The organization to compute the billing information for</param>
            /// <param name="fromDate">Billing start date (optional)</param>
            /// <param name="toDate">Billing end date (optional)</param>
            /// <returns>Task of List&lt;BillingPosition&gt;</returns>
            public async System.Threading.Tasks.Task<List<BillingPosition>> GetPositionsForOrganizationAsync (string organizationId, DateTime? fromDate = null, DateTime? toDate = null)
                {
            ApiResponse<List<BillingPosition>> localVarResponse = await GetPositionsForOrganizationAsyncWithHttpInfo(organizationId, fromDate, toDate);
                return localVarResponse.Data;

                }

                /// <summary>
                /// Get billing positions for a given organization 
                /// </summary>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <param name="organizationId">The organization to compute the billing information for</param>
            /// <param name="fromDate">Billing start date (optional)</param>
            /// <param name="toDate">Billing end date (optional)</param>
            /// <returns>Task of ApiResponse (List&lt;BillingPosition&gt;)</returns>
                public async System.Threading.Tasks.Task<ApiResponse<List<BillingPosition>>> GetPositionsForOrganizationAsyncWithHttpInfo (string organizationId, DateTime? fromDate = null, DateTime? toDate = null)
                {
                        // verify the required parameter 'organizationId' is set
                        if (organizationId == null)
                        throw new ApiException(400, "Missing required parameter 'organizationId' when calling BillingApi->GetPositionsForOrganization");

                var localVarPath = "./api/v1/billing/{organizationId}/positions";
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
                    if (fromDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fromDate", fromDate)); // query parameter
                    if (toDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "toDate", toDate)); // query parameter

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
                Exception exception = ExceptionFactory("GetPositionsForOrganization", localVarResponse);
                if (exception != null) throw exception;
                }

                    return new ApiResponse<List<BillingPosition>>(localVarStatusCode,
                    localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                    (List<BillingPosition>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BillingPosition>)));
                }

            /// <summary>
            /// Get billing amount of services for a given organization 
            /// </summary>
            /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">The organization to compute the billing information for</param>
        /// <param name="fromDate">Billing start date (optional)</param>
        /// <param name="toDate">Billing end date (optional)</param>
        /// <returns>ServiceCosts</returns>
            public ServiceCosts GetSumForOrganization (string organizationId, DateTime? fromDate = null, DateTime? toDate = null)
            {
        ApiResponse<ServiceCosts> localVarResponse = GetSumForOrganizationWithHttpInfo(organizationId, fromDate, toDate);
            return localVarResponse.Data;
            }

            /// <summary>
            /// Get billing amount of services for a given organization 
            /// </summary>
            /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">The organization to compute the billing information for</param>
        /// <param name="fromDate">Billing start date (optional)</param>
        /// <param name="toDate">Billing end date (optional)</param>
        /// <returns>ApiResponse of ServiceCosts</returns>
            public ApiResponse< ServiceCosts > GetSumForOrganizationWithHttpInfo (string organizationId, DateTime? fromDate = null, DateTime? toDate = null)
            {
                    // verify the required parameter 'organizationId' is set
                    if (organizationId == null)
                    throw new ApiException(400, "Missing required parameter 'organizationId' when calling BillingApi->GetSumForOrganization");

            var localVarPath = "./api/v1/billing/{organizationId}";
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
                if (fromDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fromDate", fromDate)); // query parameter
                if (toDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "toDate", toDate)); // query parameter

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
            Exception exception = ExceptionFactory("GetSumForOrganization", localVarResponse);
            if (exception != null) throw exception;
            }

                return new ApiResponse<ServiceCosts>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ServiceCosts) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServiceCosts)));
            }

                /// <summary>
                /// Get billing amount of services for a given organization 
                /// </summary>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <param name="organizationId">The organization to compute the billing information for</param>
            /// <param name="fromDate">Billing start date (optional)</param>
            /// <param name="toDate">Billing end date (optional)</param>
            /// <returns>Task of ServiceCosts</returns>
            public async System.Threading.Tasks.Task<ServiceCosts> GetSumForOrganizationAsync (string organizationId, DateTime? fromDate = null, DateTime? toDate = null)
                {
            ApiResponse<ServiceCosts> localVarResponse = await GetSumForOrganizationAsyncWithHttpInfo(organizationId, fromDate, toDate);
                return localVarResponse.Data;

                }

                /// <summary>
                /// Get billing amount of services for a given organization 
                /// </summary>
                /// <exception cref="BlueRain.ID4i.Client.ApiException">Thrown when fails to make API call</exception>
            /// <param name="organizationId">The organization to compute the billing information for</param>
            /// <param name="fromDate">Billing start date (optional)</param>
            /// <param name="toDate">Billing end date (optional)</param>
            /// <returns>Task of ApiResponse (ServiceCosts)</returns>
                public async System.Threading.Tasks.Task<ApiResponse<ServiceCosts>> GetSumForOrganizationAsyncWithHttpInfo (string organizationId, DateTime? fromDate = null, DateTime? toDate = null)
                {
                        // verify the required parameter 'organizationId' is set
                        if (organizationId == null)
                        throw new ApiException(400, "Missing required parameter 'organizationId' when calling BillingApi->GetSumForOrganization");

                var localVarPath = "./api/v1/billing/{organizationId}";
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
                    if (fromDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "fromDate", fromDate)); // query parameter
                    if (toDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "toDate", toDate)); // query parameter

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
                Exception exception = ExceptionFactory("GetSumForOrganization", localVarResponse);
                if (exception != null) throw exception;
                }

                    return new ApiResponse<ServiceCosts>(localVarStatusCode,
                    localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                    (ServiceCosts) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServiceCosts)));
                }

        }
    }