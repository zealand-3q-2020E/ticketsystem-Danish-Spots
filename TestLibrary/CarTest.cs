using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketLibrary;

namespace TestLibrary
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void TestPrice()
        {
            //Arrange
            Car car = new Car();

            //Act
            double price = car.Price(false);

            //Assert
            Assert.AreEqual(240.00, price);
        }

        [TestMethod]
        public void TestVehicleType()
        {
            //Arrange
            Car car = new Car();

            //Act
            string vT = car.VehicleType();

            //Assert
            Assert.AreEqual("Car", vT);
        }

        [TestMethod]
        public void TestGetAndSetLicensePlate()
        {
            //Arrange
            Car car = new Car();
            //Example plate
            string lP = "BD03302";

            //Act
            car.LicensePlate = lP;

            //Assert
            Assert.AreEqual(lP, car.LicensePlate);
        }

        [TestMethod]
        [ExpectedException(typeof(LicensePlateMaxCharacterLengthException))]
        public void TestSetLicensePlateBeyond7Characters()
        {
            //Arrange
            Car car = new Car();
            //Example plate
            string lP = "BD033023";

            //Act
            car.LicensePlate = lP;

            //Assert
            Assert.AreEqual(lP, car.LicensePlate);
        }
    }
}
