using System;
using CalculatorComponent;

namespace CalculatorUsingComponent
{
    class Program
    {
        // To make this work you must make a reference til CalculatorComponent.dll.
        // Make a reference to the right place in your file system
        static void Main()
        {
            Console.WriteLine("4 + 5 = " + Calculator.Add(4, 5)); 
            Console.WriteLine("4.1 + 5.2 = " + Calculator.Add(4.1, 5.2));
            Console.WriteLine("7 / 2 = " + Calculator.Divide(7, 2));
            Console.WriteLine("7.0 / 2.0 = " + Calculator.Divide(7.0, 2.0));
            Console.WriteLine("10.0 / 0.0 = " + Calculator.Divide(10.0, 0.0));
        }
    }
}
