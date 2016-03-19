using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgmanTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var unit = new AirHeaterUnitBuilder().BuildUnit();
            unit.PrintToConsole();

            Console.WriteLine("Type any key to exit");
            Console.ReadKey();
        }
    }

    class AirHeaterUnitBuilder
    {
        public AirHeaterUnit BuildUnit()
        {
            var parts = new List<Part>();
            parts.Add(new Fan("FAN1", "this is the first fan", Fan.FanTypes.box));
            parts.Add(new Fan("FAN2", "this is the second fan", Fan.FanTypes.floor));
            parts.Add(new Filter("FIL1", "this ís the first filter", 20));
            parts.Add(new Filter("FIL2", "this ís the second filter", 30));
            parts.Add(new Coil("COIL1", "this is the coil", 100));
            parts.Add(new HeatExchanger("HE1", "this is the heat exchanger", 200, HeatExchanger.HeatExchangerTypes.Shell));

            return new AirHeaterUnit(parts);
        }
    }

    class AirHeaterUnit
    {
        private List<Part> parts;

        public AirHeaterUnit(List<Part> parts)
        {
            this.parts = parts;
        }

        internal void PrintToConsole()
        {
            foreach (var part in parts)
            {
                part.PrintToConsole();
            }
        }
    }

    class Part
    {
        public Part(string pc, string desc)
        {
            this.ProductCode = pc;
            this.Description = desc;
        }

        public string ProductCode { get; set; }
        public string Description { get; set; }

        public virtual void PrintToConsole()
        {
            Console.WriteLine("Product Code: " + ProductCode);
            Console.WriteLine("Description: " + Description);
        }
    }

    class PowerPart:Part
    {
        public int Power { get; set; }

        public PowerPart(string pc, string desc, int power):base(pc, desc)
        {
            Power = power;
        }

        public override void PrintToConsole()
        {
            Console.WriteLine("Power: " + Power);
        }
    }

    class Fan:Part
    {
        public enum FanTypes { box, floor }
        public FanTypes FanType { get; set; }

        public Fan(string pc, string desc, FanTypes fantype):base(pc, desc)
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

    class Filter:Part
    {
        public int Length { get; set; }

        public Filter(string pc, string desc, int length) :base(pc, desc)
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

    class HeatExchanger:PowerPart
    {
        public enum HeatExchangerTypes { Shell, Tube }
        public HeatExchangerTypes HeatExchangerType { get; set; }
        public HeatExchanger(string pc, string desc, int power, HeatExchangerTypes type): base(pc, desc, power)
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
