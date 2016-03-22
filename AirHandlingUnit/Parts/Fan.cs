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
    public class Fan : Part
    {
        public enum FanTypes { Box, Floor }
        [DataMember]
        public FanTypes FanType { get; set; }

        public Fan(string pc, string desc, FanTypes fantype) : base(pc, desc)
        {
            this.FanType = fantype;
        }

        public override void PrintToConsole()
        {
            Console.WriteLine(value: "Fan properties:");
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

        public List<Fan> GetAllFans()
        {
            return new List<Fan>();
        }
    }
}
