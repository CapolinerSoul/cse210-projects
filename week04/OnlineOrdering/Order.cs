using System.Dynamic;

public class Order
{
    private List<Product> _productList = new List<Product>();
    private Customer _customer;
    private double _total = 0;

    public Order(string name, Address address)
    {
        _customer = (new Customer(address, name));
    }

    public void addProduct(string name, int id, double price, int quant)
    {
        _productList.Add(new Product(name, id, quant, price));
    }

    public double getTotal()
    {
        foreach(Product pass in _productList)
        {
            _total += pass.getTotal();
        }
        if (_customer.isUsa())
        {
            return _total += 5;
        }
        else
            return _total += 35;
    }
    public void packingLabel()
    {
        foreach(Product passed in _productList)
        {
            Console.WriteLine(passed.getName());
            Console.WriteLine(passed.getId());
        }
        
    }
    public void shippingLabel()
    {
        Console.WriteLine(_customer.getName());
        Console.WriteLine(_customer.getFullAddress());
    }
}