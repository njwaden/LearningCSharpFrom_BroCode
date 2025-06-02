namespace _41_ToStringMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ToString() = converts an object to its string representation so that it is suitable for display

            Car car = new Car("Chevy", "Corvette", 2022, "blue");

            Console.WriteLine(car);

            Console.ReadKey();
        }
    }

    class Car
    {
        String make;
        String model;
        int year;
        String colour;

        public Car(String make, String model, int year, String colour)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.colour = colour;
        }

        public override string ToString()
        {
            return "This is a " + make + " " + model;
        }
    }
}
