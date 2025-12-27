// See https://aka.ms/new-console-template for more information
using PracticeProject._01_basic;

namespace PracticeProject
{
    internal class Program : OOP_Intro
    {
         static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("Hello i am Umer Ansari");
            //int age  = 25;
            //Console.WriteLine("My age is: " + age);

            //DataTypes dt = new DataTypes();
            //dt.inputValuesDemo();
            //dt.conversionMethods();
            Operators op = new Operators();
            //op.arith();
            //op.logical();
            //op.comparison();
            math m = new math();
            //m.mathDemo();
            StringMethods sm = new StringMethods();
            //sm.stringMethodsDemo();
            Conditional cs = new Conditional();
            //cs.if_switchDemo();
            //cs.loopsDemo();

            Method md = new Method();
            int num1, num2;
            Console.WriteLine("Enter first number: ");
            num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            num2= Convert.ToInt32(Console.ReadLine());
            md.MethodDemo(num1,num2);
            //md.Farewell("Umer"); // This line will cause a compile-time error due to access modifier
            md.DemoAccess();
            //md.ProtectedDemo();// This line will cause a compile-time error due to access modifier

            OOP_Intro oOP_Intro = new OOP_Intro();
            oOP_Intro.greeting("Umer");
            //oOP_Intro.display("Umer"); // This line will cause a compile-time error due to access modifier
            oOP_Intro.DemoAccess();
            //oOP_Intro.ProtectedDemo(); // This line will cause a compile-time error due to access modifier
            //oOP_Intro.Farewell("Umer"); // This line will cause a compile-time error due to access modifier
            oOP_Intro.hello();
            //oOP_Intro.ProtectedDemo(); 


        }
    }
}
