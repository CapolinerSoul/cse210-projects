using System.Dynamic;

public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string desc, int pont):base(name, desc, pont)
    {
        _isComplete = false;
    }
    public SimpleGoal(string name, string desc, int pont, bool comp):base(name, desc, pont)
    {
        _isComplete = comp;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override int getPoints()
    {
        if (IsComplete()){
            return _points;
        }
        return 0;
    }

    public override string getStringRepresentation()
    {
        return $"SG⨝{_shortName}⨝{_description}⨝{_points}⨝{_isComplete}";
    }
}