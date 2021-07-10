using System;
using System.Collections.Generic;
using System.Text;
using TicketLibrary;

namespace OresundBron
{
    /// <summary>
    /// Class that creates a motorcycle object for traveling over the Oresund bridge
    /// </summary>
    public class OresundMC : Vehicle
    {
        /// <summary>
        /// Method that gets the price of a ticket
        /// </summary>
        /// <param name="useBrobizz">true or false for if you are using a discount (yes or no)</param>
        /// <returns>Returns 210 for no brobizz and 73 for if a brobizz is used</returns>
        public override double Price(bool useBrobizz)
        {
            if (useBrobizz)
            {
                FinalPrice = 73.00;
                return FinalPrice;
            }

            FinalPrice = 210.00;
            return FinalPrice;
        }

        /// <summary>
        /// Method that returns the vehicle type that is buying the ticket
        /// </summary>
        /// <returns>Returns "Oresund MC"</returns>
        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
