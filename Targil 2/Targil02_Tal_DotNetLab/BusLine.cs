using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Targil02_Tal_DotNetLab
{
    public class BusLine
    {
        private List<BusStation> busstations = new List<BusStation>();
        public List<BusStation> BusStations
        {
            get
            {
                List<BusStation> temp = new List<BusStation>(busstations);
                return temp;
            }
        }

        //public readonly List<BusStation> busStations;

        public BusLine()
        {
            //busStations = new List<BusStation>();
        }
         /// <summary>
        /// Line number
        /// </summary>
        public int Number { get; set; }
        public BusStation FirstStation { get; private set; }
        public BusStation LastStation { get; private set; }
        public Zone Zone { get; set; }

        public void AddLast(BusStation busStation)
        {
            busstations.Add(busStation);
            LastStation = busstations[busstations.Count - 1];
        }
        public void AddFirst(BusStation busStation)
        {
            busstations.Insert(0, busStation);
            FirstStation = busstations[0];
        }
        public void Add(int index, BusStation busStation)
        {
            if (index == 0)
            {
                AddFirst(busStation);
            }
            else
            {
                if(index > busstations.Count)
                {
                    throw new ArgumentOutOfRangeException("index", "index should be less than or equal to" + busstations.Count);
                }
                if (index == busstations.Count)
                {
                    busstations.Insert(index, busStation);
                    LastStation = busstations[busstations.Count - 1];
                }
             }
         }
    }
}