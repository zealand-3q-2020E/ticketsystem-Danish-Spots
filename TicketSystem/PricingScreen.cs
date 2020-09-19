using System;
using System.Collections.Generic;
using System.Text;

namespace TicketSystem
{
    public static class PricingScreen
    {
        public static void PriceInfoScreen()
        {
            Console.Clear();
            Console.WriteLine("Thank you for buying a ticket, the information of the ticket is below:");
            Console.WriteLine("\n");
            PrintTicketInfo();
        }

        public static void PrintTicketInfo()
        {
            Console.Write("\tVehicle Type: \t");
            Console.WriteLine(EnterInformationScreen.VehicleObject.VehicleType());

            Console.Write("\tLicense Plate: \t");
            Console.WriteLine(EnterInformationScreen.VehicleObject.LicensePlate);

            Console.Write("\tPurchase Date: \t");
            Console.WriteLine(EnterInformationScreen.VehicleObject.Date);

            Console.Write("\tTotal Price: \t");
            Console.WriteLine(EnterInformationScreen.VehicleObject.FinalPrice);

            Console.Write("\tTicket For: \t");
            Console.WriteLine(EnterInformationScreen.SelectedBridge);
        }


        public static void PriceResultScreenMethod()
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
                            Environment.Exit(0);
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
                    StartScreen.StartScreenMethod();
                    break;
                }

            }
        }

        public static void WriteToScreen(int index1, int index2)
        {
            string[] startMenu = { "> Main Menu", "  Exit", "  Main Menu", "> Exit" };
            PriceInfoScreen();
            Console.WriteLine("\n");
            Console.WriteLine("Would you like to return to the main menu, or exit the application?");
            Console.WriteLine(startMenu[index1]);
            Console.WriteLine(startMenu[index2]);
        }
    }
}
