using System;
using TicketLibrary;

namespace OresundBron
{
    public class OresundCar : Vehicle
    {
        public override double Price(bool useBrobizz)
        {
            if (useBrobizz)
                return 161.00;
            return 410.00;
        }

        public override string VehicleType()
        {
            return "Oresund car";
        }
    }
}
