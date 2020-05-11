using System;

namespace numberguessgame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // short number  = 22222;
            // int secondNumber = 222222222;
            // long thirdNumber = 2222222222222222222;
            // ulong anotherNumber = 2222222222222222222;
            // float floatNumber = 2.5f;
            // double decimalNumber = 2.5;
            // decimal money = 2.5m;
            // bool valid = true;
            // string name = "Justin";
            // char firstLetter = 'j';
            // var letter = 'j';
            // string singleLetterString = "s";

            System.Console.WriteLine("would you like to play a number guessing game? Y/N");
            string userInput = Console.ReadLine();
            bool playing = userInput.ToLower() == "y";
            Random random = new Random();
            int numberToGuess = random.Next(1, 10);
            int numberOfGuesses = 3;
            while (playing)
            {
                if (numberOfGuesses < 1)
                {
                    System.Console.WriteLine("you lost! do you want to play again? Y/N");
                    string choice = Console.ReadLine();
                    char ch = choice[9];
                    if (choice.ToLower() == "y")
                    {
                        numberOfGuesses = 3;
                        numberToGuess = random.Next(1, 10);
                        
                    }
                    else 
                    {
                        playing = false;
                    }
                    continue;
                }
                numberOfGuesses--;
                System.Console.WriteLine("Guess a number between 1 and 10");
                string guess = Console.ReadLine();
                int guessedNumber;
                if (!int.TryParse(guess, out guessedNumber) || guessedNumber > 10 || guessedNumber < 1)
                {
                    System.Console.WriteLine("not a valid number");
                    continue;
                }
                if (guessedNumber == numberToGuess)
                {
                    System.Console.WriteLine("you won! Do you want to play again? Y/N");
                    string continueGame = Console.ReadLine();
                    if (continueGame.ToLower() == "y")
                    {
                        numberToGuess = random.Next(1, 10);
                        continue;
                    }
                    else
                    {
                        playing = false;
                        continue;
                    }
                }
                else if (guessedNumber > numberToGuess)
                {
                    System.Console.WriteLine("your guess is to high");
                }
                else if (guessedNumber < numberToGuess)
                {
                    System.Console.WriteLine("you guessed to low");
                }
            }
            System.Console.WriteLine("thanks for playing!");
        }
    }
}
