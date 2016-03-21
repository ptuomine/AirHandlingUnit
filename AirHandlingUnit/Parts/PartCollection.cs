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
    public class PartCollection
    {
        [DataMember]
        public List<Part> Parts { get; set; }

        public PartCollection(List<Part> list)
        {
            this.Parts = list;
        }

    }
}