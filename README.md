# ID4i API Client Library - C#

This library allows developers to interact with the http://id4i.de HTTP API.
Typically you won't have to build it yourselves, you can just pull in the dependency from https://www.nuget.org/packages/BlueRain.ID4i/.

Feel free to look at the sources and the documentation contained in this repository.

For additional information, please refer to

* http://id4i.de for high level information about the ID4i platform
* https://backend.id4i.de/docs/reference/en/reference.html for information about implementing your own solutions on top of ID4i
* https://github.com/BlueRainSoftware/id4i-api_client-csharp for this libraries sources
* https://backend.id4i.de/docs/redoc/index.html for API documentation
* https://github.com/BlueRainSoftware/support for getting additional support

- API version: 0.5.0
- Package version: 
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

    For more information, please visit [http://bluerain.de](http://bluerain.de)

<a name="frameworks-supported"></a>
## Frameworks supported
    - .NET Core >=1.0
    - .NET Framework >=4.6
    - Mono/Xamarin >=vNext
    - UWP >=10.0

<a name="dependencies"></a>
## Dependencies
    - FubarCoder.RestSharp.Portable.Core >=4.0.7
    - FubarCoder.RestSharp.Portable.HttpClient >=4.0.7
    - Newtonsoft.Json >=10.0.3

<a name="installation"></a>
## Installation
    Generate the DLL using your preferred tool

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Client;
using BlueRain.ID4i.Model;

namespace Example
{
public class Example
{
public void main()
{

                // Configure API key authorization: Authorization
                Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
                // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
                // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

    var apiInstance = new AccountsApi();
            var organizationId = 789;  // long? | organizationId
            var username = username_example;  // string | username
            var changeRoleRequest = new ChangeRoleRequest(); // ChangeRoleRequest | changeRoleRequest

    try
    {
        // Add role(s) to user
    apiInstance.AddUserRoles(organizationId, username, changeRoleRequest);
    }
    catch (Exception e)
    {
    Debug.Print("Exception when calling AccountsApi.AddUserRoles: " + e.Message );
    }

}
}
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://backend.id4i.de*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccountsApi* | [**AddUserRoles**](docs/AccountsApi.md#adduserroles) | **POST** /api/v1/organizations/{organizationId}/users/{username}/roles | Add role(s) to user
*AccountsApi* | [**CompleteRegistration**](docs/AccountsApi.md#completeregistration) | **PUT** /account/registration | Complete registration
*AccountsApi* | [**FindUserByUsername**](docs/AccountsApi.md#finduserbyusername) | **GET** /api/v1/users/{username} | Find by username
*AccountsApi* | [**FindUsers**](docs/AccountsApi.md#findusers) | **GET** /api/v1/users | Find users
*AccountsApi* | [**GetAllOrganizationRoles**](docs/AccountsApi.md#getallorganizationroles) | **GET** /api/v1/organizations/{organizationId}/roles | List users and their roles
*AccountsApi* | [**GetOrganizationsOfUser**](docs/AccountsApi.md#getorganizationsofuser) | **GET** /api/v1/user/organizations | Retrieve organizations of user
*AccountsApi* | [**GetUserRoles**](docs/AccountsApi.md#getuserroles) | **GET** /api/v1/organizations/{organizationId}/users/{username}/roles | Get user roles by username
*AccountsApi* | [**GetUsersOfOrganization**](docs/AccountsApi.md#getusersoforganization) | **GET** /api/v1/organizations/{organizationId}/users | Find users in organization
*AccountsApi* | [**InviteUsers**](docs/AccountsApi.md#inviteusers) | **POST** /api/v1/organizations/{organizationId}/users/invite | Invite Users
*AccountsApi* | [**ListAllRoles**](docs/AccountsApi.md#listallroles) | **GET** /api/v1/roles | List roles
*AccountsApi* | [**Login**](docs/AccountsApi.md#login) | **POST** /login | 
*AccountsApi* | [**RegisterUser**](docs/AccountsApi.md#registeruser) | **POST** /account/registration | Register user
*AccountsApi* | [**RemoveUserRoles**](docs/AccountsApi.md#removeuserroles) | **DELETE** /api/v1/organizations/{organizationId}/users/{username}/roles | Remove role(s) from user
*AccountsApi* | [**RequestPasswordReset**](docs/AccountsApi.md#requestpasswordreset) | **POST** /account/password | Request password reset
*AccountsApi* | [**VerifyPasswordReset**](docs/AccountsApi.md#verifypasswordreset) | **PUT** /account/password | Verify password reset
*AccountsApi* | [**VerifyUserRegistration**](docs/AccountsApi.md#verifyuserregistration) | **POST** /account/verification | Verify registration
*AliasApi* | [**AddGuidAlias**](docs/AliasApi.md#addguidalias) | **POST** /api/v1/guids/{id4n}/alias/{aliasType} | Add alias for GUIDs
*AliasApi* | [**GetGuidAliasTypes**](docs/AliasApi.md#getguidaliastypes) | **GET** /api/v1/search/guids/aliases/types | List all supported alias types
*AliasApi* | [**GetGuidAliases**](docs/AliasApi.md#getguidaliases) | **GET** /api/v1/guids/{id4n}/alias | Get all aliases for the given GUID
*AliasApi* | [**RemoveGuidAlias**](docs/AliasApi.md#removeguidalias) | **DELETE** /api/v1/guids/{id4n}/alias/{aliasType} | Remove aliases from GUIDs
*AliasApi* | [**SearchByAlias**](docs/AliasApi.md#searchbyalias) | **GET** /api/v1/search/guids | Search for GUIDs by alias
*ApiKeysApi* | [**AddApiKeyPrivilege**](docs/ApiKeysApi.md#addapikeyprivilege) | **POST** /api/v1/apikeys/{key}/privileges | Add privilege
*ApiKeysApi* | [**AddApiKeyPrivilegeForId4ns**](docs/ApiKeysApi.md#addapikeyprivilegeforid4ns) | **POST** /api/v1/apikeys/{key}/privileges/{privilege}/id4ns | Add ID4ns of a privilege
*ApiKeysApi* | [**CreateNewApiKey**](docs/ApiKeysApi.md#createnewapikey) | **POST** /api/v1/apikeys | Create API key
*ApiKeysApi* | [**DeleteApiKey**](docs/ApiKeysApi.md#deleteapikey) | **DELETE** /api/v1/apikeys/{key} | Delete API key
*ApiKeysApi* | [**GetApiKey**](docs/ApiKeysApi.md#getapikey) | **GET** /api/v1/apikeys/{key} | Show API key
*ApiKeysApi* | [**ListAllApiKeyPrivileges**](docs/ApiKeysApi.md#listallapikeyprivileges) | **GET** /api/v1/apikeys/privileges | List all privileges
*ApiKeysApi* | [**ListAllApiKeysOfOrganization**](docs/ApiKeysApi.md#listallapikeysoforganization) | **GET** /api/v1/apikeys | Find API key by organization
*ApiKeysApi* | [**ListApiKeyPrivileges**](docs/ApiKeysApi.md#listapikeyprivileges) | **GET** /api/v1/apikeys/{key}/privileges | List privileges
*ApiKeysApi* | [**ListId4ns**](docs/ApiKeysApi.md#listid4ns) | **GET** /api/v1/apikeys/{key}/privileges/{privilege}/id4ns | ID4ns of a privilege
*ApiKeysApi* | [**RemoveApiKeyPrivilege**](docs/ApiKeysApi.md#removeapikeyprivilege) | **DELETE** /api/v1/apikeys/{key}/privileges | Remove privilege
*ApiKeysApi* | [**RemoveApiKeyPrivilegeForId4ns**](docs/ApiKeysApi.md#removeapikeyprivilegeforid4ns) | **DELETE** /api/v1/apikeys/{key}/privileges/{privilege}/id4ns | Remove id4ns of a privilege
*ApiKeysApi* | [**UpdateApiKey**](docs/ApiKeysApi.md#updateapikey) | **PUT** /api/v1/apikeys/{key} | Update API keys
*AuditingApi* | [**ListOrganizationChangeLog**](docs/AuditingApi.md#listorganizationchangelog) | **GET** /api/v1/changelog/organization/{organizationId}/ | List change log entries of an organization
*BillingApi* | [**GetPositionsForOrganization**](docs/BillingApi.md#getpositionsfororganization) | **GET** /api/v1/billing/{organizationId}/positions | Get billing positions for a given organization
*BillingApi* | [**GetSumForOrganization**](docs/BillingApi.md#getsumfororganization) | **GET** /api/v1/billing/{organizationId} | Get billing amount of services for a given organization
*CollectionsApi* | [**AddElementsToCollection**](docs/CollectionsApi.md#addelementstocollection) | **POST** /api/v1/collections/{id4n}/elements | Add elements to collection
*CollectionsApi* | [**AddElementsToLabelledCollection**](docs/CollectionsApi.md#addelementstolabelledcollection) | **POST** /api/v1/collections/labelled/{collectionId4n}/elements | Add elements to labelled collection
*CollectionsApi* | [**AddElementsToLogisticCollection**](docs/CollectionsApi.md#addelementstologisticcollection) | **POST** /api/v1/collections/logistic/{collectionId4n}/elements | Add elements to logistic collection
*CollectionsApi* | [**AddElementsToRoutingCollection**](docs/CollectionsApi.md#addelementstoroutingcollection) | **POST** /api/v1/collections/routing/{collectionId4n}/elements | Add element to routing collection
*CollectionsApi* | [**CreateLabelledCollection**](docs/CollectionsApi.md#createlabelledcollection) | **POST** /api/v1/collections/labelled | Create labelled collection
*CollectionsApi* | [**CreateLogisticCollection**](docs/CollectionsApi.md#createlogisticcollection) | **POST** /api/v1/collections/logistic | Create logistic collection
*CollectionsApi* | [**CreateRoutingCollection**](docs/CollectionsApi.md#createroutingcollection) | **POST** /api/v1/collections/routing | Create routing collecton
*CollectionsApi* | [**DeleteCollection**](docs/CollectionsApi.md#deletecollection) | **DELETE** /api/v1/collections/{id4n} | Delete collection
*CollectionsApi* | [**DeleteLabelledCollection**](docs/CollectionsApi.md#deletelabelledcollection) | **DELETE** /api/v1/collections/labelled/{id4n} | Delete labelled collection
*CollectionsApi* | [**DeleteLogisticCollection**](docs/CollectionsApi.md#deletelogisticcollection) | **DELETE** /api/v1/collections/logistic/{id4n} | Delete logistic collection
*CollectionsApi* | [**DeleteRoutingCollection**](docs/CollectionsApi.md#deleteroutingcollection) | **DELETE** /api/v1/collections/routing/{id4n} | Delete routing collection
*CollectionsApi* | [**FindCollection**](docs/CollectionsApi.md#findcollection) | **GET** /api/v1/collections/{id4n} | Find collection
*CollectionsApi* | [**FindLabelledCollection**](docs/CollectionsApi.md#findlabelledcollection) | **GET** /api/v1/collections/labelled/{id4n} | Find labelled collection
*CollectionsApi* | [**FindLogisticCollection**](docs/CollectionsApi.md#findlogisticcollection) | **GET** /api/v1/collections/logistic/{id4n} | Find logistic collection
*CollectionsApi* | [**FindRoutingCollection**](docs/CollectionsApi.md#findroutingcollection) | **GET** /api/v1/collections/routing/{id4n} | Find routing collection
*CollectionsApi* | [**GetAllCollectionsOfOrganization**](docs/CollectionsApi.md#getallcollectionsoforganization) | **GET** /api/v1/organizations/{organizationId}/collections | Get collections of organization
*CollectionsApi* | [**ListElementsOfCollection**](docs/CollectionsApi.md#listelementsofcollection) | **GET** /api/v1/collections/{id4n}/elements | List contents of the collection
*CollectionsApi* | [**ListElementsOfLabelledCollection**](docs/CollectionsApi.md#listelementsoflabelledcollection) | **GET** /api/v1/collections/labelled/{id4n}/elements | List contents of the collection
*CollectionsApi* | [**ListElementsOfLogisticCollection**](docs/CollectionsApi.md#listelementsoflogisticcollection) | **GET** /api/v1/collections/logistic/{id4n}/elements | List contents of the collection
*CollectionsApi* | [**ListElementsOfRoutingCollection**](docs/CollectionsApi.md#listelementsofroutingcollection) | **GET** /api/v1/collections/routing/{id4n}/elements | List contents of the collection
*CollectionsApi* | [**RemoveElementsFromCollection**](docs/CollectionsApi.md#removeelementsfromcollection) | **DELETE** /api/v1/collections/{id4n}/elements | Remove elements from collection
*CollectionsApi* | [**RemoveElementsFromLabelledCollection**](docs/CollectionsApi.md#removeelementsfromlabelledcollection) | **DELETE** /api/v1/collections/labelled/{collectionId4n}/elements | Remove elements from labelled collection
*CollectionsApi* | [**RemoveElementsFromLogisticCollection**](docs/CollectionsApi.md#removeelementsfromlogisticcollection) | **DELETE** /api/v1/collections/logistic/{collectionId4n}/elements | Remove elements from logistic collection
*CollectionsApi* | [**RemoveElementsFromRoutingCollection**](docs/CollectionsApi.md#removeelementsfromroutingcollection) | **DELETE** /api/v1/collections/routing/{collectionId4n}/elements | Remove elements from routing collection
*CollectionsApi* | [**UpdateCollection**](docs/CollectionsApi.md#updatecollection) | **PATCH** /api/v1/collections/{id4n} | Update collection
*CollectionsApi* | [**UpdateLabelledCollection**](docs/CollectionsApi.md#updatelabelledcollection) | **PATCH** /api/v1/collections/labelled/{id4n} | Update labelled collection
*CollectionsApi* | [**UpdateLogisticCollection**](docs/CollectionsApi.md#updatelogisticcollection) | **PATCH** /api/v1/collections/logistic/{id4n} | Update logistic collection
*CollectionsApi* | [**UpdateRoutingCollection**](docs/CollectionsApi.md#updateroutingcollection) | **PATCH** /api/v1/collections/routing/{id4n} | Update routing collection
*GuidsApi* | [**AddGuidAlias**](docs/GuidsApi.md#addguidalias) | **POST** /api/v1/guids/{id4n}/alias/{aliasType} | Add alias for GUIDs
*GuidsApi* | [**AddHistoryItem**](docs/GuidsApi.md#addhistoryitem) | **POST** /api/v1/guids/{id4n}/history | Add history item
*GuidsApi* | [**CreateGuid**](docs/GuidsApi.md#createguid) | **POST** /api/v1/guids | Create GUID(s)
*GuidsApi* | [**GetGuid**](docs/GuidsApi.md#getguid) | **GET** /api/v1/guids/{id4n} | Retrieve GUID information
*GuidsApi* | [**GetGuidAliases**](docs/GuidsApi.md#getguidaliases) | **GET** /api/v1/guids/{id4n}/alias | Get all aliases for the given GUID
*GuidsApi* | [**GetGuidsWithoutCollection**](docs/GuidsApi.md#getguidswithoutcollection) | **GET** /api/v1/guids/withoutCollection | Retrieve GUIDs not in any collection
*GuidsApi* | [**GetId4n**](docs/GuidsApi.md#getid4n) | **GET** /api/v1/id4ns/{id4n} | Retrieve ID4n information
*GuidsApi* | [**ListHistory**](docs/GuidsApi.md#listhistory) | **GET** /api/v1/guids/{id4n}/history | List history
*GuidsApi* | [**ListHistoryOfOrganization**](docs/GuidsApi.md#listhistoryoforganization) | **GET** /api/v1/guids/{id4n}/history/{organizationId} | List history
*GuidsApi* | [**RemoveGuidAlias**](docs/GuidsApi.md#removeguidalias) | **DELETE** /api/v1/guids/{id4n}/alias/{aliasType} | Remove aliases from GUIDs
*GuidsApi* | [**UpdateGuid**](docs/GuidsApi.md#updateguid) | **PUT** /api/v1/guids/{id4n} | Change GUID information.
*GuidsApi* | [**UpdateGuid1**](docs/GuidsApi.md#updateguid1) | **PATCH** /api/v1/guids/{id4n} | Change GUID information.
*GuidsApi* | [**UpdateHistoryItemVisibility**](docs/GuidsApi.md#updatehistoryitemvisibility) | **PUT** /api/v1/guids/{id4n}/history/{organizationId}/{sequence}/visibility | Set history item visibility
*ImagesApi* | [**ResolveImageUsingGET**](docs/ImagesApi.md#resolveimageusingget) | **GET** /api/v1/public/image/{imageID} | Resolve image
*MetaInformationApi* | [**ApplicationInfo**](docs/MetaInformationApi.md#applicationinfo) | **GET** /api/v1/info | Retrieve version information about ID4i
*OrganizationsApi* | [**AddUserRoles**](docs/OrganizationsApi.md#adduserroles) | **POST** /api/v1/organizations/{organizationId}/users/{username}/roles | Add role(s) to user
*OrganizationsApi* | [**CreateOrganization**](docs/OrganizationsApi.md#createorganization) | **POST** /api/v1/organizations | Create organization
*OrganizationsApi* | [**DeleteOrganization**](docs/OrganizationsApi.md#deleteorganization) | **DELETE** /api/v1/organizations/{organizationId} | Delete organization
*OrganizationsApi* | [**DeleteOrganizationBillingAddress**](docs/OrganizationsApi.md#deleteorganizationbillingaddress) | **DELETE** /api/v1/organizations/{organizationId}/addresses/billing | Remove billing address
*OrganizationsApi* | [**DeleteOrganizationLogo**](docs/OrganizationsApi.md#deleteorganizationlogo) | **DELETE** /api/v1/organizations/{organizationId}/logo | Delete organization logo
*OrganizationsApi* | [**FindOrganization**](docs/OrganizationsApi.md#findorganization) | **GET** /api/v1/organizations/{organizationId} | Find organization by id
*OrganizationsApi* | [**FindOrganizationAddress**](docs/OrganizationsApi.md#findorganizationaddress) | **GET** /api/v1/organizations/{organizationId}/addresses/default | Retrieve address
*OrganizationsApi* | [**FindOrganizationBillingAddress**](docs/OrganizationsApi.md#findorganizationbillingaddress) | **GET** /api/v1/organizations/{organizationId}/addresses/billing | Retrieve billing address
*OrganizationsApi* | [**GetAllCollectionsOfOrganization**](docs/OrganizationsApi.md#getallcollectionsoforganization) | **GET** /api/v1/organizations/{organizationId}/collections | Get collections of organization
*OrganizationsApi* | [**GetAllOrganizationRoles**](docs/OrganizationsApi.md#getallorganizationroles) | **GET** /api/v1/organizations/{organizationId}/roles | List users and their roles
*OrganizationsApi* | [**GetOrganizationsOfUser**](docs/OrganizationsApi.md#getorganizationsofuser) | **GET** /api/v1/user/organizations | Retrieve organizations of user
*OrganizationsApi* | [**GetUserRoles**](docs/OrganizationsApi.md#getuserroles) | **GET** /api/v1/organizations/{organizationId}/users/{username}/roles | Get user roles by username
*OrganizationsApi* | [**GetUsersOfOrganization**](docs/OrganizationsApi.md#getusersoforganization) | **GET** /api/v1/organizations/{organizationId}/users | Find users in organization
*OrganizationsApi* | [**InviteUsers**](docs/OrganizationsApi.md#inviteusers) | **POST** /api/v1/organizations/{organizationId}/users/invite | Invite Users
*OrganizationsApi* | [**ListCountries**](docs/OrganizationsApi.md#listcountries) | **GET** /api/v1/countries | List countries
*OrganizationsApi* | [**RemoveUserRoles**](docs/OrganizationsApi.md#removeuserroles) | **DELETE** /api/v1/organizations/{organizationId}/users/{username}/roles | Remove role(s) from user
*OrganizationsApi* | [**SetOrganizationLogo**](docs/OrganizationsApi.md#setorganizationlogo) | **POST** /api/v1/organizations/{organizationId}/logo | Update organization logo
*OrganizationsApi* | [**UpdateOrganization**](docs/OrganizationsApi.md#updateorganization) | **PUT** /api/v1/organizations/{organizationId} | Update organization
*OrganizationsApi* | [**UpdateOrganizationAddress**](docs/OrganizationsApi.md#updateorganizationaddress) | **PUT** /api/v1/organizations/{organizationId}/addresses/default | Store address
*OrganizationsApi* | [**UpdateOrganizationBillingAddress**](docs/OrganizationsApi.md#updateorganizationbillingaddress) | **PUT** /api/v1/organizations/{organizationId}/addresses/billing | Store billing address
*PublicServicesApi* | [**GetPublicDocument**](docs/PublicServicesApi.md#getpublicdocument) | **GET** /api/v1/public/documents/{id4n}/{organizationId}/{fileName}/metadata | Retrieve a document (meta-data only, no content)
*PublicServicesApi* | [**GetWebRoutes**](docs/PublicServicesApi.md#getwebroutes) | **GET** /api/v1/public/routes/{id4n} | Retrieve all public routes for a GUID
*PublicServicesApi* | [**Go**](docs/PublicServicesApi.md#go) | **GET** /go/{guid} | Forward
*PublicServicesApi* | [**ListAllPublicDocuments**](docs/PublicServicesApi.md#listallpublicdocuments) | **GET** /api/v1/public/documents/{id4n} | List organization specific documents
*PublicServicesApi* | [**ListPublicDocuments**](docs/PublicServicesApi.md#listpublicdocuments) | **GET** /api/v1/public/documents/{id4n}/{organizationId} | List organization specific documents
*PublicServicesApi* | [**ListPublicHistory**](docs/PublicServicesApi.md#listpublichistory) | **GET** /api/v1/public/history/{id4n} | Shows the public history of the given GUID
*PublicServicesApi* | [**ReadOrganizationInfo**](docs/PublicServicesApi.md#readorganizationinfo) | **GET** /api/v1/public/organizations/{organizationId} | Read public organization information
*PublicServicesApi* | [**ReadPublicDocument**](docs/PublicServicesApi.md#readpublicdocument) | **GET** /api/v1/public/documents/{id4n}/{organizationId}/{fileName} | Read document contents
*PublicServicesApi* | [**ResolveImageUsingGET**](docs/PublicServicesApi.md#resolveimageusingget) | **GET** /api/v1/public/image/{imageID} | Resolve image
*PublicServicesApi* | [**ResolveWhoIsEntry**](docs/PublicServicesApi.md#resolvewhoisentry) | **GET** /whois/{id4n} | Resolve owner of id4n
*RoutingApi* | [**GetAllWebRoutes**](docs/RoutingApi.md#getallwebroutes) | **GET** /api/v1/routingfiles/{id4n}/routes | Retrieve all web routes
*RoutingApi* | [**GetRoute**](docs/RoutingApi.md#getroute) | **GET** /api/v1/routingfiles/{id4n}/routes/{type} | Retrieve current route of a GUID (or ID4N)
*RoutingApi* | [**GetRoutingFile**](docs/RoutingApi.md#getroutingfile) | **GET** /api/v1/routingfiles/{id4n} | Retrieve routing file
*RoutingApi* | [**UpdateRoutingFile**](docs/RoutingApi.md#updateroutingfile) | **PUT** /api/v1/routingfiles/{id4n} | Store routing file
*StorageApi* | [**CreateDocument**](docs/StorageApi.md#createdocument) | **PUT** /api/v1/documents/{id4n}/{organizationId} | Create an empty document for an id4n
*StorageApi* | [**DeleteDocument**](docs/StorageApi.md#deletedocument) | **DELETE** /api/v1/documents/{id4n}/{organizationId}/{fileName} | Delete a document
*StorageApi* | [**GetDocument**](docs/StorageApi.md#getdocument) | **GET** /api/v1/documents/{id4n}/{organizationId}/{fileName}/metadata | Retrieve a document (meta-data only, no content)
*StorageApi* | [**GetPublicDocument**](docs/StorageApi.md#getpublicdocument) | **GET** /api/v1/public/documents/{id4n}/{organizationId}/{fileName}/metadata | Retrieve a document (meta-data only, no content)
*StorageApi* | [**ListAllDocuments**](docs/StorageApi.md#listalldocuments) | **GET** /api/v1/documents/{id4n} | List documents
*StorageApi* | [**ListAllPublicDocuments**](docs/StorageApi.md#listallpublicdocuments) | **GET** /api/v1/public/documents/{id4n} | List organization specific documents
*StorageApi* | [**ListDocuments**](docs/StorageApi.md#listdocuments) | **GET** /api/v1/documents/{id4n}/{organizationId} | List organization specific documents
*StorageApi* | [**ListPublicDocuments**](docs/StorageApi.md#listpublicdocuments) | **GET** /api/v1/public/documents/{id4n}/{organizationId} | List organization specific documents
*StorageApi* | [**ReadDocument**](docs/StorageApi.md#readdocument) | **GET** /api/v1/documents/{id4n}/{organizationId}/{fileName} | Read document contents
*StorageApi* | [**ReadFromMicrostorage**](docs/StorageApi.md#readfrommicrostorage) | **GET** /api/v1/microstorage/{id4n}/{organization} | Read data from microstorage
*StorageApi* | [**ReadPublicDocument**](docs/StorageApi.md#readpublicdocument) | **GET** /api/v1/public/documents/{id4n}/{organizationId}/{fileName} | Read document contents
*StorageApi* | [**UpdateDocumentMetadata**](docs/StorageApi.md#updatedocumentmetadata) | **PATCH** /api/v1/documents/{id4n}/{organizationId}/{fileName}/metadata | Update a document
*StorageApi* | [**WriteToMicrostorage**](docs/StorageApi.md#writetomicrostorage) | **PUT** /api/v1/microstorage/{id4n}/{organization} | Write data to microstorage
*TransferApi* | [**GetReceiveInfo**](docs/TransferApi.md#getreceiveinfo) | **GET** /api/v1/transfers/{id4n}/receiveInfo | Show transfer information
*TransferApi* | [**GetSendInfo**](docs/TransferApi.md#getsendinfo) | **GET** /api/v1/transfers/{id4n}/sendInfo | Show transfer preparation information
*TransferApi* | [**Prepare**](docs/TransferApi.md#prepare) | **PUT** /api/v1/transfers/{id4n}/sendInfo | Prepare an object for transfer
*TransferApi* | [**Receive**](docs/TransferApi.md#receive) | **PUT** /api/v1/transfers/{id4n}/receiveInfo | Transfer a GUID or collection, obtaining it (i.e. becoming the holder) and if allowed also taking ownership
*WhoIsApi* | [**ResolveWhoIsEntry**](docs/WhoIsApi.md#resolvewhoisentry) | **GET** /whois/{id4n} | Resolve owner of id4n


<a name="documentation-for-models"></a>
## Documentation for Models

     - [Model.AccountCredentials](docs/AccountCredentials.md)
     - [Model.AddApiKeyPrivilegeRequest](docs/AddApiKeyPrivilegeRequest.md)
     - [Model.ApiError](docs/ApiError.md)
     - [Model.ApiKeyChangeRequest](docs/ApiKeyChangeRequest.md)
     - [Model.ApiKeyCreationRequest](docs/ApiKeyCreationRequest.md)
     - [Model.ApiKeyPresentation](docs/ApiKeyPresentation.md)
     - [Model.ApiKeyPrivilege](docs/ApiKeyPrivilege.md)
     - [Model.ApiKeyPrivilegeInfo](docs/ApiKeyPrivilegeInfo.md)
     - [Model.ApiKeyPrivilegeInfoResponse](docs/ApiKeyPrivilegeInfoResponse.md)
     - [Model.ApiKeyPrivilegePaginatedResponse](docs/ApiKeyPrivilegePaginatedResponse.md)
     - [Model.AppInfoPresentation](docs/AppInfoPresentation.md)
     - [Model.BillingPosition](docs/BillingPosition.md)
     - [Model.ChangeLogEntry](docs/ChangeLogEntry.md)
     - [Model.ChangeRoleRequest](docs/ChangeRoleRequest.md)
     - [Model.CompleteUserRegistrationRequest](docs/CompleteUserRegistrationRequest.md)
     - [Model.Country](docs/Country.md)
     - [Model.CreateGuidRequest](docs/CreateGuidRequest.md)
     - [Model.CreateLabelledCollectionRequest](docs/CreateLabelledCollectionRequest.md)
     - [Model.CreateLogisticCollectionRequest](docs/CreateLogisticCollectionRequest.md)
     - [Model.CreateRoutingCollectionRequest](docs/CreateRoutingCollectionRequest.md)
     - [Model.Document](docs/Document.md)
     - [Model.DocumentUpdate](docs/DocumentUpdate.md)
     - [Model.File](docs/File.md)
     - [Model.Guid](docs/Guid.md)
     - [Model.GuidAlias](docs/GuidAlias.md)
     - [Model.GuidCollection](docs/GuidCollection.md)
     - [Model.HistoryItem](docs/HistoryItem.md)
     - [Model.Id4n](docs/Id4n.md)
     - [Model.Id4nPresentation](docs/Id4nPresentation.md)
     - [Model.Id4nPresentationPaginatedResponse](docs/Id4nPresentationPaginatedResponse.md)
     - [Model.InputStream](docs/InputStream.md)
     - [Model.InputStreamResource](docs/InputStreamResource.md)
     - [Model.ListOfId4ns](docs/ListOfId4ns.md)
     - [Model.Organization](docs/Organization.md)
     - [Model.OrganizationAddress](docs/OrganizationAddress.md)
     - [Model.OrganizationUserInvitation](docs/OrganizationUserInvitation.md)
     - [Model.OrganizationUserInvitationListRequest](docs/OrganizationUserInvitationListRequest.md)
     - [Model.OwnedDocument](docs/OwnedDocument.md)
     - [Model.PaginatedApiKeyResponse](docs/PaginatedApiKeyResponse.md)
     - [Model.PaginatedChangeLogEntryResponse](docs/PaginatedChangeLogEntryResponse.md)
     - [Model.PaginatedCountryResponse](docs/PaginatedCountryResponse.md)
     - [Model.PaginatedDocumentResponse](docs/PaginatedDocumentResponse.md)
     - [Model.PaginatedGuidCollection](docs/PaginatedGuidCollection.md)
     - [Model.PaginatedGuidResponse](docs/PaginatedGuidResponse.md)
     - [Model.PaginatedHistoryItemResponse](docs/PaginatedHistoryItemResponse.md)
     - [Model.PaginatedOrganizationResponse](docs/PaginatedOrganizationResponse.md)
     - [Model.PaginatedOwnedDocumentResponse](docs/PaginatedOwnedDocumentResponse.md)
     - [Model.PaginatedResponseApiKeyPresentation](docs/PaginatedResponseApiKeyPresentation.md)
     - [Model.PaginatedResponseApiKeyPrivilege](docs/PaginatedResponseApiKeyPrivilege.md)
     - [Model.PaginatedResponseApiKeyPrivilegeInfo](docs/PaginatedResponseApiKeyPrivilegeInfo.md)
     - [Model.PaginatedResponseChangeLogEntry](docs/PaginatedResponseChangeLogEntry.md)
     - [Model.PaginatedResponseCountry](docs/PaginatedResponseCountry.md)
     - [Model.PaginatedResponseDocument](docs/PaginatedResponseDocument.md)
     - [Model.PaginatedResponseGuid](docs/PaginatedResponseGuid.md)
     - [Model.PaginatedResponseGuidCollection](docs/PaginatedResponseGuidCollection.md)
     - [Model.PaginatedResponseHistoryItem](docs/PaginatedResponseHistoryItem.md)
     - [Model.PaginatedResponseId4nPresentation](docs/PaginatedResponseId4nPresentation.md)
     - [Model.PaginatedResponseOrganization](docs/PaginatedResponseOrganization.md)
     - [Model.PaginatedResponseOwnedDocument](docs/PaginatedResponseOwnedDocument.md)
     - [Model.PaginatedResponseRole](docs/PaginatedResponseRole.md)
     - [Model.PaginatedResponseUserPresentation](docs/PaginatedResponseUserPresentation.md)
     - [Model.PaginatedResponseUserRoles](docs/PaginatedResponseUserRoles.md)
     - [Model.PaginatedResponsestring](docs/PaginatedResponsestring.md)
     - [Model.PaginatedStringResponse](docs/PaginatedStringResponse.md)
     - [Model.PaginatedUserPresentationResponse](docs/PaginatedUserPresentationResponse.md)
     - [Model.PaginatedUserRolesResponse](docs/PaginatedUserRolesResponse.md)
     - [Model.PasswordResetRequest](docs/PasswordResetRequest.md)
     - [Model.PasswordResetVerificationRequest](docs/PasswordResetVerificationRequest.md)
     - [Model.PublicImagePresentation](docs/PublicImagePresentation.md)
     - [Model.RegistrationVerificationTokenPresentation](docs/RegistrationVerificationTokenPresentation.md)
     - [Model.RemoveApiKeyPrivilegeRequest](docs/RemoveApiKeyPrivilegeRequest.md)
     - [Model.ResponseEntity](docs/ResponseEntity.md)
     - [Model.Role](docs/Role.md)
     - [Model.RoleResponse](docs/RoleResponse.md)
     - [Model.Route](docs/Route.md)
     - [Model.RoutingFile](docs/RoutingFile.md)
     - [Model.RoutingFileRequest](docs/RoutingFileRequest.md)
     - [Model.RoutingOptions](docs/RoutingOptions.md)
     - [Model.ServiceCosts](docs/ServiceCosts.md)
     - [Model.SimpleMessageResponse](docs/SimpleMessageResponse.md)
     - [Model.Timestamp](docs/Timestamp.md)
     - [Model.TransferReceiveInfo](docs/TransferReceiveInfo.md)
     - [Model.TransferSendInfo](docs/TransferSendInfo.md)
     - [Model.URI](docs/URI.md)
     - [Model.URL](docs/URL.md)
     - [Model.UserPresentation](docs/UserPresentation.md)
     - [Model.UserRegistrationRequest](docs/UserRegistrationRequest.md)
     - [Model.UserRegistrationResponse](docs/UserRegistrationResponse.md)
     - [Model.UserRoles](docs/UserRoles.md)
     - [Model.Visibility](docs/Visibility.md)
     - [Model.VisibilityUpdate](docs/VisibilityUpdate.md)
     - [Model.WhoIsResponse](docs/WhoIsResponse.md)
    

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

    <a name="Authorization"></a>
    ### Authorization

    - **Type**: API key
    - **API key parameter name**: Authorization
    - **Location**: HTTP header
        
