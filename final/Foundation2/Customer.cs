public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetCustomerInfo()
    {
        return $"{_name}, Address: {_address.GetFullAddress()}";
    }

    public bool IsCustomerInUSA()
    {
        return _address.IsInUSA();
    }
}