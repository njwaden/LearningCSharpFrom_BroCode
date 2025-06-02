namespace _43_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //interfaces = defines a "contract" that all the classes inheriting from should follow
            //
            //             an interface delcares "what a class should have"
            //             an inheriting class defines "how it should do it"

            //             benefit = security + multiple inheritance + "plug-and-play"

            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();

            rabbit.Flee();
            hawk.Hunt();
            fish.Flee();
            fish.Hunt();

            Console.ReadKey();
        }
    }

    interface IPrey                         //common naming convention for interfaces is that you precede the interface name with "I"
    {
        void Flee();
    }

    interface IPredator
    {
        void Hunt();
    }
    class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit runs away!");
        }

    }

    class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk is searching for food");
        }
    }

    class Fish : IPrey, IPredator
    {
        public void Flee()
        {
            Console.WriteLine("The fish swims away");
        }

        public void Hunt()
        {
            Console.WriteLine("The fish is searching for smaller fish");
        }
    }
}
