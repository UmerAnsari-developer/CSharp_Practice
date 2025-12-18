using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject._01_basic
{
    internal class StringMethods
    {
        internal void stringMethodsDemo()
        {
            string sample = " Hello, World! ";
            Console.WriteLine("Original String: '" + sample + "'");
            Console.WriteLine("Length: " + sample.Length);
            Console.WriteLine("To Upper: " + sample.ToUpper());
            Console.WriteLine("To Lower: " + sample.ToLower());
            Console.WriteLine("Trimmed: '" + sample.Trim() + "'");
            Console.WriteLine("Substring (7, 5): " + sample.Substring(7, 5));
            Console.WriteLine("Replace 'World' with 'C#': " + sample.Replace("World", "C#"));
            Console.WriteLine("Index of 'o': " + sample.IndexOf('o'));
            Console.WriteLine("Contains 'Hello': " + sample.Contains("Hello"));
            Console.WriteLine("Split by ',': " + string.Join("|", sample.Split(',')));
            Console.WriteLine("Concatenate with ' How are you?': " + string.Concat(sample.Trim(), " How are you?"));

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            string greeting = $"Hello, {name}! Welcome to C# programming.";
            Console.WriteLine(greeting);
            Console.WriteLine(name[0]);
            Console.WriteLine(name[3]);
            Console.WriteLine("Length of \"your name" );
            Console.WriteLine("Length of \nyour name");
            Console.WriteLine("Length of \tyour name");



        }
    }
}
