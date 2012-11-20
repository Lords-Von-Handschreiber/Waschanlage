using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waschstrasse
{
    class WaschAnlage
    {
        private readonly IWaschProgramm _carWaschStrategy;
 
        public WaschAnlage(IWaschProgramm carWaschProgramm)
        {
            _carWaschStrategy = carWaschProgramm;
        }
 
        public void Waschen(Auto auto)
        {
            _carWaschStrategy.waschen(auto);
        }
    }
}
