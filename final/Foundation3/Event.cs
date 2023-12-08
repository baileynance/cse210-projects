using System;

public class Event
{
    protected string _type;
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;

    public Event(string type, string title, string description, string date, string time, Address address)
    {
        _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address.GetAddress();
    }

    public void DisplayStandardDetails()
    {
        Console.WriteLine($"Title: {_title} \nDescription: {_description} \nDate: {_date} \nTime: {_time} \nAddress: {_address}");
    }
    public void DisplayShortDescription()
    {
        Console.WriteLine($"Event Type: {_type} \nTitle: {_title} \nDate: {_date}");
    }
}