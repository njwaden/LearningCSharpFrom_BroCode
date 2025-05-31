internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter side A: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter side B: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double c = Math.Sqrt((a * a) + (b * b));

        Console.WriteLine("The hypotaneuse is: " + c);

        Console.ReadKey();
    }
}