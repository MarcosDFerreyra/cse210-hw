public class BreathingActivity : Activities
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly.Clear your mind and focus on your breathing.";
        _duration = 0;
    }

    public void Run()
    {
        DisplayStartingMessage();
        int totalTime = _duration;
        while (totalTime > 0)
        {
            Console.Write("Breath in... ");
            ShowCountDown(4);
            totalTime -= 4;
            Console.Write("Breath out...");
            ShowCountDown(6);
            totalTime -= 6;
            Console.WriteLine();
        }
        DisplayEndingMessage();
        Console.Clear();
    }
}