public class Order
{
    Customer _customer;
    List<Product> _products = new List<Product>();

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.TotalCost();
        }

        if (_customer.LivesInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }

        return totalCost;

    }

    public string PackingLabel()
    {

        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"Product ID: {product.GetProductId()} | Product Name: {product.GetProductName()} | {product.GetProductPrice()} | {product.GetProductQuantity()} \n";
        }

        return packingLabel;
    }

    public string ShippingLabel()
    {
        string shippingLabel = $"Customer Name: {_customer.GetCustomerName()} | {_customer.GetFullAddress()} ";

        return shippingLabel;
    }

}