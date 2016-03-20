﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirHandlingUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = AirHandlingUnitBuilder.Instance();
            var twofanunit = builder.BuildTwoFanUnit();
            var threefanunit = builder.BuildThreeFanUnit();
            var threefanunitwithbattery = builder.BuildThreeFanUnitWithBattery();


            Console.WriteLine("Two Fan Unit:");
            twofanunit.PrintToConsole();
            Console.WriteLine();
            Console.WriteLine("Three Fan Unit:");
            threefanunit.PrintToConsole();
            Console.WriteLine();
            Console.WriteLine("Three Fan Unit with Battery:");
            threefanunitwithbattery.PrintToConsole();
            Console.WriteLine("Type any key to exit");
            Console.ReadKey();
        }
    }
}