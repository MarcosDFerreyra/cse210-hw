public class ListingActivity : Activities
{
    private int _count;
    private List<string> _prompts = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };


    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 0;
        _count = 0;
    }

    public string GetRandomPrompt()
    {
        {
            Random random = new Random();
            int i = random.Next(_prompts.Count);
            string randomPrompt = _prompts[i];
            return randomPrompt;
        }
    }
    public List<string> GetListFromUser()
    {
        Console.WriteLine("List as many possible items about the following prompt:");
        Console.WriteLine($"--{GetRandomPrompt()}--");
        Console.Write("You may begin in : ");
        ShowCountDown(8);
        Console.Clear();
        List<string> responses = new List<string>();
        
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            responses.Add(response);
            _count++;
        }
        return responses;

    }
    public void Run()
    {
        _count = 0;
        DisplayStartingMessage();
        GetListFromUser();
        Console.WriteLine($"You listed {_count} items");
        DisplayEndingMessage();
        Console.Clear();
    }
}