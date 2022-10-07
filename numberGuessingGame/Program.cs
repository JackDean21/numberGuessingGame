using System;

namespace NumberGuessingGame
{
    //main class
    class Program
    {
        //entry point method
        static void Main(string[] args)
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Jack Dean";
            


            //change text colour
            Console.ForegroundColor = ConsoleColor.Green;
            //display app info
            Console.WriteLine("{0}: Version: {1} created by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();

            //ask users name
            Console.WriteLine("What is your name?");

            //get input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello, {0} lets play the guessing game!", inputName);

            while (true)
            {
                //number to guess
                Random rand = new Random();
                int correctNumber = rand.Next(0, 101);

                //init guess var
                int guess = 0;

                //prompt user for number
                Console.WriteLine("Guess the number I'm thinking of between 1 and 100:");

                //while guess is not accurate
                while (guess != correctNumber)
                {
                    //get user input
                    string input = Console.ReadLine();

                    //check if input was an integer
                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter a number between 1 and 100!");
                        Console.ResetColor();

                        //keep going
                        continue;



                    }
                    //parse string to input and put into guess
                    guess = Int32.Parse(input);


                    //match guess to correct number
                    if (guess < correctNumber)
                    {
                        //change error message to red
                        Console.ForegroundColor = ConsoleColor.Red;
                        //failure message
                        Console.WriteLine("{0} is too low... guess higher!", guess);
                        //reset console color
                        Console.ResetColor();
                    }
                    if (guess > correctNumber)
                    {
                        //change error message to red
                        Console.ForegroundColor = ConsoleColor.Red;
                        //failure message
                        Console.WriteLine("{0} is too high... guess lower!", guess);
                        //reset console color
                        Console.ResetColor();
                    }


                }
                //change right answer to green
                Console.ForegroundColor = ConsoleColor.Green;

                //message for correct number guessed
                Console.WriteLine("YOU GUESSED CORRECTLY!!!");

                //reset colour
                Console.ResetColor();
                
        //play again?
        while (true)
        {
            Console.WriteLine("Do you want to play again? Please type yes or no");

            string replay = Console.ReadLine();
            if (replay == "yes".ToLower())
            {
                break;

            }
            else if (replay == "no".ToLower())
            {
                Environment.Exit(0);

            }
            else if (replay != "yes".ToLower() || replay != "no".ToLower())
            {
                Console.WriteLine("Please answer either yes or no on whether you would like to play again.");
                        continue;
               
                if (replay == "yes".ToLower())
                {
                    continue;

                }
                else if (replay == "no".ToLower())
                {
                    Environment.Exit(0);
                }
                }
            
           




                }









            }
            
        }
    }
}
