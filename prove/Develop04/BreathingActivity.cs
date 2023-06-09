public class BreathingActivity : Acticity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Act()
    {   
        Start();

        while (DateTime.Now < GetFutureTime())
        {
            Console.Write("Breathe in... ");
            Countdown(4);
            Console.Write("\n Breathe out... ");
            Countdown(4);
            Console.WriteLine("\n");
        }

        End();
    }
}
