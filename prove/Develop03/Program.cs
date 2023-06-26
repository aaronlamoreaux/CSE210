using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        bool hidden = false;

        Mastery mastery = new Mastery();

        System.Console.WriteLine("please chose a Book of Mormon scripture mastery to memorize (0-27)");

        for (int i = 0; i < mastery.GetReferTable().Count; i++)
        {
            System.Console.Write($"{i}. {mastery.GetReferTable()[i].GetVerse()} | ");
        }

        System.Console.Write("\n>");
        int choice = int.Parse(Console.ReadLine());

        var scripture = (mastery.GetScriptTable()[choice]);
        var words = (mastery.GetVerseTable()[choice]);
        var refer = (mastery.GetReferTable()[choice]);

        scripture.Display();

        while (exit == false)
        {
            hidden = words.GetHidden();

            scripture.Display();
            Console.WriteLine("");
            Console.WriteLine("to continue press 'enter' or type 'quit' to quit");
            Console.Write("> ");
            string input = Console.ReadLine();

            if (input == "quit" || input == "Quit" || hidden == true)
            {
                exit = true;
            }
            else if (input == "")
            {
                words.HideWord();
                scripture.SetVerse(refer, words);
            }
            else
            {
                Console.WriteLine("invalid input, try again.");
            }

        }

    }
}

