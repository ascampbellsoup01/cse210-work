using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1678 Santa Ana Ave", "Costa Mesa", "CA", "USA");
        Address address2 = new Address("128-33, Macheon 1-dong", "Songpa-gu", "Seoul", "South Korea");

        Customer customer1 = new Customer("Blake Wright", address1);
        Customer customer2 = new Customer("Susan Storm", address2);

        Product product1 = new Product("Watch", "W001", 79.99, 2);
        Product product2 = new Product("Watch Strap", "W010", 29.99, 1);
        Product product3 = new Product("Watch Knob", "W005", 14.99, 3);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        List<Order> orders = new List<Order> { order1, order2 };
        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost():F2}");
            Console.WriteLine();
        }
    }
}