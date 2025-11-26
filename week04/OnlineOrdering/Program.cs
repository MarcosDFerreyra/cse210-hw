using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("Falucho 223", "Quilmes", "Buenos Aires", "Argentina");
        Customer customer = new Customer("Juan Gomez", address);

        Order order1 = new Order(customer);
        order1.AddProduct(new Product("Harina", "A1", 10, 3));
        order1.AddProduct(new Product("Azucar", "A2", 14, 5));
        order1.AddProduct(new Product("Manteca", "A3", 5, 2));

        string label = order1.GetLabel();
        Console.WriteLine($"List of Poducts:\n{label}");
        string Shipping = order1.GetShippingLabel();
        Console.WriteLine($"Shipping label:\n{Shipping}");
        int price = order1.getTotal();
        Console.WriteLine($"Total price Order 1: ${price}");

        Console.WriteLine("----------------------------------------");

        Address address2 = new Address("Main St 123", "New York", "NY", "USA");
        Customer customer2 = new Customer("Jhon Wick ", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Harina", "B1", 9, 2));
        order2.AddProduct(new Product("Azucar", "B2", 12, 4));
        order2.AddProduct(new Product("Gaseosa", "B3", 7, 3));

        string label2 = order2.GetLabel();
        Console.WriteLine($"List of Poducts:\n{label2}");
        string Shipping2 = order2.GetShippingLabel();
        Console.WriteLine($"Shipping label:\n{Shipping2}");
        int price3 = order2.getTotal();
        Console.WriteLine($"Total price Order 2: ${price3}");


    }
}