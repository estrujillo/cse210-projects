using System;

class Program
{
    static void Main()
    {
        // Creating customers
        Address customerAddress1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Doe", customerAddress1);

        Address customerAddress2 = new Address("456 Oak St", "Other City", "NY", "USA");
        Customer customer2 = new Customer("Jane Smith", customerAddress2);

        // Creating products
        Product product1 = new Product("Product 1", "P001", 10, 2);
        Product product2 = new Product("Product 2", "P002", 15, 3);
        Product product3 = new Product("Product 3", "P003", 20, 1);

        // Creating orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display packing label, shipping label, and total price for each order
        DisplayOrderDetails(order1);
        Console.WriteLine();
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.CalculateTotalPrice()}");
    }
}