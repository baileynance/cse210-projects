using System;
using System.Collections.Generic;
using System.IO;
public class Entries
{  
    public void DisplayPrompt()
    {
        Console.WriteLine(_prompt);
    }

    public string CreateEntry()
    {
        return $"\nDate: {_date} - Prompt: {_prompt} \n{_response}\n";
    } 

    public string _prompt;
    public string _date;
    public string _response;
}