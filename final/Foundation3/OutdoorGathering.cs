public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public string WeatherForecast => _weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, Address location, string weatherForecast)
        : base(title, description, date, time, location)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return base.GetStandardDetails() + $", Event Type: Outdoor Gathering, Weather Forecast: {_weatherForecast}";
    }

    public override string GetShortDescription()
    {
        return $"Outdoor Gathering: {Title} on {Date} (Weather: {_weatherForecast})";
    }

    public override string GetEventType()
    {
        return "Outdoor Gathering";
    }
}