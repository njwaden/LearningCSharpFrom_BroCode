internal class Program
{
    private static void Main(string[] args)
    {
        // constant = immutable values which are known at compile time
        //            and do not change for the life of the program
        //            (adds a bit of security)

        const double pi = 3.14159;


        Console.WriteLine(pi);

        Console.ReadKey();
    }
}