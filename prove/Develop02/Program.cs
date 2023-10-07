using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {

        List<string> prompts = new List<string>{"Who was the most interesting person I interacted with today?", "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?",
        "What is something I wish I could have done better today?", "What is something I succeeded at today?", "How many friends did I make today?"};

        string GetRandomPrompt(List<string> prompts)
        {
            Random r = new Random(); 
            int index = r.Next(prompts.Count); 
            string randomPrompt = prompts[index];
            return randomPrompt;
        }

        string GetAction()
        {
            Console.WriteLine("Welcome to the Journal Program");
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Clear");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();
            return choice;
        }

        string action = GetAction();

        Journal journal = new Journal();
        string openFile = "";

        while (action != "6")
        {
            if (action == "1")
            {
                Entries entry = new Entries();
                
                entry._prompt = GetRandomPrompt(prompts);
                
                DateTime currentTime = DateTime.Now;
                string dateString = currentTime.ToShortDateString();
                entry._date = dateString;

                Console.WriteLine("");
                entry.DisplayPrompt();
                entry._response = Console.ReadLine();

                journal.AddEntry(entry);
                Console.WriteLine("");
            }
            else if (action == "2")
            {
                if (openFile != "")
                {
                    Console.WriteLine($"\nDisplaying {openFile}");
                }
                journal.DisplayEntries();
            }
            else if (action == "3")
            {
                Console.Write("\nLoad File: ");
                string fileName = Console.ReadLine();

                journal.LoadFile(fileName);
                Console.WriteLine("File Loaded\n");

                openFile = fileName;
            }
            else if (action == "4")
            {
                if (openFile != "")
                {
                    Console.WriteLine("\n1. Save");
                    Console.WriteLine("2. Save as");
                    Console.Write("What would you like to do? ");
                    string saveMethod = Console.ReadLine();
                    
                    if (saveMethod == "1")
                    {
                        journal.SaveFile(openFile);
                        Console.WriteLine("File saved.\n");
                    }
                    else 
                    {
                        Console.Write("\nSave File as: ");
                        string fileName = Console.ReadLine();
                        Console.WriteLine("Saving file...");

                        journal.SaveFile(fileName);
                        Console.WriteLine("File saved.\n");

                        openFile = fileName;
                    }
                } 
                else 
                {
                Console.Write("\nSave File as: ");
                string fileName = Console.ReadLine();
                Console.WriteLine("Saving file...");

                journal.SaveFile(fileName);
                openFile = fileName;
                Console.WriteLine("File saved.\n");
                }
            }
            else if (action == "5")
            {
                journal.ClearFile();
                Console.WriteLine("");
            }

            action = GetAction();
        }
    }
}