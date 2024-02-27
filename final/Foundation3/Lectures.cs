class Lectures : Event
{
    private string _speaker;
    private int _capacity;

    public Lectures(string title, string description, DateTime date, TimeSpan time, string streetAddress, 
                        string city, string state, string country, string speaker, int capacity)
        : base(title, description, date, time, streetAddress, city, state, country)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}