using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgmanTest
{
    class Fan : Part
    {
        public enum FanTypes { box, floor }
        public FanTypes FanType { get; set; }

        public Fan(string pc, string desc, FanTypes fantype) : base(pc, desc)
        {
            this.FanType = fantype;
        }
        public override void PrintToConsole()
        {
            Console.WriteLine("Fan properties:");
            base.PrintToConsole();
            Console.WriteLine("Type: " + FanType);
        }
    }

    class Filter : Part
    {
        public int Length { get; set; }

        public Filter(string pc, string desc, int length) : base(pc, desc)
        {
            this.Length = length;
        }

        public override void PrintToConsole()
        {
            Console.WriteLine("Filter properties:");
            Console.WriteLine("Length: " + Length);
        }
    }

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
