using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject._01_basic
{
    internal class math
    {

        internal void mathDemo()
        {
            Console.WriteLine("Math Class Demo:");
            Console.WriteLine("Absolute value of -5: " + Math.Abs(-5));
            Console.WriteLine("Ceiling of 4.3: " + Math.Ceiling(4.3));
            Console.WriteLine("Floor of 4.7: " + Math.Floor(4.7));
            Console.WriteLine("Maximum of 10 and 20: " + Math.Max(10, 20));
            Console.WriteLine("Minimum of 10 and 20: " + Math.Min(10, 20));
            Console.WriteLine("Square root of 16: " + Math.Sqrt(16));
            Console.WriteLine("Power of 2 raised to 3: " + Math.Pow(2, 3));
            Console.WriteLine("Round of 4.5: " + Math.Round(4.5));
        }
    }
}
