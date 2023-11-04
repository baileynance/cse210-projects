using System;
using System.Diagnostics;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    private string _prompt;

    public ListingActivity(string activity, string description, List<string> prompts) : base(activity, description)
    {
        _prompts = prompts;
    }

    public void SetPrompt()
    {
        _prompt = GetRandomPrompt(_prompts);
    }

    public string GetPrompt()
    {
        return _prompt;
    }
    public void RunListingActivity()
    {
        DisplayGreeting();

        SetPrompt();
        
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {_prompt} ---");

        Console.Write("You may begin in: ");
        DisplayCountdown(3);
        Console.WriteLine();
        
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(GetDuration());

        List<string> listItems = new List<string>();

        while (currentTime < endTime)
        {
            Console.Write("> ");
            string listItem = Console.ReadLine();
            listItems.Add(listItem);
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {listItems.Count} item(s)!");

        DisplayEndingMessage();
    }
}
