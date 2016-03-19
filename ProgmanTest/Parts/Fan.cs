using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgmanTest
{
    class Fan : Part
    {
        public enum FanTypes { box, floor }
        public FanTypes FanType { get; set; }

        public Fan(string pc, string desc, FanTypes fantype) : base(pc, desc)
        {
            this.FanType = fantype;
        }
        public override void PrintToConsole()
        {
            Console.WriteLine("Fan properties:");
            base.PrintToConsole();
            Console.WriteLine("Type: " + FanType);
        }
    }
}
