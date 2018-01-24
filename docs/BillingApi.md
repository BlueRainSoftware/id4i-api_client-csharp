# .BillingApi

All URIs are relative to *https://backend.id4i.de*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSumForOrganization**](BillingApi.md#getsumfororganization) | **GET** /api/v1/billing/{organizationId} | Get billing amount of services for a given organization


<a name="getsumfororganization"></a>
# **GetSumForOrganization**
> ServiceCosts GetSumForOrganization (long? organizationId, string authorization, string acceptLanguage)

Get billing amount of services for a given organization

### Example
```csharp
using System;
using System.Diagnostics;
using ;
using DE.ID4i.Client;
using DE.ID4i.Model;

namespace Example
{
    public class GetSumForOrganizationExample
    {
        public void main()
        {
            
            var apiInstance = new BillingApi();
            var organizationId = 789;  // long? | The organization to compute the billing information for
            var authorization = authorization_example;  // string | Authorization JWT Bearer Token (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | Requested language (optional) 

            try
            {
                // Get billing amount of services for a given organization
                ServiceCosts result = apiInstance.GetSumForOrganization(organizationId, authorization, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.GetSumForOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| The organization to compute the billing information for | 
 **authorization** | **string**| Authorization JWT Bearer Token | [optional] 
 **acceptLanguage** | **string**| Requested language | [optional] 

### Return type

[**ServiceCosts**](ServiceCosts.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

