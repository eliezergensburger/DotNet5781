using System;

namespace Targil1_Lev_II
{
    public class Bus
    {
        const int MAX_TANK = 1200;

        public string Rishuy { get; private set; }
        public readonly DateTime StartWorking;
        public int Km { get; set; }
        public int Tank { get; private set; }

        public Bus()
        {
            Console.WriteLine("Enter start working date");
            bool success = DateTime.TryParse(Console.ReadLine(), out StartWorking);
            Console.WriteLine("Enter license number:");
            string license = Console.ReadLine();
            if((StartWorking.Year >= 2008 && license.Length == 8) || (StartWorking.Year < 2008 && license.Length == 7))
            {
                Rishuy = license;
            }
            else 
            {
                throw new Exception("licence number not valid");
            }         
        }

        public void Refuelling(int fuel = MAX_TANK)
        {
            if (fuel > MAX_TANK)
            {
                fuel = MAX_TANK;
            }
            Tank = fuel;
        }

        //public static bool Tipul20000(Bus bus)
        //{
        //    return true;
        //}

    }
}