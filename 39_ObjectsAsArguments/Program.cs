namespace _39_ObjectsAsArguments
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car("Mustang", "red");

            Car car2 = Copy(car1);

            Console.WriteLine(car2.colour + " " + car2.model);

            Console.ReadKey();
        }

        public static Car Copy(Car car)
        {
            return new Car(car.model, car.colour);
        }
    }

    class Car
    {

        public String model;
        public String colour;

        public Car (String model, String colour)
        {
            this.model = model;
            this.colour = colour;
        }
    }
}
