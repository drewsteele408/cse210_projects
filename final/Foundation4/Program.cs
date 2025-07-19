using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        Activity swimming = new Swimming("7-19-2025", 30, 20, 50, 2, 1);
        Console.WriteLine(swimming.GetSummary());

        Activity running = new Running("7-19-2025", 45, 10, 12, 4);
        Console.WriteLine(running.GetSummary());

        Activity cycling = new Cycling("7-19-2025", 60, 20, 15, 3);
        Console.WriteLine(cycling.GetSummary());
    }
}