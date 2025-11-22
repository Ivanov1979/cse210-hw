using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    // Encapsulation: we control how the outside reads the data
    public string GetStreet()
    {
        return _street;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetStateProvince()
    {
        return _stateProvince;
    }

    public string GetCountry()
    {
        return _country;
    }

    // Check if the address is in the USA
    public bool IsInUSA()
    {
        string countryUpper = _country.Trim().ToUpper();
        return countryUpper == "USA" || countryUpper == "UNITED STATES" || countryUpper == "UNITED STATES OF AMERICA";
    }

    // Return the full address as a formatted string
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_stateProvince}\n{_country}";
    }
}
