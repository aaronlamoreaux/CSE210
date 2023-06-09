public class Acticity
{
    private string _name = "";
    private string _description = "";
    private string _startMsg = "";
    private string _congrats = "\nWell Done!";
    private string _duration = "";
    private string _endMsg = "";

    public Acticity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }
    public string GetStartMsg()
    {
        _startMsg = $"Welcome to the {GetName()} activity!\n";
        return _startMsg;
    }

    public string GetEndMsg()
    {
        _endMsg = $"\nYou've participated in the {GetName()} activity for {GetDuration()} seconds.";
        return _endMsg;
    }

    public string GetDuration()
    {
        return _duration;
    }

    public string GetCongrats()
    {
        return _congrats;
    }

    public void SetDuration()
    {
        Console.Write("\nhow long, in seconds, would you like this activity to last? ");
        string duration = Console.ReadLine();
        _duration = duration;
    }

    public void Loading()
    {
        int i = 0;
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("\\");
        spinner.Add("-");
        spinner.Add("/");
    
        while (i != 3)
        {
            foreach (string line in spinner)
            {
                Console.Write(line);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }

            i++;
        }
    }

    public DateTime Start()
    {
        Console.Clear();
        Console.WriteLine(GetStartMsg());
        Console.WriteLine(GetDescription());


        SetDuration();

        Console.Clear();

        Console.WriteLine("Get Ready...");
        Loading();

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(int.Parse(GetDuration()));

        return futureTime;
    }

    public void End()
    {
        Console.WriteLine(GetCongrats());
        Loading();
        Console.WriteLine(GetEndMsg());
        Loading();
    }

        public void Countdown(int startnum){
        for (int i = startnum; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
        Console.Write("\b \b");
    }
}