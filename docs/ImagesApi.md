# .ImagesApi

All URIs are relative to *https://backend.id4i.de*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ResolveImageUsingGET**](ImagesApi.md#resolveimageusingget) | **GET** /api/v1/public/image/{imageID} | Resolve image


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
            
            var apiInstance = new ImagesApi();
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
                Debug.Print("Exception when calling ImagesApi.ResolveImageUsingGET: " + e.Message );
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

