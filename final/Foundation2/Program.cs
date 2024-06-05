using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address usaAddress = new Address("911 What's your emergency St", "Atlanta", "GA", "USA");
        Address nonUsaAddress = new Address("419 EFCC St", "Lekki", "LAG", "Nigeria");

        Customer usaCustomer = new Customer("John Doe", usaAddress);
        Customer nonUsaCustomer = new Customer("Alice Smith", nonUsaAddress);

        Order order1 = new Order(usaCustomer);
        order1.AddProduct(new Product("Product1", "P1", 10, 2));
        order1.AddProduct(new Product("Product2", "P2", 15, 1));

        Order order2 = new Order(nonUsaCustomer);
        order2.AddProduct(new Product("Product3", "P3", 20, 3));

        Console.WriteLine();
        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Order 1 Total Price: $ {order1.CalculateTotalPrice()}");
        Console.WriteLine();

        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Order 2 Total Price: $ {order2.CalculateTotalPrice()}");
        Console.WriteLine();
    }
}
