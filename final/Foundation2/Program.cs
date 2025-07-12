using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Micheal Jackson", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Apple", "1", 1, 5));
        order1.AddProduct(new Product("Banana", "2", 2, 3));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalOrderPrice()}");
    }
}