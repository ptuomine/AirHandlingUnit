using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirHandlingUnit
{
    public class AirHandlingUnitRepository
    {
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
            return HeatExchangerFactory.GetAllCustomHeatExchangers();
        }

        public HeatExchanger GetCustomHeatExchanger(string description, int power, HeatExchanger.HeatExchangerTypes heatExchangerType)
        {
            return HeatExchangerFactory.GetCustomHeatExchanger(description, power, heatExchangerType);
        }
    }
}
