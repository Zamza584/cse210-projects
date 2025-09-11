using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Netflix";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2024;
        job1._endYear = 2025;

        job1.Display();
    }
}