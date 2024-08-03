namespace C____applyingObjectOrientation;

class Episodeo
{
    public int Order { get; }
    public string Title { get; }
    public int Duration { get; }
    public string Resume => $"{this.Order}. {this.Title} - {this.Duration} - {string.Join(", ", Guests)}";
    private List<string> Guests = new List<string>();
    public Episodeo(int order, string title, int duration)
    {
        Order = order;
        Title = title;
        Duration = duration;
    }

    public void Add(string guest)
    {
        Guests.Add(guest);
    }
}

