using System;
using System.Collections.Generic;
using System.Text;
using TicketLibrary;

namespace OresundBron
{
    public class OresundMC : Vehicle
    {
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

        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
