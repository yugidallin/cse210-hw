using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        
        while (true)
        {
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                WriteNewEntry(journal, promptGenerator);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                SaveJournal(journal);
            }
            else if (choice == "4")
            {
                LoadJournal(journal);
            }
            else if (choice == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }

    private static void WriteNewEntry(Journal journal, PromptGenerator promptGenerator)
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        string entryText = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        string timestamp = DateTime.Now.ToString("HH:mm:ss");
        Entry newEntry = new Entry(date, timestamp, prompt, entryText);
        journal.AddEntry(newEntry);
    }

    private static void SaveJournal(Journal journal)
    {
        Console.WriteLine("Enter filename to save to:");
        string saveFile = Console.ReadLine();
        journal.SaveToFile(saveFile);
    }

    private static void LoadJournal(Journal journal)
    {
        Console.WriteLine("Enter filename to load from:");
        string loadFile = Console.ReadLine();
        journal.LoadFromFile(loadFile);
    }
}