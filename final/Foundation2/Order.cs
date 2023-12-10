using System;

public class Order
{
    private Customer customer;
    private double _totalPrice;

    private List<Product> _products = new List<Product>();

    public void DisplayShippingLabel()
    {
        Console.WriteLine();
        Console.WriteLine(customer.GetName());
        Console.WriteLine(customer.GetAddress());
    }

    public void DisplayPackagingLabel()
    {
        Console.WriteLine("\n|  Item  |  Price  |  Product ID  |  Quantity  |");
        foreach (Product product in _products)
        {
           Console.WriteLine($"| { product.GetName()} |  {product.GetPrice()}   |      {product.GetProductId()}      |     {product.GetQuantity()}      |");
        }
    }

    public string GetTotal()
    {
        foreach (Product product in _products)
        {
            _totalPrice += product.GetTotalPrice();
        }
        AddFee();
        return _totalPrice.ToString("0.00");
    }

    public void AddFee()
    {
        if (customer.IsUSA())
        {
            _totalPrice += 5;
        }
        else
        {
            _totalPrice += 35;
        }
    }

    public void CreateCustomer(string name)
    {
        customer = new Customer(name);
    }
    
    public void AddProduct(string name, double price, int productId, int quantity)
    {
        _products.Add(new Product(name, price, productId, quantity));
    }

    public void CreateAddress(string street, string city, string state, string country)
    {
        customer.SetAddress(street, city, state, country);
    }
}