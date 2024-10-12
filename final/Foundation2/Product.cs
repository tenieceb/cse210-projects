using System.Reflection.Metadata.Ecma335;

public class Product
{
    string _productName;
    double _productCode;
    double _price;
    double _productQuantity;

    public Product(string productName, int productCode, double price, double productQuantity )
    {
        _productName = productName;
        _productCode = productCode;
        _price = price;
        _productQuantity = productQuantity;
    }

    public double CalculateProductTotal()
    {
        double productTotal =  _price * _productQuantity;
        return productTotal;
    }

    public string GetProductText()
    {
        string productText = $"Product Name: {_productName} Product Code: {_productCode} Quantity: {_productQuantity}  ${CalculateProductTotal} ";
        return productText;
    }
}
