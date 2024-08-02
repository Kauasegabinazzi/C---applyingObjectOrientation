//Musica musica = new Musica();
//musica.Name = "Teste";
//musica.Artista = "teste2";
//musica.Duracao = 250;
//musica.Disponivel = true;

//musica.ExibirFicha();
//Console.WriteLine(musica.ResumeInfo);


//Conta conta = new Conta();
//conta.Titular = "Gui Lima";
//conta.IdConta = 1;
//conta.Saldo = 20.00f;
//conta.Senha = 1234;

//conta.ExibirInformacoes();

//List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//List<int> numerosPares = numeros.FindAll(numero => numero % 2 == 0);
//numerosPares.ForEach(numero => Console.WriteLine(numero));

//Holder t = new();
//Account c = new();

//t.Name = "teste";
//t.Cpf = "878909890";
//t.Adress = "Adress test";

//c.Holder = t;
//c.Agency = 1;
//c.AccountNumber = 2234;
//c.Balance = 10000000.0;
//c.Limit = 100000.0;

//Console.WriteLine($"Name: {c.Holder.Name}");
//Console.WriteLine($"CPF: {c.Holder.Cpf}");
//Console.WriteLine($"Adress: {c.Holder.Adress}");

using C____applyingObjectOrientation;

Banda queen = new Banda("queen");

Album album = new Album("The opera");

Musica musica = new Musica(queen, "Love of my live")
{
    Duracao = 210,
    Disponivel = true,
};

album.Add(musica);
queen.Add(album);

album.Exibir();
queen.Exibi();
musica.ExibirFicha();