# BlueRain.ID4i.Api.RoutingApi

All URIs are relative to *https://backend.id4i.de*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllRoutes**](RoutingApi.md#getallroutes) | **GET** /api/v1/routingfiles/{id4n}/routes/{type} | Retrieve all routes of a GUID (or ID4N)
[**GetRoute**](RoutingApi.md#getroute) | **GET** /api/v1/routingfiles/{id4n}/route/{type} | Retrieve current route of a GUID (or ID4N)
[**GetRoutingFile**](RoutingApi.md#getroutingfile) | **GET** /api/v1/routingfiles/{id4n} | Retrieve routing file
[**UpdateRoutingFile**](RoutingApi.md#updateroutingfile) | **PUT** /api/v1/routingfiles/{id4n} | Store routing file


<a name="getallroutes"></a>
# **GetAllRoutes**
> List<Route> GetAllRoutes (string id4n, string type, string organizationId = null, bool? interpolate = null)

Retrieve all routes of a GUID (or ID4N)

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class GetAllRoutesExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RoutingApi();
            var id4n = id4n_example;  // string | id4n
            var type = type_example;  // string | The type of route you want to have
            var organizationId = organizationId_example;  // string | organizationId (optional) 
            var interpolate = true;  // bool? | interpolate (optional)  (default to true)

            try
            {
                // Retrieve all routes of a GUID (or ID4N)
                List&lt;Route&gt; result = apiInstance.GetAllRoutes(id4n, type, organizationId, interpolate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetAllRoutes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 
 **type** | **string**| The type of route you want to have | 
 **organizationId** | **string**| organizationId | [optional] 
 **interpolate** | **bool?**| interpolate | [optional] [default to true]

### Return type

[**List<Route>**](Route.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getroute"></a>
# **GetRoute**
> Route GetRoute (string id4n, string type, bool? privateRoutes = null, bool? publicRoutes = null, bool? interpolate = null)

Retrieve current route of a GUID (or ID4N)

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class GetRouteExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RoutingApi();
            var id4n = id4n_example;  // string | id4n
            var type = type_example;  // string | The type of route you want to have
            var privateRoutes = true;  // bool? | privateRoutes (optional)  (default to true)
            var publicRoutes = true;  // bool? | publicRoutes (optional)  (default to true)
            var interpolate = true;  // bool? | interpolate (optional)  (default to true)

            try
            {
                // Retrieve current route of a GUID (or ID4N)
                Route result = apiInstance.GetRoute(id4n, type, privateRoutes, publicRoutes, interpolate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoute: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 
 **type** | **string**| The type of route you want to have | 
 **privateRoutes** | **bool?**| privateRoutes | [optional] [default to true]
 **publicRoutes** | **bool?**| publicRoutes | [optional] [default to true]
 **interpolate** | **bool?**| interpolate | [optional] [default to true]

### Return type

[**Route**](Route.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getroutingfile"></a>
# **GetRoutingFile**
> RoutingFile GetRoutingFile (string id4n, string organizationId = null)

Retrieve routing file

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class GetRoutingFileExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RoutingApi();
            var id4n = id4n_example;  // string | id4n
            var organizationId = organizationId_example;  // string | organizationId (optional) 

            try
            {
                // Retrieve routing file
                RoutingFile result = apiInstance.GetRoutingFile(id4n, organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.GetRoutingFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 
 **organizationId** | **string**| organizationId | [optional] 

### Return type

[**RoutingFile**](RoutingFile.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateroutingfile"></a>
# **UpdateRoutingFile**
> void UpdateRoutingFile (RoutingFileRequest rfr, string id4n)

Store routing file

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class UpdateRoutingFileExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RoutingApi();
            var rfr = new RoutingFileRequest(); // RoutingFileRequest | rfr
            var id4n = id4n_example;  // string | id4n

            try
            {
                // Store routing file
                apiInstance.UpdateRoutingFile(rfr, id4n);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RoutingApi.UpdateRoutingFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rfr** | [**RoutingFileRequest**](RoutingFileRequest.md)| rfr | 
 **id4n** | **string**| id4n | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

