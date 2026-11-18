using System;
using System.Collections.Generic;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        // Shipping: $5 within the USA, $35 otherwise
        total += _customer.LivesInUSA() ? 5 : 35;
        return total;
    }

    public void DisplayOrder()
    {
        Console.WriteLine("\nPACKING LABEL");
        foreach (Product product in _products)
        {
            Console.WriteLine($"  {product.GetName()} (ID: {product.GetProductId()})");
        }

        Console.WriteLine("\nSHIPPING LABEL");
        Console.WriteLine(_customer.GetName());
        Console.WriteLine(_customer.GetAddress());

        Console.WriteLine($"\nTotal Price: ${GetTotalPrice():0.00}");
    }
}