using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgmanTest
{
    class Coil : PowerPart
    {
        public Coil(string pc, string desc, int power) : base(pc, desc, power)
        {
        }
        public override void PrintToConsole()
        {
            Console.WriteLine("Coil parts are:");
            base.PrintToConsole();
        }

    }
}