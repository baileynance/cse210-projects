using System;

class Program
{
    static void Main(string[] args)
    {

        Reference studyMaterial = new Reference("John", "3:16", "For God so loved the world he gave his only begotten son");
        
        string study = studyMaterial.GetReference();
        string script = studyMaterial.GetVerse();

        bool action = true;
        bool completelyHidden = false;
       
        Console.WriteLine($"{study} {script}");
        Console.WriteLine("Press enter to contine or type 'quit' to finish:");

        if (Console.ReadKey().Key == ConsoleKey.Enter)
            action = true;
        else if (Console.ReadKey().Key != ConsoleKey.Enter)
            action = Console.ReadLine() != "quit";

        Scripture scripture = new Scripture(study, script);

        if (action && !completelyHidden)
        {
            while (action && !completelyHidden)
            {
                Console.Clear();

                scripture.HideWords();
                script = scripture.GetScripture();
                Console.WriteLine($"{script}\n");

                completelyHidden = scripture.IsHidden();

                Console.WriteLine("Press enter to contine or type 'quit' to finish:");
                action = Console.ReadKey().Key == ConsoleKey.Enter;
            }
        }
    }
}