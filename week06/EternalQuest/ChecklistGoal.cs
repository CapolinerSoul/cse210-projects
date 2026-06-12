public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string n, string d, int p, int t, int b):base(n, d, p)
    {
        _bonus = b;
        _target = t;
        _amountCompleted = 0;
    }
    public ChecklistGoal(string n, string d, int p, int t, int b, int ac):base(n, d, p)
    {
        _bonus = b;
        _target = t;
        _amountCompleted = ac;
    }
    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
          _amountCompleted++;  
        }
    }

    public override int getPoints()
    {
        if (IsComplete())
        {
          return (_points * _amountCompleted + _bonus);
        }
        else
        {
            return (_points * _amountCompleted);
        }
    }

    public override bool IsComplete()
    {
    return _amountCompleted == _target;
    }
    public override string getStringRepresentation()
    {
        return $"CG⨝{_shortName}⨝{_description}⨝{_points}⨝{_target}⨝{_bonus}⨝{_amountCompleted}";
    }
}