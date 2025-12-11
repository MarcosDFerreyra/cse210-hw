public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }

    public abstract void RecordEvent();

    public abstract int GetPoints();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
    public virtual string GetDetailsString()
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

        return $"{mark}, {_shortName}, {_description}";
    }

}