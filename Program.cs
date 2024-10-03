
using System;
// namespace
namespace NumberGuesser
{
    //Main class
    class Program
    {
        //entry point method
        static void Main(string[] args)
        {
            GetAppInfo(); //run GetAppInfo function to get info

            GreetInfo(); //Ask for users name and greets

            while (true)
            {

                //set or Init correct number

                //int CorrectNumber = 7;

                //Create a new Random object

                Random random = new Random();

                //set or Init correct number

                int correctNumber = random.Next(1, 10);

                //init guss number

                int guess = 0;

                //ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                //while guess is not correct number

                while (guess != correctNumber)
                {
                    //get user input

                    string input = Console.ReadLine();

                    // make sure user put a number

                    if (!int.TryParse(input, out guess))
                    {
                        //print color message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");


                        //keep trying

                        continue;
                    }
                    //cast to int and put it in to the guess variable

                    guess = Int32.Parse(input);


                    //match guess to correct number
                    if (guess != correctNumber)
                    {
                        //print color message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number please try again...");

                    }

                }

                //print success number message
                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!!...");
               
                
                //ask to play again

                Console.WriteLine("Play Again? {Y or N}");

                //get answer

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
        static void GetAppInfo()
        {
            //set app variables
            string appName = "Number Imaginer";
            string appVersion = "1.0.1";
            string appAuthor = "Dristi Khondkar";

            //change text colour

            Console.ForegroundColor = ConsoleColor.Blue;
            //Console.BackgroundColor = ConsoleColor.Green;

            // write out app information 

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text colour

            Console.ResetColor();
        }
        
        //Ask users name and greet
        static void GreetInfo()
        {
            //ask user name

            Console.WriteLine("What is your name?");

            //get user input

            string inputNumber = Console.ReadLine();

            Console.WriteLine("Hello {0}!, lets play a game...", inputNumber);
        }

        //print colour massage
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //change text colour

            Console.ForegroundColor = color;


            // tell user its not a number 

            Console.WriteLine(message);

            //Reset text colour

            Console.ResetColor();
        }
    }

                
        }
    
