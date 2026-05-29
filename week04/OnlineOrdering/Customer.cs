public class Customer
{
    private string _name;
    private Address _address;
    public Customer(Address add, string name)
    {
        _name = name;

        _address = add;
    }
    public string getFullAddress()
    {
        return _address.fullAddress();
    }
    public string getName()
    {
        return _name;
    }
    public bool isUsa()
    {
        return _address.isUsa();
    }
}