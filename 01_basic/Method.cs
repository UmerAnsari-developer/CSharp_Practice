using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject._01_basic
{
    internal class Method
    {
        internal int Add(int a, int b)
        {
            return a + b;
        }
        internal int Subtract(int a, int b)
        {
            return a - b;
        }
        internal int Multiply(int a, int b)
        {
            return a * b;
        }
        internal double Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero.");
                return 0;
            }
            return (double)a / b;
        }
        public void greeting(string name)
        {
            Console.WriteLine($"Hello, {name}! Welcome to C# programming.");
        }
        //Inaccessible  to other classes
        //Only in Withwn and derived classes

        private protected void Farewell(string name)
        {
              Console.WriteLine($"Goodbye, {name}! See you next time.");
        }
         internal void MethodDemo(int num1, int num2)
        {
           
            Console.Write($"Addition: {Add(num1, num2)}");
            Console.Write($"\nSubtraction: {Subtract(num1, num2)}");
            Console.Write($"Multiplication: {Multiply(num1, num2)}");
            Console.Write($"Division: {Divide(num1, num2)}");
            
        }
        //Inaccessible  to other classes
        //Only in Withwn and derived classes
        internal protected void DemoAccess()
        {
            Console.WriteLine("This is an internal protected method.");
        }
        //Inaccessible  to other classes
        //Only in Withwn and derived classes

        protected void ProtectedDemo()
        {
            Console.WriteLine("This is a protected method.");
        }   
    }
}
