using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Sales Specialist";
        job1._company = "Verizon";
        job1._startYear = 2021;
        job1._endYear = 2022;;

        Job job2 = new Job();
        job2._jobTitle = "Assistant Manager";
        job2._company = "DSG";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Console.WriteLine(job1._company);
        // Console.WriteLine(job2._company);
 
        // job1.DisplayJob();
        // job2.DisplayJob();
     
        Resume resume1 = new Resume();
        resume1._name = "Bailey Nance";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
 
        // Console.WriteLine(resume1._jobs[0]._jobTitle);
        // Console.WriteLine(resume1._jobs[1]._jobTitle);

        resume1.DisplayResume();
    }
}