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
    public class Coil : PowerPart
    {
        // Use the factory methods to get Coil objects
        public Coil() { }
        public Coil(string pc, string desc, int power) : base(pc, desc, power)
        {
        }
        public override void PrintToConsole()
        {
            Console.WriteLine("Coil parts are:");
            base.PrintToConsole();
        }

        #region Factory metdhods
        private static readonly Coil lowPowerCoil = new Coil(pc: "COIL2", desc: "Low power coil", power: 100);
        private static readonly Coil highPowerCoil = new Coil(pc: "COIL1", desc: "High power coil", power: 300);

        public static Coil GetTheLowPowerCoil()
        {
            return lowPowerCoil;
        }

        public static Coil GetTheHighPowerCoil()
        {
            return highPowerCoil;
        }
        #endregion

    }
}