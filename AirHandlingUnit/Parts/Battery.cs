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

        private Battery(string pc, string desc, int capacity) : base(pc, desc)
        {
            this.Capacity = capacity;
        }

        public override void PrintToConsole()
        {
            Console.WriteLine("Battery properties:");
            Console.WriteLine("Capacity: " + Capacity);
        }

        #region Factory methods

        private static readonly Battery lowCapacityBattery = new Battery(pc: "BAT1", desc: "Backup power", capacity: 60);
        private static readonly Battery highCapacityBattery = new Battery(pc: "BAT1", desc: "Backup power", capacity: 70);

        public static Battery GetLowCapacityBattery()
        {
            return lowCapacityBattery;
        }

        public static Battery GetHighCapacityBattery()
        {
            return highCapacityBattery;
        }

        #endregion
    }
}