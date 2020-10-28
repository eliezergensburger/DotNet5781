using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil_2_Lev_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hachness mispar (yanoo):");
            string kelet = Console.ReadLine();
            bool success = Int32.TryParse(kelet, out _);
            if(success)
            {
                Console.WriteLine("eize yofi");
            }
            else
            {
                Console.WriteLine("Tooo BBBBBBAAAAADDD !!!!!!");
            }
            Console.WriteLine("press any key to continue...");
            Console.ReadKey();
        }
    }
}
