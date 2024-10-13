public class Address
{
    string _streetAddress;
    string _cityAddress;
    string _state;
    string _country;

//     constructors:
    public Address()
    {}
    public Address(string streetAddress, string cityAddress, string state, string country)
    {
        _streetAddress = streetAddress;
        _cityAddress = cityAddress;
        _state = state;
        _country = country;

    }
 
    public bool IsInUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

    public string GetAddressText()
    {
        string addressText =$"{_streetAddress}\n{_cityAddress} \n{_state}, {_country}" ;
        return addressText;
    }
}