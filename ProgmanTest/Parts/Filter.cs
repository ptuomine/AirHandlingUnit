using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgmanTest
{
    class Filter : Part
    {
        public int Length { get; set; }

        public Filter(string pc, string desc, int length) : base(pc, desc)
        {
            this.Length = length;
        }

        public override void PrintToConsole()
        {
            Console.WriteLine("Filter properties:");
            Console.WriteLine("Length: " + Length);
        }
    }
}