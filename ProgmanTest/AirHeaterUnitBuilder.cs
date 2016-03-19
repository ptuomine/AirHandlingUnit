using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgmanTest
{
    class AirHeaterUnitBuilder
    {
        public AirHeaterUnit BuildUnit()
        {
            var parts = new List<Part>();
            parts.Add(new Fan(pc: "FAN1", desc: "this is the first fan", fantype: Fan.FanTypes.box));
            parts.Add(new Fan(pc: "FAN2", desc: "this is the second fan", fantype: Fan.FanTypes.floor));
            parts.Add(new Filter(pc: "FIL1", desc: "this ís the first filter", length: 20));
            parts.Add(new Filter(pc: "FIL2", desc: "this ís the second filter", length: 30));
            parts.Add(new Coil(pc: "COIL1", desc: "this is the coil", power: 100));
            parts.Add(new HeatExchanger(pc: "HE1", desc: "this is the heat exchanger", power: 200, type: HeatExchanger.HeatExchangerTypes.Shell));

            return new AirHeaterUnit(parts);
        }
    }
}