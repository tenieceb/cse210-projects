using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Address customer1Address = new Address("123 Sesame", "New York", "NY", "USA");
        Customer customer1 = new Customer(customer1Address,"Bob Dylan");
        List<Product> customer1Products = new List<Product>();
        Product product1 = new Product("guitar      ", 1234, 2.50, 1);
        Product product2 = new Product("guitar pick", 2222, 0.50, 10);
        Product product3 = new Product("guitar stand", 2314, 5.00, 1);
        customer1Products.Add(product1);
        customer1Products.Add(product2);
        customer1Products.Add(product3);
        Order order1 = new Order(customer1, customer1Products);
    
        Console.WriteLine("Order    1");
        Console.WriteLine($"\nShipping Label: \n{order1.CreateShippingLabel()}");
        Console.WriteLine($"\nPacking Label: \n{order1.CreatePackingLabel()}");
        Console.WriteLine($"Order total: ${order1.CalculateTotalWithShipping().ToString("N" + 2)}");

        Address customer2Address = new Address("543 Street", "Paris", "Île-de-France", "France");
        Customer customer2 = new Customer(customer2Address,"Lizette Deveraux");
        List<Product> customer2Products = new List<Product>();
        customer2Products.Add(product1);
        customer2Products.Add(product2);
        customer2Products.Add(product3);
        Order order2 = new Order(customer2, customer2Products);
        Console.WriteLine("_______________________________________________________");
        Console.WriteLine("\nOrder    2");

        Console.WriteLine($"\nShipping Label: \n{order2.CreateShippingLabel()}");
        Console.WriteLine($"\nPacking Label: \n{order2.CreatePackingLabel()}");
        Console.WriteLine($"Order total: ${order2.CalculateTotalWithShipping().ToString("N" + 2)}");
        


    }
}