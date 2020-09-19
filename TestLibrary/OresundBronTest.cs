using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundBron;

namespace TestLibrary
{
    [TestClass]
    public class OresundBronTest
    {
        [TestMethod]
        [DataRow(false, 410)]
        [DataRow(true, 161)]
        public void TestOresundCarPrice(bool useBrobizz, double expected)
        {
            //Arrange
            OresundCar car = new OresundCar();

            //Act
            double price = car.Price(useBrobizz);

            //Assert
            Assert.AreEqual(expected, price);
        }

        [TestMethod]
        [DataRow(false, 210)]
        [DataRow(true, 73)]
        public void TestOresundMCPrice(bool useBrobizz, double expected)
        {
            //Arrange
            OresundMC mc = new OresundMC();

            //Act
            double price = mc.Price(useBrobizz);

            //Assert
            Assert.AreEqual(expected, price);
        }

        [TestMethod]
        public void TestVehicleTypeCar()
        {
            //Arrange
            OresundCar car = new OresundCar();

            //Act
            string vT = car.VehicleType();

            //Assert
            Assert.AreEqual("Oresund car", vT);
        }

        [TestMethod]
        public void TestVehicleTypeMC()
        {
            //Arrange
            OresundMC mc = new OresundMC();

            //Act
            string vT = mc.VehicleType();

            //Assert
            Assert.AreEqual("Oresund MC", vT);
        }
    }
}
