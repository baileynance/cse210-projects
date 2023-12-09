using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("Running", "Nov 13th 2023", 60, 5.5));
        activities.Add(new Biking("Biking", "Nov 14th 2023", 45, 12.3));
        activities.Add(new Swimming("Swimming", "Nov 15th 2023", 30, 37));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}