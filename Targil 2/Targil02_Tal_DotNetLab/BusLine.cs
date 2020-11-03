using System.Collections.Generic;
using System.Threading;

namespace Targil02_Tal_DotNetLab
{
    public class BusLine 
    {
        private List<BusStation> busstations = new List<BusStation>();

        public BusLine()
        {

        }
        public List<BusStation> BusStations
        {
            get { return busstations; }
        }

        /// <summary>
        /// Line number
        /// </summary>
        public int Number { get; set; }
        public BusStation FirstStation {get; private set;}
        public BusStation LastStation { get; private set; }
        public Zone Zone { get; set; }

        public void AddLast(BusStation busStation)
        {
            busstations.Add(busStation);
            LastStation = busstations[busstations.Count -1];
        }
        public void AddFirst(BusStation busStation)
        {
            busstations.Insert(0, busStation);
            FirstStation = busstations[0];
         }
        public void Add(int index, BusStation busStation)
        {
            busstations.Insert(index, busStation);
            if(index == 0)
            {
                FirstStation = busstations[0];
            }
        }

    }
}