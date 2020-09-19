using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketLibrary;

namespace TestLibrary
{
    [TestClass]
    public class MCTest
    {
        [TestMethod]
        [DataRow(false, 125)]
        [DataRow(true, 118.75)]
        public void TestPrice(bool useBrobizz, double expected)
        {
            //Arrange
            MC mc = new MC();

            //Act
            double price = mc.Price(useBrobizz);

            //Assert
            Assert.AreEqual(expected, price, 0.01);
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

        [TestMethod]
        public void TestGetAndSetLicensePlate()
        {
            //Arrange
            MC mc = new MC();
            //Example plate
            string lP = "BD03302";

            //Act
            mc.LicensePlate = lP;

            //Assert
            Assert.AreEqual(lP, mc.LicensePlate);
        }
    }
}
