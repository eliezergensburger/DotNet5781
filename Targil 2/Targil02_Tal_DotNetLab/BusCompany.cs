using System;
using System.Collections;
using System.Collections.Generic;

namespace Targil02_Tal_DotNetLab
{
    public class BusCompany : IEnumerable<Bus>
    {
        #region private fields
        private List<int> numbers = new List<int>();
        private List<Bus> busses = new List<Bus>();
        #endregion

         public void Add(Bus bus)
        {
            if (numbers.Count != 0 && numbers.Contains(bus.Mispar))
            {
                throw new ArgumentException("mispar kvar kayam bachevra");
            }
            busses.Add(bus);
            numbers.Add(bus.Mispar);
        }

        public IEnumerator<Bus> GetEnumerator()
        {
            return busses.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

    }
}
