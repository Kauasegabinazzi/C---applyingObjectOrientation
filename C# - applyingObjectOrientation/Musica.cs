class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;

    public void ExibirFicha()
    {
        Console.WriteLine($"nome: {nome}");
        Console.WriteLine($"artista: {artista}");
        Console.WriteLine($"duracao: {duracao}");

        if (disponivel)
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
        Console.WriteLine($"o nome do artista e o nome é {this.artista} e {this.nome}");
    }
}
