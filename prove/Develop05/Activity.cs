using System;
using System.Collections.Generic;
using System.IO;
public class Activity
{   
    public void CreateGoal(string goalFile)
    {
        string[] lines = System.IO.File.ReadAllLines(goalFile);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string goalType = parts[0];
            string goalName = parts[1];
            string goalDescription = parts[2];
            string goalPoints = parts[3];
        }
    }
}