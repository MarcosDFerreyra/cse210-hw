public class Resume
{
    public string _name = "";
    public List<Job> _jobList = new List<Job>();


    public void displayResumeMethod()
    {
        Console.WriteLine(_name);
        Console.WriteLine("job");
        foreach (Job job in _jobList) 
        {
           job.displayJobMethod();
        }
    }


}