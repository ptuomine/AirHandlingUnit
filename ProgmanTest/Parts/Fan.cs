using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgmanTest
{
    class Fan : Part
    {
        public enum FanTypes { Box, Floor }
        public FanTypes FanType { get; set; }

        private Fan(string pc, string desc, FanTypes fantype) : base(pc, desc)
        {
            this.FanType = fantype;
        }

        public override void PrintToConsole()
        {
            Console.WriteLine("Fan properties:");
            base.PrintToConsole();
            Console.WriteLine("Type: " + FanType);
        }

        #region Factory methods
        private static readonly Fan boxFan = new Fan(pc: "FAN1", desc: "Box Fan", fantype: FanTypes.Box);
        private static readonly Fan floorFan = new Fan(pc: "FAN2", desc: "Floor Fan", fantype: FanTypes.Box);
        public static Fan GetTheBoxFan()
        {
            return boxFan;
        }

        public static Fan GetTheFloorFan()
        {
            return floorFan;
        }
        #endregion
    }
}
