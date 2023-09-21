using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();

        Console.WriteLine("Enter a list of numbers, tyoe 0 when finsihed.");
        string number = "0";

        do{
            Console.Write("Enter number: ");
            number = Console.ReadLine();
            int intNumber = int.Parse(number);

            if (number != "0")
            {
                numberList.Add(intNumber);
            }
        } while (number != "0");
        
        int sum = 0;
        foreach (int num in numberList) 
        {
            sum += num;
        }

        int length = numberList.Count;

        float average = ((float)sum) / length;

        int largest = 0;
        foreach (int num in numberList)
        {
            if (num > largest)
            {
                largest = num;
            }
        }

        int smallest = 100;
        foreach (int num in numberList)
        {
            if (num > 0)
            {
                if (num < smallest)
                {
                    smallest = num;
                }
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");

        numberList.Sort();
        foreach (int num in numberList)
        {
            Console.WriteLine(num);
        }
    }
}