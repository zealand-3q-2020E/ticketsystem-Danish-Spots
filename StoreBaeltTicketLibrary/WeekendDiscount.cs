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
        /// <param name="useBrobizz">true if brobizz is used false if not</param>
        /// <returns>returns the double of 240 - (240 * 20%) and then applies brobizz ontop</returns>
        public double WeekendDiscountCar(bool useBrobizz)
        {
            Car car = new Car();
            double initialPrice = car.Price(false);
            double returnValue = initialPrice * 0.8;
            if (useBrobizz)
                returnValue = returnValue - (returnValue * .05);
            FinalPrice = returnValue;
            return returnValue;
        }
    }
}
