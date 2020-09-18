using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

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
            double price = car.Price();

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
    }
}