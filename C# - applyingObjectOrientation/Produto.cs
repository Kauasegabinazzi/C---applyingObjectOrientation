
class Product
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

class StockOfProducts
{
    private List<Product> list { get; set; } = new List<Product>();

    public void Add(Product product)
    {
        list.Add((product));
        Console.WriteLine($"Product {product.Name} was add");
    }

    public void Display()
    {
        if (list.Count == 0)
        {
            Console.WriteLine("stock empty");
        }
        else
        {
            Console.WriteLine("List of products:");
            foreach (var product in list)
            {
                Console.WriteLine(product.ProductInfo);
            }
        }
    }
}

