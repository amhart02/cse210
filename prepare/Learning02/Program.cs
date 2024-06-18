using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Sony";
        job2._jobTitle = "Engineer";
        job2._startYear = 2002;
        job2._endYear = 2008;

        Resume myResume = new Resume();
        myResume._name = "John Doe";
        myResume._Jobs.Add(job1);
        myResume._Jobs.Add(job2);

        myResume.Display();
    }
}