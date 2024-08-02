class Banda
{
    private List<Album> albums = new List<Album>();
    public string Name { get; }
    public void Add(Album album)
    {
        albums.Add(album);
    }

    public void Exibi()
    {
        Console.WriteLine($"Exibi a discogradia da banda {Name}");
        foreach (Album album in albums) { 
            Console.WriteLine($"Album : {album.Name} ({album.duracaoTotal})");
        }
    }

    public Banda(string name)
    {
        Name = name;
    }
}