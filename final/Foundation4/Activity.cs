public abstract class Activity
{
    private string _date;
    private int _duration;

    public string Date => _date;
    public int Duration => _duration;
    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public abstract int GetDistance();
    public abstract int GetSpeed();
    public abstract int GetPace();

    public virtual string GetSummary()
    {
        return $"{Date} {GetType().Name} ({Duration} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} km/h, Pace: {GetPace()} min/km";
    }

    
}