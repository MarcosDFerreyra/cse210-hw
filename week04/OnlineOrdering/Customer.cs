public class Customer
{
    private string _custumersName;
    private Address _address;

    public Customer(string custumersName, Address address)
    {
        _custumersName = custumersName;
        _address = address;
    }


    public Address GetCustomerAddress()
    {
        return _address;
    }

    public bool LivesInUSA()
    {
        return _address.isUSA();
    }

    public string GetName() => _custumersName;
}