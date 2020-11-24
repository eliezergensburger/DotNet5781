using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil3b_version3
{
    public class Bus
    {
        public int BusLicense { get; set; }
        public DateTime StartWorking { get; set; }
        public double TotalKm { get; set; }
        public Maintenance Maintenance { get; set; }
        public double Fuel { get; set; }
        public Status Status { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
