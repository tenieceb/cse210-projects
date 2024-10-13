public class Customer
{

    Address _address;
    string _customerName;


    public Customer(string customerName)
    {
        _customerName = customerName;
    }
    public Customer(Address address, string customerName)
    {
        _address = address;
        _customerName = customerName;

    }
    
    public string GetCustomerInfoText()
    {
        string addressText = _address.GetAddressText();
        string customerInfoText = $"{_customerName} \n{addressText}";
        return customerInfoText;
    }

    public bool IsInUSA()
    {  
       if (_address.IsInUSA() is true)
       {
        return true;
       }
       else
       {
        return false;
       }
    }
}