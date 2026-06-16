public class Cycling : Activity
{
    public Cycling(double s, double m):base()
    {
        _distance = s*(m/60);
        _length = m;
        _speed = s;
        _pace = 60 / _speed;
    }
    public override string GetSummary()
    {
        return $"{_date} Cycling ({_length} min): Distance: {_distance} km, Speed: {_speed} kph Pace: {_pace} min per km";
    }
}