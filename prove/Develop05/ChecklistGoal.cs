public class ChecklistGoal : Goal
{
    private int _completionWorth = 0;
    private int _completion = 0;
    private int _progress = 0;
    public ChecklistGoal(string name, string description, int worth, int completedWorth, int completion, bool complete) : base(name, description, worth)
    {
        SetGoalType("ChecklistGoal");
        SetComplete(complete);
        _completionWorth = completedWorth;
        _completion = completion;
    }

    public int GetProgress()
    {
        return _progress;
    }

    public int GetCompletion()
    {
        return _completion;
    }

    public int GetCompletionWorth()
    {
        return _completionWorth;
    }

    public void SetProgress(int progress)
    {
        _progress = progress;
    }

    public override int Act(int points)
    {

        if (GetProgress() != GetCompletion())
        {
            points += GetWorth();
            SetProgress(GetProgress() + 1);
        }
        else if (GetProgress() == GetCompletion() && !GetComplete())
        {
            points += GetCompletionWorth();
            SetComplete(true);
        }

        return points;
    }

    public override int Display(int i)
    {
        if (!GetComplete())
        {
            Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()}) -- Completion: {GetProgress()}/{GetCompletion()}");
        }
        else
        {
            Console.WriteLine($"{i}. [X] {GetName()} ({GetDescription()}) -- Completion: {GetProgress()}/{GetCompletion()}");
        }
        i++;
        return i;
    }
    public override void Write(StreamWriter outputFile)
    {
        outputFile.WriteLine($"{GetGoalType()}:{GetName()}~|~{GetDescription()}~|~{GetWorth()}~|~{GetCompletionWorth()}~|~{GetCompletion()}~|~{GetComplete()}");
    }
}