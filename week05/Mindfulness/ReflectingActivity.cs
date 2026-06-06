using System.Configuration.Assemblies;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>{"Think about a time you failed but felt proud of your effort.",
    "Recall a moment when you had to say 'no' to a close friend.",
    "Think about a time you felt completely out of your comfort zone.",
    "Remember a situation where your first impression of someone was entirely wrong.",
    "Think about a time you received constructive criticism that actually helped you.",
    "Recall a moment when you had to make a choice without having all the facts.",
    "Think about a time you stood up for something you believed in.",
    "Remember a situation where you had to apologize even when it felt difficult.",
    "Think about a time you felt deeply appreciated by a coworker or peer.",
    "Recall a moment when you successfully handled a high-stress crisis.",
    "Think about a time you had to learn a complex tool or skill from scratch.",
    "Remember a situation where you gave up on a goal to prioritize your peace."};
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };
    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void run()
    {
       DisplayStartingMessage();
        
        while (true)
        {   
            string input = Console.ReadLine();

            if (int.TryParse(input, out int result)) 
            {
                _duration = result;
                break;
            }
            Console.WriteLine("type a valid number: ");
        }
        DisplayPrompt();
        ShowSpinner(5);
        DisplayQuestions();
        ShowSpinner(_duration-5);
        DisplayEndingMessage();
        ShowSpinner(5);
    }
    public string GetRandomPrompt()
    {
        int randomIndex = Random.Shared.Next(_prompts.Count);
        string selectedPrompt = _prompts[randomIndex];

        return selectedPrompt;
    }

    public string GetRandomQuestion()
    {
        int randomIndex = Random.Shared.Next(_questions.Count);
        string selectedPrompt = _questions[randomIndex];

        return selectedPrompt;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"{GetRandomPrompt()}");
    }
    public void DisplayQuestions()
    {
        Console.WriteLine($"{GetRandomQuestion()}");
    }
}