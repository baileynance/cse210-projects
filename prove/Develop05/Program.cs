using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        
        int points = 0;
        string action = "";

        List<Goal> goalsList = new List<Goal>();

        while (action != "6")
        {
            Console.WriteLine($"\nYou have {points} points.\n");
            Console.WriteLine("Menu options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit");
            Console.Write("Select a choice from the menu: ");
            action = Console.ReadLine();

            if (action == "1")
            {
                Console.WriteLine("The types of goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal");
                Console.Write("What type of goal would you like to create? ");
                string goalType = Console.ReadLine();

                Console.Write("What is the name of your goal? ");
                string goalName = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                string goalDescription = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                string stringPoints = Console.ReadLine();
                int goalPoints = int.Parse(stringPoints);

                if (goalType == "1")
                {
                    goalsList.Add(new SimpleGoal(goalName, goalDescription, goalPoints));
                }
                else if (goalType == "2")
                {
                    goalsList.Add(new EternalGoal(goalName, goalDescription, goalPoints));
                }
                if (goalType == "3")
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    string stringQuantity = Console.ReadLine();
                    int goalQuantity = int.Parse(stringQuantity);

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    string stringBonus = Console.ReadLine();
                    int goalBonus = int.Parse(stringBonus);

                    goalsList.Add(new ChecklistGoal(goalName, goalDescription, goalPoints, goalQuantity, goalBonus));
                }
            }
            else if (action == "2")
            {
                int i = 1;
                foreach (Goal goal in goalsList)
                {
                    Console.Write($"{i}. ");
                    goal.DisplayGoal();
                    i++;
                }
            }
            else if (action == "3")
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();

                using (StreamWriter file = new StreamWriter(filename))
                {
                    file.WriteLine(points);

                    foreach (Goal goal in goalsList)
                    {
                        file.WriteLine(goal.GetStringRepresentation());
                    }
                }
            }
            else if (action == "4")
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();

                string[] lines = System.IO.File.ReadAllLines(filename);

                string parseTotal = lines[0];
                points = int.Parse(parseTotal);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");

                    if (parts[0] == "simple")
                    {
                        string goalName = parts[1];
                        string goalDescription = parts[2];
                        string parsePoints = parts[3];
                        int goalPoints = int.Parse(parsePoints);
                        string parseTotalPoints = parts[4];
                        int simplePoints = int.Parse(parseTotalPoints);
                        goalsList.Add(new SimpleGoal(goalName, goalDescription, goalPoints, simplePoints));
                    }
                    else if (parts[0] == "eternal")
                    {
                        string goalName = parts[1];
                        string goalDescription = parts[2];
                        string parsePoints = parts[3];
                        int goalPoints = int.Parse(parsePoints);
                        string parseTotalPoints = parts[4];
                        int totalPoints = int.Parse(parseTotalPoints);
                        string parseLevel = parts[5];
                        int goalLevel = int.Parse(parseLevel);
                        goalsList.Add(new EternalGoal(goalName, goalDescription, goalPoints, totalPoints, goalLevel));
                    }
                    if (parts[0] == "checklist")
                    {
                        string goalName = parts[1];
                        string goalDescription = parts[2];
                        string parsePoints = parts[3];
                        int goalPoints = int.Parse(parsePoints);
                        string parseQuanity = parts[4];
                        int goalQuantity = int.Parse(parseQuanity);
                        string parseBonus = parts[5];
                        int goalBonus = int.Parse(parseBonus);
                        string parseCompletion = parts[6];
                        int goalCompletion = int.Parse(parseCompletion);
                        string parseTotalPoints = parts[7];
                        int totalPoints = int.Parse(parseTotalPoints);
                        goalsList.Add(new ChecklistGoal(goalName, goalDescription, goalPoints, goalQuantity, goalBonus, goalCompletion, totalPoints));
                    }
                }
            }
            else if (action == "5")
            {
                Console.WriteLine("The goals are: ");
                int i = 1;
                foreach (Goal goal in goalsList)
                {
                    Console.Write($"{i}. ");
                    Console.WriteLine(goal.GetGoalName());
                    i++;
                }
                Console.Write("Which goal did you accomplish? ");
                string accomplishedGoal = Console.ReadLine();
                int numberGoal = int.Parse(accomplishedGoal);  

                goalsList[numberGoal - 1].RecordEvent();
                int accomplishedPoints = goalsList[numberGoal - 1].GetPoints();
            
                points += accomplishedPoints;
                Console.WriteLine($"Congratulations! You have earned {accomplishedPoints}\n");
            }
            else if (action == "6")
            {
                Console.WriteLine("\nThank you for choosing our program!");
            }
        }
    }
}