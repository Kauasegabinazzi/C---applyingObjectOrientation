class Conta
{
    public string titular = "";
    public int idConta = 0;
    public float saldo = 0;
    public int senha  = 0;

    public void ExibirInformacoes()
    {
        Console.WriteLine($"titular: {this.titular}");
        Console.WriteLine($"saldo: {this.saldo}");
    }
}