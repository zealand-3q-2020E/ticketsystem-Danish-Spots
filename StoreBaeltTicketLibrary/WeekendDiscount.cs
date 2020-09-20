using System;
using System.Runtime.ConstrainedExecution;
using TicketLibrary;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Class for creating an object that applies a 20% discount on cars traveling over the StoreBaelt Bridge on weekends. Note, Cars Only!
    /// </summary>
    public class WeekendDiscount : Vehicle
    {
        /// <summary>
        /// Method for getting the price of a ticket for a car on the weekends for the StoreBaelt bridge.
        /// </summary>
        /// <returns>returns the double of 240 - (240 * 20%)</returns>
        public double WeekendDiscountCar()
        {
            Car car = new Car();
            double initialPrice = car.Price(false);
            FinalPrice =  initialPrice - (initialPrice * (20.0 / 100));
            return FinalPrice;
        }
    }
}
