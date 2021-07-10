using System;
using System.Collections.Generic;
using System.Text;

namespace TicketSystem
{
    public static class VehicleSelectScreen
    {
        private static int count { get; set; }

        

        public static void SelectVehicleScreen()
        {
            count = 0;
            WriteToScreen(0, 4, 5);
            while (true)
            {
                ConsoleKeyInfo k = Console.ReadKey(true);
                switch (count)
                {
                    case 0:
                        DetermineKeyInput(k, 3, 4, 2, 3, 1, 5);
                        break;
                    case 1:
                        DetermineKeyInput(k, 0, 4, 5, 3, 4, 2);
                        break;
                    case 2:
                        DetermineKeyInput(k, 3, 1, 5, 0, 4, 5);
                        break;
                }
            }

            //Below is the methods that write the selected menu option
            WriteToScreen(0, 4, 5); // Generic selected
            WriteToScreen(3, 1, 5); //StoreBaelt selected
            WriteToScreen(3, 4, 2); //Oresund Selected
            WriteToScreen(4, 5, 6); //Back Selected
        }

        public static void WriteToScreen(int index1, int index2, int index3)
        {
            Console.Clear();
            Console.WriteLine("Select the vehicle that is buying the ticket, Only supported vehicle types are shown.");
            string[] startMenu = {"> Car", "> MotorCycle", "> Back", "  Car", "  MotorCycle", "  Back"};
            Console.WriteLine(startMenu[index1]);
            Console.WriteLine(startMenu[index2]);
            Console.WriteLine(startMenu[index3]);
        }

        public static void DetermineKeyInput(ConsoleKeyInfo k, int w1n1, int w1n2, int w1n3, int w2n1, int w2n2,
            int w2n3)
        {
            switch (k.Key)
            {
                case ConsoleKey.UpArrow:
                    WriteToScreen(w1n1, w1n2, w1n3);
                    if (count > 0)
                        count -= 1;
                    else
                        count = 2;
                    break;
                case ConsoleKey.DownArrow:
                    WriteToScreen(w2n1, w2n2, w2n3);
                    if (count < 2)
                        count += 1;
                    else
                        count = 0;
                    break;
                case ConsoleKey.Enter:
                    switch (count)
                    {
                        case 0:
                            EnterInformationScreen.SelectedVehicleType = Constants.VehicleType.CAR;
                            EnterInformationScreen.EnterInfoScreen();
                            break;
                        case 1:
                            EnterInformationScreen.SelectedVehicleType = Constants.VehicleType.MOTORCYCLE;
                            EnterInformationScreen.EnterInfoScreen();
                            break;
                        case 2:
                            EnterInformationScreen.SelectedVehicleType = Constants.VehicleType.NONE;
                            OrderTicketScreen.SelectTicketScreen();
                            break;
                    }
                    break;
            }
        }
    }
}
