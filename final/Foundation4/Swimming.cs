public class Swimming : Activity
{
    private int _lapCount;
    private int _lapLength;
    private int _speed;
    private int _pace;

    public Swimming(string date, int duration, int lapCount, int lapLength, int speed, int pace)
        : base(date, duration)
    {
        _lapCount = lapCount;
        _lapLength = lapLength;
        _speed = speed;
        _pace = pace;
    }

    public override int GetDistance()
    {
        return _lapCount * _lapLength / 1000; // Convert to kilometers
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