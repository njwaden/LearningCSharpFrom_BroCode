using System.Security.Cryptography;

namespace _33_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constructor = a special method in a class
            //              same name as the class name
            //              can be used to assign arguments to the field when creating an object

            Car car1 = new Car("Toyota", "Celica", 2001, "black");
            Car car2 = new Car("Perodua", "Myvi", 2013, "green");

            car1.Drive();
            car2.Drive();

            Console.ReadKey();
        }
    }
    class Car
    {
        String make;
        String model;
        int year;
        String colour;

        public Car (String make, String model, int year, String colour)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.colour = colour;
        }
        
        public void Drive()
        {
            Console.WriteLine("You drive the " + make + " " + model);
        }
    }
    
}
