using System;
using System.Collections.Generic;
using System.Text;

namespace TicketSystem
{
    public static class Constants
    {
        public enum TicketType
        {
            GENERIC_TICKET = 0,
            STOREBAELT_TICKET = 1,
            ORESUND_TICKET = 2,
            NOT_SELECTED = 3
        }

        public enum VehicleType
        {
            CAR = 0,
            MOTORCYCLE = 1,
            NONE = 2,
        }
    }
}
