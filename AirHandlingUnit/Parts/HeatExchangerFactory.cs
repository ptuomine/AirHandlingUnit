using AirHandlingUnit.Parts;
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
        private static HeatExchangerFactory instance;
        private readonly ProductCodeManager productCodeFactoryInstance = new ProductCodeManager(prefix: "HE");
        private readonly Dictionary<string, HeatExchanger> customHeatExchangers = new Dictionary<string, HeatExchanger>();

        private HeatExchangerFactory()
        {
        } 

        public static HeatExchangerFactory GetInstance()
        {
            if (instance == null)
            {
                instance = new HeatExchangerFactory();
            }

            return instance;
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

        public HeatExchanger GetCustomHeatExchanger(string desc, int power, HeatExchanger.HeatExchangerTypes type)
        {
            // First try to find an instance with the given specifications
            var found = customHeatExchangers.Values.Where(he => he.Description == desc && he.Power == power && he.HeatExchangerType == type).FirstOrDefault();
            if (found != null)
            {
                return found;
            }

            // If not found then create one
            var pc = productCodeFactoryInstance.GetNewProductCode();
            var customHeatExchanger = new HeatExchanger(pc, desc, power, type);
            customHeatExchangers.Add(pc, customHeatExchanger);

            return customHeatExchanger;
        }
        
        #endregion

        public HeatExchangerCollection GetAllCustomHeatExchangers()
        {
            return new HeatExchangerCollection(customHeatExchangers.Values.ToList());
        }
    }
}