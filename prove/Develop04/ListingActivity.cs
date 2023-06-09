public class ListingActivity : Acticity {
    
    public ListingActivity() : base ("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Act(){
        List<string> prompts = new List<string>();   
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");

        Random rdm = new Random();
        var prompt = rdm.Next(0, prompts.Count);

        DateTime futuretime = Start();

        Console.WriteLine("List as many responses you can think of to the following prompt:");
        Console.WriteLine($"\n---------- {prompts[prompt]} ----------\n");
        Console.Write("begin in: ");
        Countdown(5);
        Console.WriteLine("");

        while(DateTime.Now < futuretime)
        {
            Console.Write("> ");
            Console.ReadLine();
        }
        
        End();
    }
}