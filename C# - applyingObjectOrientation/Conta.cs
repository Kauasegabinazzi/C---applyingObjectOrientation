﻿class Conta
{
    public string Titular { get; set; }
    public int IdConta { get; set; }
    public float Saldo { get; set; }
    public int Senha { get; set; }
    public int Soma(int a, int b) => a + b;
    public void ExibirInformacoes()
    {
        Console.WriteLine($"titular: {this.Titular}");
        Console.WriteLine($"saldo: {this.Saldo}");
    }
}