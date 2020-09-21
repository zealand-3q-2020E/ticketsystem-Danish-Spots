using System;
using System.Collections.Generic;
using System.Text;

namespace TicketSystem
{
    public static class UseBrobizzScreen
    {
        public static void SelectBroBizzScreen()
        {
            WriteToScreen(0, 1);
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.UpArrow)
                {
                    WriteToScreen(2, 3);
                    ConsoleKeyInfo key1 = Console.ReadKey(true);
                    switch (key1.Key)
                    {
                        case ConsoleKey.Enter:
                            EnterInformationScreen.VehicleObject.Price(false);
                            PricingScreen.PriceResultScreenMethod();
                            break;
                        case ConsoleKey.DownArrow:
                            WriteToScreen(0, 1);
                            break;
                        case ConsoleKey.UpArrow:
                            WriteToScreen(0, 1);
                            break;
                    }
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    EnterInformationScreen.VehicleObject.Price(true);
                    PricingScreen.PriceResultScreenMethod();
                    break;
                }

            }
        }

        public static void WriteToScreen(int index1, int index2)
        {
            string[] startMenu = { "> Yes", "  No", "  Yes", "> No" };
            Console.Clear();
            Console.WriteLine("Do you have a BroBizz and want to use it?");
            Console.WriteLine("Choose yes, if using brobizz, and no if not using brobizz");
            Console.WriteLine(startMenu[index1]);
            Console.WriteLine(startMenu[index2]);
        }
    }
}
