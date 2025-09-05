using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        int number = 1;
        int total = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numberList.Add(number);
            }
        }

        foreach (int num in numberList)
        {
            total += num;
        }

        float average = (float)total / numberList.Count;
        int largestNum = numberList.Max(); // found through ai that you can use MAX() function 

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNum}");

    }
}