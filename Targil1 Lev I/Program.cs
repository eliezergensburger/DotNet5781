using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil1_Lev_II
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bus> autobussim = new List<Bus>();
            bool success;
            OPERATION operation;
            do
            {
                do
                {
                    Console.WriteLine("please make your mind,");
                    Console.WriteLine("Choose from INSERTBUS, PICKBUS, MAINTENANCE, REFUELLING, CHECKUP, SHOWKMS, EXIT = -1");
                    success = Enum.TryParse(Console.ReadLine(), out operation);
                } while (success == false);
                switch (operation)
                {
                    case OPERATION.INSERTBUS:
                        try
                        {
                            Bus bus = new Bus { Km = 888 };
                            autobussim.Add(bus);
                            Console.WriteLine(bus);
                        }
                        catch (Exception houston)
                        {
                            Console.WriteLine(houston.Message);
                        }
                        break;
                    case OPERATION.PICKBUS:
                        break;
                    case OPERATION.MAINTENANCE:
                        break;
                    case OPERATION.REFUELLING:
                        break;
                    case OPERATION.CHECKUP:
                        break;
                    case OPERATION.SHOWKMS:
                        break;
                    case OPERATION.EXIT:
                        break;
                    default:
                        break;
                }

            } while (operation != OPERATION.EXIT);
        }
    }
}
