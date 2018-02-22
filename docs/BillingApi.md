# BlueRain.ID4i.Api.BillingApi

All URIs are relative to *https://backend.id4i.de*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPositionsForOrganization**](BillingApi.md#getpositionsfororganization) | **GET** /api/v1/billing/{organizationId}/positions | Get billing positions for a given organization
[**GetSumForOrganization**](BillingApi.md#getsumfororganization) | **GET** /api/v1/billing/{organizationId} | Get billing amount of services for a given organization


<a name="getpositionsfororganization"></a>
# **GetPositionsForOrganization**
> List<BillingPosition> GetPositionsForOrganization (long? organizationId)

Get billing positions for a given organization

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class GetPositionsForOrganizationExample
    {
        public void main()
        {
            
            // Configure API key authorization: Authorization
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new BillingApi();
            var organizationId = 789;  // long? | The organization to compute the billing information for

            try
            {
                // Get billing positions for a given organization
                List&lt;BillingPosition&gt; result = apiInstance.GetPositionsForOrganization(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.GetPositionsForOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **long?**| The organization to compute the billing information for | 

### Return type

[**List<BillingPosition>**](BillingPosition.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsumfororganization"></a>
# **GetSumForOrganization**
> ServiceCosts GetSumForOrganization (long? organizationId)

Get billing amount of services for a given organization

### Example
```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
    public class GetSumForOrganizationExample
    {
        public void main()
        {
            
            // Configure API key authorization: Authorization
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new BillingApi();
            var organizationId = 789;  // long? | The organization to compute the billing information for

            try
            {
                // Get billing amount of services for a given organization
                ServiceCosts result = apiInstance.GetSumForOrganization(organizationId);
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

### Return type

[**ServiceCosts**](ServiceCosts.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/xml, application/json;charset=UTF-8
 - **Accept**: application/xml, application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

