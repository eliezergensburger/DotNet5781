using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil02_Mivchar
{
    public class BusLineStation : BusStop
    {
        public double Distance { get; set; }
        public double TimeTravel { get; set; }

        public override string ToString()
        {
            String result = base.ToString();
            result += "last distance :" + Distance;
            result += "Time Travel : " + TimeTravel;
            result += "\n";
  
            return result;        }
    }
}
