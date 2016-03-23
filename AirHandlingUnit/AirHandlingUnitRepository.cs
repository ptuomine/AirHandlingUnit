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
        private static AirHandlingUnitRepository _instance;
        private AirHandlingUnitRepository(){}

        public static AirHandlingUnitRepository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new AirHandlingUnitRepository();
            }
            return _instance;
        }

        public AirHandlingUnit CreateNewAirHandlingUnit(string description, List<Part> parts)
        {
            return AirHandlingUnitBuilder.GetInstance().BuildCustomAirHandlingUnit(description, parts);
        }
        public AirHandlingUnitCollection GetAllCustomAirHandlingUnits()
        {
            return AirHandlingUnitBuilder.GetInstance().GetAllAirHandlingUnits();
        }

        public PartCollection GetAllCustomParts<T>() where T:Part, new()
        {
            var factory = PartFactory<T>.Instance;
            return factory.GetAllCustomParts();
        }

        public Part GetCustomPart<T>(List<Object> properties) where T:Part, new()
        {
            var factory = PartFactory<T>.Instance;
            return factory.GetCustomPart(properties);
        }
    }
}
