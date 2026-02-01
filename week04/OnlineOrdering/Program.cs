using System;

class Program
{
    static void Main(string[] args)
    {
        // First order (USA customer)
        Address address1 = new Address(
            "123 Main St",
            "Springfield",
            "IL",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Notebook", "A101", 3.50, 4));
        order1.AddProduct(new Product("Pen", "B205", 1.25, 10));

        // Display Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice():F2}");
        Console.WriteLine("-----------------------------------");

        
        // Second order (International customer)
        Address address2 = new Address(
            "45 Queen Street",
            "Lekki",
            "Lagos",
            "Nigeria"
        );

        Customer customer2 = new Customer("Nwakwuruibe Bright", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Backpack", "C333", 45.00, 1));
        order2.AddProduct(new Product("Water Bottle", "D404", 12.99, 2));

        // Display Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice():F2}");
    }
}
