using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using AirHandlingUnits.Parts;

namespace AirHandlingUnits
{
    [DataContract]
    [KnownType(typeof(HeatExchanger))]
    public class HeatExchanger : PowerPart
    {
        public enum HeatExchangerTypes { Shell, Tube }

        [DataMember]
        public HeatExchangerTypes HeatExchangerType { get; set; }

        // Default, public, parameterless constructor needed for Generics
        public HeatExchanger():base() { }
        public HeatExchanger(string pc, string desc, int power, HeatExchangerTypes type) : base(pc, desc, power)
        {
            this.HeatExchangerType = type;
        }
    }
}