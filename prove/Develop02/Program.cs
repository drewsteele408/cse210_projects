using System;
using System.Diagnostics;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        Journal journal = new Journal();
        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("1. Make an entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Entry");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Quit");
            Console.Write("Select an option: ");

            if (int.TryParse(Console.ReadLine(), out choice))
            {


                if (choice == 1)
                {
                    journal.AddEntry();

                }

                else if (choice == 2)
                {
                    journal.DisplayJournal();

                }

                else if (choice == 3)
                {
                    Console.Write("Enter file name to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);

                }

                else if (choice == 4)
                {
                    Console.Write("Enter file to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);

                }

                else if (choice == 5)
                {
                    Console.WriteLine("Goodbye");
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid Option");
                }
            }

            else
            {
                Console.WriteLine("Please enter a valid number");
            }

        }
    }
}