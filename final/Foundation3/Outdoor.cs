using System;

public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string type, string title, string description, string date, string time, Address address, string weather) : base(type, title, description, date, time, address)
    {
        _weather = weather;
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine($"Event Type: {_type} \nTitle: {_title} \nDescription: {_description} \nDate: {_date} \nTime: {_time} \nAddress: {_address} \nWeather: {_weather}");
    }
}