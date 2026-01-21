public class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is one small thing that went well today?",
        "What made me smile today?",
        "What scripture or thoughts stayed with me?",
        "What did I accomplish today(big or small)?",
        "What would I tell my future self about today?",
        "Describe today in three words",
        "What is one thing I learned today?",
        "What challenged me today, and how did I respond?",
        "What am I grateful for right now?",
        "What moment today do I want to remember?",
        "What could I improve tomorrow?",
        "What mistake did I make, and what did it teach me?",
    };
    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}