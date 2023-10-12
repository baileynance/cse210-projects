using System;

class Program
{
    static void Main(string[] args)
    {
        static void Fractions(int top, int bottom = 1)
        {
            Fraction f = new Fraction();
            f.SetTop(top);
            f.SetBottom(bottom);
            Console.WriteLine(f.GetFractionalString());
            Console.WriteLine(f.GetDecimalValue());
        }

        Fractions(1);
        Fractions(5);
        Fractions(3, 4);
        Fractions(1, 3);
    }
}