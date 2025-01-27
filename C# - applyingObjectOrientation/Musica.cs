﻿using C____applyingObjectOrientation;

class Musica
{
    public Musica(Banda artista, string name)
    {
        Artista = artista;
        Name = name;
    }

    public string Name { get; set; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string ResumeInfo =>  $"A musica {Name} é da banda topCool";
    public Genero genero = new Genero();

    //public void WriteDiponivel(bool value)
    //{
    //    disponivel = value;
    //}

    //public bool leDisponicel()
    //{
    //    return disponivel;
    //}

    public void ExibirFicha()
    {
        Console.WriteLine($"nome: {Name}");
        Console.WriteLine($"artista: {Artista.Name}");
        Console.WriteLine($"duracao: {Duracao}");

        if (Disponivel)
        {
            Console.WriteLine($"A musica está disponivel");
        }
        else
        {
            Console.WriteLine($"A musica não está disponivel");
        }
    }

    public void ExibiNomeArtista()
    {
        Console.WriteLine($"o nome do artista e o nome é {this.Artista} e {this.Name}");
    }
}
