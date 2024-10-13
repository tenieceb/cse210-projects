using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;

public class Order
{

    List<Product> _products= new List<Product>();
    
    Customer _customerName;
    double _shippingcost;
    string _packingLabel;
    public Order (Customer customer, List<Product> products)
    {
        _products = products;
        _customerName = customer;
    }

    public double CalculateTotalWithShipping()
    {
        double totalWithShipping = 0;
        foreach (Product product in _products)
        {
            totalWithShipping += product.CalculateProductTotal();
        }
        totalWithShipping += SetShippingCost();
        return totalWithShipping;
        

    }

    public double SetShippingCost()

    {
        if (_customerName.IsInUSA())
        {
            _shippingcost = 5.00;
        }
        else if (_customerName.IsInUSA() is false)
        {
            _shippingcost = 35.00;
        }
        return _shippingcost;

    }

    public string CreatePackingLabel()
    {   

        foreach (Product product in _products)
        {
            _packingLabel += product.GetProductText() + "\n";
        }
        return _packingLabel;

    }
    
    public string CreateShippingLabel()
    {
        string shippingLabel = $"{_customerName.GetCustomerInfoText()}";
        return shippingLabel;

    }

}