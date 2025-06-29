public class SimpleGoal : Goal
{
    private bool _isDone;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isDone = false;
    }

    public override int RecordEvent()
    {
        if (!_isDone)
        {
            _isDone = true;
            return _points;
        }
        else
        {
            return 0;
        }
    }

    public override bool IsComplete()
    {
        return _isDone;
    }
}