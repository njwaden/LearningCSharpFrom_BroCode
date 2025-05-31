internal class Program
{
    private static void Main(string[] args)
    {
        int friends = 10;

        //friends = friends + 2;
        //friends += 2;     shortcut for friends = friends + 2;
        //friends++;

        //friends = friends - 1;
        //friends -= 1;
        //friends--;

        //friends = friends * 2;
        //friends *= 2;

        //friends = friends / 2;
        //friends /= 2;

        int remainder = friends % 3;  //modular operator can be used to determine
                                      // if a number is even or odd

        Console.WriteLine(remainder);

        Console.ReadKey();
    }
}