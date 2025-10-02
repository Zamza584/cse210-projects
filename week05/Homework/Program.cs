using System;
using homework;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("James Stewart", "Algebra");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("3.4", "3-4", "james Reed", "Algebra");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("The end of a century", "Fran Monk", "History");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());

    }
}