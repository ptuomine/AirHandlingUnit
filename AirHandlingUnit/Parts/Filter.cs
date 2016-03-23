using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirHandlingUnits.Parts
{
    public class Filter : Part
    {
        public int Length { get; set; }

        public Filter()
        {
        }

        private Filter(string pc, string desc, int length) : base(pc, desc)
        {
            this.Length = length;
        }

        public override void PrintToConsole()
        {
            Console.WriteLine("Filter properties:");
            Console.WriteLine("Length: " + Length);
        }

        #region Factory Methods
        private static readonly Filter shortFilter = new Filter(pc: "FIL1", desc: "short filter", length: 20);
        private static readonly Filter longFilter = new Filter(pc: "FIL2", desc: "long filter", length: 30);

        public static Filter GetTheShortFilter()
        {
            return shortFilter;
        }

        public static Filter GetTheLongFilter()
        {
            return longFilter;
        }
        #endregion

    }
}