using System.ComponentModel;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string desc, int pont)
    {
        _shortName = name;
        _description = desc;
        _points = pont;
    }
    public abstract void RecordEvent();

    public abstract int getPoints();
    public abstract bool IsComplete();
    public string getName()
    {
        return _shortName;
    }
    public string getDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description})";
        }
        else
        {
            return $"[ ] {_shortName} ({_description})";
        }
    }

    public abstract string getStringRepresentation();
}