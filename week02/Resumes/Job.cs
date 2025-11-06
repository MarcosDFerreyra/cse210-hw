public class Job
{
    public string _jobTitle = "";
    public string _company = "";
    public int _startYear = -1;
    public int _endYear = -1;
    public void displayJobMethod()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}