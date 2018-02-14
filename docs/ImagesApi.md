# BlueRain.ID4i.Api.ImagesApi

All URIs are relative to *https://backend.id4i.de*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ResolveImageUsingGET**](ImagesApi.md#resolveimageusingget) | **GET** /api/v1/public/image/{imageID} | Resolve image


<a name="resolveimageusingget"></a>
# **ResolveImageUsingGET**
> byte[] ResolveImageUsingGET (string imageID)

Resolve image

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class ResolveImageUsingGETExample
    {
        public void main()
        {
            
            // Configure API key authorization: Authorization
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ImagesApi();
            var imageID = imageID_example;  // string | The id of the image to be resolved.

            try
            {
                // Resolve image
                byte[] result = apiInstance.ResolveImageUsingGET(imageID);
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

### Return type

**byte[]**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

