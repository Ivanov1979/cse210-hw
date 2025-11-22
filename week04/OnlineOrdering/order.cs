using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Total price = sum(product total) + shipping
    public decimal GetTotalPrice()
    {
        decimal subtotal = 0;

        foreach (Product product in _products)
        {
            subtotal += product.GetTotalCost();
        }

        decimal shippingCost = _customer.LivesInUSA() ? 5m : 35m;

        return subtotal + shippingCost;
    }

    // Packing label: list name + product id for each product
    public string GetPackingLabel()
    {
        string label = "PACKING LABEL\n";

        foreach (Product product in _products)
        {
            label += $"- {product.GetName()} (ID: {product.GetProductId()})\n";
        }

        return label;
    }

    // Shipping label: customer name + full address
    public string GetShippingLabel()
    {
        string label = "SHIPPING LABEL\n";
        label += _customer.GetName() + "\n";
        label += _customer.GetAddress().GetFullAddress();
        return label;
    }
}
