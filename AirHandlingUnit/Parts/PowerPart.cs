using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AirHandlingUnits.Parts
{
    [DataContract]
    public abstract class PowerPart : Part
    {
        [DataMember]
        public int Power { get; set; }

        public PowerPart(string pc, string desc, int power) : base(pc, desc)
        {
            Power = power;
        }

        public override void PrintToConsole()
        {
            Console.WriteLine("Power: " + Power);
        }
    }
}