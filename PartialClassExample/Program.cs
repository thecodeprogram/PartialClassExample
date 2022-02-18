using System;
using PartialClassExample.AircraftClass; //using folder namespace

namespace PartialClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Partial Class Example - TheCodeProgram";
            Aircraft ac = new Aircraft();
            Console.WriteLine(ac.acToString());
            ac.printUpperAC();
            ac.setAC("Airbus", "A330", "300");
            Console.WriteLine(ac.acToString());
            ac.printUpperAC();

            Console.ReadLine();
        }
    }
}
