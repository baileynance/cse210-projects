using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program");
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        string action = Console.ReadLine();

        Journal journal = new Journal();
        Entries entries = new Entries();

        while (action != "5")
        {
            if (action == "1")
            {
                Console.Write("Enter Date: ");
                string date = Console.ReadLine();
                string prompt = journal.GetPrompt(journal._prompts);
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                string entry = $"Date: {date} - Prompt: {prompt} {response}";
                entries._entries.Add(entry);
            }
            else if (action == "2")
            {
                entries.DisplayJournal();
            }
            else if (action == "3")
            {
                Console.WriteLine("Load name of Program: ");
                Console.WriteLine("Load File: ");
                string fileName = Console.ReadLine();
            }
            else if (action == "4")
            {
                Console.WriteLine("Save File as: ");
                string fileName = Console.ReadLine();
            }
        }

    }
}