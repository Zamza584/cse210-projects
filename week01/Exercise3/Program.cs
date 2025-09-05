using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber;
        int guess;
        int numberGuesses = 0;

        Random randomGenerator = new Random();
        magicNumber = randomGenerator.Next(1, 101);

        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            numberGuesses++;

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess == magicNumber)
            {
                Console.WriteLine($"You guessed it! Total guesses:{numberGuesses}");
                
                Console.Write("Play again? ");
                string answer = Console.ReadLine();

                if (answer == "yes")
                { 
                    magicNumber = randomGenerator.Next(1, 100);
                }
            }
        } while (magicNumber != guess);

    }
}