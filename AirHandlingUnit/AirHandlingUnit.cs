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
        public readonly Parts.PartCollection partcollection;

        public AirHandlingUnit(List<Part> parts)
        {
            this.partcollection = new Parts.PartCollection(parts);
        }

        public AirHandlingUnit(string desc, List<Part> parts)
        {
            Description = desc;
            this.partcollection = new Parts.PartCollection(parts);
        }

        internal void PrintToConsole()
        {
            var sortedparts = partcollection.Parts.OrderBy(p => p.ProductCode);

            foreach (var part in sortedparts)
            {
                part.PrintToConsole();
            }
        }
    }
}