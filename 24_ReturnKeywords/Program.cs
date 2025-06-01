namespace _24_ReturnKeywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // return = returns data back to the place where a method is invoked

            double x;
            double y;
            double result;
            Console.WriteLine("Enter in number 1: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter in number 2: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = Multiply(x, y);

            Console.WriteLine("Result = " + result);


            Console.ReadKey();
        }

        static double Multiply(double x, double y)          //keyword "void" changed to "double" because that's the data type of what being return to.
        {
            double z = x * y;
            return z;
        }
    }
}
