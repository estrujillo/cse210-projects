using System;

class Order
{
   private Customer _customer;
   private List<Product> _products = new List<Product>();

    public Order(List<Product> products, Customer customer)
    {
        _customer = customer;
        _products = products;
    }

    /*public void AddProduct(Product products)
    {
        _products.Add(products);
    }*/

    public string GetPackingLabel()
    {
        string _label = "";
        foreach (Product product in _products)
        {
            _label += $"{product.ToString()}\n";
        }
        return _label;
    }

    public string GetShippingLabel()
    {
        return $"Customer: {_customer.name}\nAddress:\n{_customer.address}";
    }

    public decimal CalculateTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (Product product in _products)
        {
            totalPrice += product.GetTotalCost();
        }
        //Add shipping cost
        if (_customer.LivesInUSA())
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