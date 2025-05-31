internal class Program
{
    private static void Main(string[] args)
    {
        //theres 2 steps for declaring a variable. first is declaration and next is initialisation
        int x; //declaration
        x = 123; //initialisation

        int y = 321; //declaration + initialisation
        int z = x + y;

        int age = 21; //whole integer
        double height = 300.5; //decimal number
        bool alive = true; //boolean value (true or false)
        char symbol = '@'; //single character
        String name = "nasibukhari"; //string of characters

        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
        Console.WriteLine("Your age is " + age);
        Console.WriteLine("Your height is " + height + "cm");
        Console.WriteLine("Are you alive? " + alive);
        Console.WriteLine("Your symbol is " + symbol);

        String userName = symbol + name;

        Console.WriteLine("Your username is: " + userName);

        Console.ReadKey();
    }
}