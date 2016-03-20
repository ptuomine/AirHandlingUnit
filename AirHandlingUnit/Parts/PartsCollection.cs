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
    public class PartsCollection
    {
        [DataMember]
        public List<Part> Parts { get; set; }

        public PartsCollection(List<Part> list)
        {
            this.Parts = list;
        }

    }
}