internal class Program
{
    private static void Main(string[] args)
    {
        double x = 3.14;
        double y = 5;

        //double a = Math.Pow(x, 2);
        //double b = Math.Sqrt(x);
        //double c = Math.Abs(x);
        //double d = Math.Round(x);
        //double e = Math.Ceiling(x);
        //double f = Math.Floor(x);
        //double g = Math.Max(x,y);   //maximum of two numbers (between x and y)
        double h = Math.Min(x, y);   //minimum of two numbers (between x and y)

        Console.WriteLine(h);

        Console.ReadKey();
    }
}