using System.Reflection.Metadata;

public class GoalManager
{
    private int _score;
    private List<Goal> _goal = new List<Goal>();

    public GoalManager()
    {
        _score = 0;
    }
    public void Start()
    {
        string user = "";
        while (user != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goal");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Events");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the Menu: ");
            user = Console.ReadLine();

            if (user == "1")
            {
                CreateGoal();
            }
            if (user == "2")
            {
                ListGoalDetails();
            }
            if (user == "3")
            {
                SaveFile();
            }
            if (user == "4")
            {
                LoadFile();
            }
            if (user == "5")
            {
                RecordEvent();
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have a total of {_score}");
    }

    public void CreateGoal()
    {

        Console.WriteLine("Tipes of Goals");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Select the tipe of goal ");
        string user2 = Console.ReadLine();

        Console.WriteLine("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.WriteLine("Give a short description of your Goal; ");
        string description = Console.ReadLine();

        Console.WriteLine("How many points does your goal worth? ");
        int points = int.Parse(Console.ReadLine());

        if (user2 == "1")
        {
            SimpleGoal goal1 = new SimpleGoal(name, description, points);
            _goal.Add(goal1);
        }
        if (user2 == "2")
        {
            EternalGoal goal2 = new EternalGoal(name, description, points);
            _goal.Add(goal2);
        }
        if (user2 == "3")
        {
            Console.WriteLine("How many times does this goal need tp be acomplished ");
            int target = int.Parse(Console.ReadLine());

            Console.WriteLine("How many points does your goal is worth? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal goal3 = new ChecklistGoal(name, description, points, target, bonus);
            _goal.Add(goal3);
        }
    }

    public void ListGoalNames()
    {
        int number = 0;
        Console.WriteLine("your goals");
        foreach (Goal goal in _goal)
        {
            number++;
            string name = goal.GetName();
            Console.WriteLine($"{number}. {name}");
        }
    }
    public void ListGoalDetails()
    {
        int number = 0;
        Console.WriteLine("your goals");
        foreach (Goal goal in _goal)
        {
            number++;
            string name = goal.GetDetailsString();
            Console.WriteLine($"{number}. {name}");
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("The Goals are");
        ListGoalNames();
        Console.WriteLine("Which goal did you acomplished");
        int number = int.Parse(Console.ReadLine());
        _goal[number - 1].RecordEvent();
        int totalPoints = _goal[number - 1].GetPoints();
        _score += totalPoints;
        Console.WriteLine($"Now you have {_score} Points");

    }
    public void SaveFile()
    {
        Console.Write("Name of the file: ");
        string filename = Console.ReadLine();
        using (StreamWriter newFile = new StreamWriter(filename))
        {
            newFile.WriteLine(_score);
            foreach (Goal goals in _goal)
            {
                newFile.WriteLine(goals.GetStringRepresentation());
            }
        }
    }
    public void LoadFile()
    {
        Console.Write("Name of the file: ");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);
        _goal.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split("|");

            string type = parts[0];

            if (type == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);

                SimpleGoal simpleGoals = new SimpleGoal(name, description, points);

                if (isComplete)
                {
                    simpleGoals.RecordEvent();   
                }

                _goal.Add(simpleGoals);
            }

            else if (type == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                EternalGoal g = new EternalGoal(name, description, points);
                _goal.Add(g);
            }

            else if (type == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int completed = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);

                
                ChecklistGoal checklistgoals = new ChecklistGoal(name, description, points, target, bonus);

                
                for (int c = 0; c < completed; c++)
                {
                    checklistgoals.RecordEvent();  
                }

                _goal.Add(checklistgoals);
            }
        }

        Console.WriteLine("File loaded!");
    }
}
    
