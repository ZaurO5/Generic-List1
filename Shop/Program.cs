using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Shop shop = new Shop();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add product");
            Console.WriteLine("2. Sell product");
            Console.WriteLine("3. Exit");
            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddProduct(shop);
                    break;

                case "2":
                    SellProduct(shop);
                    break;

                case "3":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    private static void AddProduct(Shop shop)
    {
        Console.Write("Enter product: ");
        string name = Console.ReadLine();
        decimal price = ReadDecimal("Enter price: ");
        int count = ReadInt("Enter count: ");

        if (price != -1 && count != -1)
        {
            Console.Write("Enter product type (c for Coffee, t for Tea): ");
            string type = Console.ReadLine().ToLower();

            if (type == "c")
            {
                shop.AddProduct(new Coffee(name, price, count));
            }
            else if (type == "t")
            {
                shop.AddProduct(new Tea(name, price, count));
            }
            else
            {
                Console.WriteLine("Invalid product type.");
            }
        }
    }

    private static void SellProduct(Shop shop)
    {
        Console.Write("Enter product to sell: ");
        string productName = Console.ReadLine();
        int sellCount = ReadInt("Enter product count to sell: ");

        if (sellCount != -1)
        {
            shop.SellProduct(productName, sellCount);
        }
    }

    private static decimal ReadDecimal(string message)
    {
        decimal result;
        Console.Write(message);
        if (!decimal.TryParse(Console.ReadLine(), out result))
        {
            Console.WriteLine("Invalid input.");
            return -1;
        }
        return result;
    }

    private static int ReadInt(string message)
    {
        int result;
        Console.Write(message);
        if (!int.TryParse(Console.ReadLine(), out result))
        {
            Console.WriteLine("Invalid input.");
            return -1;
        }
        return result;
    }
}
