namespace _22_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //continue from chap 21:

            // foreach looop = a simpler way to iterate over an array, but it's less flexible

            String[] cars = {"BMW", "Mustang", "Corvette"};

            foreach (String car in cars)                        // car is the nickname of the element we're working with
            {                                                   // foreach loop is not flexible. for loop can adjust the iterations and such.
                Console.WriteLine(car);
            }

            Console.ReadKey();
        }
    }
}
