public class PromptGenerator
{
    public List<string> _prompts = new List<string>{"What was the funniest thing that happend to you today?", "Who made me smile today ?", "Did I do something kind for someone today?", "if I had one thing I could do over today, what would it be?", "What is something I want to remember about today?", "What was the best part of my day?", "What did I learn about myself today?" };


    public string GetRandomPrompt()
    {
        Random random = new Random();
        int i = random.Next(_prompts.Count);
        string randomPrompt = _prompts[i];
        return randomPrompt;
    }
}