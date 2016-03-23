using AirHandlingUnits.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirHandlingUnits.Parts
{
    public class Battery : Part
    {
        public int Capacity { get; set; }

        // Default, public, parameterless constructor needed for Generics
        public Battery() { }

        public Battery(string pc, string desc, int capacity) : base(pc, desc)
        {
            this.Capacity = capacity;
        }
    }
}