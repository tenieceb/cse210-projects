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
        string customerInfoText = $"{_customerName} \n {_address}";
        return customerInfoText;
    }

    public bool IsInUSA()
    {  
         return _address.IsInUSA();
    }
}