Musica musica = new Musica();
musica.Name = "Teste";
musica.Artista = "teste2";
musica.Duracao = 250;
musica.Disponivel = true;

musica.ExibirFicha();
Console.WriteLine(musica.ResumeInfo);


Conta conta = new Conta();
conta.Titular = "Gui Lima";
conta.IdConta = 1;
conta.Saldo = 20.00f;
conta.Senha = 1234;

conta.ExibirInformacoes();

List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

List<int> numerosPares = numeros.FindAll(numero => numero % 2 == 0);
numerosPares.ForEach(numero => Console.WriteLine(numero));