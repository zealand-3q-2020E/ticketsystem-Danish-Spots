using System;
using System.Collections.Generic;
using System.Text;
using OresundBron;
using TicketLibrary;

namespace TicketSystem
{
    public static class EnterInformationScreen
    {
        public static Constants.TicketType SelectedTicketType { get; set; }
        public static Constants.VehicleType SelectedVehicleType { get; set; }
        public static Vehicle VehicleObject { get; set; }
        public static string EnteredLicensePlate { get; set; }

        public static void EnterInfoScreen()
        {
            bool invalidPlate = true;
            Console.Clear();
            CreateVehicleObject();
            EnterPlateInformation();
            while (invalidPlate)
            {
                invalidPlate = TrySetLicensePlate();
                
            }
            VehicleObject.Date = DateTime.Now;
            UseBrobizzScreen.SelectBroBizzScreen();

        }

        public static void CreateVehicleObject()
        {
            switch (SelectedTicketType)
            {
                case Constants.TicketType.GENERIC_TICKET:
                    if (SelectedVehicleType == Constants.VehicleType.CAR)
                        VehicleObject = new Car();
                    else if (SelectedVehicleType == Constants.VehicleType.MOTORCYCLE)
                        VehicleObject = new MC();
                    break;
                case Constants.TicketType.STOREBAELT_TICKET:
                    if (SelectedVehicleType == Constants.VehicleType.CAR)
                        VehicleObject = new Car();
                    if (SelectedVehicleType == Constants.VehicleType.MOTORCYCLE)
                        VehicleObject = new MC();
                    break;
                case Constants.TicketType.ORESUND_TICKET:
                    if (SelectedVehicleType == Constants.VehicleType.CAR)
                        VehicleObject = new OresundCar();
                    else if (SelectedVehicleType == Constants.VehicleType.MOTORCYCLE)
                        VehicleObject = new OresundMC();
                    break;
            }
        }

        public static void EnterPlateInformation()
        {
            Console.WriteLine("Please enter the license plate of your selected vehicle. Note, max 7 characters. No spaces!");
            Console.Write("> ");
            EnteredLicensePlate = Console.ReadLine();
        }

        public static bool TrySetLicensePlate()
        {
            try
            {
                VehicleObject.LicensePlate = EnteredLicensePlate;
                return false;
            }
            catch (LicensePlateMaxCharacterLengthException e)
            {
                Console.Clear();
                Console.WriteLine("ERROR: " + e.Message + "");
                EnterPlateInformation();
                return true;
            }
        }
    }
}
