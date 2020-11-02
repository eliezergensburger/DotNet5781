using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil02_Mivchar
{
    public class BusLineRoute 
    {
        private List<BusLineStation> stations = new List<BusLineStation>();

        public List<BusLineStation> Stations
        {
            get { return stations; }
            set { stations  = value; }
        }
        public BusLineStation FirstStation
        {
            get => stations[0]; 
        }
        public BusLineStation LastStation
        {
            get => stations[stations.Count -1];
        }

        public Area Area { get; set; }

        public BusLineStation this[int index] => stations[index];

    }
}
