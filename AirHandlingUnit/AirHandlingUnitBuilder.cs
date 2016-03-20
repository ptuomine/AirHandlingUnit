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
        private AirHandlingUnitBuilder(){ }
        public static AirHandlingUnitBuilder GetInstance()
        {
            if (instance == null)
            {
                instance = new AirHandlingUnitBuilder();
            }
            return instance;
        }

        internal AirHandlingUnit BuildCustomAirHandlingUnit(List<Part> parts)
        {
            return new AirHandlingUnit(parts);
        }

        internal AirHandlingUnitCollection GetAllAirHandlingUnits()
        {
            throw new NotImplementedException();
        }

        private List<Part> TwoFanUnitParts()
        {
            var parts = new List<Part>();
            parts.Add(Fan.GetTheBoxFan());
            parts.Add(Fan.GetTheFloorFan());
            parts.Add(Filter.GetTheShortFilter());
            parts.Add(Filter.GetTheLongFilter());
            parts.Add(Coil.GetTheHighPowerCoil());
            parts.Add(HeatExchangerFactory.GetShellHeatExchanger());

            return parts;
        }

        private List<Part> ThreeFanUnitParts()
        {
            var parts = TwoFanUnitParts();
            parts.Add(Fan.GetTheBoxFan());

            return parts;
        }

        public AirHandlingUnit BuildTwoFanUnit()
        {
            return new AirHandlingUnit(TwoFanUnitParts());
        }

        public AirHandlingUnit BuildThreeFanUnit()
        {
            return new AirHandlingUnit(ThreeFanUnitParts());
        }

        public AirHandlingUnit BuildThreeFanUnitWithBattery()
        {
            var parts = ThreeFanUnitParts();
                parts.Add(Battery.GetHighCapacityBattery());
            return new AirHandlingUnit(parts);
        }

        public AirHandlingUnit BuildCustomUnit()
        {
            return null;
        }

    }
}