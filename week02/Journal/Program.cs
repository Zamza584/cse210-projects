using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        int input = 0;
        Journal journal = new Journal();

        Prompt prompt = new Prompt();
        prompt._prompts.Add("What is your greatest accomplishment for this day?");
        prompt._prompts.Add("Is there something you regret today?");
        prompt._prompts.Add("What was one challenge you overcame today?");
        prompt._prompts.Add("What are you going to do to be a better person this week?");
        prompt._prompts.Add("What insights would you like saved for eternity?");

        Console.WriteLine("Journal Entries");
        while (input != 5)
        {

            Console.WriteLine("Please enter one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load ");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do from the list above?: ");
            input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                Entry entry1 = new Entry();
                DateTime date = DateTime.Today;

                entry1._promptText = prompt.GetRandomPrompt();
                entry1._date = date.ToShortDateString();

                Console.WriteLine($"{entry1._promptText}");

                string text = Console.ReadLine();
                entry1._entryText = text;
                journal.AddEntry(entry1);
            }

            else if (input == 2)
            {
                foreach (Entry entry in journal._entries)
                {
                    entry.Display();
                }
            }

            else if (input == 3)
            {
                Console.Write("Please enter a file name: ");
                string filename = Console.ReadLine() + ".txt";

                string[] lines = File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }

            else if (input == 4)
            {
                Console.Write("Please enter a file name: ");
                string filename = Console.ReadLine() + ".txt";
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (Entry entry in journal._entries)
                    {
                        outputFile.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}");
                        outputFile.WriteLine($"Entry Text: {entry._entryText}|");
                        outputFile.WriteLine("");
                        // outputFile.Write($"{entry._date}|");
                        // outputFile.Write($"{entry._entryText}|");
                        // outputFile.WriteLine($"{entry._promptText}");
                    }
                }

            }

        }

    }
}