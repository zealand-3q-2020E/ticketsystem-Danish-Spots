﻿namespace TicketLibrary
{
    /// <summary>
    /// Class that creates a car object for traveling over bridges
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Method for returning the price of a ticket
        /// </summary>
        /// <param name="useBrobizz">Specify if the vehicle uses a brobizz (true or false)</param>
        /// <returns>returns 240.00 if no brobizz is used, other wise returns 240.00 - 5% of 240.00</returns>
        public override double Price(bool useBrobizz)
        {
            if (useBrobizz)
            {
                FinalPrice = base.Price(240.00, .05);
                return FinalPrice;
            }

            FinalPrice = 240.00;
            return FinalPrice;
        }

        /// <summary>
        /// Method for getting the type of vehicle
        /// </summary>
        /// <returns>returns the string "Car"</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
