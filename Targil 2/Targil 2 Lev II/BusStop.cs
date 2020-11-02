﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil_2_Lev_II
{
    public class BusStop
    {
        private const int SIXDIGITS = 1000000;
        private const int MIN_LAT = -90;
        private const int MAX_LAT = 90;
        private const int MIN_LON = -180;
        private const int MAX_LON = 180;

        private int busStationKey;

        public int BusStationKey {
            get => busStationKey; 
            set
            {
                if (value > 0 && value < SIXDIGITS)
                {
                    busStationKey = value;
                }
                else throw new ArgumentException("number is not valid");
            }
        }

        private double  latitude;

        public double  Latitude
        {
            get { return latitude; }
            set {
                if (value >= MIN_LAT && value <= MAX_LAT)
                {
                    latitude = value;
                }
                else throw new ArgumentException(
                    String.Format("value bust be between {0} and {1}", MAX_LAT, MIN_LAT));

            }
        }
        private double longitude;

        public double Longitude
        {
            get { return longitude; }
            set
            {
                if (value >= MIN_LON && value <= MAX_LON)
                {
                    longitude = value;
                }
                else throw new ArgumentException(
                    String.Format("value bust be between {0} and {1}", MAX_LON, MIN_LON));

            }
        }
        public String Address { get; set; }

        public override string ToString()
        {
            return String.Format("Bus Station Code: {0}, {1}°N {2}°E",BusStationKey,Latitude,Longitude);
        }
    }
}
