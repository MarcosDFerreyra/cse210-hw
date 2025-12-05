public class FreeActivity : Activities
{
    public FreeActivity()
    {
        _name = "Free Activity";
        _description = "This activity like the name indicates, it's free, you can write about anything you want, could be about your day, about someone, or abour a movie, the choice is yours. (Recomended time: 120 seconds)";
        _duration = 0;
    }

    public void UserFree()
    {
        Console.WriteLine("This is the place where you can write about wherever you want:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
        }
    }
    public void Run()
    {
        DisplayStartingMessage();
        UserFree();
        DisplayEndingMessage();
        Console.Clear();
    }
}