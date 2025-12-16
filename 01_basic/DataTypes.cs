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
        internal void typeCasting()
        {

            //There are two types of type casting in C#:
            //1. Implicit Casting (automatically) - converting a smaller type to a larger type size
            //byte -> short -> int -> long -> float -> double
            int num = 10; // Implicit casting
            double dnum = num; // Implicit casting
            //Console.WriteLine("Implicit casting of int to double: " + dnum);
            //int z =dnum; // This will cause a compile-time error
            int z = 'y'; // Implicit casting from char to int
            //Console.WriteLine("Implicit casting of char 'y' to int: " + z);

            double price = 19.99f;
            //Console.WriteLine("Implicit casting of float to double: " + price);



            //2. Explicit Casting (manually) - converting a larger type to a smaller size type

            int a = (int)3.5; // Explicit casting
            double a1 = (double)3.5; // Explicit casting
            //Console.WriteLine("Explicit casting of 3.5 to double: " + a1);
            //Console.WriteLine("Explicit casting of 3.5 to int: " + a);
            float fnum = Convert.ToInt32(9.78); // Explicit casting
            string x = "34 is amazing";
            //float x1 = 

            Convert.ToSingle(x); // This will cause a runtime error
            //Convert.ToDouble
            //Convert.ToString
            //Convert.ToInt64



        }
        internal void conversionMethods() {
            Console.WriteLine("Enter your name: ");
            string str = Console.ReadLine(); 
            Console.WriteLine("How many candies do you want?: " );
            string  can =Console.ReadLine();
            Console.WriteLine("You will get 4 more candies " + (Convert.ToInt32(can) + 4));


        }
    }
}
