using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class MC : Vehicle
    {
        /// <summary>
        /// Method for getting the price of a ticket for the MC
        /// </summary>
        /// <returns>returns the double 125.00</returns>
        public override double Price()
        {
            return 125.00;
        }

        /// <summary>
        /// Method for getting the type of vehicle
        /// </summary>
        /// <returns>returns the string "MC"</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
