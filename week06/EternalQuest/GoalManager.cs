using System.Runtime.Serialization;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        Start();
    }
    
    public void Start()
    {
        bool menustatus = true;
        while (menustatus)
        {
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Create New Goal");
        Console.WriteLine(" 2. List Goals");
        Console.WriteLine(" 3. Save Goals");
        Console.WriteLine(" 4. Load Goals");
        Console.WriteLine(" 5. Record Event");
        Console.WriteLine(" 6. Quit");
        string input = Console.ReadLine();

        switch (input)
            {
                case "1":
                    CreateGoal();
                    
                    break;

                case "2":
                    DisplayPlayerInfo();

                    break;

                case "3":
                    SaveGoals();
                    
                    break;

                case "4":
                    LoadGoals();

                    break;

                case "5":
                    RecordEvent();

                    break;

                case "6":
                    Console.WriteLine("Goodbye!");
                    menustatus = false;
                    break;

                default:
                    Console.WriteLine("\nInvalid option. Press Enter to try again...");
                    Console.ReadLine();
                    break;
            }
        }
    }
    public void DisplayPlayerInfo()
    {   
        _score=0;
        ListGoalDetails();
        Console.WriteLine($"You have {_score} points");
    }
    public void ListGoalNames()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("There are no goals registered yet.");
            return;
        }

        Console.WriteLine("The goals are:");
        int index = 1;
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"{index}. {goal.getName()}");
                index++;
            }
    }
    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals) {
            Console.WriteLine(goal.getDetailsString());
            _score += goal.getPoints();
        }
    }
    public void CreateGoal()
    {
        bool menus = true;
        while (menus)
        {
            Console.WriteLine("What type of goal you want to create?");
            Console.WriteLine(" 1. Simple Goal");
            Console.WriteLine(" 2. Eternal Goal");
            Console.WriteLine(" 3. Checklist Goal");
            Console.WriteLine("Enter the type of goal: ");
            string input2 = Console.ReadLine();

        if (input2 == "1")
            {
                    Console.WriteLine("Enter a Short Name of the Goal: ");
                    string namegoal = Console.ReadLine();
                    Console.WriteLine("Enter a description of the Goal");
                    string descgoal = Console.ReadLine();
                    Console.WriteLine("Enter the amount of points to be rewarded");
                    string strpointgoal = Console.ReadLine();
                    int pointgoal = int.Parse(strpointgoal);

                    _goals.Add(new SimpleGoal(namegoal, descgoal, pointgoal));

                    menus= false;
            }

        else if (input2 == "2")
            {
                    Console.WriteLine("Enter a Short Name of the Goal: ");
                    string namegoal = Console.ReadLine();
                    Console.WriteLine("Enter a description of the Goal");
                    string descgoal = Console.ReadLine();
                    Console.WriteLine("Enter the amount of points to be rewarded");
                    string strpointgoal = Console.ReadLine();
                    int pointgoal = int.Parse(strpointgoal);

                    _goals.Add(new EternalGoal(namegoal, descgoal, pointgoal));

                    menus= false;
            }

        else if (input2 == "3")
            {
                 Console.WriteLine("Enter a Short Name of the Goal: ");
                    string namegoal = Console.ReadLine();
                    Console.WriteLine("Enter a description of the Goal");
                    string descgoal = Console.ReadLine();
                    Console.WriteLine("Enter the amount of times to comlete this goal");
                    string strtargetgoal = Console.ReadLine();
                    int targetgoal = int.Parse(strtargetgoal);
                    Console.WriteLine("Enter the amount of points to be rewarded per check");
                    string strpointgoal = Console.ReadLine();
                    int pointgoal = int.Parse(strpointgoal);
                    Console.WriteLine("Enter the amount to rewarded at the final check");
                    string strbonusgoal = Console.ReadLine();
                    int bonusgoal = int.Parse(strbonusgoal);

                    _goals.Add(new ChecklistGoal(namegoal, descgoal, pointgoal, targetgoal, bonusgoal));

                    menus= false;
            }
        else
            {
                Console.WriteLine("\nInvalid option. Press Enter to try again...");
            }
        }
    }
    public void SaveGoals()
    {   
        Console.WriteLine("Enter the name of the file to be saved: ");
        string namefile = Console.ReadLine();
        namefile = namefile + ".txt";
        using (StreamWriter outputFile = new StreamWriter(namefile))
        {
            foreach (Goal gol in _goals)
            {
                outputFile.WriteLine(gol.getStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        Console.WriteLine("Enter the name of the file to load: ");
        string loadfile = Console.ReadLine();
        _goals.Clear();
        loadfile = loadfile + ".txt";
        string[] lines = System.IO.File.ReadAllLines(loadfile);

        foreach (string line in lines)
        {
           
            if (string.IsNullOrWhiteSpace(line)) continue;

            string[] parts = line.Split("⨝");
            
            string loadcode = parts[0];
            string loadname = parts[1];  
            string loaddesc = parts[2];  
            int loadpoints = int.Parse(parts[3]); // Puntos otorgados

            if (loadcode == "SG")
            {
                bool isComplete = bool.Parse(parts[4]);
                _goals.Add(new SimpleGoal(loadname, loaddesc, loadpoints, isComplete));
            }
            else if (loadcode == "EG")
            {   
                int completedtimes = int.Parse(parts[4]);
                _goals.Add(new EternalGoal(loadname, loaddesc, loadpoints, completedtimes));
            }
            else if (loadcode == "CG")
            {
                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                int amountCompleted = int.Parse(parts[6]);
                _goals.Add(new ChecklistGoal(loadname, loaddesc, loadpoints, target, bonus, amountCompleted));
            }
        }
        Console.WriteLine("Goals loaded successfully!");
    }
    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You don't have any goals registered yet.");
            return;
        }

        ListGoalNames();

        Console.WriteLine("Which goal did you accomplish? (Enter the number): ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int goalIndex))
        {
            int actualIndex = goalIndex - 1;

            if (actualIndex >= 0 && actualIndex < _goals.Count)
            {
                _goals[actualIndex].RecordEvent();
                Console.WriteLine("Progress recorded successfully!");
            }
            else
            {
                Console.WriteLine("Invalid number. Selection out of range.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }
}