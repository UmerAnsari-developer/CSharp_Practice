using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject
{
    internal class OOP_Intro
    {
        // This class is intentionally left blank for now.
        //OOPs - Classes and  Objects 
        internal void hello()
        {
                       Console.WriteLine("Hello from OOP_Intro class!");

        }
        public void greeting(string name)
        {
            Console.WriteLine($"Hello, {name}! Welcome to C# programming.");
        }
        private void display(string name)
        {
            Console.WriteLine($"Hello, {name}! This is a private method.");
        }
        private protected void Farewell(string name)
        {
            Console.WriteLine($"Goodbye, {name}! See you next time.");
        }
        internal protected void DemoAccess()
        {
            Console.WriteLine("This is an internal protected method.");
        }
        protected void ProtectedDemo()
        {
            Console.WriteLine("This is a protected method.");
        }
    }
}
