public class ReflectionActivity : Acticity
{
    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public void Act()
    {
        List<string> prompts = new List<string>();
        prompts.Add("Think of a time when you stood up for someone else.");
        prompts.Add("Think of a time when you did something really difficult.");
        prompts.Add("Think of a time when you helped someone in need.");
        prompts.Add("Think of a time when you did something truly selfless.");

        List<string> questions = new List<string>();
        questions.Add("Why was this experience meaningful to you?");
        questions.Add("Have you ever done anything like this before?");
        questions.Add("How did you get started?");
        questions.Add("How did you feel when it was complete?");
        questions.Add("What made this time different than other times when you were not as successful?");
        questions.Add("What is your favorite thing about this experience?");
        questions.Add("What could you learn from this experience that applies to other situations?");
        questions.Add("What did you learn about yourself through this experience?");
        questions.Add("How can you keep this experience in mind in the future?");

        List<int> index = new List<int>();

        DateTime futuretime = Start();

        Console.WriteLine("Consider the following prompt:");

        Random rdm = new Random();
        var prompt = rdm.Next(0, prompts.Count);

        Console.WriteLine($"\n---------- {prompts[prompt]} ----------\n");

        Console.WriteLine("when you have an experince in mind, press enter to continue.");
        string input = Console.ReadLine();

        Console.Write("\nNow ponder on the following question as related to your chosen experince. You may begin in : ");
        Countdown(5);

        Console.Clear();

        while (DateTime.Now < futuretime)
        {

            if (index.Count == 0)
            {
                for (int i = 0; i < questions.Count; i++)
                {
                    index.Add(i);
                }
            }

            prompt = rdm.Next(0, index.Count);
            Console.Write($"\n {questions[index[prompt]]}");
            index.RemoveAt(prompt);

            Loading();
        }

        End();
    }
}