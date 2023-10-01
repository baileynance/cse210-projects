using System;

public class Journal
{
    public List<string> _prompts = new List<string>();
    
    public string GetPrompt(List<string> prompts)
    {
        Random r = new Random(); 
        int index = r.Next(prompts.Count); 
        string randomPrompt = prompts[index];
        return randomPrompt;
    }
}
