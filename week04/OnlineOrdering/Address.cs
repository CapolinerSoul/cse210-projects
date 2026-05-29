public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string address, string city, string stapro, string country)
    {
        _city = city;
        _street = address;
        _stateOrProvince = stapro;
        _country = country;
    }
    public string fullAddress()
    {
        return ($"{_street},\n{_city},\n{_stateOrProvince},\n{_country}");
    }

    public bool isUsa()
    {
        if ((_country.Contains("USA", StringComparison.OrdinalIgnoreCase))||(_country.Contains("United states", StringComparison.OrdinalIgnoreCase)))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}