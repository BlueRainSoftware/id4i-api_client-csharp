# .PublicServicesApi

All URIs are relative to *https://backend.id4i.de*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Go**](PublicServicesApi.md#go) | **GET** /go/{guid} | Forward
[**ResolveImageUsingGET**](PublicServicesApi.md#resolveimageusingget) | **GET** /api/v1/public/image/{imageID} | Resolve image
[**ResolveWhoIsEntry**](PublicServicesApi.md#resolvewhoisentry) | **GET** /whois/{id4n} | Resolve owner of id4n


<a name="go"></a>
# **Go**
> ApiError Go (string guid, string authorization, string acceptLanguage)

Forward

Forwarding to the designated route defined in the routing,

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class GoExample
    {
        public void main()
        {
            
            var apiInstance = new PublicServicesApi();
            var guid = guid_example;  // string | guid
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Forward
                ApiError result = apiInstance.Go(guid, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicServicesApi.Go: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **guid** | **string**| guid | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**ApiError**](ApiError.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resolveimageusingget"></a>
# **ResolveImageUsingGET**
> byte[] ResolveImageUsingGET (string imageID, string authorization, string acceptLanguage)

Resolve image

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class ResolveImageUsingGETExample
    {
        public void main()
        {
            
            var apiInstance = new PublicServicesApi();
            var imageID = imageID_example;  // string | The id of the image to be resolved.
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Resolve image
                byte[] result = apiInstance.ResolveImageUsingGET(imageID, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicServicesApi.ResolveImageUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageID** | **string**| The id of the image to be resolved. | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

**byte[]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resolvewhoisentry"></a>
# **ResolveWhoIsEntry**
> WhoIsResponse ResolveWhoIsEntry (string id4n, string authorization, string acceptLanguage)

Resolve owner of id4n

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class ResolveWhoIsEntryExample
    {
        public void main()
        {
            
            var apiInstance = new PublicServicesApi();
            var id4n = id4n_example;  // string | id4n
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Resolve owner of id4n
                WhoIsResponse result = apiInstance.ResolveWhoIsEntry(id4n, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicServicesApi.ResolveWhoIsEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**WhoIsResponse**](WhoIsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

