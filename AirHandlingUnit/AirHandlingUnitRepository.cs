using AirHandlingUnit.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirHandlingUnit
{
    public class AirHandlingUnitRepository
    {
        private readonly HeatExchangerFactory heatExchangerFactoryInstance = HeatExchangerFactory.GetInstance();
        public List<AirHandlingUnit> GetAllAirHandlingUnits()
        {
            return new List<AirHandlingUnit>();
        }

        public List<Fan> GetAllCustomFans()
        {
            return new List<Fan>();
        }

        public HeatExchangerCollection GetAllCustomHeatExchangers()
        {
            return heatExchangerFactoryInstance.GetAllCustomHeatExchangers();
        }

        public HeatExchanger GetCustomHeatExchanger(string description, int power, HeatExchanger.HeatExchangerTypes heatExchangerType)
        {
            return heatExchangerFactoryInstance.GetCustomHeatExchanger(description, power, heatExchangerType);
        }
    }
}
