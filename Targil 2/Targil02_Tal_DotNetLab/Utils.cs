using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

namespace Targil02_Tal_DotNetLab
{
    public static class Utils
    {
        #region distance calculations between two locations

        /// <summary>
        /// https://stackoverflow.com/questions/6366408/calculating-distance-between-two-latitude-and-longitude-geocoordinates
        /// </summary>
        /// <param name="lat1"></param>
        /// <param name="lon1"></param>
        /// <param name="lat2"></param>
        /// <param name="lon2"></param>
        /// <param name="unit"></param>
        /// <returns></returns>
        public static double DistanceTo(double lat1, double lon1, double lat2, double lon2, char unit = 'K')
        {
            //radians values for latitudes
            double rlat1 = Math.PI * lat1 / 180;
            double rlat2 = Math.PI * lat2 / 180;
            double theta = lon1 - lon2;
            //radian theta angle
            double rtheta = Math.PI * theta / 180;
            double dist = Math.Sin(rlat1) * Math.Sin(rlat2) + Math.Cos(rlat1) * Math.Cos(rlat2) * Math.Cos(rtheta);
            dist = (Math.Acos(dist) * 180) / Math.PI;

            dist = dist * 60 * 1.1515;

            switch (unit)
            {
                case 'K': //Kilometers -> default
                    return dist * 1.609344;
                case 'N': //Nautical Miles 
                    return dist * 0.8684;
                case 'M': //Miles
                    return dist;
            }

            return dist;
        }

        /// <summary>
        /// using the GeoCoordinate class (.NET Framework 4 and higher) for GetDistance
        /// </summary>
        /// <param name="lat1"></param>
        /// <param name="lon1"></param>
        /// <param name="lat2"></param>
        /// <param name="lon2"></param>
        /// <param name="unit"></param>
        /// <returns></returns>
        public static double GetDistanceTo(double lat1, double lon1, double lat2, double lon2, char unit = 'K')
        {
            GeoCoordinate geoCoordinate1 = new GeoCoordinate(lat1, lon1);
            GeoCoordinate geoCoordinate2 = new GeoCoordinate(lat2, lon2);

            return geoCoordinate1.GetDistanceTo(geoCoordinate2);
        }
        #endregion 

        #region extension methods for Station class
        // GetDistance extension method for Station Class
        public static double DistanceLocation(this Station first, Station second)
        {
            return GetDistanceTo(first.Latitude, first.Longitude, second.Latitude, second.Longitude);
        }

        // TimeBetween extension method for Station Class
        public static TimeSpan TimeBetween(this Station first, Station second, double kmHour = 60d)
        {
            Random rnd = new Random();
            double epsilon = rnd.NextDouble() * 0.5d +1d;

            double distance = first.DistanceLocation(second);
            double minutes = Math.Max(distance,Math.Round(distance * epsilon / kmHour * 60));

            return new TimeSpan(0, (int)minutes, 0);
        }
        #endregion
    }
}
