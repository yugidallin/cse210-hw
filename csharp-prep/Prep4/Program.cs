using System;

class Program
{
    static void Main(string[] args)
    {
       List<int> numbers = new List<int>();
        int userNumber;

        do
        {
            Console.WriteLine("Enter a number (type 0 when finished):");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        } while (userNumber != 0);

        if (numbers.Count > 0)
        {
            
            int sum = numbers.Sum();
            double average = numbers.Average();
            int max = numbers.Max();

            int smallestPositive = numbers.Where(n => n > 0).DefaultIfEmpty(int.MaxValue).Min();

            numbers.Sort();

            // Output the sum, average, maximum, smallest positive, and sorted list
            Console.WriteLine($"The sum of the numbers is: {sum}");
            Console.WriteLine($"The average of the numbers is: {average}");
            Console.WriteLine($"The maximum number is: {max}");
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            Console.WriteLine("The sorted list of numbers is:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}