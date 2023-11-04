using System;
using System.Diagnostics;

public class Activity
{
    private string _activity;
    private string _description;
    private int _duration;

    public Activity(string activity, string description)
    {
        _activity = activity;
        _description = description;
    }

    // get methods
    public string GetActivity()
    {
        return _activity;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public string GetRandomPrompt(List<string> prompts)
    {
        Random r = new Random(); 
        int index = r.Next(prompts.Count); 
        string randomPrompt = prompts[index];
        return randomPrompt;
    }

    // animation methods
    public void DisplaySpinner()
    {
        List <string> spinnerAnimation = new List<string>(new string[] {"|", "/", "-", "\\", "|", "/", "-", "\\", "|", "/", "-", "\\", "|", "/", "-"});
        foreach (string bit in spinnerAnimation)
        {
            Console.Write(bit);
            Thread.Sleep(300);
            Console.Write("\b \b");
        }
    }
    public void DisplayCountdown(int number)
    {
        for (int i = number; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    // display methods
    public void DisplayGreeting()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activity}.\n\n{_description}");
        Console.Write("\nHow long, in seconds, would you like your session: ");
        string stringDuration = Console.ReadLine();
        int duration = int.Parse(stringDuration);
        _duration = duration;

        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner();
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell Done!!");
        DisplaySpinner();
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_activity}.");
        DisplaySpinner();
    }
}