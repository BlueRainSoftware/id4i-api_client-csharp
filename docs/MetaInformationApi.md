# BlueRain.ID4i.Api.MetaInformationApi

All URIs are relative to *https://backend.id4i.de*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplicationInfo**](MetaInformationApi.md#applicationinfo) | **GET** /api/v1/info | Retrieve version information about ID4i


<a name="applicationinfo"></a>
# **ApplicationInfo**
> AppInfoPresentation ApplicationInfo ()

Retrieve version information about ID4i

Retrieving version information about ID4i.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class ApplicationInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MetaInformationApi();

            try
            {
                // Retrieve version information about ID4i
                AppInfoPresentation result = apiInstance.ApplicationInfo();
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
This endpoint does not need any parameter.

### Return type

[**AppInfoPresentation**](AppInfoPresentation.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

