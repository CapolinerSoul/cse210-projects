public class Running : Activity
{
    public Running(double d, double m) : base()
    {
        _distance = d;
        _length = m;
        _speed = (d/m)*60;
        _pace = 60/_speed;
    }
    public override string GetSummary()
    {
        return $"{_date} Running ({_length} min): Distance: {_distance} km, Speed: {_speed} kph Pace: {_pace} min per km";
    }
}