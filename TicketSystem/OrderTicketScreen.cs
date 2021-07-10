using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TicketSystem
{
    public static class OrderTicketScreen
    {
        
        private static int count { get; set; }
        public static void SelectTicketScreen()
        {
            count = 0;
            WriteToScreen(0, 5, 6, 7); // Generic selected
            while (true)
            {
                ConsoleKeyInfo k = Console.ReadKey(true);
                switch (count)
                {
                    case 0:
                        DetermineKeyInput(k, 4,5,6,3,4,1,6,7);
                        break;
                    case 1:
                        DetermineKeyInput(k, 0,5,6,7,4,5,2,7);
                        break;
                    case 2:
                        DetermineKeyInput(k, 4, 1, 6, 7, 4, 5, 6, 3);
                        break;
                    case 3:
                        DetermineKeyInput(k, 4, 5, 2, 7, 0, 5, 6, 7);
                        break;
                }
            }

            //Below is the methods that write the selected menu option
            WriteToScreen(0, 5, 6, 7); // Generic selected
            WriteToScreen(4, 1, 6, 7); //StoreBaelt selected
            WriteToScreen(4, 5, 2, 7); //Oresund Selected
            WriteToScreen(4, 5, 6, 3); //Back Selected
        }

        public static void WriteToScreen(int index1, int index2, int index3, int index4)
        {
            Console.Clear();
            Console.WriteLine("Select the bridge you want to buy a ticket for.");
            string[] startMenu = { "> Generic", "> StoreBaelt", "> Oresund", "> Back", "  Generic", "  StoreBaelt", "  Oresund", "  Back"};
            Console.WriteLine(startMenu[index1]);
            Console.WriteLine(startMenu[index2]);
            Console.WriteLine(startMenu[index3]);
            Console.WriteLine(startMenu[index4]);
        }

        public static void DetermineKeyInput(ConsoleKeyInfo k, int w1n1, int w1n2, int w1n3, int w1n4, int w2n1, int w2n2,
            int w2n3, int w2n4)
        {
            switch (k.Key)
            {
                case ConsoleKey.UpArrow:
                    WriteToScreen(w1n1, w1n2, w1n3, w1n4);
                    if (count > 0)
                        count -= 1;
                    else
                        count = 3;
                    break;
                case ConsoleKey.DownArrow:
                    WriteToScreen(w2n1, w2n2, w2n3, w2n4);
                    if (count < 3)
                        count += 1;
                    else
                        count = 0;
                    break;
                case ConsoleKey.Enter:
                    switch (count)
                    {
                        case 0:
                            EnterInformationScreen.SelectedTicketType = Constants.TicketType.GENERIC_TICKET;
                            EnterInformationScreen.SelectedBridge = "Generic bridge Ticket";
                            VehicleSelectScreen.SelectVehicleScreen();
                            break;
                        case 1:
                            EnterInformationScreen.SelectedTicketType = Constants.TicketType.STOREBAELT_TICKET;
                            EnterInformationScreen.SelectedBridge = "Storebaelt bridge Ticket Ticket";
                            VehicleSelectScreen.SelectVehicleScreen();
                            break;
                        case 2:
                            EnterInformationScreen.SelectedTicketType = Constants.TicketType.ORESUND_TICKET;
                            EnterInformationScreen.SelectedBridge = "Oresund Ticket";
                            VehicleSelectScreen.SelectVehicleScreen();
                            break;
                        case 3:
                            EnterInformationScreen.SelectedTicketType = Constants.TicketType.NOT_SELECTED;
                            EnterInformationScreen.SelectedBridge = "";
                            StartScreen.StartScreenMethod();
                            break;
                    }
                    break;
            }
        }
    }
}
