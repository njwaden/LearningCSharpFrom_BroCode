namespace _18_NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();       //This line is creating a new instance of the Random class in C#, and naming it random

            /*
             * Part	            Meaning
               Random	        A class in C# used to generate pseudo-random numbers.
               random	        The name you're giving to your new Random object (you can name it anything).
               new Random()	    This creates a new object from the Random class using its constructor.
             */

            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + " and " + max + ": ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);


                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is too high");
                    }

                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is too low");
                    }
                    guesses++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("Guesses: " + guesses);
                Console.WriteLine("Would you like to play again (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }
            Console.WriteLine("Thanks for playing! ..... I guess");

            Console.ReadKey();
        }
    }
}
