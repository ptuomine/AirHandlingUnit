using AirHandlingUnits.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirHandlingUnit.Parts;

namespace AirHandlingUnits
{
    public class AirHandlingUnitRepository
    {
        private readonly PartFactory<Fan> _fanFactory = new PartFactory<Fan>(prefix: "FAN"); 

        private readonly HeatExchangerFactory heatExchangerFactoryInstance = HeatExchangerFactory.GetInstance();
        private static AirHandlingUnitRepository instance;
        private AirHandlingUnitRepository()
        {

        }

        public static AirHandlingUnitRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new AirHandlingUnitRepository();
            }
            return instance;
        }

        public AirHandlingUnit CreateNewAirHandlingUnit(string description, List<Part> parts)
        {
            return AirHandlingUnitBuilder.GetInstance().BuildCustomAirHandlingUnit(description, parts);
        }
        public AirHandlingUnitCollection GetAllCustomAirHandlingUnits()
        {
            return AirHandlingUnitBuilder.GetInstance().GetAllAirHandlingUnits();
        }

        public PartCollection GetAllCustomFans()
        {
            return _fanFactory.GetAllCustomParts();
        }

        public Fan GetCustomFan(string description, Fan.FanTypes type)
        {
            var properties = new List<Object> { description, type };
            return (Fan) _fanFactory.GetCustomPart(properties);
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
