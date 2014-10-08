using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enumerations
{
    class Program
    {
        enum Temperatures
        {
            WickedCold = 0,
            FreezingPoint = 32,
            LightJacketWeater = 60,
            SwimmingWeather = 72,
            BoilingPoint = 212,
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Freezing point of water: {0}", (int)Temperatures.FreezingPoint);
            Console.WriteLine("Boiling point of water: {0}", (int)Temperatures.BoilingPoint);
            
            //added comment
            //An explicit cast is necessary to convert from enum type to an integral type
            // without casting to (int)output will be the element name:
            // Remember that  Console.WriteLine method by default convrets to string
            string a = Temperatures.FreezingPoint.ToString();

            Console.WriteLine("Freezing point of water: {0}", Temperatures.FreezingPoint);
            Console.WriteLine("Boiling point of water: {0}", Temperatures.BoilingPoint);
        }
    }
}
