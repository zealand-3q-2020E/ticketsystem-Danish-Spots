namespace TicketLibrary
{
    public class MC : Vehicle
    {
        /// <summary>
        /// Method for returning the price of a ticket
        /// </summary>
        /// <param name="useBrobizz">Specify if the vehicle uses a brobizz (true or false)</param>
        /// <returns>returns 125.00 if no brobizz is used, other wise returns 125.00 - 5% of 125.00</returns>
        public override double Price(bool useBrobizz)
        {
            if (useBrobizz)
            {
                return base.Price(125, 5);
            }
            return 125.00;
        }

        /// <summary>
        /// Method for getting the type of vehicle
        /// </summary>
        /// <returns>returns the string "MC"</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
