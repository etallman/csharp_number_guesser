using System;

namespace NumberGuesser
{
    class Program
    {
        //Entry Point Method
        public static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();

            while (true)
            {
                Random random = new Random();
                int correctNumber = random.Next(1, 20);
                int guess = 0;

                Console.WriteLine("Guess which number I'm thinking of that is between 1 and 20.");

                while (guess != correctNumber)
                {

                    //Get user's input
                    string input = Console.ReadLine();

                    //Make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {

                        ChangeMessageColor(ConsoleColor.Red, "Please enter a number");


                        continue;
                    }

                    //Casts to 32-bit int and puts in guess
                    guess = Int32.Parse(input);

                    //Run error message if the guess is incorrect.
                    if (guess != correctNumber)
                    {
                        ChangeMessageColor(ConsoleColor.Red, "That is not the correct number. Try again!");

                    }
                }

                //Run win message if guess is correct           
                ChangeMessageColor(ConsoleColor.Yellow,"That's the number that I was thinking of. You win!");

                //Play again prompt
                Console.WriteLine("Play Again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
        //Display app info
        static void GetAppInfo()
        {
            //Header variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Eileen Tallman";

            //Change text color for header
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            //Write out header
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Resets color for text after header
            Console.ResetColor();
        }
        //Greet user and ask their name
        static void GreetUser(){
            //Ask for user's name
            Console.WriteLine("What is your name?");

            //Storing input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a guessing game...", inputName);
        }
        static void ChangeMessageColor(ConsoleColor color, string message) {
                Console.ForegroundColor = color;
                Console.WriteLine(message);
                Console.ResetColor();
        }
    }
}