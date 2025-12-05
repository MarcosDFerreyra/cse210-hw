using System.Diagnostics.Tracing;

public class ReflectingActivity : Activities
{
    private List<string> _prompts = new List<string> {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };

    private List<string> _questions = new List<string> {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future? "};   

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = 0;
    }

    Random random = new Random();

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
        Console.Clear();
    }
    public string GetRandomPrompt()
    {
        int i = random.Next(_prompts.Count);
        string randomPrompt = _prompts[i];
        return randomPrompt;
    }
    public string GetRandomQuestion()
    {   
        int i = random.Next(_questions.Count);
        string randomPrompt = _questions[i];
        return randomPrompt;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt");
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.Write("When you have someting in mind please press enter to continue");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this expirence");
        Console.Write("You may begin in... ");
        ShowCountDown(8);
        Console.Clear();
    }
    public void DisplayQuestions()
    {
        int totalTime = _duration;
        while (totalTime > 0)
        {    
            Console.WriteLine($">{GetRandomQuestion()}");
            ShowSpinner(10);
            totalTime -= 10;
        }
    }
}