class Receptions : Event
{
    private string _rsvpEmail;

    public Receptions(string title, string description, DateTime date, TimeSpan time, string streetAddress, string city, string state, string country, string rsvpEmail) : base(title, description, date, time, streetAddress, city, state, country)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nRSVP Email: {_rsvpEmail}";
    }
}