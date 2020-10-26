using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil01_Mivchar
{
    class Program
    {
      //  static List<Bus> buses = new List<Bus>();
        static void Main(string[] args)
        {
            List<Bus> buses = new List<Bus>();

            CHOICE choice;
            bool success;

            do
            {
                do
                {
                    Console.WriteLine(" pick your choice:ADD, FIND, REFUEL, CHECKUP,  EXIT=-1 ");
                    string kelet = Console.ReadLine();
                    success = Enum.TryParse(kelet, out choice);
                    if (!success)
                    {
                        Console.WriteLine("Try again");
                    }
                }
                while (success == false);
                switch (choice)
                {
                    case CHOICE.ADD:
                        Console.WriteLine("ten li pratim");
                        string rishuy;
                        DateTime taarich;
                        Console.WriteLine("enter date:");
                        success =  DateTime.TryParse(Console.ReadLine(), out taarich);
                        Console.WriteLine("ten rishuy:");
                        rishuy = Console.ReadLine();
                        if (success)
                        {
                            try
                            {
                                buses.Add(new Bus(taarich, rishuy));
                                Console.WriteLine("---------------------------");
                                foreach (Bus bus in buses)
                                {
                                    Console.WriteLine(bus);
                                }
                            }
                            catch (Exception exception)
                            {
                                Console.WriteLine(exception.Message);
                            } 
                        }
                        break;
                    case CHOICE.FIND:
                        break;
                    case CHOICE.REFUEL:
                        break;
                    case CHOICE.CHECKUP:
                        break;
                    case CHOICE.EXIT:
                        break;
                    default:
                        break;
                }

            } while (choice != CHOICE.EXIT);

        }
    }
}
