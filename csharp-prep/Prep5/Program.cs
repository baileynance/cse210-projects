using System;

class Program
{
    static void Main(string[] args)
    {
        
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber() 
        {
            Console.Write("Please enter your favorite number: ");
            string number = Console.ReadLine();
            int favNum = int.Parse(number);
            return favNum;
        }
        static int SquareNumber(int num) 
        {
            int squareNum = num * num;
            return squareNum;
        }
        static void DisplayResult(string name, int num) 
        {
            Console.WriteLine($"{name}, the square of your number is {num}");
        } 

        DisplayWelcome();
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int squareNumber = SquareNumber(favNumber);
        DisplayResult(userName, squareNumber);
    }
}