namespace _40_MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //method overriding = provides a new verson of a method inherited from a parent class
            //                    inherited method must be: abstract, virtual or already overridden
            //                    used with ToString(), polymorphism

            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();

            Console.ReadKey();
        }
    }

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal goes *brrrrr*");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog goes *woof*");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The cat goes *meow*");

        }
    }
}
