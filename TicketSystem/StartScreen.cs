using System;
using System.Collections.Generic;
using System.Text;

namespace TicketSystem
{
    public static class StartScreen
    {
        public static void StartScreenMethod()
        {
            WriteToScreen(0,1);
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
                    OrderTicketScreen.SelectTicketScreen();
                    break;
                }

            }
        }

        public static void WriteToScreen(int index1, int index2)
        {
            string[] startMenu = { "> Order Ticket", "  Exit", "  Order Ticket", "> Exit" };
            Console.Clear();
            Console.WriteLine("Welcome, to purchase a ticket choose 'Order Ticket', to exit choose 'Exit'.");
            Console.WriteLine(startMenu[index1]);
            Console.WriteLine(startMenu[index2]);
        }
    }
}
