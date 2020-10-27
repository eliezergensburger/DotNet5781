using System;

namespace Targil1_Tal
{
    public class Bus
    {
        static public int GlobalKM { get; private set; }
        public readonly DateTime StartingDate;
        public DateTime Checkup { get; private set; }
        private string license;

        public DateTime Maintenance()
        {
            Checkup = DateTime.Today;
            return Checkup;
        }
        public DateTime Maintenance(DateTime checkup)
        {
            Checkup = checkup;
            return Checkup;
        }

        public string License
        {
            get
            {
                string firstpart, middlepart, endpart;
                string result;
                if (license.Length == 7)
                {
                    // xx-xxx-xx
                    firstpart = license.Substring(0, 2);
                    middlepart = license.Substring(2, 3);
                    endpart = license.Substring(5, 2);
                    result = String.Format("{0}-{1}-{2}", firstpart, middlepart, endpart);
                }
                else
                {
                    // xxx-xx-xxx
                    firstpart = license.Substring(0, 3);
                    middlepart = license.Substring(3, 2);
                    endpart = license.Substring(5, 3);
                    result = String.Format("{0}-{1}-{2}", firstpart, middlepart, endpart);
                }
                return result; 
            }

            private set 
            { 
                if((StartingDate.Year < 2018  && value.Length == 7) ||(StartingDate.Year >= 2018 && value.Length == 8))
                {
                     license = value; 
                }
                else
                {
                    throw new Exception("license not valid");
                }
            }
        }

        public Bus()
        {
            Console.WriteLine("give Starting date");
            bool succcess = DateTime.TryParse(Console.ReadLine(), out StartingDate);

            Console.WriteLine("give license number");
            License = Console.ReadLine();

        }
    }
}