# BlueRain.ID4i.Api.MessagingApi

All URIs are relative to *https://backend.id4i.de*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EnqueueCustomMessage**](MessagingApi.md#enqueuecustommessage) | **POST** /api/v1/organizations/{organizationId}/messaging/enqueueCustomMessage | Enqueue a custom message
[**GetDefaultQueue**](MessagingApi.md#getdefaultqueue) | **GET** /api/v1/organizations/{organizationId}/messaging | 
[**PatchDefaultQueue**](MessagingApi.md#patchdefaultqueue) | **PATCH** /api/v1/organizations/{organizationId}/messaging | 


<a name="enqueuecustommessage"></a>
# **EnqueueCustomMessage**
> void EnqueueCustomMessage (string organizationId, SendCustomMessage request)

Enqueue a custom message

Enqueue a custom organisation message with custom data.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class EnqueueCustomMessageExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessagingApi();
            var organizationId = organizationId_example;  // string | The organisation namespace
            var request = new SendCustomMessage(); // SendCustomMessage | request

            try
            {
                // Enqueue a custom message
                apiInstance.EnqueueCustomMessage(organizationId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.EnqueueCustomMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| The organisation namespace | 
 **request** | [**SendCustomMessage**](SendCustomMessage.md)| request | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdefaultqueue"></a>
# **GetDefaultQueue**
> QueuePresentation GetDefaultQueue (string organizationId)



### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class GetDefaultQueueExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessagingApi();
            var organizationId = organizationId_example;  // string | organizationId

            try
            {
                QueuePresentation result = apiInstance.GetDefaultQueue(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.GetDefaultQueue: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| organizationId | 

### Return type

[**QueuePresentation**](QueuePresentation.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchdefaultqueue"></a>
# **PatchDefaultQueue**
> void PatchDefaultQueue (string organizationId, QueueUpdateRequest request)



### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class PatchDefaultQueueExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessagingApi();
            var organizationId = organizationId_example;  // string | organizationId
            var request = new QueueUpdateRequest(); // QueueUpdateRequest | request

            try
            {
                apiInstance.PatchDefaultQueue(organizationId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagingApi.PatchDefaultQueue: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| organizationId | 
 **request** | [**QueueUpdateRequest**](QueueUpdateRequest.md)| request | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

