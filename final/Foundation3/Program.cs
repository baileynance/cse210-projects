using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("4400 NW Walnut Blvd", "Corvallis", "Oregon", "Wa");

        Lecture lecture = new Lecture("Lecture", "CDNG1", "How to Fix Your Code", "November 13th", "1:00 PM", address, "Bailey Nance", 1000);
        Reception reception = new Reception("Reception", "Wedding Bells", "Bailey and Isabella are getting married", "February 4th", "3:00 PM", address, "wedding@yahoo.com");
        Outdoor outdoor = new Outdoor("Outdoor Gathering", "BBQ Boys", "Some chillin and some grillin", "June 19th", "Noon", address, "Sunny with some clouds");

        lecture.DisplayShortDescription();
        Console.WriteLine("------------------------------------");
        lecture.DisplayStandardDetails();
        Console.WriteLine("------------------------------------");
        lecture.DisplayFullDetails();
        Console.WriteLine("\n\n");

        reception.DisplayShortDescription();
        Console.WriteLine("------------------------------------");
        reception.DisplayStandardDetails();
        Console.WriteLine("------------------------------------");
        reception.DisplayFullDetails();
        Console.WriteLine("\n\n");

        outdoor.DisplayShortDescription();
        Console.WriteLine("------------------------------------");
        outdoor.DisplayStandardDetails();
        Console.WriteLine("------------------------------------");
        outdoor.DisplayFullDetails();
    }
}