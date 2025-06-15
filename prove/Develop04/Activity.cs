using System.Diagnostics.Contracts;
using System.Threading;

public abstract class Activity
{
    protected string _description;
    private string _name;
    protected int _duration;


    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    protected void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string> { "-", "|"};
        int i = 0;

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write(animationStrings[i]);
            Thread.Sleep(1000);
            Console.Write("\b"); // moves the cursor back a space to delete the current image
            i = (i + 1) % animationStrings.Count;
        }
    }

    public void ShowStartMessage()
    {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("---------------------");
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine("---------------------");

        Console.WriteLine("Get ready to begin:");

        ShowSpinner(3); // shows the spinner for 3 seconds 

    }

    public void PromptForDuration()
    {
        // reads user input and converts to an int

        bool valid = false;

        while (!valid)
        {
            Console.Write("How many seconds would you like this activity to run? ");
            string userInput = Console.ReadLine();

            // convert the userInput into an int and check if it is greater than 0
            if (int.TryParse(userInput, out _duration) && _duration > 0)
            {
                valid = true;
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }
        }

        Console.WriteLine($"Great! Your activity will run for {_duration} seconds.");
        ShowSpinner(3);
    }

    public void ShowDescription()
    {
        // Empty line for spacing  
        Console.WriteLine("");
        Console.WriteLine("---------------------");

        Console.WriteLine(_description);
        ShowSpinner(3);



    }

    public void ShowEndMessage()
    {
        // shows end message of the activity 
        Console.WriteLine("");
        Console.WriteLine("---------------------");
        Console.WriteLine($"You have completed a {_duration} second long activity. Great job!");
        ShowSpinner(3);
    }


    // The perform method is abstract and empty because it will be overided by the subclasses perform method
    protected abstract void Perform();

    public void Run()
    {
        // calls the code above in order and then invokes Perform() method
        // ShowStartMessage();
        // PromptForDuration();
        // ShowDescription();

        Perform();

        ShowEndMessage();
    }


}