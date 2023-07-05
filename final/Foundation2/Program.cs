using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order(new Customer("Aaron Lamoreaux", new Address("1113 Dawn Valley Drive", "North Las Vegas", "NV", "USA")));
        order1.NewProducts(new Product("14 Pack of Socks", 1, 7, 1));
        order1.NewProducts(new Product("T-Shirt", 2, 10.00, 2));

        order1.PackingLabel();
        order1.ShippingLabel();
        Console.WriteLine($"Total price: {order1.OrderPrice()}\n\n");

        Order order2 = new Order(new Customer("Sherlock Holmes", new Address("221b Baker Street", "Marylebone", "London", "UK")));
        order2.NewProducts(new Product("Detective's hat", 1, 1.50, 1));
        order2.NewProducts(new Product("Fleece Jacket", 1, 24.00, 1));
        order2.NewProducts(new Product("Smoke pipe", 2, 4, 1));

        order2.PackingLabel();
        order2.ShippingLabel();
        Console.WriteLine($"Total price: {order2.OrderPrice()}");

    }
}