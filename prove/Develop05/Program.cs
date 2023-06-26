using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        List<Goal> goals = new List<Goal>();
        string name = "";
        string description = "";
        int points = 0;
        int worth = 0;
        bool exit = false;

        Console.Clear();

        while (exit != true)
        {
            Console.WriteLine($"You currently have {points} points\n");

            string choice = MainMenu();

            if (choice == "1")
            {
                string secondChoice = GoalMenu();
                if (secondChoice == "1")
                {
                    Console.Write("Name your Goal \n> ");
                    name = Console.ReadLine();

                    Console.Write("Describe your goal \n> ");
                    description = Console.ReadLine();

                    Console.Write("How many points is you goal worth? \n> ");
                    worth = int.Parse(Console.ReadLine());

                    goals.Add(new SimpleGoal(name, description, worth, false));
                }
                else if (secondChoice == "2")
                {
                    Console.Write("Name your Goal \n> ");
                    name = Console.ReadLine();

                    Console.Write("Describe your goal \n> ");
                    description = Console.ReadLine();

                    Console.Write("How many points is you goal worth? \n> ");
                    worth = int.Parse(Console.ReadLine());

                    goals.Add(new EternalGoal(name, description, worth));
                }
                else if (secondChoice == "3")
                {
                    int completionWorth = 0;
                    int completion = 0;

                    Console.Write("Name your Goal \n> ");
                    name = Console.ReadLine();

                    Console.Write("Describe your goal \n> ");
                    description = Console.ReadLine();

                    Console.Write("How many points is you goal worth? \n> ");
                    worth = int.Parse(Console.ReadLine());

                    Console.Write("How many times does this goal needed to be completed? \n> ");
                    completion = int.Parse(Console.ReadLine());

                    Console.Write("What is the bonus for completing this goal that many times? \n> ");
                    completionWorth = int.Parse(Console.ReadLine());

                    goals.Add(new ChecklistGoal(name, description, worth, completionWorth, completion, false));
                }
                Console.Clear();
            }
            else if (choice == "2")
            {
                Console.Clear();
                ListGoals(goals);
                Console.WriteLine("");
            }
            else if (choice == "3")
            {
                ListGoals(goals);

                Console.Write("which goal did you complete? \n> ");
                int complete = int.Parse(Console.ReadLine());

                points = goals[complete - 1].Act(points);
                Console.Clear();
            }
            else if (choice == "4")
            {
                Console.Write("what shall the file be called? \n> ");
                string filename = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine(points);
                    foreach (Goal goal in goals)
                    {
                        goal.Write(outputFile);
                    }
                }

                Console.Clear();
            }
            else if (choice == "5")
            {
                Console.Write("what shall the file be called? \n> ");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);
                string[] goalTypes;
                string[] goalOptions;

                foreach (string line in lines)
                {
                    goalTypes = line.Split(":");
                    try
                    {
                        if (int.Parse(goalTypes[0]) > 1)
                        {
                            points = int.Parse(goalTypes[0]);
                        }
                        else if (goalTypes[0] == "SimpleGoal")
                        {
                            goalTypes = goalTypes.Skip(1).ToArray();

                            foreach (string option in goalTypes)
                            {
                                goalOptions = option.Split("~|~");
                                goals.Add(new SimpleGoal(goalOptions[0], goalOptions[1], int.Parse(goalOptions[2]), bool.Parse(goalOptions[3])));
                            }
                        }
                        else if (goalTypes[0] == "eternal Goal")
                        {
                            goalTypes = goalTypes.Skip(1).ToArray();

                            foreach (string option in goalTypes)
                            {
                                goalOptions = option.Split("~|~");
                                goals.Add(new EternalGoal(goalOptions[0], goalOptions[1], int.Parse(goalOptions[2])));
                            }
                        }
                        else if (goalTypes[0] == "ChecklistGoal")
                        {
                            goalTypes = goalTypes.Skip(1).ToArray();

                            foreach (string option in goalTypes)
                            {
                                goalOptions = option.Split("~|~");
                                goals.Add(new ChecklistGoal(goalOptions[0], goalOptions[1], int.Parse(goalOptions[2]), int.Parse(goalOptions[3]), int.Parse(goalOptions[4]), bool.Parse(goalOptions[5])));
                            }
                        }
                    }
                    catch { };
                }

                Console.Clear();
            }
            else if (choice == "6")
            {
                exit = true;
            }

        }

        static string MainMenu()
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Create a goal");
            Console.WriteLine("2. list goals");
            Console.WriteLine("3. Mark event");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. exit");
            Console.Write("> ");
            string choice = Console.ReadLine();
            return choice;
        }

        static string GoalMenu()
        {
            Console.WriteLine("Please choose a Goal:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("> ");
            string choice = Console.ReadLine();
            return choice;
        }

        static void ListGoals(List<Goal> goals)
        {
            Console.WriteLine("\nCurrent Goals: ");
            int i = 1;
            foreach (Goal goal in goals)
            {
                i = goal.Display(i);
            }
        }
    }
}


