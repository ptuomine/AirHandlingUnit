using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgmanTest
{
    class HeatExchanger : PowerPart
    {
        public enum HeatExchangerTypes { Shell, Tube }
        public HeatExchangerTypes HeatExchangerType { get; set; }
        public HeatExchanger(string pc, string desc, int power, HeatExchangerTypes type) : base(pc, desc, power)
        {
            this.HeatExchangerType = type;
        }

        public override void PrintToConsole()
        {
            Console.WriteLine("HeatExchanger properties:");
            base.PrintToConsole();
            Console.WriteLine("Type:" + HeatExchangerType);
        }
    }
}