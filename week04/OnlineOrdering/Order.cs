public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product products)
    {
        _products.Add(products);
    }

    public int getTotal()
    {
        int sum = 0;

        foreach (Product product in _products)
        {
            sum += product.TotalCost();
        }

        sum += getShippingCost();
        return sum;
    }
    public int getShippingCost()
    {
        if (_customer.LivesInUSA())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    public string GetLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"- {product.GetName()}, ID: {product.GetId()}\n";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n {_customer.GetCustomerAddress().GetAddress()}";
    }
}
