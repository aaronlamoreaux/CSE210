using System;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        while (exit != true)
        {
            exit = ResolveChoice(GetMenuChoice());
        }
    }

    static string GetMenuChoice()
    {
        Console.Clear();
        Console.WriteLine("please choose an activity (1-4):");
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Reflection");
        Console.WriteLine("3. Listing");
        Console.WriteLine("4. exit");
        Console.Write("> ");
        string choice = Console.ReadLine();
        return choice;
    }

    static bool ResolveChoice(string choice)
    {
        bool result = false;
        if (choice == "1")
        {
            BreathingActivity breathing = new BreathingActivity();
            breathing.Act();

        }
        else if (choice == "2")
        {
            ReflectionActivity reflection = new ReflectionActivity();
            reflection.Act();
        }
        else if (choice == "3")
        {
            ListingActivity listing = new ListingActivity();
            listing.Act();
        }
        else if (choice == "4")
        {
            result = true;
        }
        return result;
    }
}