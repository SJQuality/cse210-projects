

public class PromptGenerator
{
    public List<string> _prompts = new List<string>

    {
        "What made you smile today?",
        "What is one thing that made you laugh today?",
        "What challenge did you overcome today, no matter how small?",
        "What are you most grateful for right now?",
        "What did you learn about yourself today?",
        "What is one decision you made today that you're proud of?",
        "Who made a positive impact on your day, and how?",
        "What is one thing you're looking forward to tomorrow?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];
    }
}