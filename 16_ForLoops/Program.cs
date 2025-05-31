namespace _16_ForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for loop = repeats some code a FINITE amount of times
            /*
            for (int i = 1; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }
            */

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Happy New Year!!");

            Console.ReadKey();
        }
    }
}
