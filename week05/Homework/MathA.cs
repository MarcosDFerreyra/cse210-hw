public class MathA : Assingment
{
    private string _textBookSection;
    private string _problems;

    public MathA(string student, string topic, string textBookSection, string problems) : base(student, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"section {_textBookSection}, problems {_problems}";
    }
}

