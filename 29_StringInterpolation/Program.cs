namespace _29_StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string interpolation = allows us to insert variables into a string literal
            //                       precede a string literal with $
            //                       {} are placeholders

            String firstName = "nasi";
            String lastName = "bukhari";
            int age = 25;

            //Console.WriteLine("Hello " + firstName+ " " + lastName + ".");
            //Console.WriteLine("You are " + age + " years old.");

            Console.WriteLine($"Hello {firstName} {lastName}.");
            Console.WriteLine($"You are {age,10} years old.");              //10 is the width of the field, it will align the text to the right

            Console.ReadKey();
        }
    }
}
