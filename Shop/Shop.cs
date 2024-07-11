public class Shop
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
        Console.WriteLine($"Product '{product.Name}' added.");
    }

    public void SellProduct(string productName, int sellCount)
    {
        Product product = products.Find(p => p.Name == productName);
        if (product != null)
        {
            if (product.Count >= sellCount)
            {
                product.Count -= sellCount;
                Console.WriteLine($"Sold {sellCount} units of '{product.Name}'.");
            }
            else
            {
                Console.WriteLine($"Insufficient stock for '{product.Name}'.");
            }
        }
        else
        {
            Console.WriteLine($"Product '{productName}' not found.");
        }
    }
}