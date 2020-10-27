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
                        foreach (Bus bus in buses)
                        {
                            Console.WriteLine(bus);
                        }
                        break;
                    case ACTION.PICK_BUS:
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
