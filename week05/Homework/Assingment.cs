public class Assingment
{
    protected string _student;
    protected string _topic;

    public Assingment(string student, string topic)
    {
        _student = student;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_student} - {_topic}";
    }
}