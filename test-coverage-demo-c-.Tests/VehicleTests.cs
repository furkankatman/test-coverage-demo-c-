
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace test_coverage_demo_c_.Tests
{
    [TestClass]
    public class VehicleTests
    {
        [TestMethod]
        public void Start_ShouldWriteExpectedMessage()
        {
            // Arrange
            var vehicle = new Vehicle("Toyota", "Camry", 2020);
            using var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            vehicle.Start();

            // Assert
            var output = consoleOutput.ToString().Trim();
            Assert.AreEqual("Vehicle is starting...x", output);
        }
    }
}
