# BlueRain.ID4i.Api.TransferApi

All URIs are relative to *https://backend.id4i.de*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSendInfo**](TransferApi.md#getsendinfo) | **GET** /api/v1/transfers/{id4n}/sendInfo | Show transfer preparation information
[**Prepare**](TransferApi.md#prepare) | **PUT** /api/v1/transfers/{id4n}/sendInfo | Prepare an object for transfer
[**Receive**](TransferApi.md#receive) | **PUT** /api/v1/transfers/{id4n}/receiveInfo | Transfer a GUID or collection, obtaining it (i.e. becoming the holder) and if allowed also taking ownership


<a name="getsendinfo"></a>
# **GetSendInfo**
> TransferSendInfo GetSendInfo (string id4n)

Show transfer preparation information

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class GetSendInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransferApi();
            var id4n = id4n_example;  // string | The ID4N to retrieve information about

            try
            {
                // Show transfer preparation information
                TransferSendInfo result = apiInstance.GetSendInfo(id4n);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransferApi.GetSendInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| The ID4N to retrieve information about | 

### Return type

[**TransferSendInfo**](TransferSendInfo.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="prepare"></a>
# **Prepare**
> Object Prepare (string id4n, TransferSendInfo request)

Prepare an object for transfer

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class PrepareExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransferApi();
            var id4n = id4n_example;  // string | The ID4N to prepare for transfer
            var request = new TransferSendInfo(); // TransferSendInfo | Transfer preparation status

            try
            {
                // Prepare an object for transfer
                Object result = apiInstance.Prepare(id4n, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransferApi.Prepare: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| The ID4N to prepare for transfer | 
 **request** | [**TransferSendInfo**](TransferSendInfo.md)| Transfer preparation status | 

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="receive"></a>
# **Receive**
> void Receive (string id4n, TransferReceiveInfo request)

Transfer a GUID or collection, obtaining it (i.e. becoming the holder) and if allowed also taking ownership

Taking ownership can be forbidden by a previous owner. See methods prepare and getInfo

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class ReceiveExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransferApi();
            var id4n = id4n_example;  // string | This ID4N identifies the object to take hold of
            var request = new TransferReceiveInfo(); // TransferReceiveInfo | Required information to receive an id4n object

            try
            {
                // Transfer a GUID or collection, obtaining it (i.e. becoming the holder) and if allowed also taking ownership
                apiInstance.Receive(id4n, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransferApi.Receive: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| This ID4N identifies the object to take hold of | 
 **request** | [**TransferReceiveInfo**](TransferReceiveInfo.md)| Required information to receive an id4n object | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

