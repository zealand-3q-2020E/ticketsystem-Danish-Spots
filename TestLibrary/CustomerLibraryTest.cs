using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerLibrary;
using OresundBron;
using StoreBaeltTicketLibrary;
using TicketLibrary;

namespace TestLibrary
{
    [TestClass]
    public class CustomerLibraryTest
    {
        [TestMethod]
        public void TestCustomerListLength()
        {
            //Arrange
            Customer c = new Customer();

            OresundCar oCar1 = new OresundCar();
            WeekendDiscount sCar1 = new WeekendDiscount();
            Car car1 = new Car();
            MC mc1 = new MC();
            OresundMC oMC = new OresundMC();


            //Act
            oCar1.Price(false);
            sCar1.WeekendDiscountCar();
            car1.Price(true);
            mc1.Price(false);
            oMC.Price(true);
            c.TripsList.Add(oCar1);
            c.TripsList.Add(sCar1);
            c.TripsList.Add(car1);
            c.TripsList.Add(mc1);
            c.TripsList.Add(oMC);

            //Assert
            Assert.AreEqual(5, c.TripsList.Count);
        }

        [TestMethod]
        public void TestCustomerListPriceSum()
        {
            //Arrange
            Customer c = new Customer();

            OresundCar oCar1 = new OresundCar();
            WeekendDiscount sCar1 = new WeekendDiscount();
            Car car1 = new Car();
            MC mc1 = new MC();
            OresundMC oMC = new OresundMC();


            //Act
            oCar1.Price(false);
            sCar1.WeekendDiscountCar();
            car1.Price(true);
            mc1.Price(false);
            oMC.Price(true);
            c.TripsList.Add(oCar1);
            c.TripsList.Add(sCar1);
            c.TripsList.Add(car1);
            c.TripsList.Add(mc1);
            c.TripsList.Add(oMC);

            double totalPrice = c.TotalPriceOfAllTrips();

            //Assert
            Assert.AreEqual(1028, totalPrice);
        }
    }
}
