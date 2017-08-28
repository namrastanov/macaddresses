using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MacAddresses.Models.InputParamModels;
using System.Collections.Generic;
using MacAddresses.Controllers;
using MacAddresses.Models.ResponseModels;
using MacAddresses.Data.Entities;
using MacAddresses.Data.Services.DataServices;
using MacAddresses.Data.Services.ValidationServices;

namespace MacAddresses.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddMacs()
        {
            var testMacs = new AddMacsParams
            {
                Macs = new List<MacAddress>
                {
                    new MacAddress{ Value = "AA:AA:AA:AA:AA:A1" },
                    new MacAddress{ Value = "BB:BB:BB:BB:BB:B1" },
                    new MacAddress{ Value = "BB:BB:BB:BB:BB:B2" },
                    new MacAddress{ Value = "CC:CC:CC:CC:CC:C1" },
                    new MacAddress{ Value = "CC:CC:CC:CC:CC:C2" }
                }
            };
            var dataService = new MacAddressService();
            var validationService = new MacAddressValidationService();
            var controller = new HomeController(dataService, validationService);
            var result = controller.AddMacs(testMacs);
            Assert.IsTrue(result.IsSuccess);
        }
    }
}
