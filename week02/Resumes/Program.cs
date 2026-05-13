using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._jobTitle = "Spanish interpreter";
        job1._company = "Multilingual";
        job1._startYear = 2025;
        job1._endYear = 2030;

        Job job2 = new Job();
        job2._jobTitle = "English interpreter";
        job2._company = "Multinational";
        job2._startYear = 2021;
        job2._endYear = 2040;
        
        Resume resume = new Resume();
        resume._Name = "Jhon Steward";
        
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();


    }
}