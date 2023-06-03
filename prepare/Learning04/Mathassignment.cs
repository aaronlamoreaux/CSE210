public class MathAssignment : Assignment
{
    private string _texbookSection = "";
    private string _problems = "";
    
    public MathAssignment(string studentName, string topic, string texbookSection, string problems) : base(studentName, topic)
    {
        _texbookSection = texbookSection;
        _problems = problems;
    }

    public string GetSection()
    {
        return _texbookSection;
    }

    public void SetSection(string texbookSection)
    {
        _texbookSection = texbookSection;
    }

    public string GetProblems()
    {
        return _problems;
    }

    public void SetProblems(string problems)
    {
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{_texbookSection} {_problems}";
    }
}