using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waschstrasse
{
    class PremiumProgramm : IWaschProgramm
    {

        public void waschen(Auto auto)
        {
            Console.WriteLine(
                 "** Starting Premium Program on {0} **",
                auto.Name);
            Console.WriteLine("Wasser");
            Console.WriteLine("Seifen");
            Console.WriteLine("laaange Waschen");
            Console.WriteLine("Trocknen");
            Console.WriteLine("Polierung");
            Console.WriteLine("** DONE **");
        }
    }
}
