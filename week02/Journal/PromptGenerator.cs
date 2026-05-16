class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPromp()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("Try telling the worst part of your day as if was good");
        _prompts.Add("Craziest thing of today?");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(_prompts.Count);
        string randomprompt = _prompts[number];
        return randomprompt;
    }


}