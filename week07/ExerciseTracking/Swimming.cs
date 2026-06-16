public class Swimming : Activity
{
    private double _lapnumbers;
    public Swimming(double l, double m) : base()
    {
        _distance = l * 50 /1000;
        _length = m;
        _speed = (_distance/m)*60;
        _pace = 60/_speed;
        _lapnumbers = l;
    }
    public double GetLapNumbers()
    {
        return _lapnumbers;
    }
    public override string GetSummary()
    {
        return $"{_date} Swimming({_length} min): Distance: {_distance} km, Speed: {_speed} kph Pace: {_pace} min per km Laps: {_lapnumbers}";
    }
}