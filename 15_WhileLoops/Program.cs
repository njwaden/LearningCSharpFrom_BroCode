namespace _15_WhileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while loop = repeats some code while some condition remains true

            Console.Write("Enter your name: ");
            String name = Console.ReadLine();

            while (name == "")                  //needs something to exit the while loop or else it will be infinite loop
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello " + name);

            Console.ReadKey();
        }
    }
}
