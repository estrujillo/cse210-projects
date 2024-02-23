using System;

class Order
{
   private Customer customer;
    private List<Product> products;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (var product in products)
        {
            label += $"{product.name} ({product.productId})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return customer.name + "\n" + customer.address.ToString();
    }

    public decimal CalculateTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (var product in products)
        {
            totalPrice += product.GetTotalCost();
        }
        // Add shipping cost
        if (customer.IsInUSA())
        {
            totalPrice += 5; // USA shipping cost
        }
        else
        {
            totalPrice += 35; // International shipping cost
        }
        return totalPrice;
    }
}