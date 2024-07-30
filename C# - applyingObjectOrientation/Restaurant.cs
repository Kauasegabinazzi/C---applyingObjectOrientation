namespace C____applyingObjectOrientation;

class ProductRestaurant
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

class Table
{
    public int Number { get; set; }
    public List<Order> Order { get; set; } = new List<Order>();
}

class Order
{
    public ProductRestaurant Product { get; set; }
    public int Quantity { get; set; }
}

class Menu
{
    public List<ProductRestaurant> Itens { get; set; } = new List<ProductRestaurant>();
}

class Restaurante
{
    public List<Table> Tables { get; set; } = new List<Table>();
    public Menu Menu { get; set; } = new Menu();
}