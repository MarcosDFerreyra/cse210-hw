using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();

        int square = SquareNumber(number);
        DisplayResult(name, square);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("welcome to the program");
    }
    static string PromptUserName()
    {
        Console.Write("please enter your name: ");
        string name = Console.ReadLine();
        return name;

    }
    static int PromptUserNumber()
    {
        Console.Write("please enter your favourite number: ");
        string userNumber = Console.ReadLine();
        int number = int.Parse(userNumber);
        return number;
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }
    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }


}