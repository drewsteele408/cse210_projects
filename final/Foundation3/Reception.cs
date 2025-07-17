public class Reception : Event
{
    private string _rsvpEmail;
    public string RsvpEmail => _rsvpEmail;

    public Reception(string title, string description, string date, string time, Address location, string rsvpEmail)
        : base(title, description, date, time, location)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return base.GetStandardDetails() + $", Event Type: Reception, RSVP Email: {_rsvpEmail}";
    }

    public override string GetShortDescription()
    {
        return $"Reception: {Title} on {Date} (RSVP: {_rsvpEmail})";
    }

    public override string GetEventType()
    {
        return "Reception";
    }
}