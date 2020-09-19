using System;
using System.Runtime.ConstrainedExecution;
using TicketLibrary;

namespace StoreBaeltTicketLibrary
{
    public class WeekendDiscount : Vehicle
    {
        public double WeekendDiscountCar()
        {
            Car car = new Car();
            double initialPrice = car.Price(false);
            FinalPrice =  initialPrice - (initialPrice * (20.0 / 100));
            return FinalPrice;
        }
    }
}
