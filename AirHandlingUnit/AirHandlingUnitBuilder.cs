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
        private static AirHandlingUnitBuilder _instance;
        private readonly List<AirHandlingUnit> _allUnits = new List<AirHandlingUnit>(); 
        private AirHandlingUnitBuilder(){ }
        public static AirHandlingUnitBuilder GetInstance()
        {
            if (_instance == null)
            {
                _instance = new AirHandlingUnitBuilder();
            }
            return _instance;
        }

        internal AirHandlingUnit BuildCustomAirHandlingUnit(string desc, List<Part> parts)
        {
            var unit = new AirHandlingUnit(desc, parts);
            _allUnits.Add(unit);
            return unit;
        }

        internal AirHandlingUnitCollection GetAllAirHandlingUnits()
        {
            return new AirHandlingUnitCollection(_allUnits);
        }

    }
}