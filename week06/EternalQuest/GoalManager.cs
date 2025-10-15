public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager() { }
    public void Start()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goal");
        Console.WriteLine("  3. Save Goal");
        Console.WriteLine("  4. Load Goal");
        Console.WriteLine("  5. Record Events");
        Console.WriteLine("  6. Quit");
        Console.Write("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            CreateGoal();
        }
        else if (choice == 2)
        {
            ListGoalDetails();
        }
        else if (choice == 3)
        {
            SaveGoals();
        }
        else if (choice == 4)
        {
            LoadGoals();
        }
        else if (choice == 5)
        {
            RecordEvent();
        }
        else if (choice == 5)
        {
            RecordEvent();
        }
        else if (choice == 6)
        {
            return;
        }
        Start();
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine("");
        Console.WriteLine($"Player current score: {_score}");
        Console.WriteLine("");

    }
    public void ListGoalNames()
    {
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetShortName()}");
            i++;
        }
    }
    public void ListGoalDetails()
    {
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }
        DisplayPlayerInfo();

    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goales are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("What type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1) //simple goal
        {
            Console.Write("What is the name of your simple goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with the goal? ");
            int points = int.Parse(Console.ReadLine());
            DisplayPlayerInfo();

            SimpleGoal sg = new SimpleGoal(name, description, points);
            _goals.Add(sg);
        }
        if (choice == 2) //eternal goal
        {
            Console.Write("What is the name of your eternal goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with the goal? ");
            int points = int.Parse(Console.ReadLine());
            DisplayPlayerInfo();

            EternalGoal eg = new EternalGoal(name, description, points);
            _goals.Add(eg);
        }
        if (choice == 3) //checklist goals
        {
            Console.Write("What is the name of your checklist goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with the goal? ");
            int points = int.Parse(Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            DisplayPlayerInfo();

            ChecklistGoal cg = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(cg);

        }

        Start();
    }
    public void RecordEvent()
    {
        ListGoalNames();
        Console.WriteLine("Which goal have you accomplished? ");
        int choice = int.Parse(Console.ReadLine());
        choice--;

        for (int i = 0; i < _goals.Count(); i++)
        {
            if (choice == i)
            {
                int points = _goals[i].RecordEvent();
                _score += points;
                Console.WriteLine($"Congratulations! You have earned {points} points!");
            }
        }
    }
    public void SaveGoals()
    {
        Console.WriteLine("Enter a file name: ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRespresentation());
            }
        }

    }
    public void LoadGoals()
    {
        Console.Write("Enter a file name: ");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);
        _goals.Clear();

        _score = int.Parse(lines[0]);

        foreach (string line in lines)
        {
            char[] d = { ':', ',' }; // had to use google ai response to help me understand delimiter
            string[] entries = line.Split(d);
            string[] goalType = line.Split(":");

            if (goalType[0] == "SimpleGoal")
            {
                SimpleGoal sg = new SimpleGoal(entries[1], entries[2], int.Parse(entries[3]));
                _goals.Add(sg);
            }
            else if (goalType[0] == "EternalGoal")
            {
                EternalGoal eg = new EternalGoal(entries[1], entries[2], int.Parse(entries[3]));
                _goals.Add(eg);
            }
            if (goalType[0] == "ChecklistGoal")
            {
                ChecklistGoal cg = new ChecklistGoal(entries[1], entries[2], int.Parse(entries[3]), int.Parse(entries[5]), int.Parse(entries[4]));
                cg.SetAmountCompleted(int.Parse(entries[6]));
                _goals.Add(cg);
            }

        }

    }
}