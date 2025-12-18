using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject._01_basic
{
    internal class Operators
    {

        //Arithmetic Operators
        internal void arith()
        {
            Console.WriteLine("Arithmetic Operators Demo:");
            Console.WriteLine(2+3);
            Console.WriteLine(2-3);
            Console.WriteLine(2*3);
            Console.WriteLine(2/4);
        }
        internal void logical()
        {
            Console.WriteLine("Logical Operators Demo:");
            Console.WriteLine(true && true);
            Console.WriteLine(true && false);
            Console.WriteLine(false && true);
            Console.WriteLine(false && false);
        }
        internal void comparison()
        {
            Console.WriteLine("Comparison Operators Demo:");
            Console.WriteLine(2 == 2);
            Console.WriteLine(2>3);
            Console.WriteLine(2<3);
            Console.WriteLine(2!=4);
            Console.WriteLine(2 >= 4);
            Console.WriteLine(2 <= 4);


        }
    }
}
