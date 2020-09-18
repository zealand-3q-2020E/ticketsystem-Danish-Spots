using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ClassLibrary
{
    public class Vehicle
    {
        private string _lP = "";

        /// <summary>
        /// Property for getting and setting the license plate of a vehicle buying a ticket
        /// </summary>
        public string LicensePlate
        {
            get { return _lP;}
            set
            {
                if (value.Length > 7)
                {
                    throw new LicensePlateMaxCharacterLengthException();
                }

                _lP = value;
            }
        }

        /// <summary>
        /// Property for getting and setting the Date and Time of ticket purchase
        /// </summary>
        public DateTime Date
        {
            get;
            set;
        }

        /// <summary>
        /// Method to be overriden in child classes that returns the price of a ticket for a vehicle
        /// </summary>
        /// <returns>returns 0 unless overridden</returns>
        public virtual double Price()
        {
            return 0;
        }

        /// <summary>
        /// Method to be overriden in child classes that returns the vehicle type of a vehicle buying a ticket
        /// </summary>
        /// <returns>returns "" unless overridden</returns>
        public virtual string VehicleType()
        {
            return "";
        }
    }
}
