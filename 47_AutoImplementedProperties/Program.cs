namespace _47_AutoImplementedProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //auto-implemented properties = shortcut when no additional logic is required in the property
            //                              you do not have to define a field for a property,
            //                              you only have to write get; and/or set; inside the property

            Car car = new Car("Porche");

            Console.WriteLine(car.Model);

            Console.ReadKey();
        }
    }

    class Car
    {
        public String Model { get; set; }       //can use this when there's no additional logic besides setting the value and getting the value

        public Car (String model)
        {
            this.Model = model;
        }
    }
}
