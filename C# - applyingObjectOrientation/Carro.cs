using static System.Runtime.InteropServices.JavaScript.JSType;

class Carro
{
    public string Fabricante { get; set; }
    public string Model { get; set; }
    public int Year
    {
        get => Year; 
        set
        {
            if (value < 1960 || value > 2023)
            {
                Console.WriteLine("Está errado");
            }
            else
            {
                Year = value;
            }
        }
    }
    public string DescricaoDetalhada => $"Model is : {this.Fabricante} {this.Model} {this.Year}";

    public void acelerar()
    {
        Console.WriteLine("está acelerando");
    }

    public void frear()
    {
        Console.WriteLine("está freando");
    }

    public void buzinar()
    {
        Console.WriteLine("está buzinando");
    }
}