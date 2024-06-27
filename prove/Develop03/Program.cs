using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        bool quit = false;

        while (!scripture.IsCompletelyHidden() && !quit)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            
            if (!scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    quit = true;
                else
                    scripture.HideRandomWords(3);
            }
        }

        if (scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nAll words have been hidden. Press Enter to exit.");
            Console.ReadLine();
        }

        Console.WriteLine("Program ended.");
    }
}