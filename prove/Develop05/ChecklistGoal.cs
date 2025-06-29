public class ChecklistGoal : Goal
{
    // Private tracking for progress 
    private int _currentCount;
    private int _targetCount;
    private int _bonusPoints;

    // Public variables so that the base class can access 
    public int CurrentCount => _currentCount;
    public int TargetCount => _targetCount;
    public int BonusPoints => _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    public override int RecordEvent()
    {
        // Keep a tally of points
        _currentCount++;

        int earned = _points;

        if (_currentCount == _targetCount)
        {
            earned += _bonusPoints;
        }
        return earned;
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }
}