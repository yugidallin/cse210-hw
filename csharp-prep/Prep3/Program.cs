using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;

        while (playAgain)
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,100);
            int userNumberInt = 0;
            int guesses = 0;

            Console.WriteLine("Welcome to the Magic Number Game");

            do 
            {
                Console.Write("What is your guess?: ");
                string userNumber = Console.ReadLine();
                userNumberInt = int.Parse(userNumber);
                guesses++;

                if (userNumberInt > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (userNumberInt < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed the magic number!");
                    Console.WriteLine($"It took you {guesses}.");
                }

            } while (userNumberInt != magicNumber);
            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            if (response !="yes")
            {
                playAgain = false;
            }
        }
    }
}