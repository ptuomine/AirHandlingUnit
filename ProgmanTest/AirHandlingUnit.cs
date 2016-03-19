using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirHandlingUnit
{
    class AirHandlingUnit
    {
        private readonly List<Part> parts;

        public AirHandlingUnit(List<Part> parts)
        {
            this.parts = parts;
        }

        internal void PrintToConsole()
        {
            var sortedparts = parts.OrderBy(p => p.ProductCode);

            foreach (var part in sortedparts)
            {
                part.PrintToConsole();
            }
        }
    }
}