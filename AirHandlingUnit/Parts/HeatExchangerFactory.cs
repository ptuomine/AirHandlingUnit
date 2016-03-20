using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AirHandlingUnit
{
    [DataContract]
    public class HeatExchangerCollection
    {
        [DataMember]
        public List<HeatExchanger> CustomHeatExchangers { get; set; }

        public HeatExchangerCollection(List<HeatExchanger> list)
        {
            this.CustomHeatExchangers = list;
        }

    }
    public class HeatExchangerFactory
    {
        private static int lastUsedProductCode = 0;
        private static Dictionary<string, HeatExchanger> CustomHeatExchangers = new Dictionary<string, HeatExchanger>();

        private static string GetNewProductCode()
        {
            return "HEC" + lastUsedProductCode++;
        }

        #region Factory methods
        
        public static HeatExchanger GetShellHeatExchanger()
        {
            return HeatExchanger.ShellHeatExchanger;
        }

        public static HeatExchanger GetTubeHeatExchanger()
        {
            return HeatExchanger.TubeHeatExchanger;
        }

        public static HeatExchanger GetCustomHeatExchanger(string desc, int power, HeatExchanger.HeatExchangerTypes type)
        {
            // First try to find an instance with the given specifications
            var found = CustomHeatExchangers.Values.Where(he => he.Description == desc && he.Power == power && he.HeatExchangerType == type).FirstOrDefault();
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

        public static HeatExchangerCollection GetAllCustomHeatExchangers()
        {
            return new HeatExchangerCollection(CustomHeatExchangers.Values.ToList());
        }
    }
}