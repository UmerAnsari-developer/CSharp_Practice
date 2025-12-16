using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject
{
    internal class DataTypes
    {

        internal void dataTypesDemo()
        {

            // Integer data type
            int age = 25; // 4 bytes
            Console.WriteLine("Age: " + age);
            // Float data type 
            float height = 5.9f; // 4 bytes
            Console.WriteLine("Height: " + height);
            // Double data type 
            double weight = 70.5; // 8 bytes
            Console.WriteLine("Weight: " + weight);
            // Char data type 
            char grade = 'A';  // 2 bytes
            Console.WriteLine("Grade: " + grade);
            // String data type
            string name = "Umer Ansari"; // 2 bytes per character
            Console.WriteLine("Name: " + name);
            // Boolean data type
            bool isStudent = true; // 1 bit
            Console.WriteLine("Is Student: " + isStudent);
            //long data type
            long population = 7800000000; // 8 bytes    
            Console.WriteLine("Population: " + population);



        }
        internal void inputValuesDemo() { 
            Console.WriteLine("Enter your name: ");
            string a = Console.ReadLine();
            Console.WriteLine("You entered: " + a);
            
            Console.WriteLine("Enter your age: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered: " + b);

            Console.WriteLine("Enter your height: ");
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine("You entered: " + c);

            Console.WriteLine("Enter your weight: ");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("You entered: " + d);

            Console.WriteLine("Enter your grade: ");
            char e = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("You entered: " + e);
            Console.WriteLine("Are you a student (true/false): ");
            bool f = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("You entered: " + f);


        }
    }
}
