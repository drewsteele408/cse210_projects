public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address location, string speaker, int capacity) : base(title, description, date, time, location)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + "Event Type: Lecture, Speaker: " + _speaker + ", Capacity: " + _capacity;
    }

    public override string GetShortDescription()
    {
        return $"Lecture: {Title} by {_speaker} on {Date}";
    }

    public override string GetEventType()
    {
        return "Lecture";
    }
}