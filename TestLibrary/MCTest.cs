using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestLibrary
{
    [TestClass]
    public class MCTest
    {
        [TestMethod]
        public void TestPrice()
        {
            //Arrange
            MC mc = new MC();

            //Act
            double price = mc.Price();

            //Assert
            Assert.AreEqual(125.00, price);
        }

        [TestMethod]
        public void TestVehicleType()
        {
            //Arrange
            MC mc = new MC();

            //Act
            string vT = mc.VehicleType();

            //Assert
            Assert.AreEqual("MC", vT);
        }
    }
}
