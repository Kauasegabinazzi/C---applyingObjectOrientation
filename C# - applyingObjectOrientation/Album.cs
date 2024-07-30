class Album
{
    private List<Musica> list = new List<Musica>();
    public string Name { get; set; }
    public int duracao { get; set; }

    public void Add(Musica musica)
    {
        list.Add(musica);
    }
}
