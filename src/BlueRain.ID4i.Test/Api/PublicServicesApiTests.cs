/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.2.4
 * Contact: info@bluerain.de
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using BlueRain.ID4i.Client;
using BlueRain.ID4i.Api;
using BlueRain.ID4i.Model;

namespace BlueRain.ID4i.Test
{
    /// <summary>
    ///  Class for testing PublicServicesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PublicServicesApiTests
    {
        private PublicServicesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PublicServicesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PublicServicesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PublicServicesApi
            //Assert.IsInstanceOfType(typeof(PublicServicesApi), instance, "instance is a PublicServicesApi");
        }

        
        /// <summary>
        /// Test GetPublicDocument
        /// </summary>
        [Test]
        public void GetPublicDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? organizationId = null;
            //string id4n = null;
            //string fileName = null;
            //var response = instance.GetPublicDocument(organizationId, id4n, fileName);
            //Assert.IsInstanceOf<Document> (response, "response is Document");
        }
        
        /// <summary>
        /// Test Go
        /// </summary>
        [Test]
        public void GoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string guid = null;
            //instance.Go(guid);
            
        }
        
        /// <summary>
        /// Test ListAllPublicDocuments
        /// </summary>
        [Test]
        public void ListAllPublicDocumentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id4n = null;
            //long? organizationId = null;
            //int? offset = null;
            //int? limit = null;
            //var response = instance.ListAllPublicDocuments(id4n, organizationId, offset, limit);
            //Assert.IsInstanceOf<PaginatedOwnedDocumentResponse> (response, "response is PaginatedOwnedDocumentResponse");
        }
        
        /// <summary>
        /// Test ListPublicDocuments
        /// </summary>
        [Test]
        public void ListPublicDocumentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? organizationId = null;
            //string id4n = null;
            //int? offset = null;
            //int? limit = null;
            //var response = instance.ListPublicDocuments(organizationId, id4n, offset, limit);
            //Assert.IsInstanceOf<PaginatedDocumentResponse> (response, "response is PaginatedDocumentResponse");
        }
        
        /// <summary>
        /// Test ReadPublicDocument
        /// </summary>
        [Test]
        public void ReadPublicDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? organizationId = null;
            //string id4n = null;
            //string fileName = null;
            //var response = instance.ReadPublicDocument(organizationId, id4n, fileName);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ResolveImageUsingGET
        /// </summary>
        [Test]
        public void ResolveImageUsingGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string imageID = null;
            //var response = instance.ResolveImageUsingGET(imageID);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ResolveWhoIsEntry
        /// </summary>
        [Test]
        public void ResolveWhoIsEntryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id4n = null;
            //var response = instance.ResolveWhoIsEntry(id4n);
            //Assert.IsInstanceOf<WhoIsResponse> (response, "response is WhoIsResponse");
        }
        
    }

}
