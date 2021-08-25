using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1();
            //Exercise2();
        }

        static void Exercise1()
        {
            var result = 0;

            Console.WriteLine("Type in the operator of the function you'd like to do");
            char function = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter your first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            int b = Convert.ToInt32(Console.ReadLine());

            switch (function)
            {
                case '*':
                    result = a * b;
                    Console.WriteLine($"{a} * {b} is {result}");
                    break;
                case '+':
                    result = a + b;
                    Console.WriteLine($"{a} + {b} is {result}");
                    break;
                case '/':
                    result = a / b;
                    Console.WriteLine($"{a}/{b} is {result} remainder {a % b}");
                    break;
                case '-':
                    result = a - b;
                    Console.WriteLine($"{a} - {b} is {result}");
                    break;
            }
        }
        static void Exercise2()
        {
            decimal PI = 3.14m;
            Console.WriteLine("What is the radius of your circle?");
            var r = decimal.Parse(Console.ReadLine());
            var result = PI * (r * r);
            Console.WriteLine($"The area of a circle with a radius of {r} is {result}");
        }
    }
}
