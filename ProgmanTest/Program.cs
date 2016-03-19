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
            var twofanunit = new AirHeaterUnitBuilder().BuildTwoFanUnit();
            var threefanunit = new AirHeaterUnitBuilder().BuildTwoFanUnit();
            var threefanunitwithbattery = new AirHeaterUnitBuilder().BuildThreeFanUnitWithBattery();


            Console.WriteLine("Two Fan Unit:");
            twofanunit.PrintToConsole();
            Console.WriteLine();
            Console.WriteLine("Three Fan Unit:");
            threefanunit.PrintToConsole();
            Console.WriteLine();
            Console.WriteLine("Three Fan Unit:");
            threefanunitwithbattery.PrintToConsole();
            Console.WriteLine("Type any key to exit");
            Console.ReadKey();
        }
    }
}
