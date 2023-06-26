public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int worth) : base(name, description, worth)
    {
        SetGoalType("EternalGoal");
    }

    public override int Act(int points)
    {
        return points + GetWorth();
    }

    public override int Display(int i)
    {
        if (!GetComplete())
        {
            Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})");
        }
        else
        {
            Console.WriteLine($"{i}. [X] {GetName()} ({GetDescription()})");
        }
        i++;
        return i;
    }

    public override void Write(StreamWriter outputFile)
    {
        outputFile.WriteLine($"{GetGoalType()}:{GetName()}~|~{GetDescription()}~|~{GetWorth()}");
    }
}