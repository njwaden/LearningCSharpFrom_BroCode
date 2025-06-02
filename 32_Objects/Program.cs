namespace _32_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //object = an instance of a class
            //         a class can be used as a blueprint to create object (OOP)
            //         object can have fields & methods (characteristics & actions)

            Human human1 = new Human();             //human object in human1
            Human human2 = new Human();

            human1.name = "nasibukhari";
            human1.age = 25;

            human2.name = "cimerm";
            human2.age = 26;

            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();

            Console.ReadKey();
        }
    }

    class Human()
    {
        public String name;
        public int age;

        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }

        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }
}
