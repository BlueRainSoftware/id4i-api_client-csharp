/* 
 * ID4i API
 *
 * ID4i HTTP API
 *
 * OpenAPI spec version: 0.2.4-SNAPSHOT
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
    ///  Class for testing GuidsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class GuidsApiTests
    {
        private GuidsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GuidsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GuidsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' GuidsApi
            //Assert.IsInstanceOfType(typeof(GuidsApi), instance, "instance is a GuidsApi");
        }

        
        /// <summary>
        /// Test AddGuidAlias
        /// </summary>
        [Test]
        public void AddGuidAliasTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id4n = null;
            //string aliasType = null;
            //GuidAlias alias = null;
            //instance.AddGuidAlias(id4n, aliasType, alias);
            
        }
        
        /// <summary>
        /// Test CreateGuid
        /// </summary>
        [Test]
        public void CreateGuidTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateGuidRequest createGUIDInfo = null;
            //var response = instance.CreateGuid(createGUIDInfo);
            //Assert.IsInstanceOf<ListOfId4ns> (response, "response is ListOfId4ns");
        }
        
        /// <summary>
        /// Test GetGuid
        /// </summary>
        [Test]
        public void GetGuidTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id4n = null;
            //var response = instance.GetGuid(id4n);
            //Assert.IsInstanceOf<Guid> (response, "response is Guid");
        }
        
        /// <summary>
        /// Test GetGuidAliases
        /// </summary>
        [Test]
        public void GetGuidAliasesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id4n = null;
            //var response = instance.GetGuidAliases(id4n);
            //Assert.IsInstanceOf<Dictionary<string, string>> (response, "response is Dictionary<string, string>");
        }
        
        /// <summary>
        /// Test GetGuidsWithoutCollection
        /// </summary>
        [Test]
        public void GetGuidsWithoutCollectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? organizationId = null;
            //int? offset = null;
            //int? limit = null;
            //var response = instance.GetGuidsWithoutCollection(organizationId, offset, limit);
            //Assert.IsInstanceOf<PaginatedResponseGuid> (response, "response is PaginatedResponseGuid");
        }
        
        /// <summary>
        /// Test GetId4n
        /// </summary>
        [Test]
        public void GetId4nTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id4n = null;
            //var response = instance.GetId4n(id4n);
            //Assert.IsInstanceOf<Id4nPresentation> (response, "response is Id4nPresentation");
        }
        
        /// <summary>
        /// Test RemoveGuidAlias
        /// </summary>
        [Test]
        public void RemoveGuidAliasTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id4n = null;
            //string aliasType = null;
            //instance.RemoveGuidAlias(id4n, aliasType);
            
        }
        
        /// <summary>
        /// Test SetGuid
        /// </summary>
        [Test]
        public void SetGuidTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id4n = null;
            //Guid request = null;
            //var response = instance.SetGuid(id4n, request);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test SetGuid1
        /// </summary>
        [Test]
        public void SetGuid1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id4n = null;
            //Guid request = null;
            //var response = instance.SetGuid1(id4n, request);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
    }

}
