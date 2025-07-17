using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        Address lectureAddress = new Address("123 Main St", "Rexburg", "ID", "83440", "USA");
        Address receptionAddress = new Address("456 Burger St", "Rexburg", "ID", "83440", "USA");
        Address outdoorAddress = new Address("789 Park Ave", "Rexburg", "ID", "83440", "USA");


        Lecture lecture = new Lecture("C# Programming", "An introduction to C# programming.", "7-01-2025", "10:00 AM", lectureAddress, "Professor Tuck", 100);

        Reception reception = new Reception("Wedding Reception", "Join us for a celebration!", "7-02-2025", "6:00 PM", receptionAddress, "JustinTimberlake@gmail.com");

        OutdoorGathering outdoorEvent = new OutdoorGathering("Outdoor Concert", "Enjoy live music in the park.", "7-03-2025", "5:00 PM", outdoorAddress, "Sunny with a chance of meatballs");

        Event[] events = new Event[] { lecture, reception, outdoorEvent };

        foreach (Event ev in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine("");

            Console.WriteLine("Full Details:");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine("");

            Console.WriteLine("Short Description:");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine();
        }

    }

}