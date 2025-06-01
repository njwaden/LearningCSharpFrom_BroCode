namespace _21_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array = variable that can store multiple values. fixed size

            String[] cars = new string[3];

            //String[] cars = { "BMW", "Mustang", "Corvette" };

            cars[0] = "Tesla";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            Console.ReadKey();
        }
    }
}
