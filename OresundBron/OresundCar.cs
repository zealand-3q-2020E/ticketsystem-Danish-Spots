using System;
using TicketLibrary;

namespace OresundBron
{
    public class OresundCar : Vehicle
    {
        public override double Price(bool useBrobizz)
        {
            if (useBrobizz)
            {
                FinalPrice = 161.00;
                return FinalPrice;
            }

            FinalPrice = 410;
            return FinalPrice;
        }

        public override string VehicleType()
        {
            return "Oresund car";
        }
    }
}
