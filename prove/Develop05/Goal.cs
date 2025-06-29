public abstract class Goal
{
    private string _name;
    private string _description;
    protected int _points;
    protected bool _done;

    // Base constructor 
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // Returns the points earned
    public abstract int RecordEvent();

    // Simple goals return true once, eternal goals always false, checklist goals once the count is reached
    public abstract bool IsComplete();

    // Get status for the goals 
    public virtual string GetStatusLine()
    {
        // Add a check symbol if completed 
        string statusSymbol;
        if (IsComplete())
        {
            statusSymbol = "[X]";
        }
        else
        {
            statusSymbol = "[ ]";
        }

        string line = $" {statusSymbol} {_name}";

        if (this is ChecklistGoal checklist)
        {
            // Show progress for the checklist goal
            line += $" ({checklist.CurrentCount}/{checklist.TargetCount})";

            // Once completed checklist goal add the bonus points 
            if (checklist.IsComplete())
            {
                line += $" {_points + checklist.BonusPoints} pts!";
            }
            else
            {
                line += $" {_points} pts each";
            }
        }

        else if (this is EternalGoal)
        {
            line += $" {_points} pts each time";
        }

        // Simple adds points once completed
        else
        {
            line += $" {_points} pts once";
        }
        return line;
    }

}