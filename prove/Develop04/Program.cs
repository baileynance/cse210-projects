using System;

class Program
{
    static void Main(string[] args)
    {
        List <string> reflectionPrompts = new List<string>(new string[] {"Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."});
        List <string> reflectionQuestions = new List<string>(new string[] {"Why was this experience meaningful to you?", "Have you ever done anything like this before?",
        "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", 
        "How can you keep this experience in mind in the future?"});
        
        List <string> listingPrompts = new List<string>(new string[] {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"});
        
        string action = "0";
        int counter = 0;

        while (action != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options: \n  1. Breathing Activity \n  2. Reflection Activity \n  3. Listing Activity \n  4. Quit");
            Console.Write("Select a choice from the menu: ");
            action = Console.ReadLine();

            if (action == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathingActivity.RunBreathingActivity();
                counter++;
            }
            else if (action == "2")
            {
                if (reflectionPrompts.Count > 0)
                {
                    ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
                    reflectionPrompts, reflectionQuestions);
                    reflectionActivity.runReflectionActivity();
                    string prompt = reflectionActivity.GetPrompt();
                    reflectionPrompts.Remove(prompt);
                    counter++;
                }
            }
            else if (action == "3")
            {
                if (listingPrompts.Count > 0)
                {
                    ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", listingPrompts);
                    listingActivity.RunListingActivity();
                    string prompt = listingActivity.GetPrompt();
                    listingPrompts.Remove(prompt);
                    counter++;
                }
            }
            else if (action == "4")
            {
                Console.Clear();
                Console.WriteLine("Thank you for participating!");
                Console.WriteLine($"\nYou completed {counter} activities.");
            }
        }
    }
}