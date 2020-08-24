using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me two variables and I'll tell you the quotient");

            Console.WriteLine("A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int quotient = Division(a, b);
            int remainder = Remainder(a, b);

            Console.WriteLine($"{a} / {b} = {quotient} r {remainder}");

            Console.WriteLine("Give me a radius and I'll give you the area of a circle");
            Console.WriteLine("Radius: ");
            int r = Convert.ToInt32(Console.ReadLine());
            double area = AreaOfCircle(r);
            Console.WriteLine($"Area: {area}");
        }

        static int Division(int a, int b)
        {
            int quotient = a / b;
            return quotient;
        }

        static int Remainder(int a, int b)
        {
            int remainder = a % b;
            return remainder;
        }

        static double AreaOfCircle(int r)
        {
            const double pi = 3.14;
            double area = pi * Math.Pow(r, 2);
            return area;
        }
    }
}

       
