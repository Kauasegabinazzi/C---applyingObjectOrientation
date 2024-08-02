namespace C____applyingObjectOrientation;

class Game
{
    public string Name { get; set; }
    public string Gender { get; set; }
    public int Year { get; set; }

    public Game(string name, string gender, int year)
    {
        Name = name;
        Gender = gender;
        Year = year;
    }
}

class GamesCatalog
{
    private List<Game> Games { get; set; }

    public bool EmptyCatalog => Games.Count == 0;

    public GamesCatalog()
    {
        Games = new List<Game>();
    }

    public void Add(string name, string gender, int year)
    {
        Game novoJogo = new Game(name, gender, year);
        Games.Add(novoJogo);
    }

    public void ListarJogos()
    {
        if (EmptyCatalog)
        {
            Console.WriteLine("Catalog is empty");
        }
        else
        {
            foreach (var game in Games)
            {
                Console.WriteLine($"Name: {game.Name}, Gender: {game.Gender}, Year: {game.Year}");
            }
        }
    }
}


