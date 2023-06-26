public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int worth, bool complete) : base(name, description, worth)
    {
        SetGoalType("SimpleGoal");
        SetComplete(complete);
    }

    public override int Act(int points)
    {

        if (!GetComplete())
        {
            points += GetWorth();
            SetComplete(true);
        }

        return points;
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
        outputFile.WriteLine($"{GetGoalType()}:{GetName()}~|~{GetDescription()}~|~{GetWorth()}~|~{GetComplete()}");
    }
}