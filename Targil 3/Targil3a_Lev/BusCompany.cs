using System.Collections;
using System.Collections.Generic;

namespace Targil3a_Lev
{
    public class BusCompany : IEnumerable
    {
        private List<BusLine> busLines = new List<BusLine>(0);
 
        public List<BusLine> BusLines
        {
            get
            {
                return busLines.FindAll(p=>true);
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return busLines.GetEnumerator();
        }
        public BusLine this[int index]
        {
            get { return busLines[index]; }
         }
    }
}