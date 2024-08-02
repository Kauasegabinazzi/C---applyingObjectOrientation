using System.Collections.Generic;

namespace C____applyingObjectOrientation.Classes;

class Playlist
{
    private List<Musica> Musicas = new List<Musica>();
    public int Ordem { get; set; }
    public string Tema { get; set; }

    public void Add(Musica musica)
    {
        Musicas.Add(musica);
    }
}

