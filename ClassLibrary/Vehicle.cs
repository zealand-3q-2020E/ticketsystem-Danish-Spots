using System;

namespace TicketLibrary
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
        /// Method to be overridden in child classes for returning the price of a ticket
        /// </summary>
        /// <param name="useBrobizz">A bool that determines if a brobizz is used, true is yes and false is no</param>
        /// <returns>returns 0 unless overridden</returns>
        public virtual double Price(bool useBrobizz)
        {
            return 0;
        }

        /// <summary>
        /// Internal method that can only be called from child classes, which calculates the new price if a brobizz is used.
        /// </summary>
        /// <param name="initialPrice">The initial price of the ticket</param>
        /// <param name="discount">the discount percentage given in double form eg 5 is 5%</param>
        /// <returns>returns the initial price - the discount</returns>
        protected double Price(double initialPrice, double discount)
        {
            return initialPrice - (initialPrice * (discount/100));
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
