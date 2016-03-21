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
        public readonly PartCollection partcollection;

        public AirHandlingUnit(List<Part> parts)
        {
            partcollection = new PartCollection(parts);
        }

        public AirHandlingUnit(string desc, List<Part> parts)
        {
            Description = desc;
            partcollection = new PartCollection(parts);
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