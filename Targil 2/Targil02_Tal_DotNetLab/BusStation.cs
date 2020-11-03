using System;

namespace Targil02_Tal_DotNetLab
{
    public class BusStation :Station
    {
        /// <summary>
        /// distance from previous BusStation
        /// </summary>
        public double Distance { get; set; }
        /// <summary>
        /// Travel time from previous BusStation
        /// </summary>
        public TimeSpan TravelTime { get; set; }

        public override string ToString()
        {
            //TODO
            return base.ToString();
        }
    }
}