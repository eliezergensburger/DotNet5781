using System.Collections.Generic;

namespace Targil02_Tal_DotNetLab
{
    public class BusCompany
    {
        private List<BusLine>   buses = new List<BusLine>();

        public List<BusLine> Busses
        {
            get { return buses; }
        }

    }
}