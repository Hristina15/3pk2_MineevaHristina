// See https://aka.ms/new-console-template for more information
using ConsoleApp10;

internal class Program
{
    static void Main(string[] args)
    {
        Jeans jeans1 = new Jeans() { Name = "Бананы", colour = "Чёрный", Price = 2000 };
        Jeans jeans2 = new Jeans() { Name = "Клёш", colour = "Голубой", Price = 1700 };

        Sweater sweater1 = new Sweater() { Name = "СвитШот", Size = 36, Price = 800 };
        Sweater sweater2 = new Sweater() { Name = "Толстовка", Size = 44, Price = 1100 };

        Footwear footwear1 = new Footwear() { Name = "Тапочки", Type = "Домашние", Price = 3299 };
        Footwear footwear2 = new Footwear() { Name = "Сапоги", Type = "Уличные", Price = 1499 };


        Product[] products = { jeans1, jeans2, sweater1, sweater2, footwear1, footwear2 };
        foreach (Product p in products) { p.GetDiscount(); };

        Client client = new Client()
        {
            Name = "Бегемотова АТ"
        };

        client.Buy(Store.SaveOrder(products[3], client));

        Console.WriteLine($"{client.Name} приобрёл товар " + $"на сумму {client.AllPurshares}");

        Client client1 = new Client()
        {
            Name = "Солнцева ВА"
        };

        client1.Buy(Store.SaveOrder(products[4], client1));

        Console.WriteLine($"{client1.Name} приобрёл товар " + $"на сумму {client1.AllPurshares}");
    }
}
