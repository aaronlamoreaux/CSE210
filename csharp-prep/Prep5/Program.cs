using System;

class Program
{
    static void Main(string[] args)
    {
        string name = "";
        int number = 0;

        DisplayWelcome();
        name = PromptUserName(name);
        number = PromptUserNumber(number);
        number = SquareNumber(number);
        DisplayResult(name, number);


    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName (string name)
    {
        Console.Write("Please enter your name: ");
        name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber (int number)
    {
        Console.Write("Please enter your favorite number: ");
        number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        number *= number;
        return number;
    }

    static void DisplayResult (string name, float number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}