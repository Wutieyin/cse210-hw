using System;
using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Address address1 = new Address("112 Maiz St", "New York", "NY", "USA");
        Address address2 = new Address("247 Word Hard St", "Abraka", "DEL", "Nigera");
        Address address3 = new Address("080 Glo St", "Ikoyi", "Lagos", "Nigeria");

        Lecture lecture = new Lecture("Tech Talk", "How to keep up with technology", DateTime.Now, address1, "Utiey Wyse", 50);
        Reception reception = new Reception("Networking Event", "Networking your way up your career", DateTime.Now, address2, "info@example.com");
        OutdoorGathering gathering = new OutdoorGathering("Picnic", "Look up, sidways and mingle", DateTime.Now, address3, "Sunny");

        Console.WriteLine("Standard Message:");
        Console.WriteLine(lecture.GetStandardMessage());
        Console.WriteLine();
        Console.WriteLine(reception.GetStandardMessage());
        Console.WriteLine();
        Console.WriteLine(gathering.GetStandardMessage());
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine("Full Message:");
        Console.WriteLine(lecture.GetFullMessage());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullMessage());
        Console.WriteLine();
        Console.WriteLine(gathering.GetFullMessage());
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(gathering.GetShortDescription());
        Console.WriteLine();
    }
}
