using System;

public class Customer
{
    private string _name;
    
    private Address address;

    public Customer(string name)
    {
        _name = name;
    }

    public void SetAddress(string street, string city, string state, string country)
    {
        address = new Address(street, city, state, country);
    }

    public string GetAddress()
    {
        return address.GetAddress();
    }

    public string GetName()
    {
        return _name;
    }

    public bool IsUSA()
    {
        if (address.IsUSA())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}