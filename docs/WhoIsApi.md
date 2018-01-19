# .WhoIsApi

All URIs are relative to *https://backend.id4i.de*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ResolveWhoIsEntry**](WhoIsApi.md#resolvewhoisentry) | **GET** /whois/{id4n} | Resolve owner of id4n


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
            
            var apiInstance = new WhoIsApi();
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
                Debug.Print("Exception when calling WhoIsApi.ResolveWhoIsEntry: " + e.Message );
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

