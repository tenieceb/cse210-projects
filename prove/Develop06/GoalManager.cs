public class GoalManager
{    
    int _playerScore;
    List<Goal> _goals = new List<Goal>();
    public GoalManager()
    {
        _playerScore = 0;
        _goals = new List<Goal>();
    }

    public void Start()
    {
        string userOption;
        Console.WriteLine("\nReady to start your Eternal Quest?\n");
        do
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Help");
            Console.WriteLine("   7. Quit");
            Console.Write("Select an option from the menu: ");
            userOption = Console.ReadLine();

            if(userOption == "1")
            {
                CreateGoal();
            }
            else if(userOption == "2")
            {
                ListGoalDetails();
            }
            else if(userOption == "3")
            {
                SaveGoals();
            }
            else if(userOption == "4")
            {
                LoadGoals();
            }
            else if(userOption == "5")
            {
                RecordEvent();
            }
            else if(userOption == "6")
            {
                Console.WriteLine("Help: ");
                Console.WriteLine("Create New Goal : Allows you to create a new goal and set the points associated with it.");
                Console.WriteLine("List Goals : Lists any goals you currently have in this current session.");
                Console.WriteLine("Save Goals : Enables you to create a save file to save your goals from this current session.");
                Console.WriteLine("Load Goals : Enables you to load a save file and add the goals to this current session.");
                Console.WriteLine("Record Event : Helps you to record your achieved goals.\nPush enter to return to menu\n");
                Console.ReadLine();
            }
            else if(userOption != "7")
            {
                Console.WriteLine("That is an invalid option.");
            }



        } while (userOption != "7"); 


    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_playerScore} points.\n");

    }

    public void ListGoalNames()
    {
        List<string> goalNames = new List<string>();
        foreach (Goal goal in _goals)
        {

            string goalLine = goal.GetStringRepresentation();
            string[] goaldetails = goalLine.Split('|');
            string goalName = goaldetails[2];
            goalNames.Add(goalName);
            
        }
        for (int i=0; i<goalNames.Count; i++)
        {
            Console.WriteLine($"    {i+1}. {goalNames[i]}");
        }
    }
    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goal.GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        string userGoalChoice="";
        string userMoreGoals = "YES";
        while(userGoalChoice !="5" && userMoreGoals == "YES")
        {
            Console.WriteLine("Goal Types: ");
            Console.WriteLine("   1. Simple Goal");
            Console.WriteLine("   2. Eternal Goal");
            Console.WriteLine("   3. Checklist Goal");
            Console.WriteLine("   4. Help");
            Console.WriteLine("   5. Cancel");
            Console.Write("What type of goal would you like to create? ");
            userGoalChoice = Console.ReadLine();
            Console.WriteLine("");
            if (userGoalChoice != "4")
            {    
                Console.Write("What is the name of your goal? ");
                string goalName = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string goalDescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                string _p = Console.ReadLine();
                int goalPoints = int.Parse(_p);

                if (userGoalChoice == "1")
                {

                    SimpleGoal sg1 = new SimpleGoal(goalName, goalDescription, goalPoints,false);
                    _goals.Add(sg1);
                }
                else if (userGoalChoice == "2")
                {

                    EternalGoal eg1 = new EternalGoal(goalName, goalDescription, goalPoints,false);
                    _goals.Add(eg1);

                }
                else if (userGoalChoice == "3")
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    string _t = Console.ReadLine();
                    int target = int.Parse(_t);
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    string _b = Console.ReadLine();
                    int bonus = int.Parse(_b);


                    ChecklistGoal cg1 = new ChecklistGoal(goalName, goalDescription, goalPoints, target, bonus,0);
                    _goals.Add(cg1);
                }
                Console.WriteLine("Do you want to make another goal (YES or NO)? ");
                userMoreGoals = Console.ReadLine();
            }

            else if (userGoalChoice == "4")
            {
                Console.WriteLine("Help: ");
                Console.WriteLine("Simple Goal : A simple goal is a one time goal.");
                Console.WriteLine("Eternal Goal : An eternal goal is a goal that will continue forever but you can complete it once a day");
                Console.WriteLine("Checklist Goal : A checklist goal is a goal that you want to complete a certain amount of times.\nPress enter to return to the goal list\n");
                Console.ReadLine();
            }
            
            else if (userGoalChoice != "5")
            {
                Console.WriteLine("That is not an option\n");
            }


        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are: ");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        string userAccomplished = Console.ReadLine();
        int accomplishedNumber = int.Parse(userAccomplished)-1;
        if(_goals[accomplishedNumber].IsComplete() != true)
        {
            _goals[accomplishedNumber].RecordEvent();
            int _goalpoints = _goals[accomplishedNumber].SetGoalPoints();
            _playerScore +=  _goalpoints;
        }
        else Console.WriteLine("You have already completed that goal.");
        
    }

    public void SaveGoals()
    {
         Console.WriteLine("What filename do you want to save to? ");
        string fileName = Console.ReadLine();


        using (StreamWriter outputFile = new StreamWriter(fileName))

        {
            outputFile.WriteLine($"{_playerScore}");
            foreach (Goal goal in _goals)
            {
                string saveGoaldetails = goal.GetStringRepresentation();
                outputFile.WriteLine(saveGoaldetails);
            }
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine("What filename do you want to load the journal from? ");
        string fileName = Console.ReadLine();       
        string[] lines = System.IO.File.ReadAllLines(fileName);
        string playerScore = lines[0];
        _playerScore = int.Parse(playerScore);
        _goals.Clear();

        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split("|");
            string ic = parts[0];
            bool isComplete = bool.Parse(ic);
            string goalType = parts[1];
            string goalName = parts[2];
            string goalDescprition = parts[3];
            string gp = parts[4];
            int goalPoints = int.Parse(gp);

        
            if (goalType == "Simple Goal")
            {
                SimpleGoal sg = new SimpleGoal(goalName,goalDescprition,goalPoints,isComplete);
                sg.IsComplete();
                _goals.Add(sg);
            }
            else if (goalType == "Eternal Goal")
            {
                
                EternalGoal eg = new EternalGoal(goalName,goalDescprition,goalPoints,isComplete);
                _goals.Add(eg);
            }
            else if(goalType == "Checklist Goal")
            {
                string b = parts[5];
                int bonus = int.Parse(b);
                string tc = parts[6];
                int _totalCompleted = int.Parse(tc);
                string t = parts[7];
                int target = int.Parse(t);
                ChecklistGoal cg = new ChecklistGoal(goalName,goalDescprition,goalPoints,target,bonus,_totalCompleted);
                
                _goals.Add(cg);
            }
        }
    }
}