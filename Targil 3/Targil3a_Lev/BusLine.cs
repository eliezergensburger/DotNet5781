using System;

namespace Targil3a_Lev
{
    public class BusLine : IComparable<BusLine>
    {
        public int BusLineNum { get; set; }
        public object Stations { get; internal set; }

        public int CompareTo(BusLine other)
        {
            throw new NotImplementedException();
        }
    }
}