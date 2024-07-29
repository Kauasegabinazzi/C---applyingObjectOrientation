Musica musica = new Musica();
musica.Name = "Teste";
musica.Artista = "teste2";
musica.Duracao = 250;
musica.Disponivel = true;

musica.ExibirFicha();
Console.WriteLine(musica.ResumeInfo);


Conta conta = new Conta();
conta.titular = "Gui Lima";
conta.idConta = 1;
conta.saldo = 20.00f;
conta.senha = 1234;

conta.ExibirInformacoes();