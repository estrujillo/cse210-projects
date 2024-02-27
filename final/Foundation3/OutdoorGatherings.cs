class OutdoorGatherings : Event
{
    private string _weatherForecast;

    public OutdoorGatherings(string title, string description, DateTime date, TimeSpan time, string streetAddress, string city, string state, string country, string weatherForecast): base(title, description, date, time, streetAddress, city, state, country)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nWeather Forecast: {_weatherForecast}";
    }
}