using System.Collections.Generic;

namespace Targil02_Tal_DotNetLab
{
    public class BusLine
    {
        private List<BusStation> busstations = new List<BusStation>();

        public List<BusStation> BusStations
        {
            get { return busstations; }
        }

    }
}