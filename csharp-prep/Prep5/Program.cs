using System;

class Program
{
    static void Main(string[] args)
        {
            DisplayWelcome();
            string userName = PromptUserName();
            int userNumber = PromptUserNumber();
            int squaredNumber = SquareNumber(userNumber);
            DisplayResult(userName, squaredNumber);
        }

    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

    static string PromptUserName()
        {
            Console.Write("Please enter your name");
            string userName = Console.ReadLine();
            return userName;
        }

    static int PromptUserNumber()
        {
            Console.Write("Please enter you favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }

    static int SquareNumber(int userNumber)
        {
            int numberSquared = userNumber * userNumber;
            return numberSquared;
        }

    static void DisplayResult(string userName, int numberSquared)
        {
            Console.Write($"{userName}, the square of your number is {numberSquared}");
        }
}