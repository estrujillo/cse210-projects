class Lectures : Event
{
    private string speaker;
    private int capacity;

    public Lectures(string title, string description, DateTime date, TimeSpan time, string streetAddress, 
                        string city, string state, string country, string speaker, int capacity)
        : base(title, description, date, time, streetAddress, city, state, country)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nSpeaker: {speaker}\nCapacity: {capacity}";
    }
}