using System;

class Program
{
    static void Main(string[] args)
    {
        // (USA)
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Order order1 = new Order("John Doe", address1);

        order1.addProduct("Laptop", 101, 1200.00, 1);
        order1.addProduct("Mouse", 102, 25.50, 2);
        order1.addProduct("Keyboard", 103, 45.00, 1);

        Console.WriteLine("");
        Console.WriteLine("Packing Label:");
        order1.packingLabel();

        Console.WriteLine("Shipping Label:");
        order1.shippingLabel();

        Console.WriteLine("Total Price:");
        Console.WriteLine($"${order1.getTotal():F2}");

        //(International)
        Address address2 = new Address("742 Evergreen Terrace", "Springfield", "Unknown", "Argentina");
        Order order2 = new Order("Jane Smith", address2);

        order2.addProduct("Phone", 201, 800.00, 1);
        order2.addProduct("Charger", 202, 20.00, 2);

        Console.WriteLine("");
        Console.WriteLine("Packing Label:");
        order2.packingLabel();

        Console.WriteLine("Shipping Label:");
        order2.shippingLabel();

        Console.WriteLine("Total Price:");
        Console.WriteLine($"${order2.getTotal():F2}");
    }
}