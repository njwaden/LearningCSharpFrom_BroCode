namespace _37_AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //abstract class = modifier that indicates missing components or incomplete implementation

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();
            //Vehicle vehicle = new Vehicle();

            Console.ReadKey();
        }
    }
    abstract class Vehicle
    {
        public int speed = 0;

        public void Go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }

    class Car : Vehicle                         //Car is the child class, Vehicle is the parent class
    {
        public int wheels = 4;
        int maxSpeed = 500;
    }

    class Bicycle : Vehicle                         //Bicycle is the child class, Vehicle is the parent class
    {
        public int wheels = 2;
        int maxSpeed = 50;
    }

    class Boat : Vehicle                         //Boat is the child class, Vehicle is the parent class
    {
        public int wheels = 0;
        int maxSpeed = 100;
    }
}
