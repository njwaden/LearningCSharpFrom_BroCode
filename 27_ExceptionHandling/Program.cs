using System;

namespace _27_ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exception = errors that occur during execution/interrupt our flow of program

            //try = try some code that is considered "dangerous" (caught in exception)
            // catch = catch and handles exceptions when they occur
            // finally = always executes regardless if exception is caught or not
            double x;
            double y;
            double result;

            try
            {
                Console.Write("Enter number 1: ");
                x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                y = Convert.ToDouble(Console.ReadLine());

                result = x / y;

                Console.WriteLine("Result = " + result);
            }

            catch (FormatException e)
            {
                Console.WriteLine("Enter only numbers please!");
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("You can't divide by 0!");
            }
            catch (Exception e)                                     //not a good practice is it wont specify what went wrong to the user
            {                                                       //its better to put Exception e at the last part to catch anything we can't anticipate
                Console.WriteLine("Something went wrong");
            }

            finally                                                 //optional. usually used to close any open files, needs to reset anything, etc
            {
                Console.WriteLine("Thanks for visiting");
            }

            Console.ReadKey();
        }
    }
}
