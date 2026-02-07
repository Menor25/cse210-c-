using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 (USA)
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "A100", 1000, 1));
        order1.AddProduct(new Product("Mouse", "M200", 25, 2));

        // Order 2 (Nigeria) 
        Address address2 = new Address("456 Maple Ave", "Lagos", "ON", "Nigeria");
        Customer customer2 = new Customer("Jane Olu", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Keyboard", "K300", 50, 1));
        order2.AddProduct(new Product("Monitor", "D400", 200, 2));
        order2.AddProduct(new Product("HDMI Cable", "C500", 10, 3));

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {

            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());

            Console.WriteLine($"Total Cost: ${order.CalculateTotalCost()}");

            Console.WriteLine();
        }
    }
}