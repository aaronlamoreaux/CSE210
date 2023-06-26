public abstract class Goal
{
    private string _name = "";
    private string _description = "";
    private int _worth = 0;
    private bool _complete = false;
    private string _goalType = "";
    public Goal(string name, string description, int worth)
    {
        _name = name;
        _description = description;
        _worth = worth;
    }

    public bool GetComplete()
    {
        return _complete;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetWorth()
    {
        return _worth;
    }

    public string GetGoalType()
    {
        return _goalType;
    }

    public void SetComplete(bool complete)
    {
        _complete = complete;
    }

    public void SetGoalType(string goalType)
    {
        _goalType = goalType;
    }

    public abstract int Act(int points);

    public abstract int Display(int i);

    public abstract void Write(StreamWriter outputFile);
}