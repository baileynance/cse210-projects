using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        do
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            Console.WriteLine($"What is the magic number? {number}");
            int intGuess = 0;
            int counter = 0;

            do
            {
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                intGuess = int.Parse(guess);

                counter++;

                if (intGuess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (intGuess < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (intGuess == number)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You guessed {counter} time(s)");
                }
            } while (intGuess != number);
            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine();
        } while (playAgain == "yes");
    }
}