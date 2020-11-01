using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil02_Mivchar
{
    public class BusException :Exception
    {
        public BusException(string bex) :base(bex)
        {
            //NADA
        }
        public override string Message => base.Message +" hello kityy";
    }
}
