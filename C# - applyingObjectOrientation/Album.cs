class Album
{
    private List<Musica> list = new List<Musica>();
    public string Name { get; set; }
    public int duracaoTotal => list.Sum(song => song.Duracao);

    public void Add(Musica musica)
    {
        list.Add(musica);
    }

    public void Exibir()
    {
        Console.WriteLine($"List of Songs of Album {this.Name}");
        foreach (var musica in list)
        {
            Console.WriteLine($"Songs: {musica.Name}");
        }
        Console.WriteLine($"Total duração do album : {this.duracaoTotal}");
    }
}
