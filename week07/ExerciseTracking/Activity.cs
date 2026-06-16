using System.ComponentModel;

public abstract class Activity
{
    protected double _distance;
    protected double _length;
    protected string _date;
    protected double _speed;
    protected double _pace;
    public Activity()
    {
        DateTime now = DateTime.Now;
        _date = now.ToString("dd MMM yyyy");
    }
    public abstract string GetSummary();
    public double GetSpeed()
    {
        return _speed;
    }
    public double GetDistance()
    {
        return _distance;
    }

    public string SetDate()
    {
        DateTime now = DateTime.Now;
        return now.ToString("dd MMM yyyy");
    }
    public string GetDate()
    {
        return _date;
    }
    public double GetLength()
    {
        return _length;
    }
}