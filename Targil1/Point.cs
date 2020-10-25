using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil1
{
    public class Point
    {
        public int X { get;set; }
        public int Y { get;set; }
        public override string ToString()
        {
            return string.Format("({0},{1}", X, Y);
        }
    }
}
