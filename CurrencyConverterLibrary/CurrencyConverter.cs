using System;

namespace CurrencyConverterLibrary
{
    /// <summary>
    /// Library for converting from danish kroner (dkk) to other major currencies, the convert rates are from googles convert page on the date 19/09/2020 at 15:51 danish time
    /// </summary>
    public static class CurrencyConverter
    {
        /// <summary>
        /// Converts from dkk to usd (us dollar at a rate of 1dkk = 0.16 usd)
        /// </summary>
        /// <param name="amount">The amount to be converted in dkk</param>
        /// <returns>returns the amount in usd</returns>
        public static double ConvertDkkToUSD(double amount)
        {
            return amount * 0.16;
        }

        /// <summary>
        /// Converts from dkk to eur (euro at a rate of 1 dkk = 0.13 eur) 
        /// </summary>
        /// <param name="amount">The amount to be converted in dkk</param>
        /// <returns>returns the amount in eur</returns>
        public static double ConvertDkkToEur(double amount)
        {
            return amount * 0.13;
        }

        /// <summary>
        /// Converts from dkk to cad (canadian dollar at a rate of 1 dkk = 0.21 eur) 
        /// </summary>
        /// <param name="amount">The amount to be converted in dkk</param>
        /// <returns>returns the amount in cad</returns>
        public static double ConvertDkkToCad(double amount)
        {
            return amount * 0.21;
        }

        /// <summary>
        /// Converts from dkk to gbp (pound sterling at a rate of 1 dkk = 0.12 eur) 
        /// </summary>
        /// <param name="amount">The amount to be converted in dkk</param>
        /// <returns>returns the amount in gbp</returns>
        public static double ConvertDkkToGbp(double amount)
        {
            return amount * 0.12;
        }
    }
}
