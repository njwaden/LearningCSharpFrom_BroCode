internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();

        //int num = random.Next(1, 7);       generates a random number between 1 and 6 (inclusive of 1, exclusive of 7)
        int num1 = random.Next(1, 7);
        int num2 = random.Next(1, 7);
        int num3 = random.Next(1, 7);
        //double num = random.NextDouble();     generates a random number between 0.0 and 1.0 (exclusive of 1.0)

        Console.WriteLine(num1);
        Console.WriteLine(num2);
        Console.WriteLine(num3);

        Console.ReadKey();
    }
}