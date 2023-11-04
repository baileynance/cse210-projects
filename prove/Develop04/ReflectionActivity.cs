using System;
using System.Diagnostics;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _reflections;

    private string _prompt;

    public ReflectionActivity(string activity, string description, List<string> prompts, List<string> reflections) : base(activity, description)
    {
        _prompts = prompts;
        _reflections = reflections;
    }

    public void SetPrompt()
    {
        _prompt = GetRandomPrompt(_prompts);
    }

    public string GetPrompt()
    {
        return _prompt;
    }

    public void runReflectionActivity()
    {
        DisplayGreeting();

        SetPrompt();

        Console.WriteLine("\nConsider the following prompt: ");
        Console.WriteLine($"\n--- {_prompt} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadKey();

        Console.WriteLine("\nNow ponder each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        DisplayCountdown(3);
        
        Console.Clear();

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(GetDuration());

        while (currentTime < endTime)
        {
            string reflection = GetRandomPrompt(_reflections);
            _reflections.Remove(reflection);
            Console.Write($"> {reflection} ");
            DisplaySpinner();
            Console.WriteLine();
            currentTime = DateTime.Now;
        }

        DisplayEndingMessage();
    }
}