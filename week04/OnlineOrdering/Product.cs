using System.Dynamic;

public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double TotalCost()
    {
        return _price * _quantity;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public string GetProductName()
    {
        return _name;
    }
    public double GetProductPrice()
    {
        return _price;
    }
    public int GetProductQuantity()
    {
        return _quantity; 
    }

}