namespace TicketLibrary
{
    public class Car : Vehicle
    {
        /// <summary>
        /// Method for returning the price of a ticket
        /// </summary>
        /// <param name="useBrobizz">Specify if the vehicle uses a brobizz (true or false)</param>
        /// <returns>returns 240.00 if no brobizz is used, other wise returns 240.00 - 5% of 240.00</returns>
        public override double Price(bool useBrobizz)
        {
            if (useBrobizz)
            {
                return base.Price(240.00, 5);
            }
            return 240.00;
        }

        /// <summary>
        /// Method for getting the type of vehicle
        /// </summary>
        /// <returns>returns the string "Car"</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
