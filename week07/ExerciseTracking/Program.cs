using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose an Activity to track: ");
        Console.WriteLine("  1. Running");
        Console.WriteLine("  2. Bicycles");
        Console.WriteLine("  3. Swimming");

        int option = int.Parse(Console.ReadLine());

        if (option == 1)
        {
            Console.WriteLine("--Running Acitivty--");
            Console.WriteLine("Date of the Activity: ");
            string date = Console.ReadLine();
            Console.WriteLine("Length of the Activity (minutes): ");
            int minutes = int.Parse(Console.ReadLine());
            Console.WriteLine("Distance of the Activity: ");
            float distance = float.Parse(Console.ReadLine());

            RunningActivity ra = new RunningActivity(date, minutes, distance);
            
        }
        else if (option == 2)
        {
            Console.WriteLine("--Bicycles Acitivty--");
            Console.WriteLine("Date of the Activity: ");
            string date = Console.ReadLine();
            Console.WriteLine("Length of the Activity (minutes): ");
            int minutes = int.Parse(Console.ReadLine());
            Console.WriteLine("Speed of the Activity: ");
            float speed = float.Parse(Console.ReadLine());
            RunningActivity ra = new RunningActivity(date, minutes, speed);
        }
        else if (option == 3)
        {
            Console.WriteLine("--Swimming Acitivty--");
            Console.WriteLine("Date of the Activity: ");
            string date = Console.ReadLine();
            Console.WriteLine("Length of the Activity (minutes): ");
            int minutes = int.Parse(Console.ReadLine());
            Console.WriteLine("Laps: ");
            int laps = int.Parse(Console.ReadLine());
            SwimmingActivity ra = new SwimmingActivity(date, minutes, laps);
        }

    }

    public static void TrackActivity(Activity activity)
    {
        Console.WriteLine("Date of the Activity: ");
        string date = Console.ReadLine();
        Console.WriteLine("Length of the Activity (minutes): ");
        int minutes = int.Parse(Console.ReadLine());




    }
}