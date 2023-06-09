public class Acticity
{
    private string _name = "";
    private string _description = "";
    private string _startMsg = "";
    private string _congrats = "";
    private string _duration = "";
    private string _endMsg = "";
    private DateTime _futureTime = new DateTime();

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
        return _startMsg;
    }

    public string GetEndMsg()
    {
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

    public DateTime GetFutureTime(){
        return _futureTime;
    }

    public void SetStartMsg( string startMsg) {
        _startMsg = startMsg;
    }

    public void SetCongrats(string congrats)
    {
        _congrats = congrats;
    }

    public void SetEndMsg(string endMsg){
        _endMsg = endMsg;
    }

    public void SetDuration(string duration)
    {
        _duration = duration;
    }

    public void SetFutureTime(DateTime time){
        _futureTime = time.AddSeconds(int.Parse(GetDuration()));
    }

    public void Loading()
    {
        int i = 0;
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("\\");
        spinner.Add("-");
        spinner.Add("/");
    
        while (i != 2)
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

    public void Start()
    {
        SetStartMsg($"Welcome to the {GetName()} activity!");
        Console.Clear();
        Console.WriteLine($"{GetStartMsg()}\n");
        Console.WriteLine($"{GetDescription()}");

        Console.Write("\nhow long, in seconds, would you like this activity to last? ");
        string duration = Console.ReadLine();

        SetDuration(duration);
        SetFutureTime(DateTime.Now);

        Console.Clear();

        Console.WriteLine("Get Ready...");
        Loading();
        Console.WriteLine("");
    }

    public void End()
    {
        SetCongrats($"Well done!");
        SetEndMsg($"You've participated in the {GetName()} activity for {GetDuration()} seconds.");

        Console.WriteLine($"\n{GetCongrats()}");
        Loading();

        Console.WriteLine($"\n{GetEndMsg()}");
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