using System;

public class Product
{
    private string _name;
    private double _price;
    private int _productId;
    private int _quantity;

    public Product(string name, double price, int productId, int quantity)
    {
        _name = name;
        _price = price;
        _productId = productId;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public double GetPrice()
    {
        return _price;
    }

    public int GetProductId()
    {
        return _productId;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public double GetTotalPrice()
    {
        return _price * _quantity;
    }
}