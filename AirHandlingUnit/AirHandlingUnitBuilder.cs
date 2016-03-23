using AirHandlingUnits.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirHandlingUnits
{
    class AirHandlingUnitBuilder
    {
        private static AirHandlingUnitBuilder instance;
        private List<AirHandlingUnit> AllUnits = new List<AirHandlingUnit>(); 
        private AirHandlingUnitBuilder(){ }
        public static AirHandlingUnitBuilder GetInstance()
        {
            if (instance == null)
            {
                instance = new AirHandlingUnitBuilder();
            }
            return instance;
        }

        internal AirHandlingUnit BuildCustomAirHandlingUnit(string desc, List<Part> parts)
        {
            var unit = new AirHandlingUnit(desc, parts);
            AllUnits.Add(unit);
            return unit;
        }

        internal AirHandlingUnitCollection GetAllAirHandlingUnits()
        {
            return new AirHandlingUnitCollection(AllUnits);
        }

    }
}