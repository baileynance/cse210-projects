using System;

public class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string type, string title, string description, string date, string time, Address address, string speakerName, int capacity) : base(type, title, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine($"Event Type: {_type} \nTitle: {_title} \nDescription: {_description} \nDate: {_date} \nTime: {_time} \nAddress: {_address} \nSpeaker Name: {_speakerName} \nCapacity: {_capacity}");
    }
}