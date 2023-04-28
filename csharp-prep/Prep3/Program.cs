using System;

class Program
{
    static void Main(string[] args)
    {
        int playAgain = 0;

        do 
        {
            int guessNumber = 0;
            int numberOfGuesses = 0;
            

            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,100);

            do 
            {
                Console.Write ("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());

                if (guessNumber < magicNumber) 
                {
                    Console.WriteLine("Higher");
                }
                else if (guessNumber > magicNumber) 
                {
                    Console.WriteLine("Lower");
                }
                else 
                {
                    Console.WriteLine("You guessed it!");
                }

                numberOfGuesses++;

            } while (guessNumber != magicNumber);
            
            Console.WriteLine($"Total number of guesses: {numberOfGuesses}");

            Console.Write("would you like to play again? (y/n) ");
            string playInput = Console.ReadLine();

            if (playInput == "n" || playInput == "N")
            {
                playAgain = 1;
            }

        } while (playAgain != 1);

    }
}