using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true; // initialize playAgain to true
        while (playAgain)
        {
            playGame();
            Console.Write("Do you want to play again? (yes/no) ");
            string response = Console.ReadLine().ToLower(); // convert response to lowercase

            playAgain = response == "yes";
        }
    }
    static void playGame()
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guess = -1;
        int numberOfGuesses = 0; // initialize numberOfGuesses to 0

        Console.WriteLine("Welcome to the Number of Guessing Game! ");


        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            numberOfGuesses++;

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You guessed it in {numberOfGuesses} guesses!"); 
            }
        }
        
    }
}