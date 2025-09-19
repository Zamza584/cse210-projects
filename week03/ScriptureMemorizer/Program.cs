using System;

class Program
{
    static void Main(string[] args)
    {
        Reference ref1 = new Reference("Romans", 8, 38, 39);
        Scripture scripture = new Scripture(ref1, "38 For I am persuaded, that neither death, nor life, nor angels, nor principalities, nor powers, nor things present, nor things to come, 39 Nor height, nor depth, nor any other creature, shall be able to separate us from the love of God, which is in Christ Jesus our Lord.");

        string s = scripture.GetDisplayText();

        Console.WriteLine(s);


    }
}