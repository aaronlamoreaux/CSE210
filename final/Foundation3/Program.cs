using System;

class Program
{
    static void Main(string[] args)
    {

        Lecture lecture = new Lecture("General Conference", "The 193rd semi-annual General Conference", "September 30th, 2023", "9:00 am", new Address("50 N W Temple St", "Salt Lake City", "UT", "USA"), "Various", 3500);
        Outdoor outdoor = new Outdoor("FHE", "North Star YSA family home evening", "7/17/2023", "7:00 pm", new Address("3350 West Alexander Road", "North Las Vegas", "NV", "USA"), "Sunny");
        Reception reception = new Reception("Las Vegas Regional Activity", "Heritage YSA Pool Party", "7/15/2023", "6:30 pm", new Address("3350 West Alexander Road", "North Las Vegas", "NV", "USA"), "NickLeavitt@test.com");

        Console.WriteLine(lecture.ShortDescription());
        Console.WriteLine(lecture.StandardDetails());
        Console.WriteLine(lecture.EventDetails());

        Console.WriteLine(outdoor.ShortDescription());
        Console.WriteLine(outdoor.StandardDetails());
        Console.WriteLine(outdoor.EventDetails());

        Console.WriteLine(reception.ShortDescription());
        Console.WriteLine(reception.StandardDetails());
        Console.WriteLine(reception.EventDetails());
    }
}