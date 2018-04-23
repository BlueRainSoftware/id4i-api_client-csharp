# BlueRain.ID4i.Api.HistoryApi

All URIs are relative to *https://backend.id4i.de*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddItem**](HistoryApi.md#additem) | **POST** /api/v1/history/{id4n} | Add history item
[**List**](HistoryApi.md#list) | **GET** /api/v1/history/{id4n}/{organizationId} | List history
[**ListAll**](HistoryApi.md#listall) | **GET** /api/v1/history/{id4n} | List history
[**RetrieveItem**](HistoryApi.md#retrieveitem) | **GET** /api/v1/history/{id4n}/{organizationId}/{sequenceId} | List history
[**UpdateItem**](HistoryApi.md#updateitem) | **PATCH** /api/v1/history/{id4n}/{organizationId}/{sequenceId} | Update history item
[**UpdateItemVisibility**](HistoryApi.md#updateitemvisibility) | **PUT** /api/v1/history/{id4n}/{organizationId}/{sequenceId}/visibility | Set history item visibility


<a name="additem"></a>
# **AddItem**
> void AddItem (string id4n, HistoryItem historyItem)

Add history item

Add a new history item

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class AddItemExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new HistoryApi();
            var id4n = id4n_example;  // string | GUID to retrieve the history for
            var historyItem = new HistoryItem(); // HistoryItem | The history item to publish

            try
            {
                // Add history item
                apiInstance.AddItem(id4n, historyItem);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HistoryApi.AddItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| GUID to retrieve the history for | 
 **historyItem** | [**HistoryItem**](HistoryItem.md)| The history item to publish | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="list"></a>
# **List**
> PaginatedHistoryItemResponse List (string id4n, long? organizationId, bool? includePrivate = null, int? offset = null, int? limit = null)

List history

Lists the history of a GUID

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class ListExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new HistoryApi();
            var id4n = id4n_example;  // string | GUID to retrieve the history for
            var organizationId = 789;  // long? | organizationId
            var includePrivate = true;  // bool? | Also return private history entries (optional)  (default to true)
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // List history
                PaginatedHistoryItemResponse result = apiInstance.List(id4n, organizationId, includePrivate, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HistoryApi.List: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| GUID to retrieve the history for | 
 **organizationId** | **long?**| organizationId | 
 **includePrivate** | **bool?**| Also return private history entries | [optional] [default to true]
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedHistoryItemResponse**](PaginatedHistoryItemResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listall"></a>
# **ListAll**
> PaginatedHistoryItemResponse ListAll (string id4n, bool? includePrivate = null, int? offset = null, int? limit = null)

List history

Lists the history of a GUID

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class ListAllExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new HistoryApi();
            var id4n = id4n_example;  // string | GUID to retrieve the history for
            var includePrivate = true;  // bool? | Also return private history entries (optional)  (default to true)
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // List history
                PaginatedHistoryItemResponse result = apiInstance.ListAll(id4n, includePrivate, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HistoryApi.ListAll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| GUID to retrieve the history for | 
 **includePrivate** | **bool?**| Also return private history entries | [optional] [default to true]
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedHistoryItemResponse**](PaginatedHistoryItemResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrieveitem"></a>
# **RetrieveItem**
> PaginatedHistoryItemResponse RetrieveItem (string id4n, long? organizationId, int? sequenceId)

List history

Lists the history of a GUID

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class RetrieveItemExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new HistoryApi();
            var id4n = id4n_example;  // string | GUID to retrieve the history for
            var organizationId = 789;  // long? | organizationId
            var sequenceId = 56;  // int? | sequenceId

            try
            {
                // List history
                PaginatedHistoryItemResponse result = apiInstance.RetrieveItem(id4n, organizationId, sequenceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HistoryApi.RetrieveItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| GUID to retrieve the history for | 
 **organizationId** | **long?**| organizationId | 
 **sequenceId** | **int?**| sequenceId | 

### Return type

[**PaginatedHistoryItemResponse**](PaginatedHistoryItemResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateitem"></a>
# **UpdateItem**
> HistoryItem UpdateItem (string id4n, long? organizationId, int? sequenceId, HistoryItemUpdate update)

Update history item

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class UpdateItemExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new HistoryApi();
            var id4n = id4n_example;  // string | GUID to retrieve the history for
            var organizationId = 789;  // long? | organizationId
            var sequenceId = 56;  // int? | sequenceId
            var update = new HistoryItemUpdate(); // HistoryItemUpdate | update

            try
            {
                // Update history item
                HistoryItem result = apiInstance.UpdateItem(id4n, organizationId, sequenceId, update);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HistoryApi.UpdateItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| GUID to retrieve the history for | 
 **organizationId** | **long?**| organizationId | 
 **sequenceId** | **int?**| sequenceId | 
 **update** | [**HistoryItemUpdate**](HistoryItemUpdate.md)| update | 

### Return type

[**HistoryItem**](HistoryItem.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateitemvisibility"></a>
# **UpdateItemVisibility**
> HistoryItem UpdateItemVisibility (string id4n, long? organizationId, int? sequenceId, Visibility visibility)

Set history item visibility

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class UpdateItemVisibilityExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new HistoryApi();
            var id4n = id4n_example;  // string | GUID to retrieve the history for
            var organizationId = 789;  // long? | organizationId
            var sequenceId = 56;  // int? | sequenceId
            var visibility = new Visibility(); // Visibility | History item visibility restrictions

            try
            {
                // Set history item visibility
                HistoryItem result = apiInstance.UpdateItemVisibility(id4n, organizationId, sequenceId, visibility);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HistoryApi.UpdateItemVisibility: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| GUID to retrieve the history for | 
 **organizationId** | **long?**| organizationId | 
 **sequenceId** | **int?**| sequenceId | 
 **visibility** | [**Visibility**](Visibility.md)| History item visibility restrictions | 

### Return type

[**HistoryItem**](HistoryItem.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
