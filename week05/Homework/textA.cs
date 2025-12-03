public class textA : Assing
{
    private string _title;

    public textA(string student, string topic, string title) : base(student, topic)
    {
        _title = title;
    }

    public string GetWritingInfo()
    {
        return $"{_title} by {_student}";
    }
}