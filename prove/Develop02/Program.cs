using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        DateTime theCurrentTime = DateTime.Now;
        bool exit = false;

        while (exit == false)
        {
            string input = Choice();

            if (input == "1")
            {
                Entry entry = new Entry();
                string prompt = getPrompt();

                Console.WriteLine($"{prompt}");
                Console.Write("> ");
                string userEntry = Console.ReadLine();

                entry._date = theCurrentTime.ToShortDateString();
                entry._message = userEntry;
                entry._prompt = prompt;

                journal._journal.Add(entry);
            }
            else if (input == "2")
            {
                journal.Display();
            }
            else if (input == "3")
            {
                
                Console.WriteLine("what is your file name?");
                string fileName = Console.ReadLine();

                string[] lines = System.IO.File.ReadAllLines(fileName);
                foreach (string line in lines)
                {
                    string[] parts = line.Split("~|~");

                    Entry entry = new Entry();
                    entry._date = parts[1];
                    entry._prompt = parts[3];
                    entry._message = parts[5];

                    journal._journal.Add(entry);
                }
            }
            else if (input == "4") 
            {
                                Console.WriteLine("what is your file name?");
                string fileName = Console.ReadLine();

                foreach (Entry entry in journal._journal)
                {
                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                        outputFile.WriteLine($"Date:~|~{entry._date}~|~Prompt:~|~{entry._prompt}~|~Entry:~|~{entry._message}");
                    }
                }
            }
            else if (input == "5")
            {
                exit = true;
            }
            else
            {
                Console.WriteLine("not valid input. please enter '1', '2', '3', '4', or '5'.");
            }
        }
    }

    static string Choice()
    {
        Console.WriteLine("please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("what would you like to do? ");
        string input = Console.ReadLine();

        return input;
    }

    static string getPrompt()
    {
        string prompt = "";
        List<string> prompts = new List<string>();
        prompts.Add("What was the best thing that happened to you today?");
        prompts.Add("What is something that made you laugh today?");
        prompts.Add("Who made your day better today?");
        prompts.Add("What is one thing you want to remember from today?");

        Random random = new Random();
        int num = random.Next(0, 3);

        prompt = prompts[num];

        return prompt;
    }
}