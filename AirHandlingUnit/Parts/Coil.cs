using AirHandlingUnits.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AirHandlingUnits.Parts
{
    [DataContract]
    public class Coil : PowerPart
    {
        // Default, public, parameterless constructor needed for Generics
        public Coil() { }
        public Coil(string pc, string desc, int power) : base(pc, desc, power)
        {
        }
    }
}