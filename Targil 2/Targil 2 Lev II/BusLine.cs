using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil_2_Lev_II
{
    public class BusLine
    {
        public int BusNumber { get; set; }

        private List<BusStopLine> stations = new List<BusStopLine>();

        public List<BusStopLine> Stations
        {
            get
            {
                return stations;
            }
        }
        public Area Area { get; set; }

        public BusStopLine FirstStation { get => Stations[0]; set => Stations[0] = value; }
        public BusStopLine LastStation { get => Stations[stations.Count - 1]; set => Stations[stations.Count - 1] = value; }

    }
}
