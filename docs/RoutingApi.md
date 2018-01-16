# DE.ID4i..RoutingApi

All URIs are relative to *https://backend.id4i.de*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetRoute**](RoutingApi.md#getroute) | **GET** /api/v1/routingfiles/{id4n}/route/{type} | Retrieve current route of a GUID (or ID4N)
[**GetRoutingFile**](RoutingApi.md#getroutingfile) | **GET** /api/v1/routingfiles/{id4n} | Retrieve routing file
[**UpdateRoutingFile**](RoutingApi.md#updateroutingfile) | **PUT** /api/v1/routingfiles/{id4n} | Store routing file


<a name="getroute"></a>
# **GetRoute**
> Route GetRoute (string id4n, string type, string authorization, string acceptLanguage, bool? privateRoutes, bool? publicRoutes)

Retrieve current route of a GUID (or ID4N)

### Example
```csharp
using System;
using System.Diagnostics;
using DE.ID4i.Api;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class GetRouteExample
    {
        public void main()
        {
            
            var apiInstance = new RoutingApi();
            var id4n = id4n_example;  // string | id4n
            var type = type_example;  // string | The type of route you want to have
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var privateRoutes = true;  // bool? | privateRoutes (optional) 
            var publicRoutes = true;  // bool? | publicRoutes (optional) 

            try
            {
                // Retrieve current route of a GUID (or ID4N)
                Route result = apiInstance.GetRoute(id4n, type, authorization, acceptLanguage, privateRoutes, publicRoutes);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **privateRoutes** | **bool?**| privateRoutes | [optional] 
 **publicRoutes** | **bool?**| publicRoutes | [optional] 

### Return type

[**Route**](Route.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getroutingfile"></a>
# **GetRoutingFile**
> RoutingFile GetRoutingFile (string id4n, string authorization, string acceptLanguage, long? organizationId)

Retrieve routing file

### Example
```csharp
using System;
using System.Diagnostics;
using DE.ID4i.Api;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class GetRoutingFileExample
    {
        public void main()
        {
            
            var apiInstance = new RoutingApi();
            var id4n = id4n_example;  // string | id4n
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var organizationId = 789;  // long? | organizationId (optional) 

            try
            {
                // Retrieve routing file
                RoutingFile result = apiInstance.GetRoutingFile(id4n, authorization, acceptLanguage, organizationId);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **organizationId** | **long?**| organizationId | [optional] 

### Return type

[**RoutingFile**](RoutingFile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateroutingfile"></a>
# **UpdateRoutingFile**
> ApiError UpdateRoutingFile (RoutingFileRequest rfr, string id4n, string authorization, string acceptLanguage)

Store routing file

### Example
```csharp
using System;
using System.Diagnostics;
using DE.ID4i.Api;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class UpdateRoutingFileExample
    {
        public void main()
        {
            
            var apiInstance = new RoutingApi();
            var rfr = new RoutingFileRequest(); // RoutingFileRequest | rfr
            var id4n = id4n_example;  // string | id4n
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Store routing file
                ApiError result = apiInstance.UpdateRoutingFile(rfr, id4n, authorization, acceptLanguage);
                Debug.WriteLine(result);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**ApiError**](ApiError.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

