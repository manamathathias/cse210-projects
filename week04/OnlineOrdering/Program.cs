using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ONLINE ORDERING SYSTEM");
        Console.WriteLine("======================");

        // CREATE CUSTOMER ADDRESS
        Address address1 = new Address(
            "15 Lagos Street",
            "Ikeja",
            "Lagos State",
            "Nigeria"
        );

        // CREATE CUSTOMER
        Customer customer1 = new Customer(
            "Mathias Abbas",
            address1
        );

        // CREATE PRODUCTS
        Product product1 = new Product(
            "Laptop",
            "P001",
            500,
            1
        );

        Product product2 = new Product(
            "Mouse",
            "P002",
            20,
            2
        );

        // CREATE ORDER
        Order order1 = new Order(customer1);

        // ADD PRODUCTS TO ORDER
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // DISPLAY ORDER
        order1.DisplayOrder();
    }
}