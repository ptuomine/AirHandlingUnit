using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace AirHandlingUnit
{
    [DataContract]
    public class HeatExchanger : PowerPart
    {
        public static readonly HeatExchanger ShellHeatExchanger = new HeatExchanger(pc: "HE1", desc: "Shell heat exchanger", power: 200, type: HeatExchanger.HeatExchangerTypes.Shell);
        public static readonly HeatExchanger TubeHeatExchanger = new HeatExchanger(pc: "HE2", desc: "Tube heat exchanger", power: 200, type: HeatExchanger.HeatExchangerTypes.Tube);

        public enum HeatExchangerTypes { Shell, Tube }
        [DataMember]
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