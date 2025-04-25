using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string classGrade = "";

        if (grade >= 90)
        {
            classGrade = "A";
        }

        else if (grade >= 80)
        {
            classGrade = "B";
        }

        else if (grade >= 70)
        {
            classGrade = "C";
        }

        else if (grade >= 60)
        {
            classGrade = "D";
        }

        else 
        {
            classGrade = "F";
        }

        Console.WriteLine($"Your grade is {classGrade}");

        if (grade >= 70)
        {
            Console.WriteLine("Congrats you pass!");
        }

        else
        {
            Console.WriteLine("Sorry you fail.");
        }

    }
}