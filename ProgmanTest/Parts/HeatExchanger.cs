using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirHandlingUnit
{
    public class HeatExchanger : PowerPart
    {
        private static int lastUsedProductCode = 0;
        private static Dictionary<string, HeatExchanger> CustomHeatExchangers = new Dictionary<string, HeatExchanger>();
        public enum HeatExchangerTypes { Shell, Tube }
        public HeatExchangerTypes HeatExchangerType { get; set; }
        private HeatExchanger(string pc, string desc, int power, HeatExchangerTypes type) : base(pc, desc, power)
        {
            this.HeatExchangerType = type;
        }

        private static string GetNewProductCode()
        {
            return "HEC" + lastUsedProductCode++;
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
        
        public static HeatExchanger GetShellHeatExchanger()
        {
            return shellHeatExchanger;
        }

        public static HeatExchanger GetTubeHeatExchanger()
        {
            return tubeHeatExchanger;
        }

        public static HeatExchanger GetCustomHeatExchanger(string desc, int power, HeatExchangerTypes type)
        {
            // First try to find an instance with the given specifications
            var found = CustomHeatExchangers.Values.Where(he => he.Power == power && he.HeatExchangerType == type).FirstOrDefault();
            if (found != null)
            {
                return found;
            }

            // If not found then create one
            var pc = GetNewProductCode();
            var customHeatExchanger = new HeatExchanger(pc, desc, power, type);
            CustomHeatExchangers.Add(pc, customHeatExchanger);

            return customHeatExchanger;
        }
        
        #endregion
    }
}