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
    public class HeatExchangerCollection
    {
        [DataMember]
        public List<HeatExchanger> CustomHeatExchangers { get; set; }

        public HeatExchangerCollection(List<HeatExchanger> list)
        {
            this.CustomHeatExchangers = list;
        }

    }
}