/* 
 * TrackingAPI
 *
 * API for retrieving tracking data and changing settings on LightBug & RemoteThings tracking devices
 *
 * OpenAPI spec version: 1.1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing Device
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class DeviceTests
    {
        // TODO uncomment below to declare an instance variable for Device
        //private Device instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Device
            //instance = new Device();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Device
        /// </summary>
        [Test]
        public void DeviceInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Device
            //Assert.IsInstanceOfType<Device> (instance, "variable 'instance' is a Device");
        }


        /// <summary>
        /// Test the property 'Imei'
        /// </summary>
        [Test]
        public void ImeiTest()
        {
            // TODO unit test for the property 'Imei'
        }
        /// <summary>
        /// Test the property 'Iccid'
        /// </summary>
        [Test]
        public void IccidTest()
        {
            // TODO unit test for the property 'Iccid'
        }
        /// <summary>
        /// Test the property 'LoraId'
        /// </summary>
        [Test]
        public void LoraIdTest()
        {
            // TODO unit test for the property 'LoraId'
        }
        /// <summary>
        /// Test the property 'Imsi'
        /// </summary>
        [Test]
        public void ImsiTest()
        {
            // TODO unit test for the property 'Imsi'
        }
        /// <summary>
        /// Test the property 'BtMac'
        /// </summary>
        [Test]
        public void BtMacTest()
        {
            // TODO unit test for the property 'BtMac'
        }
        /// <summary>
        /// Test the property 'BtMacAddress'
        /// </summary>
        [Test]
        public void BtMacAddressTest()
        {
            // TODO unit test for the property 'BtMacAddress'
        }
        /// <summary>
        /// Test the property 'Serial'
        /// </summary>
        [Test]
        public void SerialTest()
        {
            // TODO unit test for the property 'Serial'
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'Expires'
        /// </summary>
        [Test]
        public void ExpiresTest()
        {
            // TODO unit test for the property 'Expires'
        }
        /// <summary>
        /// Test the property 'LastConnection'
        /// </summary>
        [Test]
        public void LastConnectionTest()
        {
            // TODO unit test for the property 'LastConnection'
        }
        /// <summary>
        /// Test the property 'FirstSeen'
        /// </summary>
        [Test]
        public void FirstSeenTest()
        {
            // TODO unit test for the property 'FirstSeen'
        }
        /// <summary>
        /// Test the property 'Mode'
        /// </summary>
        [Test]
        public void ModeTest()
        {
            // TODO unit test for the property 'Mode'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'BatteryVoltage'
        /// </summary>
        [Test]
        public void BatteryVoltageTest()
        {
            // TODO unit test for the property 'BatteryVoltage'
        }
        /// <summary>
        /// Test the property 'BatteryType'
        /// </summary>
        [Test]
        public void BatteryTypeTest()
        {
            // TODO unit test for the property 'BatteryType'
        }
        /// <summary>
        /// Test the property 'Tags'
        /// </summary>
        [Test]
        public void TagsTest()
        {
            // TODO unit test for the property 'Tags'
        }
        /// <summary>
        /// Test the property 'CurrentMode'
        /// </summary>
        [Test]
        public void CurrentModeTest()
        {
            // TODO unit test for the property 'CurrentMode'
        }
        /// <summary>
        /// Test the property 'Color'
        /// </summary>
        [Test]
        public void ColorTest()
        {
            // TODO unit test for the property 'Color'
        }
        /// <summary>
        /// Test the property 'SaveToWeb'
        /// </summary>
        [Test]
        public void SaveToWebTest()
        {
            // TODO unit test for the property 'SaveToWeb'
        }
        /// <summary>
        /// Test the property 'Active'
        /// </summary>
        [Test]
        public void ActiveTest()
        {
            // TODO unit test for the property 'Active'
        }
        /// <summary>
        /// Test the property 'DeepSleep'
        /// </summary>
        [Test]
        public void DeepSleepTest()
        {
            // TODO unit test for the property 'DeepSleep'
        }
        /// <summary>
        /// Test the property 'Simstate'
        /// </summary>
        [Test]
        public void SimstateTest()
        {
            // TODO unit test for the property 'Simstate'
        }
        /// <summary>
        /// Test the property 'StripeSubscription'
        /// </summary>
        [Test]
        public void StripeSubscriptionTest()
        {
            // TODO unit test for the property 'StripeSubscription'
        }
        /// <summary>
        /// Test the property 'SubscriptionType'
        /// </summary>
        [Test]
        public void SubscriptionTypeTest()
        {
            // TODO unit test for the property 'SubscriptionType'
        }
        /// <summary>
        /// Test the property 'Meta'
        /// </summary>
        [Test]
        public void MetaTest()
        {
            // TODO unit test for the property 'Meta'
        }
        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'OwnerId'
        /// </summary>
        [Test]
        public void OwnerIdTest()
        {
            // TODO unit test for the property 'OwnerId'
        }
        /// <summary>
        /// Test the property 'SecurePhoneId'
        /// </summary>
        [Test]
        public void SecurePhoneIdTest()
        {
            // TODO unit test for the property 'SecurePhoneId'
        }
        /// <summary>
        /// Test the property 'ResellerId'
        /// </summary>
        [Test]
        public void ResellerIdTest()
        {
            // TODO unit test for the property 'ResellerId'
        }
        /// <summary>
        /// Test the property 'ResellerPlanId'
        /// </summary>
        [Test]
        public void ResellerPlanIdTest()
        {
            // TODO unit test for the property 'ResellerPlanId'
        }

    }

}
