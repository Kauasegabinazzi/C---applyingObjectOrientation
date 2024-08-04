namespace C____applyingObjectOrientation;

class Podcast
{
    public string Name { get; }
    public string Host {  get; }
    public int TotalEpisodeos => episodeoList.Count;
    private List<Episodeo> episodeoList = new();

    public Podcast(string name, string host)
    {
        Name = name;
        Host = host;
    }

    public void Add(Episodeo episodeo)
    {
        episodeoList.Add(episodeo);
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Podcat {this.Name} for {this.Host} \n");
        foreach(Episodeo episodeo in episodeoList.OrderBy(e => e.Order))
        {
            Console.WriteLine(episodeo.Resume);
        }
        Console.WriteLine($"\n\n Total episodeos is {this.TotalEpisodeos}" );
    }
}

