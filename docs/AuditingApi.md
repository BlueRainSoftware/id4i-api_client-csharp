# BlueRain.ID4i.Api.AuditingApi

All URIs are relative to *https://backend.id4i.de*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListOrganizationChangeLog**](AuditingApi.md#listorganizationchangelog) | **GET** /api/v1/changelog/organization/{organizationId}/ | List change log entries of an organization


<a name="listorganizationchangelog"></a>
# **ListOrganizationChangeLog**
> PaginatedChangeLogEntryResponse ListOrganizationChangeLog (string organizationId, string messageMimeType = null, DateTime? fromDate = null, DateTime? toDate = null, int? offset = null, int? limit = null)

List change log entries of an organization

Listing change log entries of the specified organization id.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class ListOrganizationChangeLogExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuditingApi();
            var organizationId = organizationId_example;  // string | The namespace identifying the organization whose change log entries are to be listed
            var messageMimeType = messageMimeType_example;  // string | The Mime-type for the message format that should be returned. e.g. 'text/plain' or 'text/mustache'  (optional)  (default to text/mustache)
            var fromDate = 2013-10-20T19:20:30+01:00;  // DateTime? | From date time as UTC Date-Time format (optional) 
            var toDate = 2013-10-20T19:20:30+01:00;  // DateTime? | To date time as UTC Date-Time format (optional) 
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // List change log entries of an organization
                PaginatedChangeLogEntryResponse result = apiInstance.ListOrganizationChangeLog(organizationId, messageMimeType, fromDate, toDate, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuditingApi.ListOrganizationChangeLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| The namespace identifying the organization whose change log entries are to be listed | 
 **messageMimeType** | **string**| The Mime-type for the message format that should be returned. e.g. &#39;text/plain&#39; or &#39;text/mustache&#39;  | [optional] [default to text/mustache]
 **fromDate** | **DateTime?**| From date time as UTC Date-Time format | [optional] 
 **toDate** | **DateTime?**| To date time as UTC Date-Time format | [optional] 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedChangeLogEntryResponse**](PaginatedChangeLogEntryResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

