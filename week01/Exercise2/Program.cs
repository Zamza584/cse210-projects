using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Grade percentage: ");
        int percentage = int.Parse(Console.ReadLine());
        string letter;
        string sign;

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (percentage % 10 >= 7)
        {
            sign = "+";
        }
        else if (percentage % 10 < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (percentage >= 93 || percentage < 60)
        {
            sign = ""; 
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations you passed the course!!");
        }
    }
}