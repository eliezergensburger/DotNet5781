using System;

namespace Targil3b_Alef
{
    public class Bus
    {
        public static int FULLTANK = 1200;
        public int License { get; set; }
        public DateTime  StartingDate { get; set; }
        public double TotalKms { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public double CurrentKms { get; set; }
        public double CurrentFuel { get; set; }

        public Bus(int license, DateTime start)
        {
            StartingDate = start;
            License = license;
            TotalKms = 0;
            MaintenanceDate = start;
            CurrentFuel = FULLTANK;
            CurrentKms = 0;
        }

        public Bus()
        {
        }

        public override string ToString()
        {
            string firstpart, middlepart, endpart;
            string formattedLicense;
            string license = License.ToString();
            if (License <= 10000000)
            {
                // xx-xxx-xx
                firstpart = license.Substring(0, 2);
                middlepart = license.Substring(2, 3);
                endpart = license.Substring(5, 2);
                formattedLicense = String.Format("{0}-{1}-{2}", firstpart, middlepart, endpart);
            }
            else
            {
                // xxx-xx-xxx
                firstpart = license.Substring(0, 3);
                middlepart = license.Substring(3, 2);
                endpart = license.Substring(5, 3);
                formattedLicense = String.Format("{0}-{1}-{2}", firstpart, middlepart, endpart);
            }
            return String.Format("license is: {0,-10}, starting date: {1}", formattedLicense, StartingDate);
        }

    }

}