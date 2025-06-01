namespace _23_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //method = performs a section of code, whenever it's called "invoked".
            // benefit = Let's us reuse code without writing it multiple times.

            String name = "sayang";                        //arguments = what is sent to methods
            int age = 26;
            singHappyBirthday(name, age);                            
            
            Console.ReadKey();
        }

        static void singHappyBirthday(String birthdayGIRL, int yearsOld)     //parameters = what a method needs to receive to be invoked. parameters doesnt necessarily use the same name as the arguments we're passing.                       
                                                                //methods do not have access to any variables on another method
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear " + birthdayGIRL + "!");
            Console.WriteLine("You are " + yearsOld + " years old! :3");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine();
        }
    }
}
