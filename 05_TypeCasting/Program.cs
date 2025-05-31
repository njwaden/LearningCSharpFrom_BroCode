﻿internal class Program
{
    private static void Main(string[] args)
    {
        // type casting = converting a values to a different data type
        //                Useful when we accept user input (String)
        //                Different data types can do different things

        double a = 3.14;
        int b = Convert.ToInt32(a);

        int c = 123;
        double d = Convert.ToDouble(c) + 0.1;

        int e = 321;
        String f = Convert.ToString(e);

        String g = "$";
        char h = Convert.ToChar(g);

        String i = "true";
        bool j = Convert.ToBoolean(i);

        Console.WriteLine(b.GetType());
        Console.WriteLine(d.GetType());
        Console.WriteLine(f.GetType());
        Console.WriteLine(h.GetType());
        Console.WriteLine(j.GetType());

        Console.ReadKey();
    }
}