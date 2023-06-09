public class ReflectionActivity : Acticity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private List<int> _index = new List<int>();
    private Random _rdm = new Random();
    private int _prompt = 0;
    private string _input = "";

    private DateTime _time = new DateTime();

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {

        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");


        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void Act()
    {
        _prompt = _rdm.Next(0, _prompts.Count);
        _time = Start();

        Console.WriteLine("Consider the following _prompt:");

        Console.WriteLine($"\n---------- {_prompts[_prompt]} ----------\n");

        Console.WriteLine("when you have an experince in mind, press enter to continue.");
        _input = Console.ReadLine();

        Console.Write("\nNow ponder on the following question as related to your chosen experince. You may begin in : ");
        Countdown(5);

        Console.Clear();

        while (DateTime.Now < _time)
        {

            if (_index.Count == 0)
            {
                for (int i = 0; i < _questions.Count; i++)
                {
                    _index.Add(i);
                }
            }

            _prompt = _rdm.Next(0, _index.Count);
            Console.Write($"\n {_questions[_index[_prompt]]}");
            _index.RemoveAt(_prompt);

            Loading();
        }

        End();
    }
}