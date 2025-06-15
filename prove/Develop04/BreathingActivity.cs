public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing")
    {

    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
    }

    protected override void Perform()
    {
        ShowStartMessage();
        PromptForDuration();
        ShowDescription();

        DateTime stopTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < stopTime)
        {
            Console.WriteLine("Breath in...");
            ShowCountdown(5);

            Console.WriteLine("Breathe out....");
            ShowCountdown(5);

        }

    }
        
        
    
}