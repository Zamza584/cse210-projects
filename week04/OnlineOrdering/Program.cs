using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Online ordering program\n");

        // 1st order
        List<Product> products1 = new List<Product>();
        Product product1 = new Product("headphones", "10", 60.50, 2);
        Product product2 = new Product("Iphone", "11", 1000.70, 1);

        products1.Add(product1);
        products1.Add(product2);

        Address address1 = new Address("parkway 12", "Lima", "Lima", "Peru");

        Customer customer1 = new Customer("Sam", address1);

        Order order1 = new Order(customer1, products1);

        Console.Write(order1.PackingLabel());
        Console.WriteLine($"Total Cost: {order1.CalculateTotalCost()}");
        Console.WriteLine($"{order1.ShippingLabel()} \n");

        // 2nd order
        List<Product> products2 = new List<Product>();
        Product product3 = new Product("Summer Shorts", "115", 20.50, 10);
        Product product4 = new Product("surfing board", "116", 500.50, 3);

        products2.Add(product3);
        products2.Add(product4);

        Address address2 = new Address("Santa street 12", "Lima", "Lima", "Peru");

        Customer customer2 = new Customer("Dante", address2);

        Order order2 = new Order(customer2, products2);

        Console.Write(order2.PackingLabel());
        Console.WriteLine($"Total Cost: {order2.CalculateTotalCost()}");
        Console.WriteLine($"{order2.ShippingLabel()} \n");



    }
}