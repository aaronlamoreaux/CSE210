using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int sum = 0;
        float average = 0;
        int largestNum = 0;
        int smallestPos = int.MaxValue;
        int listEnd = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do 
        {
            Console.Write("Enter a Number: ");
            int input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }
            else 
            {
                listEnd = 1;
            }

        } while (listEnd !=1);

        numbers.Sort();

        foreach (int input in numbers) 
        {
            sum += input;

            average = ((float)sum) / numbers.Count;

            if (largestNum < input)
            {
                largestNum = input;
            }

            if (input <= smallestPos && input > 0)
            {
                smallestPos = input;
            }
        }

        Console.WriteLine($"The sum is: {sum}");

        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The largest number is: {largestNum}");

        Console.WriteLine($"The smallest positive number is: {smallestPos}");

        Console.WriteLine("The sorted list is:");
        foreach (int input in numbers) 
        {
            Console.WriteLine(input);
        }
    }
}