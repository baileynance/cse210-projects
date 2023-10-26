using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment = new MathAssignment("Bailey Nance", "Math 101", "7.1", "9-11");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(assignment.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment writing = new WritingAssignment("Bailey Nance", "Writing 101", "How to Write a Paper");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}