public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        // Personal reflection and wellness
        "Tell me how many times you felt good this week",
        "List the activities that brought you joy during the weekend",
        "Describe the moments today when you felt completely at peace",

        // Organization and workflow
        "Write down the tasks you need to complete before tomorrow morning",
        "Identify the bottlenecks that slowed down your project delivery",
        "Enumerate the tools you use daily to keep track of your goals",

        // Ideas and general lists
        "Brainstorm alternative ways to solve regular customer service issues",
        "Name the books that completely changed your perspective on career growth",
        "List the features you find essential in a modern text editor"
    };
    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
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
        GetRandomPrompt();
        ShowCountDown(5);
        Console.WriteLine("Start Listing Now!");

        _count=GetListFromUser().Count;

        Console.WriteLine($"you listed {_count}");

        DisplayEndingMessage();
        ShowSpinner(5);
    }
    public void GetRandomPrompt()
    {
        int randomIndex = Random.Shared.Next(_prompts.Count);
        string selectedPrompt = _prompts[randomIndex];

        Console.WriteLine($"{selectedPrompt}");
    }
    public List<string> GetListFromUser()
    {   

        DateTime starttime = DateTime.Now;
        DateTime endTime = starttime.AddSeconds(_duration);
        List<string> myList = new List<string>();
        
        while (DateTime.Now < endTime)
        {
           Console.WriteLine("");
           string userInput = Console.ReadLine();
           myList.Add(userInput);
        }
        return myList;
    }
}