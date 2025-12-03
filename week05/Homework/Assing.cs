public class Assing
{
    protected string _student;
    protected string _topic;

    public Assing(string student, string topic)
    {
        _student = student;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_student} - {_topic}";
    }
}