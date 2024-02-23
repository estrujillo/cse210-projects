class Receptions : Event
{
    private string rsvpEmail;

    public Receptions(string title, string description, DateTime date, TimeSpan time, string streetAddress, string city, string state, string country, string rsvpEmail) : base(title, description, date, time, streetAddress, city, state, country)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nRSVP Email: {rsvpEmail}";
    }
}