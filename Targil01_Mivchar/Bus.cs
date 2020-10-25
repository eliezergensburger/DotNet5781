using System;

namespace Targil01_Mivchar
{
    public class Bus
    {
        public DateTime DateOfAbsorption { get; set; }
       
        private String licence;

        public String License
        {
            get
            {
                string prefix, middle, suffix;
                string result;
                if (licence.Length == 7)
                {
                    prefix = licence.Substring(0, 2);
                    middle = licence.Substring(2, 3);
                    suffix = licence.Substring(4, 2);
                    result = string.Format("{0}-{1}-{2}", prefix, middle, suffix);
                }
                else
                {
                    prefix = licence.Substring(0, 3);
                    middle = licence.Substring(3, 2);
                    suffix = licence.Substring(5, 3);

                    result = string.Format("{0}-{1}-{2}", prefix, middle, suffix);
                }

                return result;
            }

            set
            {
                if (DateOfAbsorption.Year >= 2018 && value.Length == 8)
                {
                    licence = value;
                }
                else if (DateOfAbsorption.Year < 2018 &&  value.Length == 7)
                {
                    licence = value;
                }
                else
                {
                    throw new Exception("kuku not happy");
                }
            }
        }
        public Bus(DateTime date,   string license)
        {
            DateOfAbsorption = date;
            License = license;
        }
        public override string ToString()
        {
            return string.Format("rishuy = {0}, date ={1}",License,DateOfAbsorption.ToShortDateString());
        }

    }
}