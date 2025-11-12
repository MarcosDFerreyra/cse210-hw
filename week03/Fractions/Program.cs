using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);

        fraction3.SetTop(5);
        fraction3.SetBottom(1);

        Console.WriteLine(fraction3.GetTop());
        Console.WriteLine(fraction3.GetBottom());
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

    }
}