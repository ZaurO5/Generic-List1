public abstract class Product
{
    public string Name { get; }
    public decimal Price { get; }
    public int Count { get; set; }

    protected Product(string name, decimal price, int count)
    {
        Name = name;
        Price = price;
        Count = count;
    }
}