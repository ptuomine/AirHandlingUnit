using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgmanTest
{
    class AirHeaterUnitBuilder
    {
        private static AirHeaterUnitBuilder instance;
        private AirHeaterUnitBuilder(){ }
        public static AirHeaterUnitBuilder Instance()
        {
            if (instance == null)
            {
                instance = new AirHeaterUnitBuilder();
            }
            return instance;
        }
        private List<Part> TwoFanUnitParts()
        {
            var parts = new List<Part>();
            parts.Add(Fan.GetTheBoxFan());
            parts.Add(Fan.GetTheFloorFan());
            parts.Add(Filter.GetTheShortFilter());
            parts.Add(Filter.GetTheLongFilter());
            parts.Add(Coil.GetTheHighPowerCoil());
            parts.Add(HeatExchanger.GetShellHeatExchanger(power: 200));

            return parts;
        }

        private List<Part> ThreeFanUnitParts()
        {
            var parts = TwoFanUnitParts();
            parts.Add(Fan.GetTheBoxFan());

            return parts;
        }

        public AirHeaterUnit BuildTwoFanUnit()
        {
            return new AirHeaterUnit(TwoFanUnitParts());
        }

        public AirHeaterUnit BuildThreeFanUnit()
        {
            return new AirHeaterUnit(ThreeFanUnitParts());
        }

        public AirHeaterUnit BuildThreeFanUnitWithBattery()
        {
            var parts = ThreeFanUnitParts();
                parts.Add(Battery.GetHighCapacityBattery());
            return new AirHeaterUnit(parts);
        }

    }
}