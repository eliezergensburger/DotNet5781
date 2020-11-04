using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil02_Tal_DotNetLab
{
    class Program
    {
        static void Main(string[] args)
        {
            BusCompany egged = new BusCompany();
            Random r = new Random();
            double stam = r.NextDouble() * (33.3 - 31 -1) + 31;
        }
    }
}
