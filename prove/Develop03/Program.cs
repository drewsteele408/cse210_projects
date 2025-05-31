using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Reference reference = new Reference("Proverbs", 3, 5, 6);

        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, text);

        Console.WriteLine("Original Scripture:");
        Console.WriteLine(scripture.GetDisplayText());

        scripture.HideRandomWords(5);
        Console.WriteLine("Scripture after hiding random words:");

        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}