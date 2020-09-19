using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;

namespace TestLibrary
{
    [TestClass]
    public class WeekendDiscountTest
    {
        [TestMethod]
        public void TestWeekendDiscountCar()
        {
            //Arrange
            WeekendDiscount wD = new WeekendDiscount();

            //Act
            double discountedPrice = wD.WeekendDiscountCar();

            //Assert
            Assert.AreEqual(192, discountedPrice, 0.01);
        }
    }
}
