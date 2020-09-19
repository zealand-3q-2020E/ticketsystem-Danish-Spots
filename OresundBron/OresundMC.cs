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
                return 73.00;
            return 210.00;
        }

        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
