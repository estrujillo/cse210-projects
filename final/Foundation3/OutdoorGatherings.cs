class OutdoorGatherings : Event
{
    private string weatherForecast;

    public OutdoorGatherings(string title, string description, DateTime date, TimeSpan time, string streetAddress, string city, string state, string country, string weatherForecast): base(title, description, date, time, streetAddress, city, state, country)
    {
        this.weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nWeather Forecast: {weatherForecast}";
    }
}