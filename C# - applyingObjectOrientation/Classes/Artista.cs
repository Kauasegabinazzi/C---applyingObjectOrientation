

namespace C____applyingObjectOrientation.Classes;

class Artista
{
    public string Name { get; set; }
    public string Biografia { get; set; }

    private List<Album> Albums = new List<Album>();

    public Artista(string name, string biografia)
    {
        Name = name;
        Biografia = biografia;
    }

    public void Add(Album album)
    {
        Albums.Add(album);
    }
}

