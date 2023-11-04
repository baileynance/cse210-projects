using System;
using System.Diagnostics;

public class BreathingActivity : Activity
{
    public BreathingActivity(string activity, string description) : base(activity, description)
    {

    }
    public void DisplayBreatheIn()
    {
        Console.Write("Breath in...");
        DisplayCountdown(4);
    }

    public void DisplayBreatheOut()
    {
        Console.Write("Breath out...");
        DisplayCountdown(4);
    }

    public void RunBreathingActivity()
    {
        DisplayGreeting();
        
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(GetDuration());

        while (currentTime < endTime)
        {
            Console.WriteLine();

            if (currentTime < endTime)
            {
                DisplayBreatheIn();
                Console.WriteLine();
                currentTime = DateTime.Now;
            }
            if (currentTime < endTime)
            {
                DisplayBreatheOut();
                Console.WriteLine();
                currentTime = DateTime.Now;
            }
        }

        DisplayEndingMessage();
    }
}