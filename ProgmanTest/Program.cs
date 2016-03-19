using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgmanTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var unit = new AirHeaterUnitBuilder().BuildUnit();
            unit.PrintToConsole();

            Console.WriteLine("Type any key to exit");
            Console.ReadKey();
        }
    }
}
