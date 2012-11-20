using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waschstrasse
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IWaschProgramm waschProgramStrategy = new PremiumProgramm();
            WaschAnlage waschAnlage = new WaschAnlage(waschProgramStrategy);

            Auto auto = new Auto { Name = "Fiat Punto" };
            waschAnlage.Waschen(auto);

            Console.ReadLine();
        }
    }
}
