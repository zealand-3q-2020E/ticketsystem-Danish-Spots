using System;
using TicketLibrary;

namespace OresundBron
{
    /// <summary>
    /// Class that creates a car object for traveling over the Oresund bridge
    /// </summary>
    public class OresundCar : Vehicle
    {
        /// <summary>
        /// Method that gets the price of a ticket
        /// </summary>
        /// <param name="useBrobizz">true for if the car has a brobizz, false if no</param>
        /// <returns>Returns 410 if brobizz is used, and 161 if no brobizz is used</returns>
        public override double Price(bool useBrobizz)
        {
            if (useBrobizz)
            {
                FinalPrice = 161.00;
                return FinalPrice;
            }

            FinalPrice = 410;
            return FinalPrice;
        }

        /// <summary>
        /// Method that returns the vehicle type that is buying the ticket
        /// </summary>
        /// <returns>Returns "Oresund car"</returns>
        public override string VehicleType()
        {
            return "Oresund car";
        }
    }
}
