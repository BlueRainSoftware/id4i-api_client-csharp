# .CollectionsApi

All URIs are relative to *https://backend.id4i.de*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddElementToCollection**](CollectionsApi.md#addelementtocollection) | **PUT** /api/v1/collections/{id4n}/elements/{elementGuid} | Add element to collection
[**AddElementToLabelledCollection**](CollectionsApi.md#addelementtolabelledcollection) | **PUT** /api/v1/collections/labelled/{collectionId4n}/elements/{elementGuid} | Add element to labelled collection
[**AddElementToLogisticCollection**](CollectionsApi.md#addelementtologisticcollection) | **PUT** /api/v1/collections/logistic/{collectionId4n}/elements/{guid} | Add element to logistic collection
[**AddElementToRoutingCollection**](CollectionsApi.md#addelementtoroutingcollection) | **PUT** /api/v1/collections/routing/{collectionId4n}/elements/{guid} | Add element to routing collection
[**AddElementsToCollection**](CollectionsApi.md#addelementstocollection) | **PUT** /api/v1/collections/{id4n}/elements | Add elements to collection
[**AddElementsToLabelledCollection**](CollectionsApi.md#addelementstolabelledcollection) | **PUT** /api/v1/collections/labelled/{collectionId4n}/elements | Add elements to labelled collection
[**AddElementsToLogisticCollection**](CollectionsApi.md#addelementstologisticcollection) | **PUT** /api/v1/collections/logistic/{collectionId4n}/elements | Add elements to logistic collection
[**AddElementsToRoutingCollection**](CollectionsApi.md#addelementstoroutingcollection) | **PUT** /api/v1/collections/routing/{collectionId4n}/elements | Add element to routing collection
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
[**RemoveElementFromCollection**](CollectionsApi.md#removeelementfromcollection) | **DELETE** /api/v1/collections/{id4n}/elements/{elementGuid} | Remove element from collection
[**RemoveElementFromLabelledCollection**](CollectionsApi.md#removeelementfromlabelledcollection) | **DELETE** /api/v1/collections/labelled/{collectionId4n}/elements/{elementGuid} | Remove element from labelled collection
[**RemoveElementFromLogisticCollection**](CollectionsApi.md#removeelementfromlogisticcollection) | **DELETE** /api/v1/collections/logistic/{collectionId4n}/elements/{elementId4n} | Remove element from logistic collection
[**RemoveElementFromRoutingCollection**](CollectionsApi.md#removeelementfromroutingcollection) | **DELETE** /api/v1/collections/routing/{collectionId4n}/elements/{guid} | Remove element from routing collection
[**RemoveElementsFromCollection**](CollectionsApi.md#removeelementsfromcollection) | **DELETE** /api/v1/collections/{id4n}/elements | Remove elements from collection
[**RemoveElementsFromLabelledCollection**](CollectionsApi.md#removeelementsfromlabelledcollection) | **DELETE** /api/v1/collections/labelled/{collectionId4n}/elements | Remove elements from labelled collection
[**RemoveElementsFromLogisticCollection**](CollectionsApi.md#removeelementsfromlogisticcollection) | **DELETE** /api/v1/collections/logistic/{collectionId4n}/elements | Remove elements from logistic collection
[**RemoveElementsFromRoutingCollection**](CollectionsApi.md#removeelementsfromroutingcollection) | **DELETE** /api/v1/collections/routing/{collectionId4n}/elements | Remove elements from routing collection
[**UpdateCollection**](CollectionsApi.md#updatecollection) | **PUT** /api/v1/collections/{id4n} | Alter collection
[**UpdateLabelledCollection**](CollectionsApi.md#updatelabelledcollection) | **PUT** /api/v1/collections/labelled/{id4n} | Rename labelled collection
[**UpdateLogisticCollection**](CollectionsApi.md#updatelogisticcollection) | **PUT** /api/v1/collections/logistic/{id4n} | Update logistic collection
[**UpdateRoutingCollection**](CollectionsApi.md#updateroutingcollection) | **PUT** /api/v1/collections/routing/{id4n} | Update routing collection


<a name="addelementtocollection"></a>
# **AddElementToCollection**
> ApiError AddElementToCollection (string id4n, string elementGuid, string authorization, string acceptLanguage)

Add element to collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class AddElementToCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var elementGuid = elementGuid_example;  // string | elementGuid
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Add element to collection
                ApiError result = apiInstance.AddElementToCollection(id4n, elementGuid, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.AddElementToCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 
 **elementGuid** | **string**| elementGuid | 
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**ApiError**](ApiError.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addelementtolabelledcollection"></a>
# **AddElementToLabelledCollection**
> ApiError AddElementToLabelledCollection (string collectionId4n, string elementGuid, string authorization, string acceptLanguage)

Add element to labelled collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class AddElementToLabelledCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var collectionId4n = collectionId4n_example;  // string | collectionId4n
            var elementGuid = elementGuid_example;  // string | elementGuid
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Add element to labelled collection
                ApiError result = apiInstance.AddElementToLabelledCollection(collectionId4n, elementGuid, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.AddElementToLabelledCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId4n** | **string**| collectionId4n | 
 **elementGuid** | **string**| elementGuid | 
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**ApiError**](ApiError.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addelementtologisticcollection"></a>
# **AddElementToLogisticCollection**
> ApiError AddElementToLogisticCollection (string collectionId4n, string guid, string authorization, string acceptLanguage)

Add element to logistic collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class AddElementToLogisticCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var collectionId4n = collectionId4n_example;  // string | collectionId4n
            var guid = guid_example;  // string | guid
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Add element to logistic collection
                ApiError result = apiInstance.AddElementToLogisticCollection(collectionId4n, guid, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.AddElementToLogisticCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId4n** | **string**| collectionId4n | 
 **guid** | **string**| guid | 
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**ApiError**](ApiError.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addelementtoroutingcollection"></a>
# **AddElementToRoutingCollection**
> ApiError AddElementToRoutingCollection (string collectionId4n, string guid, string authorization, string acceptLanguage)

Add element to routing collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class AddElementToRoutingCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var collectionId4n = collectionId4n_example;  // string | collectionId4n
            var guid = guid_example;  // string | guid
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Add element to routing collection
                ApiError result = apiInstance.AddElementToRoutingCollection(collectionId4n, guid, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.AddElementToRoutingCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId4n** | **string**| collectionId4n | 
 **guid** | **string**| guid | 
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**ApiError**](ApiError.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addelementstocollection"></a>
# **AddElementsToCollection**
> ApiError AddElementsToCollection (string id4n, ListOfId4ns listOfGuids, string authorization, string acceptLanguage)

Add elements to collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class AddElementsToCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var listOfGuids = new ListOfId4ns(); // ListOfId4ns | listOfGuids
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Add elements to collection
                ApiError result = apiInstance.AddElementsToCollection(id4n, listOfGuids, authorization, acceptLanguage);
                Debug.WriteLine(result);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**ApiError**](ApiError.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addelementstolabelledcollection"></a>
# **AddElementsToLabelledCollection**
> ApiError AddElementsToLabelledCollection (string collectionId4n, ListOfId4ns listOfGuids, string authorization, string acceptLanguage)

Add elements to labelled collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class AddElementsToLabelledCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var collectionId4n = collectionId4n_example;  // string | collectionId4n
            var listOfGuids = new ListOfId4ns(); // ListOfId4ns | listOfGuids
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Add elements to labelled collection
                ApiError result = apiInstance.AddElementsToLabelledCollection(collectionId4n, listOfGuids, authorization, acceptLanguage);
                Debug.WriteLine(result);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**ApiError**](ApiError.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addelementstologisticcollection"></a>
# **AddElementsToLogisticCollection**
> ApiError AddElementsToLogisticCollection (string collectionId4n, ListOfId4ns listOfGuids, string authorization, string acceptLanguage)

Add elements to logistic collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class AddElementsToLogisticCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var collectionId4n = collectionId4n_example;  // string | collectionId4n
            var listOfGuids = new ListOfId4ns(); // ListOfId4ns | listOfGuids
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Add elements to logistic collection
                ApiError result = apiInstance.AddElementsToLogisticCollection(collectionId4n, listOfGuids, authorization, acceptLanguage);
                Debug.WriteLine(result);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**ApiError**](ApiError.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addelementstoroutingcollection"></a>
# **AddElementsToRoutingCollection**
> ApiError AddElementsToRoutingCollection (string collectionId4n, ListOfId4ns listOfGuids, string authorization, string acceptLanguage)

Add element to routing collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class AddElementsToRoutingCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var collectionId4n = collectionId4n_example;  // string | collectionId4n
            var listOfGuids = new ListOfId4ns(); // ListOfId4ns | listOfGuids
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Add element to routing collection
                ApiError result = apiInstance.AddElementsToRoutingCollection(collectionId4n, listOfGuids, authorization, acceptLanguage);
                Debug.WriteLine(result);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**ApiError**](ApiError.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createlabelledcollection"></a>
# **CreateLabelledCollection**
> Id4n CreateLabelledCollection (CreateLabelledCollectionRequest createInfo, string authorization, string acceptLanguage)

Create labelled collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class CreateLabelledCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var createInfo = new CreateLabelledCollectionRequest(); // CreateLabelledCollectionRequest | createInfo
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Create labelled collection
                Id4n result = apiInstance.CreateLabelledCollection(createInfo, authorization, acceptLanguage);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**Id4n**](Id4n.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createlogisticcollection"></a>
# **CreateLogisticCollection**
> Id4n CreateLogisticCollection (CreateLogisticCollectionRequest createInfo, string authorization, string acceptLanguage)

Create logistic collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class CreateLogisticCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var createInfo = new CreateLogisticCollectionRequest(); // CreateLogisticCollectionRequest | createInfo
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Create logistic collection
                Id4n result = apiInstance.CreateLogisticCollection(createInfo, authorization, acceptLanguage);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**Id4n**](Id4n.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createroutingcollection"></a>
# **CreateRoutingCollection**
> Id4n CreateRoutingCollection (CreateRoutingCollectionRequest createInfo, string authorization, string acceptLanguage)

Create routing collecton

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class CreateRoutingCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var createInfo = new CreateRoutingCollectionRequest(); // CreateRoutingCollectionRequest | createInfo
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Create routing collecton
                Id4n result = apiInstance.CreateRoutingCollection(createInfo, authorization, acceptLanguage);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**Id4n**](Id4n.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecollection"></a>
# **DeleteCollection**
> ApiError DeleteCollection (string id4n, string authorization, string acceptLanguage)

Delete collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class DeleteCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Delete collection
                ApiError result = apiInstance.DeleteCollection(id4n, authorization, acceptLanguage);
                Debug.WriteLine(result);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**ApiError**](ApiError.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelabelledcollection"></a>
# **DeleteLabelledCollection**
> ApiError DeleteLabelledCollection (string id4n, string authorization, string acceptLanguage)

Delete labelled collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class DeleteLabelledCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Delete labelled collection
                ApiError result = apiInstance.DeleteLabelledCollection(id4n, authorization, acceptLanguage);
                Debug.WriteLine(result);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**ApiError**](ApiError.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelogisticcollection"></a>
# **DeleteLogisticCollection**
> Object DeleteLogisticCollection (string id4n, string authorization, string acceptLanguage)

Delete logistic collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class DeleteLogisticCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Delete logistic collection
                Object result = apiInstance.DeleteLogisticCollection(id4n, authorization, acceptLanguage);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteroutingcollection"></a>
# **DeleteRoutingCollection**
> ApiError DeleteRoutingCollection (string id4n, string authorization, string acceptLanguage)

Delete routing collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class DeleteRoutingCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Delete routing collection
                ApiError result = apiInstance.DeleteRoutingCollection(id4n, authorization, acceptLanguage);
                Debug.WriteLine(result);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**ApiError**](ApiError.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findcollection"></a>
# **FindCollection**
> GuidCollection FindCollection (string id4n, string authorization, string acceptLanguage)

Find collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class FindCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Find collection
                GuidCollection result = apiInstance.FindCollection(id4n, authorization, acceptLanguage);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**GuidCollection**](GuidCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findlabelledcollection"></a>
# **FindLabelledCollection**
> GuidCollection FindLabelledCollection (string id4n, string authorization, string acceptLanguage)

Find labelled collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class FindLabelledCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Find labelled collection
                GuidCollection result = apiInstance.FindLabelledCollection(id4n, authorization, acceptLanguage);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**GuidCollection**](GuidCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findlogisticcollection"></a>
# **FindLogisticCollection**
> GuidCollection FindLogisticCollection (string id4n, string authorization, string acceptLanguage)

Find logistic collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class FindLogisticCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Find logistic collection
                GuidCollection result = apiInstance.FindLogisticCollection(id4n, authorization, acceptLanguage);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**GuidCollection**](GuidCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findroutingcollection"></a>
# **FindRoutingCollection**
> GuidCollection FindRoutingCollection (string id4n, string authorization, string acceptLanguage)

Find routing collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class FindRoutingCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Find routing collection
                GuidCollection result = apiInstance.FindRoutingCollection(id4n, authorization, acceptLanguage);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**GuidCollection**](GuidCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallcollectionsoforganization"></a>
# **GetAllCollectionsOfOrganization**
> PaginatedGuidCollection GetAllCollectionsOfOrganization (long? organizationId, string authorization, string acceptLanguage, int? offset, int? limit, string type, string label, string labelPrefix)

Get collections of organization

Retrieving all collections of an organization in a paginated manner.

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class GetAllCollectionsOfOrganizationExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var organizationId = 789;  // long? | organizationId
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var offset = 56;  // int? | Start with the n-th element.  (optional) 
            var limit = 56;  // int? | The maximum count of returned elements. (optional) 
            var type = type_example;  // string | Filter by this type (optional) 
            var label = label_example;  // string | Filter by this label (optional) 
            var labelPrefix = labelPrefix_example;  // string | Filter by this label prefix (optional) 

            try
            {
                // Get collections of organization
                PaginatedGuidCollection result = apiInstance.GetAllCollectionsOfOrganization(organizationId, authorization, acceptLanguage, offset, limit, type, label, labelPrefix);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **offset** | **int?**| Start with the n-th element.  | [optional] 
 **limit** | **int?**| The maximum count of returned elements. | [optional] 
 **type** | **string**| Filter by this type | [optional] 
 **label** | **string**| Filter by this label | [optional] 
 **labelPrefix** | **string**| Filter by this label prefix | [optional] 

### Return type

[**PaginatedGuidCollection**](PaginatedGuidCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listelementsofcollection"></a>
# **ListElementsOfCollection**
> PaginatedGuidResponse ListElementsOfCollection (string id4n, string authorization, string acceptLanguage, int? offset, int? limit)

List contents of the collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class ListElementsOfCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var offset = 56;  // int? | Start with the n-th element.  (optional) 
            var limit = 56;  // int? | The maximum count of returned elements. (optional) 

            try
            {
                // List contents of the collection
                PaginatedGuidResponse result = apiInstance.ListElementsOfCollection(id4n, authorization, acceptLanguage, offset, limit);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **offset** | **int?**| Start with the n-th element.  | [optional] 
 **limit** | **int?**| The maximum count of returned elements. | [optional] 

### Return type

[**PaginatedGuidResponse**](PaginatedGuidResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listelementsoflabelledcollection"></a>
# **ListElementsOfLabelledCollection**
> PaginatedGuidResponse ListElementsOfLabelledCollection (string id4n, string authorization, string acceptLanguage, int? offset, int? limit)

List contents of the collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class ListElementsOfLabelledCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var offset = 56;  // int? | Start with the n-th element.  (optional) 
            var limit = 56;  // int? | The maximum count of returned elements. (optional) 

            try
            {
                // List contents of the collection
                PaginatedGuidResponse result = apiInstance.ListElementsOfLabelledCollection(id4n, authorization, acceptLanguage, offset, limit);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **offset** | **int?**| Start with the n-th element.  | [optional] 
 **limit** | **int?**| The maximum count of returned elements. | [optional] 

### Return type

[**PaginatedGuidResponse**](PaginatedGuidResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listelementsoflogisticcollection"></a>
# **ListElementsOfLogisticCollection**
> PaginatedGuidResponse ListElementsOfLogisticCollection (string id4n, string authorization, string acceptLanguage, int? offset, int? limit)

List contents of the collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class ListElementsOfLogisticCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var offset = 56;  // int? | Start with the n-th element.  (optional) 
            var limit = 56;  // int? | The maximum count of returned elements. (optional) 

            try
            {
                // List contents of the collection
                PaginatedGuidResponse result = apiInstance.ListElementsOfLogisticCollection(id4n, authorization, acceptLanguage, offset, limit);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **offset** | **int?**| Start with the n-th element.  | [optional] 
 **limit** | **int?**| The maximum count of returned elements. | [optional] 

### Return type

[**PaginatedGuidResponse**](PaginatedGuidResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listelementsofroutingcollection"></a>
# **ListElementsOfRoutingCollection**
> PaginatedGuidResponse ListElementsOfRoutingCollection (string id4n, string authorization, string acceptLanguage, int? offset, int? limit)

List contents of the collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class ListElementsOfRoutingCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 
            var offset = 56;  // int? | Start with the n-th element.  (optional) 
            var limit = 56;  // int? | The maximum count of returned elements. (optional) 

            try
            {
                // List contents of the collection
                PaginatedGuidResponse result = apiInstance.ListElementsOfRoutingCollection(id4n, authorization, acceptLanguage, offset, limit);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 
 **offset** | **int?**| Start with the n-th element.  | [optional] 
 **limit** | **int?**| The maximum count of returned elements. | [optional] 

### Return type

[**PaginatedGuidResponse**](PaginatedGuidResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeelementfromcollection"></a>
# **RemoveElementFromCollection**
> ApiError RemoveElementFromCollection (string id4n, string elementGuid, string authorization, string acceptLanguage)

Remove element from collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class RemoveElementFromCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var elementGuid = elementGuid_example;  // string | elementGuid
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Remove element from collection
                ApiError result = apiInstance.RemoveElementFromCollection(id4n, elementGuid, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.RemoveElementFromCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id4n** | **string**| id4n | 
 **elementGuid** | **string**| elementGuid | 
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**ApiError**](ApiError.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeelementfromlabelledcollection"></a>
# **RemoveElementFromLabelledCollection**
> ApiError RemoveElementFromLabelledCollection (string collectionId4n, string elementGuid, string authorization, string acceptLanguage)

Remove element from labelled collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class RemoveElementFromLabelledCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var collectionId4n = collectionId4n_example;  // string | collectionId4n
            var elementGuid = elementGuid_example;  // string | elementGuid
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Remove element from labelled collection
                ApiError result = apiInstance.RemoveElementFromLabelledCollection(collectionId4n, elementGuid, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.RemoveElementFromLabelledCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId4n** | **string**| collectionId4n | 
 **elementGuid** | **string**| elementGuid | 
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**ApiError**](ApiError.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeelementfromlogisticcollection"></a>
# **RemoveElementFromLogisticCollection**
> ApiError RemoveElementFromLogisticCollection (string collectionId4n, string guid, string authorization, string acceptLanguage)

Remove element from logistic collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class RemoveElementFromLogisticCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var collectionId4n = collectionId4n_example;  // string | collectionId4n
            var guid = guid_example;  // string | guid
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Remove element from logistic collection
                ApiError result = apiInstance.RemoveElementFromLogisticCollection(collectionId4n, guid, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.RemoveElementFromLogisticCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId4n** | **string**| collectionId4n | 
 **guid** | **string**| guid | 
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**ApiError**](ApiError.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeelementfromroutingcollection"></a>
# **RemoveElementFromRoutingCollection**
> ApiError RemoveElementFromRoutingCollection (string collectionId4n, string guid, string authorization, string acceptLanguage)

Remove element from routing collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class RemoveElementFromRoutingCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var collectionId4n = collectionId4n_example;  // string | collectionId4n
            var guid = guid_example;  // string | guid
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Remove element from routing collection
                ApiError result = apiInstance.RemoveElementFromRoutingCollection(collectionId4n, guid, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CollectionsApi.RemoveElementFromRoutingCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId4n** | **string**| collectionId4n | 
 **guid** | **string**| guid | 
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**ApiError**](ApiError.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeelementsfromcollection"></a>
# **RemoveElementsFromCollection**
> ApiError RemoveElementsFromCollection (string id4n, ListOfId4ns listOfGuids, string authorization, string acceptLanguage)

Remove elements from collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class RemoveElementsFromCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var listOfGuids = new ListOfId4ns(); // ListOfId4ns | listOfGuids
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Remove elements from collection
                ApiError result = apiInstance.RemoveElementsFromCollection(id4n, listOfGuids, authorization, acceptLanguage);
                Debug.WriteLine(result);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**ApiError**](ApiError.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeelementsfromlabelledcollection"></a>
# **RemoveElementsFromLabelledCollection**
> ApiError RemoveElementsFromLabelledCollection (string collectionId4n, ListOfId4ns listOfGuids, string authorization, string acceptLanguage)

Remove elements from labelled collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class RemoveElementsFromLabelledCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var collectionId4n = collectionId4n_example;  // string | collectionId4n
            var listOfGuids = new ListOfId4ns(); // ListOfId4ns | listOfGuids
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Remove elements from labelled collection
                ApiError result = apiInstance.RemoveElementsFromLabelledCollection(collectionId4n, listOfGuids, authorization, acceptLanguage);
                Debug.WriteLine(result);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**ApiError**](ApiError.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeelementsfromlogisticcollection"></a>
# **RemoveElementsFromLogisticCollection**
> ApiError RemoveElementsFromLogisticCollection (string collectionId4n, ListOfId4ns listOfGuids, string authorization, string acceptLanguage)

Remove elements from logistic collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class RemoveElementsFromLogisticCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var collectionId4n = collectionId4n_example;  // string | collectionId4n
            var listOfGuids = new ListOfId4ns(); // ListOfId4ns | listOfGuids
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Remove elements from logistic collection
                ApiError result = apiInstance.RemoveElementsFromLogisticCollection(collectionId4n, listOfGuids, authorization, acceptLanguage);
                Debug.WriteLine(result);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**ApiError**](ApiError.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeelementsfromroutingcollection"></a>
# **RemoveElementsFromRoutingCollection**
> ApiError RemoveElementsFromRoutingCollection (string collectionId4n, ListOfId4ns listOfGuids, string authorization, string acceptLanguage)

Remove elements from routing collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class RemoveElementsFromRoutingCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var collectionId4n = collectionId4n_example;  // string | collectionId4n
            var listOfGuids = new ListOfId4ns(); // ListOfId4ns | listOfGuids
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Remove elements from routing collection
                ApiError result = apiInstance.RemoveElementsFromRoutingCollection(collectionId4n, listOfGuids, authorization, acceptLanguage);
                Debug.WriteLine(result);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**ApiError**](ApiError.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecollection"></a>
# **UpdateCollection**
> Object UpdateCollection (string id4n, GuidCollection request, string authorization, string acceptLanguage)

Alter collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class UpdateCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var request = new GuidCollection(); // GuidCollection | request
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Alter collection
                Object result = apiInstance.UpdateCollection(id4n, request, authorization, acceptLanguage);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelabelledcollection"></a>
# **UpdateLabelledCollection**
> Object UpdateLabelledCollection (string id4n, GuidCollection request, string authorization, string acceptLanguage)

Rename labelled collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class UpdateLabelledCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var request = new GuidCollection(); // GuidCollection | request
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Rename labelled collection
                Object result = apiInstance.UpdateLabelledCollection(id4n, request, authorization, acceptLanguage);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelogisticcollection"></a>
# **UpdateLogisticCollection**
> Object UpdateLogisticCollection (string id4n, GuidCollection request, string authorization, string acceptLanguage)

Update logistic collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class UpdateLogisticCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var request = new GuidCollection(); // GuidCollection | request
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Update logistic collection
                Object result = apiInstance.UpdateLogisticCollection(id4n, request, authorization, acceptLanguage);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateroutingcollection"></a>
# **UpdateRoutingCollection**
> Object UpdateRoutingCollection (string id4n, GuidCollection request, string authorization, string acceptLanguage)

Update routing collection

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class UpdateRoutingCollectionExample
    {
        public void main()
        {
            
            var apiInstance = new CollectionsApi();
            var id4n = id4n_example;  // string | id4n
            var request = new GuidCollection(); // GuidCollection | request
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token as returned from /login (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Update routing collection
                Object result = apiInstance.UpdateRoutingCollection(id4n, request, authorization, acceptLanguage);
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
 **authorization** | **string**| Authorization JWT Bearer Token as returned from /login | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

