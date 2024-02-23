class Event
{
protected string title;
    protected string description;
    protected DateTime date;
    protected TimeSpan time;
    protected Address address;

    public Event(string title, string description, DateTime date, TimeSpan time, string streetAddress, 
                 string city, string state, string country)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = new Address(streetAddress, city, state, country);
    }

    public virtual string GetStandardDetails()
    {
        return $"Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time}\nAddress: {address}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"Type: {GetType().Name}\nTitle: {title}\nDate: {date.ToShortDateString()}";
    }
    }