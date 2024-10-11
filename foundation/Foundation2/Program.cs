using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses for the customers
        Address address1 = new Address("79 Vevay Dr", "Springfield", "IL", "USA");
        Address address2 = new Address("821 Mill St", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("Zachary Jones", address1);
        Customer customer2 = new Customer("Jeff Johnson", address2);

        // Create products for the first order
        Product product1A = new Product("Watch", "P001", 3.00m, 5);
        Product product2A = new Product("Phone", "P002", 10.00m, 2);

        // Create the first order and add products
        Order order1 = new Order(customer1);
        order1.AddProduct(product1A);
        order1.AddProduct(product2A);

        // Create products for the second order
        Product product1B = new Product("Tablet", "P003", 7.50m, 1);
        Product product2B = new Product("Echo Show", "P004", 2.25m, 10);

        // Create the second order and add products
        Order order2 = new Order(customer2);
        order2.AddProduct(product1B);
        order2.AddProduct(product2B);

        // Display order details for the first order
        Console.WriteLine($"Order 1 Total Cost: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();

        // Display order details for the second order
        Console.WriteLine($"Order 2 Total Cost: ${order2.CalculateTotalCost():F2}");
        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
    }
}