namespace _36_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inheritance = 1 or more child classes receiving fields, method, etc from a parent

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();
            
            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheels);
            car.Go();

            Console.WriteLine(bicycle.speed);
            Console.WriteLine(bicycle.wheels);
            bicycle.Go();

            Console.WriteLine(boat.speed);
            Console.WriteLine(boat.wheels);
            boat.Go();

            Console.ReadKey();
        }
    }

    class Vehicle
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
    }

    class Bicycle : Vehicle                         //Bicycle is the child class, Vehicle is the parent class
    {
        public int wheels = 2;
    }

    class Boat : Vehicle                         //Boat is the child class, Vehicle is the parent class
    {
        public int wheels = 0;
    }
}
