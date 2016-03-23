using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AirHandlingUnits.Parts
{
    [DataContract]
    public class Filter : Part
    {
        [DataMember]
        public int Length { get; set; }

        // Default, public, parameterless constructor needed for Generics
        public Filter(){}

        public Filter(string pc, string desc, int length) : base(pc, desc)
        {
            this.Length = length;
        }
    }
}