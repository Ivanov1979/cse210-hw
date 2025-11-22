using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    // Uses the Address object to decide if the customer lives in the USA
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
}
