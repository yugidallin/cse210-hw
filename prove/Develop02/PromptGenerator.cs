using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is one thing I learned today, and how did it impact me?",
        "Describe a moment today when you felt truly at peace. What were you doing?",
        "How did you challenge yourself today, and what did you discover about yourself in the process?",
        "Who did you help or encourage today, and how did it make you feel?",
        "Reflect on a decision you made today. What were the factors that influenced it, and are you satisfied with the outcome?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
