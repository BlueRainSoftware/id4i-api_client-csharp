# .MetaInformationApi

All URIs are relative to *https://backend.id4i.de*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplicationInfo**](MetaInformationApi.md#applicationinfo) | **GET** /api/v1/info | Retrieve version information about ID4i


<a name="applicationinfo"></a>
# **ApplicationInfo**
> AppInfoPresentation ApplicationInfo (string authorization, string acceptLanguage)

Retrieve version information about ID4i

Retrieving version information about ID4i.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class ApplicationInfoExample
    {
        public void main()
        {
            
            var apiInstance = new MetaInformationApi();
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Retrieve version information about ID4i
                AppInfoPresentation result = apiInstance.ApplicationInfo(authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetaInformationApi.ApplicationInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**AppInfoPresentation**](AppInfoPresentation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

