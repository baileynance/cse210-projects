using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter grade percentage: ");
        string stringGrade = Console.ReadLine();
        int grade = int.Parse(stringGrade);
        string letter = "A";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        string finalLetter = letter;
        int remainder = grade % 10;
        if (remainder >= 7) 
        {
            if (grade >= 93 || grade < 60)
            {
                finalLetter = letter;
            }
            else
            {
                finalLetter = letter + "+";
            }
        }
        else if (remainder < 3)
        {
            if (grade >= 93 || grade < 60)
            {
                finalLetter = letter;
            }
            else
            {
                finalLetter = letter + "-";;
            }
        }

        Console.WriteLine($"Final Grade: {finalLetter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Sorry, you failed. You got it next time!");
        }
    }
}