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
        private HeatExchanger(string pc, string desc, int power, HeatExchangerTypes type) : base(pc, desc, power)
        {
            this.HeatExchangerType = type;
        }

        public override void PrintToConsole()
        {
            Console.WriteLine("HeatExchanger properties:");
            base.PrintToConsole();
            Console.WriteLine("Type:" + HeatExchangerType);
        }

        #region Factory methods

        private static readonly HeatExchanger shellHeatExchanger = new HeatExchanger(pc: "HE1", desc: "Shell heat exchanger", power: 200, type: HeatExchanger.HeatExchangerTypes.Shell);
        private static readonly HeatExchanger tubeHeatExchanger = new HeatExchanger(pc: "HE2", desc: "Tube heat exchanger", power: 200, type: HeatExchanger.HeatExchangerTypes.Tube);
        
        public static HeatExchanger GetShellHeatExchanger(int power)
        {
            shellHeatExchanger.Power = power;
            return shellHeatExchanger;
        }

        public static HeatExchanger GetTubeHeatExchanger(int power)
        {
            tubeHeatExchanger.Power = power;
            return tubeHeatExchanger;
        }
        
        #endregion
    }
}