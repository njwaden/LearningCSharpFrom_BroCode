﻿namespace _48_Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //enums = special "class" that contains a set of named integer constants.
            //        use enums when you have value that you know will not change
            //        to get the integer value from an item, you must explicitly convert to an int

            //        name = integer

            Console.WriteLine(Planets.Pluto + " is a planet");
            Console.WriteLine(Planets.Pluto.ToString() + " is a planet");       //same thing as line above
            Console.WriteLine(Planets.Mercury + " is planet number " + (int)Planets.Mercury);

            String name = PlanetRadius.Earth.ToString();
            int radius = (int)PlanetRadius.Earth;
            double volume = Volume(PlanetRadius.Earth);

            Console.WriteLine("Planet: " + name);
            Console.WriteLine("Radius: " + radius + "km");
            Console.WriteLine("Volume: " + volume + "km^3");

            Console.ReadKey();
        }

        public static double Volume(PlanetRadius radius)
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius,3);
            return volume;
        }
    }

    enum Planets
    {
        Mercury = 1, 
        Venus = 2, 
        Earth = 3, 
        Mars = 4, 
        Jupiter = 5,                      //wont change throughout the life of the program
        Saturn = 6, 
        Uranus = 7, 
        Neptune = 8,
        Pluto = 9
    }

    enum PlanetRadius
    {
        Mercury = 2439,
        Venus = 6051,
        Earth = 6371,
        Mars = 3389,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25362,
        Neptune = 24622,
        Pluto = 1188
    }
}
