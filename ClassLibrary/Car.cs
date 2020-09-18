using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Car
    {
        /// <summary>
        /// Property for getting and setting the license plate of a car buying a ticket
        /// </summary>
        public string LicensePlate
        {
            get;
            set;
        }

        /// <summary>
        /// Property for getting and setting the Date of ticket purchase
        /// </summary>
        public DateTime Date
        {
            get;
            set;
        }

        /// <summary>
        /// Property for getting the price of a ticket for the car
        /// </summary>
        /// <returns>returns the double 240.00</returns>
        public double Price()
        {
            return 240.00;
        }

        /// <summary>
        /// Property for getting the type of vehicle
        /// </summary>
        /// <returns>returns the string "Car"</returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}
