using System;
public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    protected Address _location;

    public string Title => _title;
    public string Description => _description;
    public string Date => _date;
    public string Time => _time;

    public Event(string title, string description, string date, string time, Address location)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _location = location;
    }

    public  virtual string GetStandardDetails()
    {
        return $"{_title}, {_description}, {_date}, {_time}";
    }

    public virtual string GetFullDetails()
    {
        // list title, description, date, time, plus type of event and information specific to that event type
        return $"{GetStandardDetails()}, Event Type: {GetEventType()}";
    }

    public virtual string GetShortDescription()
    {
        // Lists the type of event, title, and the date
        return $"{GetEventType()}: {_title} on {_date}";
    }

    public virtual string GetEventType()
    {
        // Get event type
        return "Generic Event";
    }

}