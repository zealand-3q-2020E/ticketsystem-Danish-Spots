using System;

namespace TicketLibrary
{
    /// <summary>
    /// Custom exception class for license plates exceeding 7 characters in length
    /// </summary>
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
