using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using TicketLibrary;

namespace CustomerLibrary
{
    public class Customer
    {

        public Customer()
        {
            TripsList = new List<Vehicle>();
        }

        public Customer(List<Vehicle> tripsList)
        {
            TripsList = tripsList;
        }

        public List<Vehicle> TripsList
        {
            get;
        }

        public double TotalPriceOfAllTrips()
        {
            return TripsList.Sum(v => v.FinalPrice);
        }
    }
}
