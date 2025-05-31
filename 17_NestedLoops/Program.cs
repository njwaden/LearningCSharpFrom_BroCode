namespace _17_NestedLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nested loops = loops inside of other loops
            //              uses vary. used a lot in sorting algorithms

            Console.Write("How many rows?: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many columns?: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many symbol?: ");
            String symbol = Console.ReadLine();

            for (int i = 0; i < rows; i++)                  //in order to complete one outer for loop, all iteration in inner loop must be completed first
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();                        //so that it moves to the next line after completing all inner loop
            }

            Console.ReadKey();
        }
    }
}
