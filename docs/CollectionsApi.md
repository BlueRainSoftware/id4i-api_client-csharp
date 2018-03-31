# BlueRain.ID4i.Api.CollectionsApi

All URIs are relative to *https://backend.id4i.de*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddElementsToCollection**](CollectionsApi.md#addelementstocollection) | **POST** /api/v1/collections/{id4n}/elements | Add elements to collection
[**AddElementsToLabelledCollection**](CollectionsApi.md#addelementstolabelledcollection) | **POST** /api/v1/collections/labelled/{collectionId4n}/elements | Add elements to labelled collection
[**AddElementsToLogisticCollection**](CollectionsApi.md#addelementstologisticcollection) | **POST** /api/v1/collections/logistic/{collectionId4n}/elements | Add elements to logistic collection
[**AddElementsToRoutingCollection**](CollectionsApi.md#addelementstoroutingcollection) | **POST** /api/v1/collections/routing/{collectionId4n}/elements | Add element to routing collection
[**CreateLabelledCollection**](CollectionsApi.md#createlabelledcollection) | **POST** /api/v1/collections/labelled | Create labelled collection
[**CreateLogisticCollection**](CollectionsApi.md#createlogisticcollection) | **POST** /api/v1/collections/logistic | Create logistic collection
[**CreateRoutingCollection**](CollectionsApi.md#createroutingcollection) | **POST** /api/v1/collections/routing | Create routing collecton
[**DeleteCollection**](CollectionsApi.md#deletecollection) | **DELETE** /api/v1/collections/{id4n} | Delete collection
[**DeleteLabelledCollection**](CollectionsApi.md#deletelabelledcollection) | **DELETE** /api/v1/collections/labelled/{id4n} | Delete labelled collection
[**DeleteLogisticCollection**](CollectionsApi.md#deletelogisticcollection) | **DELETE** /api/v1/collections/logistic/{id4n} | Delete logistic collection
[**DeleteRoutingCollection**](CollectionsApi.md#deleteroutingcollection) | **DELETE** /api/v1/collections/routing/{id4n} | Delete routing collection
[**FindCollection**](CollectionsApi.md#findcollection) | **GET** /api/v1/collections/{id4n} | Find collection
[**FindLabelledCollection**](CollectionsApi.md#findlabelledcollection) | **GET** /api/v1/collections/labelled/{id4n} | Find labelled collection
[**FindLogisticCollection**](CollectionsApi.md#findlogisticcollection) | **GET** /api/v1/collections/logistic/{id4n} | Find logistic collection
[**FindRoutingCollection**](CollectionsApi.md#findroutingcollection) | **GET** /api/v1/collections/routing/{id4n} | Find routing collection
[**GetAllCollectionsOfOrganization**](CollectionsApi.md#getallcollectionsoforganization) | **GET** /api/v1/organizations/{organizationId}/collections | Get collections of organization
[**ListElementsOfCollection**](CollectionsApi.md#listelementsofcollection) | **GET** /api/v1/collections/{id4n}/elements | List contents of the collection
[**ListElementsOfLabelledCollection**](CollectionsApi.md#listelementsoflabelledcollection) | **GET** /api/v1/collections/labelled/{id4n}/elements | List contents of the collection
[**ListElementsOfLogisticCollection**](CollectionsApi.md#listelementsoflogisticcollection) | **GET** /api/v1/collections/logistic/{id4n}/elements | List contents of the collection
[**ListElementsOfRoutingCollection**](CollectionsApi.md#listelementsofroutingcollection) | **GET** /api/v1/collections/routing/{id4n}/elements | List contents of the collection
[**RemoveElementsFromCollection**](CollectionsApi.md#removeelementsfromcollection) | **DELETE** /api/v1/collections/{id4n}/elements | Remove elements from collection
[**RemoveElementsFromLabelledCollection**](CollectionsApi.md#removeelementsfromlabelledcollection) | **DELETE** /api/v1/collections/labelled/{collectionId4n}/elements | Remove elements from labelled collection
[**RemoveElementsFromLogisticCollection**](CollectionsApi.md#removeelementsfromlogisticcollection) | **DELETE** /api/v1/collections/logistic/{collectionId4n}/elements | Remove elements from logistic collection
[**RemoveElementsFromRoutingCollection**](CollectionsApi.md#removeelementsfromroutingcollection) | **DELETE** /api/v1/collections/routing/{collectionId4n}/elements | Remove elements from routing collection
[**UpdateCollection**](CollectionsApi.md#updatecollection) | **PATCH** /api/v1/collections/{id4n} | Update collection
[**UpdateLabelledCollection**](CollectionsApi.md#updatelabelledcollection) | **PATCH** /api/v1/collections/labelled/{id4n} | Update labelled collection
[**UpdateLogisticCollection**](CollectionsApi.md#updatelogisticcollection) | **PATCH** /api/v1/collections/logistic/{id4n} | Update logistic collection
[**UpdateRoutingCollection**](CollectionsApi.md#updateroutingcollection) | **PATCH** /api/v1/collections/routing/{id4n} | Update routing collection


<a name="addelementstocollection"></a>
# **AddElementsToCollection**
> void AddElementsToCollection (string id4n, ListOfId4ns listOfGuids)

Add elements to collection

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class AddElementsToCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var listOfGuids = new ListOfId4ns(); // ListOfId4ns | listOfGuids

            try
            {
                // Add elements to collection
                apiInstance.AddElementsToCollection(id4n, listOfGuids);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.AddElementsToCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 
 **listOfGuids** | [**ListOfId4ns**](ListOfId4ns.md)| listOfGuids | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addelementstolabelledcollection"></a>
# **AddElementsToLabelledCollection**
> void AddElementsToLabelledCollection (string collectionId4n, ListOfId4ns listOfGuids)

Add elements to labelled collection

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class AddElementsToLabelledCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var collectionId4n = collectionId4n_example;  // string | collectionId4n
            var listOfGuids = new ListOfId4ns(); // ListOfId4ns | listOfGuids

            try
            {
                // Add elements to labelled collection
                apiInstance.AddElementsToLabelledCollection(collectionId4n, listOfGuids);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.AddElementsToLabelledCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId4n** | **string**| collectionId4n | 
 **listOfGuids** | [**ListOfId4ns**](ListOfId4ns.md)| listOfGuids | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addelementstologisticcollection"></a>
# **AddElementsToLogisticCollection**
> void AddElementsToLogisticCollection (string collectionId4n, ListOfId4ns listOfGuids)

Add elements to logistic collection

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class AddElementsToLogisticCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var collectionId4n = collectionId4n_example;  // string | collectionId4n
            var listOfGuids = new ListOfId4ns(); // ListOfId4ns | listOfGuids

            try
            {
                // Add elements to logistic collection
                apiInstance.AddElementsToLogisticCollection(collectionId4n, listOfGuids);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.AddElementsToLogisticCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId4n** | **string**| collectionId4n | 
 **listOfGuids** | [**ListOfId4ns**](ListOfId4ns.md)| listOfGuids | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addelementstoroutingcollection"></a>
# **AddElementsToRoutingCollection**
> void AddElementsToRoutingCollection (string collectionId4n, ListOfId4ns listOfGuids)

Add element to routing collection

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class AddElementsToRoutingCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var collectionId4n = collectionId4n_example;  // string | collectionId4n
            var listOfGuids = new ListOfId4ns(); // ListOfId4ns | listOfGuids

            try
            {
                // Add element to routing collection
                apiInstance.AddElementsToRoutingCollection(collectionId4n, listOfGuids);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.AddElementsToRoutingCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId4n** | **string**| collectionId4n | 
 **listOfGuids** | [**ListOfId4ns**](ListOfId4ns.md)| listOfGuids | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createlabelledcollection"></a>
# **CreateLabelledCollection**
> Id4n CreateLabelledCollection (CreateLabelledCollectionRequest createInfo)

Create labelled collection

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class CreateLabelledCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var createInfo = new CreateLabelledCollectionRequest(); // CreateLabelledCollectionRequest | createInfo

            try
            {
                // Create labelled collection
                Id4n result = apiInstance.CreateLabelledCollection(createInfo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.CreateLabelledCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createInfo** | [**CreateLabelledCollectionRequest**](CreateLabelledCollectionRequest.md)| createInfo | 

### Return type

[**Id4n**](Id4n.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createlogisticcollection"></a>
# **CreateLogisticCollection**
> Id4n CreateLogisticCollection (CreateLogisticCollectionRequest createInfo)

Create logistic collection

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class CreateLogisticCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var createInfo = new CreateLogisticCollectionRequest(); // CreateLogisticCollectionRequest | createInfo

            try
            {
                // Create logistic collection
                Id4n result = apiInstance.CreateLogisticCollection(createInfo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.CreateLogisticCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createInfo** | [**CreateLogisticCollectionRequest**](CreateLogisticCollectionRequest.md)| createInfo | 

### Return type

[**Id4n**](Id4n.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createroutingcollection"></a>
# **CreateRoutingCollection**
> Id4n CreateRoutingCollection (CreateRoutingCollectionRequest createInfo)

Create routing collecton

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class CreateRoutingCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var createInfo = new CreateRoutingCollectionRequest(); // CreateRoutingCollectionRequest | createInfo

            try
            {
                // Create routing collecton
                Id4n result = apiInstance.CreateRoutingCollection(createInfo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.CreateRoutingCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createInfo** | [**CreateRoutingCollectionRequest**](CreateRoutingCollectionRequest.md)| createInfo | 

### Return type

[**Id4n**](Id4n.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecollection"></a>
# **DeleteCollection**
> void DeleteCollection (string id4n)

Delete collection

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class DeleteCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n

            try
            {
                // Delete collection
                apiInstance.DeleteCollection(id4n);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.DeleteCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelabelledcollection"></a>
# **DeleteLabelledCollection**
> void DeleteLabelledCollection (string id4n)

Delete labelled collection

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class DeleteLabelledCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n

            try
            {
                // Delete labelled collection
                apiInstance.DeleteLabelledCollection(id4n);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.DeleteLabelledCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelogisticcollection"></a>
# **DeleteLogisticCollection**
> Object DeleteLogisticCollection (string id4n)

Delete logistic collection

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class DeleteLogisticCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n

            try
            {
                // Delete logistic collection
                Object result = apiInstance.DeleteLogisticCollection(id4n);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.DeleteLogisticCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteroutingcollection"></a>
# **DeleteRoutingCollection**
> void DeleteRoutingCollection (string id4n)

Delete routing collection

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class DeleteRoutingCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n

            try
            {
                // Delete routing collection
                apiInstance.DeleteRoutingCollection(id4n);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.DeleteRoutingCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findcollection"></a>
# **FindCollection**
> GuidCollection FindCollection (string id4n)

Find collection

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class FindCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n

            try
            {
                // Find collection
                GuidCollection result = apiInstance.FindCollection(id4n);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.FindCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 

### Return type

[**GuidCollection**](GuidCollection.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findlabelledcollection"></a>
# **FindLabelledCollection**
> GuidCollection FindLabelledCollection (string id4n)

Find labelled collection

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class FindLabelledCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n

            try
            {
                // Find labelled collection
                GuidCollection result = apiInstance.FindLabelledCollection(id4n);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.FindLabelledCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 

### Return type

[**GuidCollection**](GuidCollection.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findlogisticcollection"></a>
# **FindLogisticCollection**
> GuidCollection FindLogisticCollection (string id4n)

Find logistic collection

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class FindLogisticCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n

            try
            {
                // Find logistic collection
                GuidCollection result = apiInstance.FindLogisticCollection(id4n);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.FindLogisticCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 

### Return type

[**GuidCollection**](GuidCollection.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findroutingcollection"></a>
# **FindRoutingCollection**
> GuidCollection FindRoutingCollection (string id4n)

Find routing collection

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class FindRoutingCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n

            try
            {
                // Find routing collection
                GuidCollection result = apiInstance.FindRoutingCollection(id4n);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.FindRoutingCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 

### Return type

[**GuidCollection**](GuidCollection.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallcollectionsoforganization"></a>
# **GetAllCollectionsOfOrganization**
> PaginatedGuidCollection GetAllCollectionsOfOrganization (long? organizationId, int? offset = null, int? limit = null, string type = null, string label = null, string labelPrefix = null)

Get collections of organization

Retrieving all collections of an organization in a paginated manner.

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class GetAllCollectionsOfOrganizationExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var organizationId = 789;  // long? | organizationId
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 
            var type = type_example;  // string | Filter by this type (optional) 
            var label = label_example;  // string | Filter by this label (optional) 
            var labelPrefix = labelPrefix_example;  // string | Filter by this label prefix (optional) 

            try
            {
                // Get collections of organization
                PaginatedGuidCollection result = apiInstance.GetAllCollectionsOfOrganization(organizationId, offset, limit, type, label, labelPrefix);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.GetAllCollectionsOfOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| organizationId | 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 
 **type** | **string**| Filter by this type | [optional] 
 **label** | **string**| Filter by this label | [optional] 
 **labelPrefix** | **string**| Filter by this label prefix | [optional] 

### Return type

[**PaginatedGuidCollection**](PaginatedGuidCollection.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listelementsofcollection"></a>
# **ListElementsOfCollection**
> PaginatedGuidResponse ListElementsOfCollection (string id4n, int? offset = null, int? limit = null)

List contents of the collection

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class ListElementsOfCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // List contents of the collection
                PaginatedGuidResponse result = apiInstance.ListElementsOfCollection(id4n, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.ListElementsOfCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedGuidResponse**](PaginatedGuidResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listelementsoflabelledcollection"></a>
# **ListElementsOfLabelledCollection**
> PaginatedGuidResponse ListElementsOfLabelledCollection (string id4n, int? offset = null, int? limit = null)

List contents of the collection

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class ListElementsOfLabelledCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // List contents of the collection
                PaginatedGuidResponse result = apiInstance.ListElementsOfLabelledCollection(id4n, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.ListElementsOfLabelledCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedGuidResponse**](PaginatedGuidResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listelementsoflogisticcollection"></a>
# **ListElementsOfLogisticCollection**
> PaginatedGuidResponse ListElementsOfLogisticCollection (string id4n, int? offset = null, int? limit = null)

List contents of the collection

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class ListElementsOfLogisticCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // List contents of the collection
                PaginatedGuidResponse result = apiInstance.ListElementsOfLogisticCollection(id4n, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.ListElementsOfLogisticCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedGuidResponse**](PaginatedGuidResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listelementsofroutingcollection"></a>
# **ListElementsOfRoutingCollection**
> PaginatedGuidResponse ListElementsOfRoutingCollection (string id4n, int? offset = null, int? limit = null)

List contents of the collection

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class ListElementsOfRoutingCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var offset = 56;  // int? | Start with the n-th element (optional) 
            var limit = 56;  // int? | The maximum count of returned elements (optional) 

            try
            {
                // List contents of the collection
                PaginatedGuidResponse result = apiInstance.ListElementsOfRoutingCollection(id4n, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.ListElementsOfRoutingCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 
 **offset** | **int?**| Start with the n-th element | [optional] 
 **limit** | **int?**| The maximum count of returned elements | [optional] 

### Return type

[**PaginatedGuidResponse**](PaginatedGuidResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeelementsfromcollection"></a>
# **RemoveElementsFromCollection**
> void RemoveElementsFromCollection (string id4n, ListOfId4ns listOfGuids)

Remove elements from collection

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class RemoveElementsFromCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var listOfGuids = new ListOfId4ns(); // ListOfId4ns | listOfGuids

            try
            {
                // Remove elements from collection
                apiInstance.RemoveElementsFromCollection(id4n, listOfGuids);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.RemoveElementsFromCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 
 **listOfGuids** | [**ListOfId4ns**](ListOfId4ns.md)| listOfGuids | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeelementsfromlabelledcollection"></a>
# **RemoveElementsFromLabelledCollection**
> void RemoveElementsFromLabelledCollection (string collectionId4n, ListOfId4ns listOfGuids)

Remove elements from labelled collection

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class RemoveElementsFromLabelledCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var collectionId4n = collectionId4n_example;  // string | collectionId4n
            var listOfGuids = new ListOfId4ns(); // ListOfId4ns | listOfGuids

            try
            {
                // Remove elements from labelled collection
                apiInstance.RemoveElementsFromLabelledCollection(collectionId4n, listOfGuids);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.RemoveElementsFromLabelledCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId4n** | **string**| collectionId4n | 
 **listOfGuids** | [**ListOfId4ns**](ListOfId4ns.md)| listOfGuids | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeelementsfromlogisticcollection"></a>
# **RemoveElementsFromLogisticCollection**
> void RemoveElementsFromLogisticCollection (string collectionId4n, ListOfId4ns listOfGuids)

Remove elements from logistic collection

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class RemoveElementsFromLogisticCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var collectionId4n = collectionId4n_example;  // string | collectionId4n
            var listOfGuids = new ListOfId4ns(); // ListOfId4ns | listOfGuids

            try
            {
                // Remove elements from logistic collection
                apiInstance.RemoveElementsFromLogisticCollection(collectionId4n, listOfGuids);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.RemoveElementsFromLogisticCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId4n** | **string**| collectionId4n | 
 **listOfGuids** | [**ListOfId4ns**](ListOfId4ns.md)| listOfGuids | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeelementsfromroutingcollection"></a>
# **RemoveElementsFromRoutingCollection**
> void RemoveElementsFromRoutingCollection (string collectionId4n, ListOfId4ns listOfGuids)

Remove elements from routing collection

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class RemoveElementsFromRoutingCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var collectionId4n = collectionId4n_example;  // string | collectionId4n
            var listOfGuids = new ListOfId4ns(); // ListOfId4ns | listOfGuids

            try
            {
                // Remove elements from routing collection
                apiInstance.RemoveElementsFromRoutingCollection(collectionId4n, listOfGuids);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.RemoveElementsFromRoutingCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId4n** | **string**| collectionId4n | 
 **listOfGuids** | [**ListOfId4ns**](ListOfId4ns.md)| listOfGuids | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecollection"></a>
# **UpdateCollection**
> Object UpdateCollection (string id4n, GuidCollection request)

Update collection

Update collection changing only the given values

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class UpdateCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var request = new GuidCollection(); // GuidCollection | request

            try
            {
                // Update collection
                Object result = apiInstance.UpdateCollection(id4n, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.UpdateCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 
 **request** | [**GuidCollection**](GuidCollection.md)| request | 

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelabelledcollection"></a>
# **UpdateLabelledCollection**
> Object UpdateLabelledCollection (string id4n, GuidCollection request)

Update labelled collection

Update labelled collection updating only the given values

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class UpdateLabelledCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var request = new GuidCollection(); // GuidCollection | request

            try
            {
                // Update labelled collection
                Object result = apiInstance.UpdateLabelledCollection(id4n, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.UpdateLabelledCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 
 **request** | [**GuidCollection**](GuidCollection.md)| request | 

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelogisticcollection"></a>
# **UpdateLogisticCollection**
> Object UpdateLogisticCollection (string id4n, GuidCollection request)

Update logistic collection

Update logistic collection updating only the given values

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class UpdateLogisticCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var request = new GuidCollection(); // GuidCollection | request

            try
            {
                // Update logistic collection
                Object result = apiInstance.UpdateLogisticCollection(id4n, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.UpdateLogisticCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 
 **request** | [**GuidCollection**](GuidCollection.md)| request | 

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateroutingcollection"></a>
# **UpdateRoutingCollection**
> Object UpdateRoutingCollection (string id4n, GuidCollection request)

Update routing collection

Update routing collection updating only the given values

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class UpdateRoutingCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var request = new GuidCollection(); // GuidCollection | request

            try
            {
                // Update routing collection
                Object result = apiInstance.UpdateRoutingCollection(id4n, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.UpdateRoutingCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 
 **request** | [**GuidCollection**](GuidCollection.md)| request | 

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

