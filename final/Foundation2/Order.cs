using System.Net.Http.Headers;

public class Order
{

    List<Product> _products= new List<Product>();
    
    Customer _customerName;
    double _shippingcost;

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
        SetShippingCost();
        totalWithShipping += SetShippingCost();
        return totalWithShipping;
        

    }

    public double SetShippingCost()
    {
        _customerName.IsInUSA();
        if (_customerName.IsInUSA() is true)
        {
           return  _shippingcost = 5;
        }
        else return _shippingcost = 35;


    }

    public void CreatePackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine(product.GetProductText());
            
        }
        Console.WriteLine($"Shipping: ${SetShippingCost()}");
        Console.WriteLine($"Total: ${CalculateTotalWithShipping()}");

    }
    
    public string CreateShippingLabel()
    {
        string shippingLabel = $"{_customerName.GetCustomerInfoText()}";
        return shippingLabel;

    }

}