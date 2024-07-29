
class Produto
{
    private double price;
    private int stocks;
    public string Name { get; set; }
    public string Brand { get; set; }
    public double Price
    {
        get => price;
        set
        {
            if (value > 0)
                price = value;
            else
                price = 10;
        }
    }

    public int Stock
    {
        get => stocks;
        set
        {
            if (value > 0)
                stocks = value;
            else
                stocks = 0;
        }
    }

    public string ProductInfo => $"{this.Name} {this.Brand} - {this.Price}";

}

