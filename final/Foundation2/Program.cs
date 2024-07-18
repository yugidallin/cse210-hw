using System;

class Program
{
    static void Main(string[] args)
    {
        // Create products
        Product product1 = new Product("Laptop", "P001", 999.99m, 1);
        Product product2 = new Product("Mouse", "P002", 29.99m, 2);
        Product product3 = new Product("Keyboard", "P003", 59.99m, 1);

        // Create addresses
        Address usAddress = new Address("123 Main St", "New York", "NY", "USA");
        Address nonUsAddress = new Address("456 Maple Rd", "Toronto", "ON", "Canada");

        // Create customers
        Customer usCustomer = new Customer("John Doe", usAddress);
        Customer nonUsCustomer = new Customer("Jane Smith", nonUsAddress);

        // Create orders
        Order order1 = new Order(usCustomer);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(nonUsCustomer);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display order information
        DisplayOrderInfo(order1);
        Console.WriteLine();
        DisplayOrderInfo(order2);
    }

    static void DisplayOrderInfo(Order order)
    {
        Console.WriteLine("Order Details:");
        Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():F2}");
        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order.GetShippingLabel());
    }
    
}