public class Activities
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activities()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for the session? ");
        string number = Console.ReadLine();
        int secondsUser = int.Parse(number);
        _duration = secondsUser;
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(4);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done");
        ShowSpinner(2);
        Console.WriteLine($"You have done another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
        Console.WriteLine();
    }
    public void ShowSpinner(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            seconds--; //resta un segundo//
        }
    }
    public void ShowCountDown(int second)
    {
        for (int i = second; i >= 1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }
}