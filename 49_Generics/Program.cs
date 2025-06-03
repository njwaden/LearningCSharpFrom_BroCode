﻿namespace _49_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //generic = "not specific to a particular data type"
            //          add <T> to: classes, methods, fields, etc.
            //          allows for code reusability for different data types

            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            String[] stringArray = { "1", "2", "3" };

            displayElements(intArray);
            displayElements(doubleArray);
            displayElements(stringArray);

            Console.ReadKey();
        }
        public static void displayElements<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.Write(item + " ");                  //one method that accepts all data type
            }
            Console.WriteLine();
        }
    }
}
