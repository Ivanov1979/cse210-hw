using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // ----- Customer 1 (USA) -----
        Address address1 = new Address(
            "123 Main Street",
            "Salt Lake City",
            "UT",
            "USA");

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LAP123", 999.99m, 1));
        order1.AddProduct(new Product("Wireless Mouse", "MOU456", 25.50m, 2));
        order1.AddProduct(new Product("USB-C Cable", "CAB789", 9.99m, 3));

        // ----- Customer 2 (International) -----
        Address address2 = new Address(
            "Av. Libertador 1010",
            "Buenos Aires",
            "Buenos Aires",
            "Argentina");

        Customer customer2 = new Customer("María González", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "HDP111", 75.00m, 1));
        order2.AddProduct(new Product("Webcam", "WEB222", 59.99m, 1));
        order2.AddProduct(new Product("Microphone", "MIC333", 120.00m, 1));

        // Put orders in a list (optional but nice)
        List<Order> orders = new List<Order> { order1, order2 };

        // ----- Display all orders -----
        int orderNumber = 1;
        foreach (Order order in orders)
        {
            Console.WriteLine("========================================");
            Console.WriteLine($"Order #{orderNumber}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();
            Console.WriteLine($"Total Price: ${order.GetTotalPrice():0.00}");
            Console.WriteLine("========================================");
            Console.WriteLine();

            orderNumber++;
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
