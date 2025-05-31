namespace _12_IfStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 100)                                              //if put (age >= 18) first, then age > 100 will not be shown as first output will be put out first. order of the code matters. always.
            {
                Console.WriteLine("You are too old to sign up!");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You are now signed up!");
            }
            else if (age < 0)
            {
                Console.WriteLine("You haven't been born yet");
            }
            else
            {
                Console.WriteLine("You must be 18 and above to sign up.");
            }*/

            //if statement = basic form of decision making

            Console.WriteLine("Please enter your name: ");
            String name = Console.ReadLine();

            if (name == "")
            {
                Console.WriteLine("You did not enter your name!");
            }

            else
            {
                Console.WriteLine("Hello " + name);
            }

            Console.ReadKey();
        }
    }
}
