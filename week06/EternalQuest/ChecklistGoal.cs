using System.Drawing;
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    public override void RecordEvent()
    {
        _amountCompleted++;

        if (_amountCompleted == _target)
        {
            Console.WriteLine($"¡congratulations you completed the goal, you recived a bonus of {_bonus} points!");
        }
        else
        {
            Console.WriteLine($"¡congratulations you completed part of the goal, you recived {_points} points!");

        }
    }
     public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return  false;
        }
    }
    public override string GetDetailsString()
    {
        string mark;
        if (IsComplete())
        {
            mark = "[x]";
        }
        else
        {
            mark = "[ ]";
        }

        return $"{mark} {_shortName}, {_description}, ({_amountCompleted}/{_target})";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal | {_shortName} | {_description} | {_points} | {_amountCompleted} | {_target} | {_bonus}";
    }

    public override int GetPoints()
    {
        if (IsComplete() == true)
        {
            int pointsEarned = _points + _bonus;
            return pointsEarned;
        }
        else
        {
            return _points;
        }
    }
}