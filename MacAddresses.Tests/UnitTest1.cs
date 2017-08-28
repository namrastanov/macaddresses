using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MacAddresses.Models.InputParamModels;
using System.Collections.Generic;
using MacAddresses.Controllers;
using MacAddresses.Models.ResponseModels;

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
                Macs = new List<string>
                {
                    "AA:AA:AA:AA:AA:A1",
                    "BB:BB:BB:BB:BB:B1",
                    "BB:BB:BB:BB:BB:B1",
                    "CC:CC:CC:CC:CC:C1",
                    "CC:CC:CC:CC:CC:C2"
                }
            };
            var controller = new HomeController();
            var result = controller.AddMacs(testMacs);
            Assert.AreEqual(testMacs.Macs.Count, result.AddedCount);
        }
    }
}
