using System;

class Program
{
    static void Main(string[] args)
    {
        // ---------------- CUSTOMER 1 ----------------
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", 101, 800, 1));
        order1.AddProduct(new Product("Mouse", 102, 25, 2));

        // ---------------- CUSTOMER 2 ----------------
        Address address2 = new Address("45 Queen St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Emily Clark", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", 201, 500, 1));
        order2.AddProduct(new Product("Case", 202, 20, 3));

        // ---------------- DISPLAY ORDER 1 ----------------
        Console.WriteLine("========== ORDER 1 ==========");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}\n");

        // ---------------- DISPLAY ORDER 2 ----------------
        Console.WriteLine("========== ORDER 2 ==========");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}