using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in products)
        {
            totalCost += product.GetTotalCost();
        }

        if (customer.IsInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }

    return totalCost;
    }


    public string GetPackingLabel()
    {
        string label = "Packing List:\n";
        foreach (Product product in products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping To:\n{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
    }
}
