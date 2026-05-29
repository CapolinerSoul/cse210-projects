using System.Dynamic;

public class Product
{
    private string _productName;
    private int _productId;
    private int _quantity;
    private double _price;
    private double _totalcost;

    public Product(string name, int id, int quant, double price)
    {
        _productName = name;
        _productId = id;
        _quantity = quant;
        _price = price;

        _totalcost = (_price * _quantity);
    }
    public string getName()
    {
        return _productName;
    }
    public int getId()
    {
        return _productId;
    }
    public int getQuantity()
    {
        return _quantity;
    }
    public double getTotal()
    {
        return _totalcost;
    }
}