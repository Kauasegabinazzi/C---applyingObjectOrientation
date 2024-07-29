Musica musica = new Musica();
musica.nome = "Teste";
musica.artista = "teste2";
musica.duracao = 250;
musica.WriteDiponivel(true);

musica.ExibirFicha();


Conta conta = new Conta();
conta.titular = "Gui Lima";
conta.idConta = 1;
conta.saldo = 20.00f;
conta.senha = 1234;

conta.ExibirInformacoes();