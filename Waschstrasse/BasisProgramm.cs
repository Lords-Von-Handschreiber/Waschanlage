using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waschstrasse
{
    class BasisProgramm: IWaschProgramm
    {

        public void waschen(Auto auto)
        {
            Console.WriteLine(
                 "** Starting Basic Program on {0} **",
                auto.Name);
            Console.WriteLine("Wasser");
            Console.WriteLine("Seifen");
            Console.WriteLine("Waschen");
            Console.WriteLine("Trocknen");
            Console.WriteLine("** DONE **");
        }
    }
}
