using System;

namespace TicketLibrary
{
    public class LicensePlateMaxCharacterLengthException : Exception
    {
        public LicensePlateMaxCharacterLengthException() : base("The entered license plate exceeds 7 characters")
        {

        }

        public LicensePlateMaxCharacterLengthException(string message) : base(message)
        {

        }
        public LicensePlateMaxCharacterLengthException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
