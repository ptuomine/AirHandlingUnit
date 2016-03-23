using AirHandlingUnits.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AirHandlingUnits
{
    [DataContract]
    public class AirHandlingUnit
    {
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public readonly Parts.PartCollection Partcollection;

        public AirHandlingUnit(List<Part> parts)
        {
            this.Partcollection = new Parts.PartCollection(parts);
        }

        public AirHandlingUnit(string desc, List<Part> parts)
        {
            Description = desc;
            this.Partcollection = new Parts.PartCollection(parts);
        }
    }
}