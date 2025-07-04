﻿using System.Numerics;

namespace _25_MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //method overloading = methods share same name, but different parameters.
            //                     name + paremeters = signature
            //                     methods must have a unique signature

            double total;

            total = Multiply(2, 3, 4);

            Console.WriteLine(total);
            Console.ReadKey();
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }
    }
}
