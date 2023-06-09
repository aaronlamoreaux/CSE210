public class ListingActivity : Acticity {
    private List<string> _prompts = new List<string>();   
    private Random _rdm = new Random();
    private int _prompt = 1;
    private  DateTime _time = DateTime.Now;
    
    public ListingActivity() : base ("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Act(){
        
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        
        _prompt = _rdm.Next(0, _prompts.Count);

        _time = Start();

        Console.WriteLine("List as many responses you can think of to the following _prompt:");
        Console.WriteLine($"\n---------- {_prompts[_prompt]} ----------\n");
        Console.Write("begin in: ");
        Countdown(5);
        Console.WriteLine("");

        while(DateTime.Now < _time)
        {
            Console.Write("> ");
            Console.ReadLine();
        }
        
        End();
    }
}