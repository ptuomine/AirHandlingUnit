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
    public class AirHandlingUnitCollection
    {
        [DataMember]
        public List<AirHandlingUnit> AirHandlingUnits { get; set; }

        public AirHandlingUnitCollection(List<AirHandlingUnit> list)
        {
            this.AirHandlingUnits = list;
        }

    }
}