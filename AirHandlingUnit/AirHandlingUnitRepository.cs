using AirHandlingUnits.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirHandlingUnits
{
    public class AirHandlingUnitRepository
    {
        private readonly HeatExchangerFactory heatExchangerFactoryInstance = HeatExchangerFactory.GetInstance();

        public AirHandlingUnit CreateNewAirHandlingUnit(string description, List<Part> parts)
        {
            return AirHandlingUnitBuilder.GetInstance().BuildCustomAirHandlingUnit(parts);
        }
        public AirHandlingUnitCollection GetAllCustomAirHandlingUnits()
        {
            return AirHandlingUnitBuilder.GetInstance().GetAllAirHandlingUnits();
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
