public class Running : Activity
{
    private int _distance;
    private int _speed;
    private int _pace;

    public Running(string date, int duration, int distance, int speed, int pace)
        : base(date, duration)
    {
        _distance = distance;
        _speed = speed;
        _pace = pace;
    }

    public override int GetDistance()
    {
        return _distance;
    }

    public override int GetSpeed()
    {
        return _speed;
    }

    public override int GetPace()
    {
        return _pace;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance()} km, Speed: {GetSpeed()} km/h, Pace: {GetPace()} min/km";
    }
}