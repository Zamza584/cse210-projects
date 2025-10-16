using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Choose an Activity to track: ");
        // Console.WriteLine("  1. Running");
        // Console.WriteLine("  2. Bicycles");
        // Console.WriteLine("  3. Swimming");
        // Console.Write("Enter option: ");
        // int option = int.Parse(Console.ReadLine());

        // if (option == 1)
        // {
        //     Console.WriteLine("--Running Acitivty--");
        //     Console.Write("Date of the Activity: ");
        //     string date = Console.ReadLine();
        //     Console.Write("Length of the Activity (minutes): ");
        //     int minutes = int.Parse(Console.ReadLine());
        //     Console.Write("Distance of the Activity (miles): ");
        //     float distance = float.Parse(Console.ReadLine());

        //     RunningActivity ra = new RunningActivity(date, minutes, distance);
        //     Console.WriteLine(ra.GetFullSummary());

        // }
        // else if (option == 2)
        // {
        //     Console.WriteLine("--Bicycles Acitivty--");
        //     Console.Write("Date of the Activity: ");
        //     string date = Console.ReadLine();
        //     Console.Write("Length of the Activity (minutes): ");
        //     int minutes = int.Parse(Console.ReadLine());
        //     Console.Write("Speed of the Activity (miles): ");
        //     float speed = float.Parse(Console.ReadLine());
        //     BicycleActivity ba = new BicycleActivity(date, minutes, speed);
        //     Console.WriteLine(ba.GetFullSummary());

        // }
        // else if (option == 3)
        // {
        //     Console.WriteLine("--Swimming Acitivty--");
        //     Console.Write("Date of the Activity: ");
        //     string date = Console.ReadLine();
        //     Console.Write("Length of the Activity (minutes): ");
        //     int minutes = int.Parse(Console.ReadLine());
        //     Console.Write("Number of Laps: ");
        //     int laps = int.Parse(Console.ReadLine());
        //     SwimmingActivity sa = new SwimmingActivity(date, minutes, laps);
        //     Console.WriteLine(sa.GetFullSummary());

        // }

        RunningActivity ra = new RunningActivity("10/15/25", 30, 3);
        BicycleActivity ba = new BicycleActivity("10/15/25", 20, 5);
        SwimmingActivity sa = new SwimmingActivity("10/15/25", 25, 5);

        List<Activity> activities = new List<Activity>();

        activities.Add(ra);
        activities.Add(ba);
        activities.Add(sa);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetFullSummary());

        }


    }
}