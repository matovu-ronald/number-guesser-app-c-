using System;

namespace NumberGuesserApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set app information
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string authorName = "Matovu Ronald";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write app information
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, authorName);

            // Reset Color
            Console.ResetColor();

            // Ask Users name
            Console.WriteLine("What is your name?");

            // Get user input
            string username = Console.ReadLine();

            // Display the greetings message
            Console.WriteLine("Hello {0}, let's play a game...", username);

            while(true)
            {

                // Create a new Random Object
                Random random = new Random();

                // Init Correct Number
                int correctNumber = random.Next(1, 10);

                // Init Guess Number 
                int guess = 0;

                // Ask User for the Number 
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get user input
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Change text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        // Tell the user that the number entered is incorrect
                        Console.WriteLine("Please, Enter an actual number");

                        // Reset Color
                        Console.ResetColor();
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match Guess to Correct Number
                    if (guess != correctNumber)
                    {
                        // Change text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        // Tell the user that the number entered is incorrect
                        Console.WriteLine("Wrong Number Please Try Again");

                        // Reset Color
                        Console.ResetColor();
                    }
                }

                // Change text color
                Console.ForegroundColor = ConsoleColor.Yellow;

                // Tell the user that the number entered is incorrect
                Console.WriteLine("You are Correct");

                // Reset Color
                Console.ResetColor();

                // Ask to play again 
                Console.WriteLine("Play Again? [Y or N]");

                // Get answer 
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N") {
                    return;
                }
                else
                {
                    return;
                }

            }
        }
    }
}
