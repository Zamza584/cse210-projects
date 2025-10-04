using System;
using System.Diagnostics;
using mindfulness;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("MenuOptions:");
        Console.WriteLine("  1. Start breathing");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
        Console.Write("Select a choice from the menu: ");
        int option = int.Parse(Console.ReadLine());

        BreathingActivity a1 = new BreathingActivity();
        ReflectingActivity a2 = new ReflectingActivity();
        ListingActivity a3 = new ListingActivity();


        if (option == 1)
        {
            a1.DisplayStartMessage();
            a1.StartBreathing();
            a1.DisplayEndMessage();
        }
        else if (option == 2)
        {
            a2.DisplayStartMessage();
            a2.StartReflecting();
            a2.DisplayEndMessage();
        }
        else if (option == 3)
        {
            a3.DisplayStartMessage();
            a3.StartListing();
            a3.DisplayEndMessage();
        }

        else if (option == 4)
        {
            Console.WriteLine("Hope you have a great time. See you soon!");
        }

    }
}