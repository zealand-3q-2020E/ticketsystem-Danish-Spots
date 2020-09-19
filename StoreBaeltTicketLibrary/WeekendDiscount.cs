using System;
using TicketLibrary;

namespace StoreBaeltTicketLibrary
{
    public class WeekendDiscount
    {
        public double WeekendDiscountCar()
        {
            double initialPrice = new Car().Price(false);
            return initialPrice - (initialPrice * (20.0 / 100));
        }
    }
}
