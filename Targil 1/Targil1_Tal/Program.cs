﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil1_Tal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bus> buses = new List<Bus>();
            ACTION action;
            bool success;
            SartEgged(buses, out action, out success);
        }

        private static void SartEgged(List<Bus> buses, out ACTION action, out bool success)
        {
            do
            {
                do
                {
                    Console.WriteLine("choose an action");
                    Console.WriteLine("ADD_BUS, PICK_BUS, MAINTENANCE, REFUELLING, EXIT = -1");
                    success = Enum.TryParse(Console.ReadLine(), out action);

                } while (success == false);
                switch (action)
                {
                    case ACTION.ADD_BUS:
                        try
                        {
                            buses.Add(new Bus());
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception.Message);
                        }
                        //print all buses
                        foreach (Bus bus in buses)
                        {
                            Console.WriteLine(bus);
                        }
                        break;
                    case ACTION.PICK_BUS:
                        Console.WriteLine("enter a license number");
                        string license = Console.ReadLine().Replace("-", String.Empty);
                        Bus foundBus = null;
                        foreach (Bus bus in buses)
                        {
                            if(bus.License == license)
                            {
                                foundBus = bus;
                                break;
                            }
                        }
                        if(foundBus != null)
                        {
                            Console.WriteLine(foundBus);
                        }
                        break;
                    case ACTION.MAINTENANCE:
                        break;
                    case ACTION.REFUELLING:
                        break;
                    case ACTION.EXIT:
                        break;
                    default:
                        break;
                }
            } while (action != ACTION.EXIT);
        }
    }
}
