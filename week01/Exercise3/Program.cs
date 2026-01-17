using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            Random randomGenerator = new Random();

            int magicNumberInt = randomGenerator.Next(1, 100);
            int guessNumber = -1;
            int count = 0;

            while (guessNumber != magicNumberInt)
            {
                Console.Write("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());
                count++;

                if (guessNumber < magicNumberInt)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessNumber > magicNumberInt)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }   
            Console.WriteLine($"It took you {count} guesses.");

            Console.Write("Do you want to play again (yes/no)? ");
            playAgain = Console.ReadLine();
        }
        Console.WriteLine("Thank you for playing!");
    }
}