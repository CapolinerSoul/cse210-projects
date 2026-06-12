public class EternalGoal : Goal
{
    private int _timesCompleted;
    public EternalGoal(string n, string d, int p) : base(n, d, p)
    {
        _timesCompleted = 0;
    }
    public EternalGoal(string n, string d, int p, int tc) : base(n, d, p)
    {
        _timesCompleted = tc;
    }
    public override void  RecordEvent()
    {
        _timesCompleted ++;
    }
    public override bool IsComplete()
    {
        return false;
    }
    
    public int getTimesCompleted()
    {
        return _timesCompleted;
    }
    public override int getPoints()
    {
        return _points * _timesCompleted;
    }
    public override string getStringRepresentation()
    {
        return $"EG⨝{_shortName}⨝{_description}⨝{_points}⨝{_timesCompleted}";
    }
}