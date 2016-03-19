using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgmanTest
{
    class Battery : Part
    {
        public int Capacity { get; set; }

        public Battery(string pc, string desc, int capacity) : base(pc, desc)
        {
            this.Capacity = capacity;
        }

        public override void PrintToConsole()
        {
            Console.WriteLine("Battery properties:");
            Console.WriteLine("Capacity: " + Capacity);
        }
    }
}