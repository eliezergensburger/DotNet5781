using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Targil1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bus> buses = new List<Bus>();
            CHOICE choice;
            bool success = true;
            do
            {
                Console.WriteLine("Please, make your choce:");
                Console.WriteLine("ADD_BUS, PICK_BUS, REFUEL_BUS, MAINTENANCE_BUS,  EXIT");

                success = Enum.TryParse(Console.ReadLine(), out choice);
                if (!success)
                {
                    continue;
                }
                switch (choice)
                {
                    case CHOICE.ADD_BUS:
                        Console.WriteLine("taarich");
                        DateTime taarich;
                        success = DateTime.TryParse(Console.ReadLine(), out taarich);
                        if (!success)
                        {
                            Console.WriteLine("Error");
                            continue;
                        }
                        Console.WriteLine("rishuy: ");
                        string rishuy = Console.ReadLine();
                        try
                        {
                            buses.Add(new Bus(rishuy, taarich));
                            printall(buses);
                        }
                        catch (Exception baaya)
                        {
                            Console.WriteLine(baaya.Message);
                        }
                        //TODO
                        break;
                    case CHOICE.PICK_BUS:
                        break;
                    case CHOICE.REFUEL_BUS:
                        break;
                    case CHOICE.MAINTENANCE_BUS:
                        break;
                    //case CHOICE.EXIT: //-1
                    //    break;
                    default:
                        break;
                }

            } while (choice != CHOICE.EXIT);
        }

        private static void printall(List<Bus> buses)
        {
            foreach (Bus bus in buses)
            {
                Console.WriteLine(bus);
            }
        }
    }
}
