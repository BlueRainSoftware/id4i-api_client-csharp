# .MicrostorageApi

All URIs are relative to *https://backend.id4i.de*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Read**](MicrostorageApi.md#read) | **GET** /api/v1/microstorage/{id4n}/{organization} | Read data from microstorage
[**Write**](MicrostorageApi.md#write) | **PUT** /api/v1/microstorage/{id4n}/{organization} | Write data to microstorage


<a name="read"></a>
# **Read**
> InputStreamResource Read (long? organization, string id4n, string authorization, string acceptLanguage)

Read data from microstorage

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class ReadExample
    {
        public void main()
        {
            
            var apiInstance = new MicrostorageApi();
            var organization = 789;  // long? | organization
            var id4n = id4n_example;  // string | id4n
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Read data from microstorage
                InputStreamResource result = apiInstance.Read(organization, id4n, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MicrostorageApi.Read: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organization** | **long?**| organization | 
 **id4n** | **string**| id4n | 
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**InputStreamResource**](InputStreamResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="write"></a>
# **Write**
> Object Write (long? organization, string id4n, string authorization, string acceptLanguage, string contentType, long? contentLength)

Write data to microstorage

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class WriteExample
    {
        public void main()
        {
            
            var apiInstance = new MicrostorageApi();
            var organization = 789;  // long? | organization
            var id4n = id4n_example;  // string | id4n
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var contentType = contentType_example;  // string | Content-Type (optional) 
            var contentLength = 789;  // long? | Content-Length (optional) 

            try
            {
                // Write data to microstorage
                Object result = apiInstance.Write(organization, id4n, authorization, acceptLanguage, contentType, contentLength);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MicrostorageApi.Write: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organization** | **long?**| organization | 
 **id4n** | **string**| id4n | 
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **contentType** | **string**| Content-Type | [optional] 
 **contentLength** | **long?**| Content-Length | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, */*, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

