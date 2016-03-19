using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirHandlingUnit
{
    public abstract class PowerPart : Part
    {
        public int Power { get; set; }

        public PowerPart(string pc, string desc, int power) : base(pc, desc)
        {
            Power = power;
        }

        public override void PrintToConsole()
        {
            Console.WriteLine("Power: " + Power);
        }
    }
}