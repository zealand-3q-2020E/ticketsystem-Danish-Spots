namespace TicketLibrary
{
    /// <summary>
    /// Class that creates a motorcycle object for traveling over bridges
    /// </summary>
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
                FinalPrice = base.Price(125, .05);
                return FinalPrice;
            }

            FinalPrice = 125.00;
            return FinalPrice;
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
