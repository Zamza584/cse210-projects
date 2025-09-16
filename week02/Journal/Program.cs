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
                Entry entry = new Entry();
                DateTime date = DateTime.Today;

                entry._promptText = prompt.GetRandomPrompt();
                entry._date = date.ToShortDateString();

                Console.WriteLine($"{entry._promptText}");
                string text = Console.ReadLine();
                entry._entryText = text;

                journal.AddEntry(entry);
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
                journal._entries.Clear();
                string[] lines = File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    Entry entry = new Entry();
                    string[] entries = line.Split("|");
                    entry._date = entries[0];
                    entry._promptText = entries[1];
                    entry._entryText = entries[2];
                    journal.AddEntry(entry);

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
                        outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
                    }
                }

            }

        }

    }
}