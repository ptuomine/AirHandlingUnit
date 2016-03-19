using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgmanTest
{
    class AirHeaterUnit
    {
        private readonly List<Part> parts;

        public AirHeaterUnit(List<Part> parts)
        {
            this.parts = parts;
        }

        internal void PrintToConsole()
        {
            foreach (var part in parts)
            {
                part.PrintToConsole();
            }
        }
    }
}