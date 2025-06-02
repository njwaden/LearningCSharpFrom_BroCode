namespace _28_ConditionalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //conditional operator = used in conditional assignment if a condition is true/false

            //(condition) ? x : y;              if condition is true, x is assigned, if false y is assigned

            double temperature = 20;
            String message;

            /*if (temperature >= 15)
            {
                message = "It's warm outside";
            }
            else
            {
                message = "It's cold outside";
            }

            Console.WriteLine(message); */

            message = (temperature >= 15) ? "It's warm outside" : "It's cold outside";              //if condition is true, x is assigned, if false y is assigned
            Console.WriteLine(message);
            //Console.WriteLine(message = (temperature >= 15) ? "It's warm outside" : "It's cold outside");

            Console.ReadKey();
        }
    }
}
