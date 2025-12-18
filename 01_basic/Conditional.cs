using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject._01_basic
{
    internal class Conditional
    {
        internal void  if_switchDemo()
        {
            Console.WriteLine("Conditional Statements Demo:");
            int number = 10;
            // If-Else Statement
            if (number > 0)
            {
                Console.WriteLine($"{number} is a positive number.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is a negative number.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
            // Switch Statement
            int day = 3;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }
        }
        internal void ternaryDemo()
        {
            Console.WriteLine("Ternary Operator Demo:");
            int age = 20;
            string eligibility = (age >= 18) ? "Eligible to vote." : "Not eligible to vote.";
            Console.WriteLine($"Age: {age} - {eligibility}");
        }
        internal void nullCoalescingDemo()
        {
            Console.WriteLine("Null Coalescing Operator Demo:");
            string input = null;
            string result = input ?? "Default Value";
            Console.WriteLine($"Result: {result}");
        }
        internal void loopsDemo()
        {
            int [] arr = {1,2,3,4,5};
            Console.WriteLine("Loops Demo:");
            // For Loop
            Console.WriteLine("For Loop:");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write(i+"\t");
            }
            //For Each Loop
            Console.WriteLine("\nFor Each Loop:");
            foreach (int i in arr)
            {
                Console.Write(i + "\t");
            }

            // While Loop
            Console.WriteLine("\nWhile Loop:");
            int j = 1;
            while (j <= 5)
            {
                Console.Write(j + "\t");
                j++;
            }
            // Do-While Loop
            Console.WriteLine("\nDo-While Loop:");
            int k = 1;
            do
            {
                Console.Write(k + "\t");
                k++;
            } while (k <= 5);

            //for Each loop with Strings
            Console.WriteLine("\nFor Each loop with strings");
            string str = "Umer Ansari";

                foreach (char s in str)
            {
                 Console.Write(s+"\t");
            }
        }
    }
}
