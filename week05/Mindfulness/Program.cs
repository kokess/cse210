using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Order 1 (USA customer)
        Address address1 = new Address(
            "123 Main Street",
            "Dallas",
            "TX",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        List<Product> products1 = new List<Product>
        {
            new Product("Laptop", "P1001", 900.00, 1),
            new Product("Mouse", "P1002", 25.00, 2)
        };

        Order order1 = new Order(products1, customer1);

        // Order 2 (International customer)
        Address address2 = new Address(
            "45 King Road",
            "Toronto",
            "ON",
            "Canada"
        );

        Customer customer2 = new Customer("Emily Brown", address2);

        List<Product> products2 = new List<Product>
        {
            new Product("Headphones", "P2001", 80.00, 1),
            new Product("Keyboard", "P2002", 60.00, 1),
            new Product("USB Cable", "P2003", 10.00, 3)
        };

        Order order2 = new Order(products2, customer2);

        // Display Order 1
        Console.WriteLine("ORDER 1");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}");

        Console.WriteLine(new string('-', 40));

        // Display Order 2
        Console.WriteLine("ORDER 2");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}");
    }
}
