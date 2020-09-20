using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using TicketLibrary;

namespace CustomerLibrary
{
    /// <summary>
    /// Class that creates a customer object for traveling over bridges
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Basic constructor that takes no arguments
        /// </summary>
        public Customer()
        {
            TripsList = new List<Vehicle>();
        }

        /// <summary>
        /// Overloaded constructor that takes a list of trips as an argument
        /// </summary>
        /// <param name="tripsList">A list of trips that can be loaded into a customer object</param>
        public Customer(List<Vehicle> tripsList)
        {
            TripsList = tripsList;
        }

        /// <summary>
        /// A list of trips a customer has taken over bridges, only has get
        /// </summary>
        public List<Vehicle> TripsList
        {
            get;
        }

        /// <summary>
        /// A method for calculating the total cost of all trips over bridges a customer has been on
        /// </summary>
        /// <returns>Returns the sum of all the vehicle object's ticket prices in TripsList</returns>
        public double TotalPriceOfAllTrips()
        {
            return TripsList.Sum(v => v.FinalPrice);
        }
    }
}
