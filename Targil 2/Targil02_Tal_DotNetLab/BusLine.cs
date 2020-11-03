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

        /// <summary>
        /// Line number
        /// </summary>
        public int Number { get; set; }
        public BusStation FirstStation { get; set; }
        public BusStation LastStation { get; set; }
        public Zone Zone { get; set; }

    }
}