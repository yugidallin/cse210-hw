using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        string gradePercentage = Console.ReadLine();

        int gradeInNumber = int.Parse(gradePercentage);
        string letter;
        string sign = "";

        if (gradeInNumber >= 90)
        {
            letter = "A";
        }
        else if (gradeInNumber >= 80)
        {
            letter = "B";
        }
        else if (gradeInNumber >= 70)
        {
            letter = "C";
        }
        else if (gradeInNumber >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign
        int lastDigit = gradeInNumber % 10;

        if (letter != "A" && letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A" && lastDigit < 3)
        {
            sign = "-";
        }

        Console.WriteLine($"Your letter grade is {letter}{sign}.");

        if (gradeInNumber >= 70)
        {
            Console.Write("Congratulations you passed!");
        }
        else
        {
            Console.Write("You can do better next time!");
        }
    }
}
