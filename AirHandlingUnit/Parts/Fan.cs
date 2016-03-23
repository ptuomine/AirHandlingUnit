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
    public class Fan : Part
    {
        public enum FanTypes { Box, Floor }
        [DataMember]
        public FanTypes FanType { get; set; }

        // Default, public, parameterless constructor needed for Generics
        public Fan() { }

        public Fan(string pc, string desc, FanTypes fantype) : base(pc, desc)
        {
            this.FanType = fantype;
        }

    }
}
