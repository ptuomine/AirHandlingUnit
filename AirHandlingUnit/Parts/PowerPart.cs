using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AirHandlingUnits.Parts
{
    [DataContract]
    [KnownType(typeof(PowerPart))]
    public class PowerPart : Part
    {
        [DataMember]
        public int Power { get; set; }

        // Default, public, parameterless constructor needed for Generics
        public PowerPart():base() { }
        public PowerPart(string pc, string desc, int power) : base(pc, desc)
        {
            Power = power;
        }
    }
}